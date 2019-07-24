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
    /// Converts between angular units.
    /// </summary>
    public class AngularVelocityConverter : BaseUnitConverter
    {
        UnitFactors units = new UnitFactors("rad/s")
        {
            { new UnitFactorSynonyms("rad/s", "rad/sec", "radians per second", "rads"), 1.0 },

            { new UnitFactorSynonyms("deg/s", "deg/sec", "degrees per second", "degs"), 57.2957795 },
            
            { new UnitFactorSynonyms("rpm", "rev/sec", "revolutions per second"), 9.5492965964254 },

        };

        public AngularVelocityConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public AngularVelocityConverter() : base()
        {
            Instantiate(units);
        }
    }
}
