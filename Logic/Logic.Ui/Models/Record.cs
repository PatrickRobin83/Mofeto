/*
*----------------------------------------------------------------------------------
*          Filename:	Record.cs
*          Date:        2020.01.30 22:13:41
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using RietRob.Mofeto.Logic.Ui.Interfaces;
using System;

namespace RietRob.Mofeto.Logic.Ui.Models

{
    /// <summary>
    /// This Class represents one bill from the gasstation
    /// </summary>
    public class Record : IRecord
    {
        #region Fields
        /// <summary>
        /// Date of the refuel
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Price for one Liter Gasoline
        /// </summary>
        private double _pricePerLiter;

        private readonly double _totalAmountOfFuelInLiter;

        /// <summary>
        /// The total costs for this refuel entry 
        /// </summary>
        private readonly double _totalPrice;

        /// <summary>
        /// Driven Distance from the last refueling
        /// </summary>
        private double _drivenDistance;

        /// <summary>
        /// This double represents how many Liter in 100 km the consumed.
        /// </summary>
        private readonly double _consumptionInHundredKilometer;

        /// <summary>
        /// This double represents the costs for 100 km.
        /// </summary>
        private readonly double _costsForHundredKilometer;

        private Car _car;

        #endregion

        #region Properties


        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public double PricePerLiter
        {
            get => _pricePerLiter;
            set => _pricePerLiter = value;
        }

        public double TotalPrice
        {
            get => _totalPrice;
        }

        /// <summary>
        /// The total amount of Fuel in Liter
        /// </summary>
        public double AmountOfFuelInLiter
        {
            get => _totalAmountOfFuelInLiter;
        }

        public double DrivenDistance
        {
            get => _drivenDistance;
            set => _drivenDistance = value;
        }

        public double ConsumptionInHundredKilometer => _consumptionInHundredKilometer;

        public double CostsForHundredKilometer => _costsForHundredKilometer;

        #endregion

        #region Constructor 

        public Record(DateTime date, double pricePerLiter, double drivenDistance, double totalAmountOfFuelInLiter, Car car)
        {
            _date = date;
            _pricePerLiter = pricePerLiter;
            _drivenDistance = drivenDistance;
            _totalAmountOfFuelInLiter = totalAmountOfFuelInLiter;
            _car = car;
            _totalPrice = GetTotalAmount();
            _consumptionInHundredKilometer = GetConsumptionForHundredKilometer();
            _costsForHundredKilometer = GetCostsForHundredKilometer();
        }
        #endregion


        #region Methods

        public double GetConsumptionForHundredKilometer()
        {
            return (_totalAmountOfFuelInLiter / _drivenDistance) * 100;
            
        }

        public double GetCostsForHundredKilometer()
        {
            return _pricePerLiter * ConsumptionInHundredKilometer;
        }

        public double GetTotalAmount()
        {

            return _pricePerLiter * _totalAmountOfFuelInLiter;
        }

        #endregion


    }
}