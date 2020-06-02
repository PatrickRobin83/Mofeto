/*
*----------------------------------------------------------------------------------
*          Filename:	SelectedEntryViewModel.cs
*          Date:        2020.06.01 17:15:07
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using Mofeto.DesktopApplication.Models;

namespace Mofeto.DesktopApplication.ViewModels

{
    public class DashboardEntryViewModel : BaseViewModel
    {

        #region Fields

        private CarModel carModel;

        public CarModel CarModel
        {
            get { return carModel; }
            set
            {
                carModel = value;
                OnPropertyChanged(nameof(CarModel));
            }
        }
        
        #endregion

        #region Properties

        #endregion

        #region Constructor

        public DashboardEntryViewModel(CarModel selectedCarModel)
        {
            CarModel = selectedCarModel;
            CarModel.Brand = selectedCarModel.Brand;
        }

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion


    }
}