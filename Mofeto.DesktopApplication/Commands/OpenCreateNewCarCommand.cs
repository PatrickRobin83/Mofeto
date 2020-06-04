/*
*----------------------------------------------------------------------------------
*          Filename:	OpenCarViewCommand.cs
*          Date:        2020.05.31 21:57:10
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using System.Runtime.Serialization.Formatters;
using System.Windows.Input;
using Mofeto.DesktopApplication.ViewModels;

namespace Mofeto.DesktopApplication.Commands

{
    public class OpenCreateNewCarCommand : ICommand
    {

        #region Fields

        private readonly DashboardViewModel dashboardViewModel;

        #endregion

        #region Properties

        #endregion

        #region Constructor

        public OpenCreateNewCarCommand(DashboardViewModel dashboardViewModel)
        {
            if (dashboardViewModel != null) this.dashboardViewModel = dashboardViewModel;
        }

        #endregion

        #region Methods

        #endregion

        #region Implementation of ICommand

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            dashboardViewModel.CreateNewCar();
        }
        #endregion
    }
}