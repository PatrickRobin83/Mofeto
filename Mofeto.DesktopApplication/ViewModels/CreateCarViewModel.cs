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
using System.ComponentModel;
using System.Windows.Input;
using Mofeto.DesktopApplication.Commands;
using Mofeto.DesktopApplication.DataAccess;
using Mofeto.DesktopApplication.Models;

namespace Mofeto.DesktopApplication.ViewModels

{
    public class CreateCarViewModel : BaseViewModel, IDataErrorInfo
    {

        #region Fields

        private CarModel carModel;
        private int id;
        private bool isActive;
        private BrandModel selectedBrand;
        private ModelTypeModel modelType;
        private FuelTypeModel fuelType;
        private string carTaxPerYear;
        private string carInsurance;
        private ObservableCollection<EntryModel> entries;
        private ObservableCollection<BrandModel> availableBrands;
        private ObservableCollection<ModelTypeModel> availableCarModels;
        private ObservableCollection<FuelTypeModel> availableFuelTypes;
        private bool saveCarCommandExecutet;
        private string title;
        private IDataErrorInfo dataErrorInfoImplementation;

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

        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
                OnPropertyChanged(nameof(IsActive));
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
        public string CarTaxPerYear
        {
            get { return carTaxPerYear; }
            set
            {
                carTaxPerYear = value;
                OnPropertyChanged(nameof(CarTaxPerYear));
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
        public string CarInsurance
        {
            get { return carInsurance; }
            set
            { 
                carInsurance = value; 
                OnPropertyChanged(nameof(CarInsurance));
            }
        }
        public ICommand SaveCarCommand { get; set; }
        public ICommand CancelCommand { get; set; }
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

        public IDataErrorInfo DataErrorInfoImplementation
        {
            get { return dataErrorInfoImplementation; }
            set
            {
                dataErrorInfoImplementation = value;
                OnPropertyChanged(nameof(DataErrorInfoImplementation));
            }
        }
        public string Error { get; }

        #endregion

        #region Constructor
        public CreateCarViewModel()
        {
            carModel = new CarModel();
            AvailableFuelTypes = new ObservableCollection<FuelTypeModel>(SqliteDataAccess.LoadAllFuelTypes());
            SaveCarCommandExecutet = true;
            AvailableBrands = new ObservableCollection<BrandModel>(SqliteDataAccess.LoadAllBrands());
            SaveCarCommand = new SaveCarCommand(this);
            CancelCommand = new CancelCommand(this);

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
                this.IsActive = carModel.IsActive;
                if (carModel.Brand != null) this.SelectedBrand = carModel.Brand;
                if (carModel.ModelType != null) this.ModelType = carModel.ModelType;
                if (carModel.FuelType != null) this.FuelType = carModel.FuelType;
                if (Convert.ToString(carModel.CarTaxPerYear) != null) this.CarTaxPerYear = Convert.ToString(carModel.CarTaxPerYear);
                if (carModel.Entries != null) this.Entries = carModel.Entries;
                if (Convert.ToString(carModel.CarInsurance) != null) this.CarInsurance = Convert.ToString(carModel.CarInsurance);
                SaveCarCommand = new SaveCarCommand(this);
                CancelCommand = new CancelCommand(this);
            }
        }
        #endregion

        #region Methods
        public void SaveCar(CarModel carToSave)
        {
            carToSave.IsActive = IsActive;
            carToSave.Brand = SelectedBrand;
            carToSave.ModelType = ModelType;
            carToSave.FuelType = FuelType;
            carToSave.CarTaxPerYear = Convert.ToDouble(CarTaxPerYear);
            carToSave.Entries = Entries;
            carToSave.CarInsurance = Convert.ToDouble(CarInsurance);

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

        public void CancelCreateCar()
        {
            SaveCarCommandExecutet = false;
        }

        public bool CanSaveCarExecutet()
        {
            bool canExecutet = false;
            double tmp = 0;

            if (double.TryParse(CarTaxPerYear, out tmp) && 
                double.TryParse(CarInsurance, out tmp))
            {
                canExecutet = true;
            }

            return canExecutet;
        }

        #endregion

        #region EventHandler

        public string this[string propertyName]
        {
            get
            {
                if (propertyName == "CarTaxPerYear")
                {
                    double tmp;
                    if (!Double.TryParse(CarTaxPerYear, out tmp))
                    {
                        return "not a double";
                    }
                }
                if (propertyName == "CarInsurance")
                {
                    double tmp;
                    if (!Double.TryParse(CarInsurance, out tmp))
                    {
                        return "not a double";
                    }
                }

                return null;
            }
        }

        #endregion

    }
}