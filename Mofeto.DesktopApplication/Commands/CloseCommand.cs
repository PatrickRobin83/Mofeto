/*
*----------------------------------------------------------------------------------
*          Filename:	CloseCommand.cs
*          Date:        2020.05.31 23:05:50
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using System.Windows.Input;
using Mofeto.DesktopApplication.ViewModels;

namespace Mofeto.DesktopApplication.Commands

{
    public class CloseCommand : ICommand
    {

        #region Fields

        private ShellViewModel shellViewModel;

        #endregion

        #region Properties

        #endregion

        #region Constructor

        public CloseCommand(ShellViewModel shellViewModel)
        {
            if (shellViewModel != null) this.shellViewModel = shellViewModel;
        }

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion


        #region Implementation of ICommand

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            shellViewModel.Close();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        #endregion
    }
}