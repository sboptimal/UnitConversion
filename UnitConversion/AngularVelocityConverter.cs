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

            { new UnitFactorSynonyms("deg/s", "deg/sec", "degrees per second", "degs"), 360/(2*Math.PI) },
            
            { new UnitFactorSynonyms("rps", "rev/s", "revolutions per second"), 2*Math.PI },

            { new UnitFactorSynonyms("rpm", "rev/min", "revolutions per minute"), 60/(2*Math.PI) },

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
