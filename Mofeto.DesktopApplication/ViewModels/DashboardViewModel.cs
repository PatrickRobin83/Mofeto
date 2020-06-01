﻿/*
*----------------------------------------------------------------------------------
*          Filename:	DashboardViewModel.cs
*          Date:        2020.05.31 22:43:52
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

namespace Mofeto.DesktopApplication.ViewModels

{
    public class DashboardViewModel : BaseViewModel
    {

        #region Fields

        private DashboardEntryViewModel dashboardEntryViewModel;

        #endregion

        #region Properties

        public DashboardEntryViewModel DashboardEntryViewModel
        {
            get => dashboardEntryViewModel;
            set => dashboardEntryViewModel = value;
        }

        #endregion

        #region Constructor

        public DashboardViewModel()
        {
            DashboardEntryViewModel = new DashboardEntryViewModel();
        }

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion


        
    }
}