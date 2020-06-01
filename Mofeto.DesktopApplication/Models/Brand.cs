/*
*----------------------------------------------------------------------------------
*          Filename:	Brand.cs
*          Date:        2020.06.01 14:52:25
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Collections.ObjectModel;

namespace Mofeto.DesktopApplication.Models

{
    public class Brand : ModelBase
    {

        #region Fields

        private int id;
        private string brandName;
        private ObservableCollection<ModelType> modelList;

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
        public string BrandName
        {
            get { return brandName; }
            set
            {
                brandName = value;
                OnPropertyChanged(nameof(BrandName));

            }
        }
        public ObservableCollection<ModelType> ModelList
        {
            get { return modelList; }
            set
            {
                modelList = value;
                OnPropertyChanged(nameof(ModelList));
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