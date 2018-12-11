//-----------------------------------------------------------------------
// <copyright file="VelocityConverter.cs" company="George Kampolis">
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
    public class VelocityConverter : BaseUnitConverter
    {
        UnitFactors units = new UnitFactors("m/s")
        {
            { new UnitFactorSynonyms("m/s", "m/sec", "metre per second"), 1.0 },

            { new UnitFactorSynonyms("cm/s", "Centimetres per second"), 100.000000000000 },
            { new UnitFactorSynonyms("cm/min", "Centimetres per minute"), 6_000.000000000000 },
            { new UnitFactorSynonyms("cm/hour", "Centimetres per hour"), 360_000.000000000000 },

            { new UnitFactorSynonyms("ft/s", "feet per second"), 3.280839895013 },
            { new UnitFactorSynonyms("ft/min", "feet per minute"), 196.850393700787 },
            { new UnitFactorSynonyms("ft/hour", "feet per hour"), 11_811.023622047244 },

            { new UnitFactorSynonyms("in/s", "inches per second"), 39.370078740157 },
            { new UnitFactorSynonyms("in/min", "inches per minute"), 2_362.204724409449 },
            { new UnitFactorSynonyms("in/hour", "inches per hour"), 141_732.283464566929 },

            { new UnitFactorSynonyms("kph", "KPH", "Kilometres per hour"), 3.600000000000 },

            { new UnitFactorSynonyms("knots (UK)"), 1.941747572816 },
            { new UnitFactorSynonyms("knots (US)"), 1.943844492441 },

            { new UnitFactorSynonyms("m/min", "metre per minute"), 60.0 },
            { new UnitFactorSynonyms("m/hour", "metre per hour"), 3600.0 },

            { new UnitFactorSynonyms("mm/s", "mm/sec", "millimetre per second"), 1_000.000000000000 },
            { new UnitFactorSynonyms("mm/min", "millimetre per minute"), 60_000.000000000000 },
            { new UnitFactorSynonyms("mm/hour", "millimetre per hour"), 3_600_000.000000000000 },

            { new UnitFactorSynonyms("mph", "MPH", "miles per hour"), 2.236936292054 },

        };

        public VelocityConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public VelocityConverter() : base()
        {
            Instantiate(units);
        }
    }
}
