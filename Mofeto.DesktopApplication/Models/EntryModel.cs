/*
*----------------------------------------------------------------------------------
*          Filename:	EntryModel.cs
*          Date:        2020.06.01 14:52:35
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;

namespace Mofeto.DesktopApplication.Models

{
    public class EntryModel : ModelBase
    {

        #region Fields
        private int id;
        private string entrydate;
        private double pricePerLiter;
        private double amountOffuel;
        private double drivenDistance;
        private double totalamount;
        private double costPerHundredKilometer;
        private double consumptionperHundredKilometer;
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
        public string Entrydate
        {
            get { return entrydate; }
            set
            {
                entrydate = value;
                OnPropertyChanged(nameof(Entrydate));
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
        public double AmountOffuel
        {
            get { return amountOffuel; }
            set
            {
                amountOffuel = value;
                OnPropertyChanged(nameof(AmountOffuel));
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
        public double Totalamount
        {
            get { return totalamount; }
            set
            {
                totalamount = value;
                OnPropertyChanged(nameof(Totalamount));
            }
        }
        public double CostPerHundredKilometer
        {
            get { return costPerHundredKilometer; }
            set
            {
                costPerHundredKilometer = value;
                OnPropertyChanged(nameof(CostPerHundredKilometer));
            }
        }
        public double ConsumptationPerHundredKilometer
        {
            get { return consumptionperHundredKilometer; }
            set
            {
                consumptionperHundredKilometer = value;
                OnPropertyChanged(nameof(ConsumptationPerHundredKilometer));
            }
        }

        #endregion

        #region Constructor

        public EntryModel()
        {
         //   CalculateTotalCosts(PricePerLiter, AmountOffuel);
         //   CalculateConsumptionPerHundredKilometer(AmountOffuel, DrivenDistance);
        }

        #endregion

        #region Methods

        private double CalculateTotalCosts(double pricePerLiter, double amountOfRefuel)
        {
            this.pricePerLiter = pricePerLiter;
            this.amountOffuel = amountOfRefuel;

            totalamount = pricePerLiter * amountOfRefuel;


            return Totalamount;
        }

        private double CalculateConsumptionPerHundredKilometer(double amountOfFuel, double drivenDistance)
        {
            ConsumptationPerHundredKilometer = (amountOfFuel / drivenDistance) * 100;

            return ConsumptationPerHundredKilometer;
        }

        #endregion

        #region EventHandler

        #endregion


    }
}