//-----------------------------------------------------------------------
// <copyright file="AccelerationConverter.cs" company="George Kampolis">
//     Copyright (c) George Kampolis. All rights reserved.
//     Licensed under the MIT License, Version 2.0. See LICENSE.md in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------

namespace UnitConversion
{
    using System;
    using UnitConversion.Base;

    /// <summary>
    /// Converts between mass units.
    /// </summary>
    public class AccelerationConverter : BaseUnitConverter
    {
        UnitFactors units = new UnitFactors("m/s2")
        {
            { new UnitFactorSynonyms("m/s2", "metres per second squared"), 1 },

            { new UnitFactorSynonyms("cm/s2", "centimetres per second squared"), 100.0 },

            { new UnitFactorSynonyms("ft/s2", "feet per second squared"), 3.280839895013 },

            { new UnitFactorSynonyms("in/s2", "inches per second squared"), 39.370078740157 },

            { new UnitFactorSynonyms("mm/s2", "millimetres per second squared"), 1_000.0 },
        };

        public AccelerationConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public AccelerationConverter() : base()
        {
            Instantiate(units);
        }
    }
}
