/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   SaveCarCommand.cs
 *   Date			:   2020-06-04 15:57:55
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
    public class SaveCarCommand : ICommand
    {
        

        #region Fields

        private CreateCarViewModel createCarViewModel;
        #endregion

        #region Properties

        #endregion

        #region Constructor

        public SaveCarCommand(CreateCarViewModel createCarViewModel)
        {
            this.createCarViewModel = createCarViewModel;
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
            createCarViewModel.SaveCar();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}