/*
*----------------------------------------------------------------------------------
*          Filename:	SayHelloMessage.cs
*          Date:        2020.01.25 23:03:47
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using GalaSoft.MvvmLight.Messaging;

namespace RietRob.Mofeto.Logic.Ui.Messages

{
    /// <summary>
    /// If sent through the Messenger this message tells that there has to be a Message displayed in the Console
    /// Example how messaging works.
    /// </summary>
    public class SayHelloMessage
    {

        #region Fields

        

        #endregion

        #region Properties

        public string SayHello { get; private set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Just the text from the sender
        /// </summary>
        /// <param name="sayHello"></param>
        public SayHelloMessage(string sayHello)
        {
            SayHello = sayHello;
        }

        #endregion

        #region Methods

        #endregion
    }
}