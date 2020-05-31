/*
*----------------------------------------------------------------------------------
*          Filename:	BaseViewModel.cs
*          Date:        2020.05.31 19:21:19
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.ComponentModel;
using System.Runtime.CompilerServices;
using Mofeto.DesktopApplication.Annotations;

namespace Mofeto.DesktopApplication.ViewModels

{
    public class BaseViewModel : INotifyPropertyChanged
    {

        #region Fields



        #endregion

        #region Properties

        #endregion

        #region Constructor

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion



    }
}