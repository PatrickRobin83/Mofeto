/*
*----------------------------------------------------------------------------------
*          Filename:	ICar.cs
*          Date:        2020.01.30 22:31:29
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System;

namespace RietRob.Mofeto.Logic.Ui.Interfaces
{
    public interface IRecord
    {
        #region Properties

        /// <summary>
        /// Date of the refuel
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Price for one Liter Gasoline
        /// </summary>
        double PricePerLiter { get; set; }

        /// <summary>
        /// The total costs for this refuel entry 
        /// </summary>
        double TotalPrice { get; }

        /// <summary>
        /// The total amount of Fuel in Liter
        /// </summary>
        double AmountOfFuelInLiter { get;}

        /// <summary>
        /// Driven Distance from the last refueling
        /// </summary>
        double DrivenDistance { get; set; }
        /// <summary>
        /// This double represents how many Liter in 100 km the consumed.
        /// </summary>
        double ConsumptionInHundredKilometer { get; }

        /// <summary>
        /// This double represents the costs for 100 km.
        /// </summary>
        double CostsForHundredKilometer { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the consumption on 100 Kilometer
        /// </summary>
        /// <returns>the consumption in average for 100 Kilometer </returns>
        double GetConsumptionForHundredKilometer();

        /// <summary>
        /// Calculates the Costs in Average for 100 Kilometer
        /// </summary>
        /// <returns>Returns the average costs for 100 Kilometer as double</returns>
        double GetCostsForHundredKilometer();

        /// <summary>
        /// Calculates the total Amount for the refueling
        /// </summary>
        /// <returns> Returns the total Amount of the refueling as double </returns>
        double GetTotalAmount();

        #endregion
    }
}