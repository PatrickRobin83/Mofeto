/*
*----------------------------------------------------------------------------------
*          Filename:	CarModel.cs
*          Date:        2020.06.01 14:50:53
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Collections.ObjectModel;

namespace Mofeto.DesktopApplication.Models

{
    public class CarModel : ModelBase
    {

        #region Fields
        #endregion

        #region Properties

        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int TypeoffuelId { get; set; }
        public ModelTypeModel ModelType { get; set; }
        public FuelTypeModel FuelType { get; set; }
        public BrandModel Brand { get; set; }
        public double CarTaxPerYear { get; set; }
        public string InsurancePayAgreement { get; set; }
        public ObservableCollection<EntryModel> Entries { get; set; }
        public double InsuranceCosts { get; set; }

        #endregion

        #region Constructor

        public CarModel()
        {
            Brand = new BrandModel();
            ModelType = new ModelTypeModel();
            FuelType = new FuelTypeModel();
            Brand.Id = BrandId;
            ModelType.Id = ModelId;
            FuelType.Id = TypeoffuelId;
        }

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion


    }
}