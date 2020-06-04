/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   DeleteCarCommand.cs
 *   Date			:   2020-06-04 14:48:36
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
    public class DeleteCarCommand : ICommand
    {


        #region Fields

        private DashboardViewModel dashboardViewModel;

        #endregion

        #region Constructor

        public DeleteCarCommand(DashboardViewModel dashboardViewmodel)
        {
            this.dashboardViewModel = dashboardViewmodel;
        }
        #endregion

        #region Implementation of ICommand

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return dashboardViewModel.CanDeleteCar();
        }

        public void Execute(object parameter)
        {
            dashboardViewModel.DeleteCar();
        }
        #endregion

    }
}