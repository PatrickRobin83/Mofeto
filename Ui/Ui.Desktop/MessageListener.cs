/*
*----------------------------------------------------------------------------------
*          Filename:	MessageListener.cs
*          Date:        2020.01.25 22:43:57
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Diagnostics;
using GalaSoft.MvvmLight.Messaging;
using RietRob.Mofeto.Logic.Ui.Messages;

namespace RietRob.Mofeto.Ui.Desktop

{
    /// <summary>
    /// Central Listener for all Messages of the App
    /// </summary>
    public class MessageListener
    {

        #region Fields

        #endregion

        #region Properties

        // We need this property so that this type can be put into the resources
        public bool BindableProperty => true;

        #endregion

        #region Constructor

        public MessageListener()
        {
            InitMessenger();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Is called by the constructor to define the messages we are interested in.
        /// </summary>
        private void InitMessenger()
        {
            //// Example how Messaging works between Windows and User Controls
            //Messenger.Default.Register<>(this, msg =>
            //{
            //    var window = new ChildWindow();
            //    var model = window.DataContext as ChildViewModel;
            //    if (model != null)
            //    {
            //        model.MessageFromParent = msg.SomeText;
            //    }

            //    window.ShowDialog();
            //});

            // Own Message
            // Messenger.Default.Register<SayHelloMessage>(this, msg => NotifyMe(msg.SayHello));
        }


        ///// <summary>
        ///// Helper Method to get the string from the message and show it on the console
        ///// </summary>
        ///// <param name="message"></param>
        //public void NotifyMe(string message)
        //{
        //    Debug.WriteLine(message);
        //}

        #endregion
    }
}