/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   FuelTypeModel.cs
 *   Date			:   2020-06-05 15:17:49
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

namespace Mofeto.DesktopApplication.Models
{
    public class FuelTypeModel
    {
        

        #region Fields

        #endregion

        #region Properties

        public int Id { get; set; }
        public string TypeOfFuel { get; set; }

        #endregion

        #region Constructor

        #endregion

        #region Methods

        public override string ToString()
        {
            return TypeOfFuel;
        }

        #endregion

    }
}