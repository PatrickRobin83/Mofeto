/*
*----------------------------------------------------------------------------------
*          Filename:	FuelType.cs
*          Date:        2020.06.01 14:52:47
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

namespace Mofeto.DesktopApplication.Models

{
    public class FuelType : ModelBase 

    {

        #region Fields

        private int id;
        private string title;

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        #endregion

        #region Constructor

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion


    }
}