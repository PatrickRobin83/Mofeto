/*
*----------------------------------------------------------------------------------
*          Filename:	ShellViewModel.cs
*          Date:        2020.05.31 19:18:41
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using System.Windows.Input;
using System.Xaml;
using Mofeto.DesktopApplication.Commands;
using Mofeto.DesktopApplication.Views;

namespace Mofeto.DesktopApplication.ViewModels

{
    public class ShellViewModel : BaseViewModel
    {
        #region Fields

        private string title;
        private CarViewModel carViewModel;
        private DashboardViewModel dashboardViewModel;
        private object selectedViewModel;

        #endregion

        #region Properties

        public string Title
        {
            get
            {
                return title;
            }
            private set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public ICommand OpenCarViewCommand { get; private set; }
        public ICommand OpenDashboardViewCommand { get; private set; }
        public ICommand CloseCommand { get; private set; }
        public object SelectedViewModel
         {
             get { return selectedViewModel; }
             set
             {
                 selectedViewModel = value;
                 OnPropertyChanged(nameof(SelectedViewModel));
             }
         }


        #endregion

        #region Constructor

        public ShellViewModel()
        {
            InitializeApp();
        }



        #endregion

        #region Methods

        private void InitializeApp()
        {
            Title = "Mofeto Desktop Application";

            #region ViewModel initialisation

            carViewModel = new CarViewModel();
            dashboardViewModel = new DashboardViewModel();

            #endregion

            SelectedViewModel = dashboardViewModel;

            #region Command Initialisation

            CloseCommand = new CloseCommand(this);

            #endregion

           
        }
        public void OpenCarView()
        {
            SelectedViewModel = carViewModel;
        }

        public void OpenDashboardView()
        {
            SelectedViewModel = dashboardViewModel;
        }

        public void Close()
        {
            Environment.Exit(0);
        }
        #endregion

        #region EventHandler

        #endregion
    }
}