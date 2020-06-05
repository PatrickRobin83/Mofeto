/*
*----------------------------------------------------------------------------------
*          Filename:	CarViewModel.cs
*          Date:        2020.05.31 22:13:47
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Mofeto.DesktopApplication.Commands;
using Mofeto.DesktopApplication.DataAccess;
using Mofeto.DesktopApplication.Models;

namespace Mofeto.DesktopApplication.ViewModels

{
    public class CreateCarViewModel : BaseViewModel
    {

        #region Fields

        private CarModel carModel;
        private int id;
        private BrandModel selectedBrand;
        private ModelTypeModel modelType;
        private FuelTypeModel fuelType;
        private double carTaxPerYear;
        private string insurancePayAgreement;
        private double insuranceCosts;
        private ObservableCollection<EntryModel> entries;
        private ObservableCollection<BrandModel> availableBrands;
        private ObservableCollection<ModelTypeModel> availableCarModels;
        private ObservableCollection<FuelTypeModel> availableFuelTypes;
        private bool saveCarCommandExecutet;
        private string title;

        #endregion

        #region Properties
        public string Title
        {
            get { return title; }
            set
            {
                title = value; 
                OnPropertyChanged(nameof(Title));
            }
        }
        public CarModel CarModel
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
                OnPropertyChanged(nameof(CarModel));
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
        public BrandModel SelectedBrand
        {
            get
            {
                return selectedBrand;
            }
            set
            {
                selectedBrand = value;
                OnPropertyChanged(nameof(SelectedBrand));
                AvailableCarModels = new ObservableCollection<ModelTypeModel>(SqliteDataAccess.ModelsFromBrands(SelectedBrand.Id));
            }
        }
        public ModelTypeModel ModelType
        {
            get { return modelType; }
            set
            {
                modelType = value;
                OnPropertyChanged(nameof(ModelType));
            }
        }
        public FuelTypeModel FuelType
        {
            get { return fuelType; }
            set
            {
                fuelType = value;
                OnPropertyChanged(nameof(FuelType));
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
        public ObservableCollection<BrandModel> AvailableBrands
        {
            get { return availableBrands; }
            set
            {
                availableBrands = value;
                OnPropertyChanged(nameof(AvailableBrands));
            }
        }
        public ObservableCollection<ModelTypeModel> AvailableCarModels
        {
            get { return availableCarModels; }
            set
            {
                availableCarModels = value;
                OnPropertyChanged(nameof(AvailableCarModels));
            }
        }
        public ObservableCollection<FuelTypeModel> AvailableFuelTypes
        {
            get { return availableFuelTypes; }
            set
            {
                availableFuelTypes = value;
                OnPropertyChanged(nameof(AvailableFuelTypes));
            }
        }
        public double InsuranceCosts
        {
            get { return insuranceCosts; }
            set
            {
                insuranceCosts = value; 
                OnPropertyChanged(nameof(InsuranceCosts));
            }
        }
        public ICommand SaveCarCommand { get; set; }
        public bool SaveCarCommandExecutet
        {
            get
            {
                return saveCarCommandExecutet;
            }
            set
            {
                saveCarCommandExecutet = value;
                OnPropertyChanged(nameof(SaveCarCommandExecutet));
            }
        }

        #endregion

        #region Constructor
        public CreateCarViewModel()
        {
            carModel = new CarModel();
            AvailableFuelTypes = new ObservableCollection<FuelTypeModel>(SqliteDataAccess.LoadAllFuelTypes());
            SaveCarCommandExecutet = true;
            AvailableBrands = new ObservableCollection<BrandModel>(SqliteDataAccess.LoadAllBrands());
            SaveCarCommand = new SaveCarCommand(this);
        }
        public CreateCarViewModel(CarModel carModel)
        {
            SaveCarCommandExecutet = true;
            this.carModel = carModel;
            AvailableBrands = new ObservableCollection<BrandModel>(SqliteDataAccess.LoadAllBrands());
            AvailableFuelTypes = new ObservableCollection<FuelTypeModel>(SqliteDataAccess.LoadAllFuelTypes());
            if (carModel != null)
            {
                this.Id = carModel.Id;
                if (carModel.Brand != null) this.SelectedBrand = carModel.Brand;
                if (carModel.ModelType != null) this.ModelType = carModel.ModelType;
                if (carModel.FuelType != null) this.FuelType = carModel.FuelType;
                if (Math.Abs(carModel.CarTaxPerYear) > 0) this.CarTaxPerYear = carModel.CarTaxPerYear;
                if (!string.IsNullOrWhiteSpace(carModel.InsurancePayAgreement)) this.InsurancePayAgreement = carModel.InsurancePayAgreement;
                if (carModel.Entries != null) this.Entries = carModel.Entries;
                if (Math.Abs(carModel.InsuranceCosts) > 0) this.InsuranceCosts = carModel.InsuranceCosts;
                SaveCarCommand = new SaveCarCommand(this);
            }


            Title = "Hier kommen die CarDetails";
        }
        #endregion

        #region Methods
        public void SaveCar(CarModel carToSave)
        {
            carToSave.Brand = SelectedBrand;
            carToSave.ModelType = ModelType;
            carToSave.FuelType = FuelType;
            carToSave.CarTaxPerYear = CarTaxPerYear;
            carToSave.InsurancePayAgreement = InsurancePayAgreement;
            carToSave.Entries = Entries;
            carToSave.InsuranceCosts = InsuranceCosts;

            if (carToSave.Id > 0)
            {
                SqliteDataAccess.UpdateCar(carToSave);
            }
            else
            {
                SqliteDataAccess.SaveCar(carToSave);
            }

            Console.WriteLine($"{carToSave.Brand.BrandName} {carToSave.ModelType.ModelName} wurde gespeichert.");
            SaveCarCommandExecutet = false;
            SqliteDataAccess.LoadCars();
        }

        #endregion

        #region EventHandler

        #endregion


    }
}