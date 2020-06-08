/*
*----------------------------------------------------------------------------------
*          Filename:	OpenAddBrandViewCommand.cs
*          Date:        2020.06.09 00:24:03
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using System.Windows.Input;
using Mofeto.DesktopApplication.Models;
using Mofeto.DesktopApplication.ViewModels;

namespace Mofeto.DesktopApplication.Commands

{
    public class OpenAddBrandViewCommand : ICommand
    {

        #region Fields

        private CreateCarViewModel createCarViewModel;

        #endregion

        #region Properties

        #endregion

        #region Constructor

        public OpenAddBrandViewCommand(CreateCarViewModel createCarViewModel)
        {
            this.createCarViewModel = createCarViewModel;
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
            createCarViewModel.OpenBrandView();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        #endregion
    }
}