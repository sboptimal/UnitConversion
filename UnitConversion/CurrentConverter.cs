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
    /// Converts between current units.
    /// </summary>
    public class CurrentConverter : BaseUnitConverter
    {
        readonly UnitFactors units = new UnitFactors("A")
        {
            { new UnitFactorSynonyms("A", "Amp", "amp", "Amps", "amps"), 1.0 },
            { new UnitFactorSynonyms("mA", "milliamp", "milliamps"), 1E3 },
            { new UnitFactorSynonyms("uA", "microamp", "microamps"), 1E6 },

        };

        public CurrentConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public CurrentConverter() : base()
        {
            Instantiate(units);
        }
    }
}
