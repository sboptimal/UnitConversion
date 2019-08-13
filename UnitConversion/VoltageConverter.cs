//-----------------------------------------------------------------------
// <copyright file="VelocityConverter.cs" company="George Kampolis">
//     Copyright (c) George Kampolis. All rights reserved.
//     Licensed under the MIT License, Version 2.0. See LICENSE.md in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------

namespace UnitConversion
{
    using UnitConversion.Base;

    /// <summary>
    /// Converts between voltage units.
    /// </summary>
    public class VoltageConverter : BaseUnitConverter
    {
        readonly UnitFactors units = new UnitFactors("V")
        {
            { new UnitFactorSynonyms("V", "Volts", "volts"), 1.0 },
            { new UnitFactorSynonyms("mV", "millivolts"), 1E3 },
            { new UnitFactorSynonyms("uV", "microvolts"), 1E6 },
            
        };

        public VoltageConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public VoltageConverter() : base()
        {
            Instantiate(units);
        }
    }
}
