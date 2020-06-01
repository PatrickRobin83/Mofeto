/*
*----------------------------------------------------------------------------------
*          Filename:	Entry.cs
*          Date:        2020.06.01 14:52:35
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;

namespace Mofeto.DesktopApplication.Models

{
    public class Entry : ModelBase
    {

        #region Fields
        private int id;
        private DateTime dateOfRefueling;
        private double pricePerLiter;
        private double amountOfRefuel;
        private double drivenDistance;
        private double totalCostsOfRefueling;
        private double costsPerHundredKilometer;
        private double consumptionOfHundredKilometer;
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
        public DateTime DateOfRefueling
        {
            get { return dateOfRefueling; }
            set
            {
                dateOfRefueling = value;
                OnPropertyChanged(nameof(DateOfRefueling));
            }
        }
        public double PricePerLiter
        {
            get { return pricePerLiter; }
            set
            {
                pricePerLiter = value;
                OnPropertyChanged(nameof(PricePerLiter));
            }
        }
        public double AmountOfRefuel
        {
            get { return amountOfRefuel; }
            set
            {
                amountOfRefuel = value;
                OnPropertyChanged(nameof(AmountOfRefuel));
            }
        }
        public double DrivenDistance
        {
            get { return drivenDistance; }
            set
            {
                drivenDistance = value;
                OnPropertyChanged(nameof(DrivenDistance));
            }
        }
        public double TotalCostsOfRefueling
        {
            get { return totalCostsOfRefueling; }
            set
            {
                totalCostsOfRefueling = value;
                OnPropertyChanged(nameof(TotalCostsOfRefueling));
            }
        }
        public double CostsPerHundredKilometer
        {
            get { return costsPerHundredKilometer; }
            set
            {
                costsPerHundredKilometer = value;
                OnPropertyChanged(nameof(CostsPerHundredKilometer));
            }
        }
        public double ConsumptationOfHundredKilometer
        {
            get { return consumptionOfHundredKilometer; }
            set
            {
                consumptionOfHundredKilometer = value;
                OnPropertyChanged(nameof(ConsumptationOfHundredKilometer));
            }
        }

        #endregion

        #region Constructor

        public Entry(DateTime dateOfRefueling, 
                     double pricePerLiter, 
                     double amountOfFuel, 
                     double drivenDistance)
        {
            this.dateOfRefueling = dateOfRefueling;
            this.pricePerLiter = pricePerLiter;
            this.amountOfRefuel = amountOfFuel;
            this.drivenDistance = drivenDistance;
            CalculateTotalCosts(PricePerLiter, AmountOfRefuel);
            CalculateConsumptionPerHundredKilometer(AmountOfRefuel, DrivenDistance);
        }

        #endregion

        #region Methods

        private double CalculateTotalCosts(double pricePerLiter, double amountOfRefuel)
        {
            this.pricePerLiter = pricePerLiter;
            this.amountOfRefuel = amountOfRefuel;

            totalCostsOfRefueling = pricePerLiter * amountOfRefuel;


            return TotalCostsOfRefueling;
        }

        private double CalculateConsumptionPerHundredKilometer(double amountOfFuel, double drivenDistance)
        {
            ConsumptationOfHundredKilometer = (amountOfFuel / drivenDistance) * 100;

            return ConsumptationOfHundredKilometer;
        }

        #endregion

        #region EventHandler

        #endregion


    }
}