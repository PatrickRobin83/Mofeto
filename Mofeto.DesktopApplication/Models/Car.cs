/*
*----------------------------------------------------------------------------------
*          Filename:	Car.cs
*          Date:        2020.06.01 14:50:53
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Collections.ObjectModel;

namespace Mofeto.DesktopApplication.Models

{
    public class Car : ModelBase
    {

        #region Fields

        private int id;
        private Brand brand;
        private ModelType modelType;
        private double carTaxPerYear;
        private string insurancePayAgreement;
        private ObservableCollection<Entry> entries;
        
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

        public ModelType ModelType
        {
            get { return modelType; }
            set
            {
                modelType = value;
                OnPropertyChanged(nameof(ModelType));
            }
        }

        public Brand Brand
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

        public ObservableCollection<Entry> Entries
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

        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion


    }
}