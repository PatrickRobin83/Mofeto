/*
*----------------------------------------------------------------------------------
*          Filename:	ModelTypeModel.cs
*          Date:        2020.06.01 14:52:56
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

namespace Mofeto.DesktopApplication.Models

{
    public class ModelTypeModel : ModelBase
    {

        #region Fields

        private int id;
        private string modelName;

        #endregion

        #region Properties

        public string ModelName
        {
            get { return modelName; }
            set
            {
                modelName = value;
                OnPropertyChanged(nameof(ModelName));
            }
        }
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
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