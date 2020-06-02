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

        private int id;
        private int brandId;
        private int modelId;
        private int typeoffuelid;
        private string brand;
        private string modelType;
        private string fuelType;
        private double carTaxPerYear;
        private string insurancePayAgreement;
        private ObservableCollection<EntryModel> entries;
        
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

        public int BrandId
        {
            get { return brandId; }
            set
            {
                brandId = value;
                OnPropertyChanged(nameof(BrandId));
            }
        }

        public int ModelId
        {
            get { return modelId; }
            set
            {
                modelId = value; 
                OnPropertyChanged(nameof(ModelId));
            }
        }

        public int Typeoffuelid
        {
            get { return typeoffuelid; }
            set
            {
                typeoffuelid = value; 
                OnPropertyChanged(nameof(Typeoffuelid));
            }
        }

        public string ModelType
        {
            get { return modelType; }
            set
            {
                modelType = value;
                OnPropertyChanged(nameof(ModelType));
            }
        }

        public string FuelType
        {
            get { return fuelType; }
            set
            {
                fuelType = value;
                OnPropertyChanged(nameof(fuelType));
            }
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
                OnPropertyChanged(nameof(Brand));
            }
        }

        public double CarTaxPerYear
        {
            get { return carTaxPerYear; }
            set
            {
                carTaxPerYear = value;
                OnPropertyChanged(nameof(CarTaxPerYear));
            }
        }

        public string InsurancePayAgreement
        {
            get { return insurancePayAgreement; }
            set
            {
                insurancePayAgreement = value;
                OnPropertyChanged(nameof(InsurancePayAgreement));
            }
        }

        public ObservableCollection<EntryModel> Entries
        {
            get { return entries; }
            set
            {
                entries = value;
                OnPropertyChanged(nameof(Entries));
            }
        }

        

        #endregion

        #region Constructor

        public CarModel()
        {
            
        }

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion


    }
}