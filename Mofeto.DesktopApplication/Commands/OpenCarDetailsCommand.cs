/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   OpenCarDetailsCommand.cs
 *   Date			:   2020-06-04 13:24:36
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using System;
using System.Windows.Input;
using Mofeto.DesktopApplication.ViewModels;

namespace Mofeto.DesktopApplication.Commands
{
    public class OpenCarDetailsCommand : ICommand
    {
        #region Fields

        private readonly DashboardViewModel dashboardViewModel;

        #endregion

        #region Properties

        #endregion

        #region Constructor

        public OpenCarDetailsCommand(DashboardViewModel dashboardViewModel)
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
            return dashboardViewModel.CanShowCarDetailsView();
        }

        public void Execute(object parameter)
        {
            dashboardViewModel.EditCar();
        }
        #endregion
    }
}