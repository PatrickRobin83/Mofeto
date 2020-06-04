/*
*----------------------------------------------------------------------------------
*          Filename:	DashboardViewModel.cs
*          Date:        2020.05.31 22:43:52
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Collections.ObjectModel;
using System.Dynamic;
using System.Windows.Input;
using Mofeto.DesktopApplication.Commands;
using Mofeto.DesktopApplication.DataAccess;
using Mofeto.DesktopApplication.Models;
using Mofeto.DesktopApplication.Views;

namespace Mofeto.DesktopApplication.ViewModels

{
    public class DashboardViewModel : BaseViewModel
    {

        #region Fields

        private DashboardEntryViewModel selectedEntryViewModel;
        private CreateCarViewModel carViewModel;
        private CarModel selectedCarModel;
        private ObservableCollection<CarModel> availableCars;
        private bool carIsSelected;


        #endregion

        #region Properties

        public DashboardEntryViewModel SelectedEntryViewModel
        {
            get { return selectedEntryViewModel; }
            set
            {
                selectedEntryViewModel = value; 
                OnPropertyChanged(nameof(SelectedEntryViewModel));

            }
        }
        public CreateCarViewModel CarViewModel
        {
            get { return carViewModel; }
            set
            {
                carViewModel = value;
                OnPropertyChanged(nameof(CarViewModel));
            }
        }
        public CarModel SelectedCarModel
        {
            get
            {
                return selectedCarModel;
            }
            set
            {
                selectedCarModel = value;
                OnPropertyChanged(nameof(SelectedCarModel));
                ShowSelectedEntryViewModel();
                CarIsSelected = SelectedCarModel != null;
            }
        }
        public ObservableCollection<CarModel> AvailableCars
        {
            get
            {
                return availableCars;
            }
            set
            {
                availableCars = value;
                OnPropertyChanged(nameof(AvailableCars));
            }
        }
        public ICommand OpenCreateNewCarCommand { get; private set; }
        public ICommand OpenCarDetailsCommand { get; private set; }
        public ICommand DeleteCarCommand { get; private set; }
        public bool CarIsSelected
        {
            get
            {
                return carIsSelected;
            }
            set
            {
                carIsSelected = value;
                OnPropertyChanged(nameof(CarIsSelected));
            }
        }


        #endregion

        #region Constructor

        public DashboardViewModel()
        {
            AvailableCars = new ObservableCollection<CarModel>(SqliteDataAccess.LoadCars());
            OpenCreateNewCarCommand = new OpenCreateNewCarCommand(this);
            OpenCarDetailsCommand = new OpenCarDetailsCommand(this);
            DeleteCarCommand = new DeleteCarCommand(this);
        }

        #endregion

        #region Methods

        public void ShowSelectedEntryViewModel()
        {
            SelectedEntryViewModel = new DashboardEntryViewModel(SelectedCarModel);
        }

        public bool CanShowCarDetailsView()
        {
            bool canShow = SelectedCarModel != null;

            return canShow;
        }

        public void CreateNewCar()
        {
            
            CarViewModel = new CreateCarViewModel();
        }

        public void EditCar()
        {
            CarViewModel = new CreateCarViewModel(selectedCarModel);
        }

        public bool CanDeleteCar()
        {
            bool canDelete = SelectedCarModel != null;

            return canDelete;
        }

        public void DeleteCar()
        {
            DataAccess.SqliteDataAccess.DeleteCar(selectedCarModel);
        }


        #endregion

        #region EventHandler

        #endregion
    }
}