/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   CancelCommand.cs
 *   Date			:   2020-06-08 11:41:19
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
    public class CancelCommand : ICommand
    {
        

        #region Fields

        private CreateCarViewModel createCarViewModel;
        #endregion

        #region Properties

        #endregion

        #region Constructor

        public CancelCommand( CreateCarViewModel carViewModel)
        {
            this.createCarViewModel = carViewModel;
        }

        #endregion

        #region Methods

        #endregion

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            createCarViewModel.CancelCreateCar();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}