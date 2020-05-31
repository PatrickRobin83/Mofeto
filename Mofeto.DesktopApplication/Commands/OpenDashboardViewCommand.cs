using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Mofeto.DesktopApplication.ViewModels;

namespace Mofeto.DesktopApplication.Commands
{
    public class OpenDashboardViewCommand : ICommand
    {
        #region Fields

        private readonly ShellViewModel shellViewModel;

        #endregion

        #region Constructor

        public OpenDashboardViewCommand(ShellViewModel shellViewModel)
        {
            if (shellViewModel != null) this.shellViewModel = shellViewModel;
        }

        #endregion

        #region Implementation of ICommand

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            shellViewModel.OpenDashboardView();
        }
        
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        #endregion
    }
}
