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
    public class OpenCarViewCommand : ICommand
    {

        #region Fields

        private readonly ShellViewModel shellViewModel;

        #endregion

        #region Properties

        #endregion

        #region Constructor

        public OpenCarViewCommand(ShellViewModel shellViewModel)
        {
            if (shellViewModel != null) this.shellViewModel = shellViewModel;
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
            shellViewModel.OpenCarView();
        }
        #endregion
    }
}