/*
*----------------------------------------------------------------------------------
*          Filename:	SelectedEntryViewModel.cs
*          Date:        2020.06.01 17:15:07
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Collections.ObjectModel;
using Mofeto.DesktopApplication.Models;

namespace Mofeto.DesktopApplication.ViewModels

{
    public class DashboardEntryViewModel : BaseViewModel
    {

        #region Fields

        private CarModel carModel;
        private ObservableCollection<EntryModel> carEntrys;

        private EntryModel selectedEntryModel;

        #endregion

        #region Properties

        public CarModel CarModel
        {
            get { return carModel; }
            set
            {
                carModel = value;
                OnPropertyChanged(nameof(CarModel));
            }
        }
        public ObservableCollection<EntryModel> CarEntrys
        {
            get { return carEntrys; }
            set
            {
                carEntrys = value;
                OnPropertyChanged(nameof(CarEntrys));
            }
        }

        public EntryModel SelectedEntryModel
        {
            get { return selectedEntryModel; }
            set
            {
                selectedEntryModel = value;
                OnPropertyChanged(nameof(SelectedEntryModel));
            }
        }

        #endregion

        #region Constructor

        public DashboardEntryViewModel(CarModel selectedCarModel)
        {
            if (selectedCarModel != null)
            {
                CarModel = selectedCarModel;
                CarEntrys = selectedCarModel.Entries;
            }
        }

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion

    }
}