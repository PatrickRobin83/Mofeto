using System;
using System.ComponentModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using RietRob.Mofeto.Logic.Ui.Messages;

namespace RietRob.Mofeto.Logic.Ui.ViewModel
{
    

    public class MainViewModel : ViewModelBase
    {

        #region Fields


        #endregion

        #region Properties
        public string MainWindowTitle { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {

            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                MainWindowTitle = "Mofeto is in Design Mode";
            }
            else
            {
                // Code runs "for real"
                MainWindowTitle = "Mofeto";
            }
            // Example how the Command thing works with Meesengers
           // SayHelloCommand = new RelayCommand(() => MessengerInstance.Send(new SayHelloMessage("Say Hello")));
        }

        #endregion

        #region Methods



        #endregion

        #region Commands

        // Property for the View to bind to
        // public RelayCommand SayHelloCommand { get; private set; }

        #endregion


    }
}