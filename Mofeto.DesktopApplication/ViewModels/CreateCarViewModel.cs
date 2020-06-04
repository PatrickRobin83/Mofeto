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
using System.Runtime.InteropServices;
using System.Windows.Input;
using Mofeto.DesktopApplication.Commands;
using Mofeto.DesktopApplication.Models;

namespace Mofeto.DesktopApplication.ViewModels

{
    public class CreateCarViewModel : BaseViewModel
    {

        #region Fields

        private CarModel carModel;
        private int id;
        private string brand;
        private string modelType;
        private string fuelType;
        private double carTaxPerYear;
        private string insurancePayAgreement;
        private double insuranceCosts;
        private ObservableCollection<EntryModel> entries;

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

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value; 
                OnPropertyChanged(nameof(Brand));
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

        public double InsuranceCosts
        {
            get { return insuranceCosts; }
            set
            {
                insuranceCosts = value; 
                OnPropertyChanged(nameof(InsuranceCosts));
            }
        }

        public ICommand SaveCarCommand;

        public bool IsSelected = true;

        #endregion

        #region Constructor

        public CreateCarViewModel()
        {
            this.IsSelected = true;
            Title = "Hier kommen die CarDetails";
            CarModel = new CarModel();
            SaveCarCommand = new SaveCarCommand(this);
        }

        public CreateCarViewModel(CarModel carModel)
        {
            IsSelected = true;
            this.carModel = carModel;
            if (carModel != null)
            {
                this.Id = carModel.Id;
                if (!string.IsNullOrWhiteSpace(carModel.Brand)) this.Brand = carModel.Brand;
                if (!string.IsNullOrWhiteSpace(carModel.FuelType)) this.FuelType = carModel.FuelType;
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

        public void SaveCar()
        {
            Console.WriteLine($"{CarModel.Brand} {CarModel.ModelType} wurde gespeichert.");
            IsSelected = false;

        }

        #endregion

        #region EventHandler

        #endregion


    }
}