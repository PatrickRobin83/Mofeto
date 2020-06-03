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
        private CarModel selectedCarModel;
        private ObservableCollection<CarModel> availableCars;

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
        
        #endregion

        #region Constructor

        public DashboardViewModel()
        {
            AvailableCars = new ObservableCollection<CarModel>(SqliteDataAccess.LoadCars());
        }

        #endregion

        #region Methods

        public void ShowSelectedEntryViewModel()
        {
            SelectedEntryViewModel = new DashboardEntryViewModel(SelectedCarModel);
        }

        #endregion

        #region EventHandler

        #endregion


        
    }
}