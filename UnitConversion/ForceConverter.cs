//-----------------------------------------------------------------------
// <copyright file="ForceConverter.cs" company="George Kampolis">
//     Copyright (c) George Kampolis. All rights reserved.
//     Licensed under the MIT License, Version 2.0. See LICENSE.md in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------

namespace UnitConversion
{
    using System;
    using UnitConversion.Base;

    /// <summary>
    /// Converts between force units.
    /// </summary>
    public class ForceConverter : BaseUnitConverter
    {
        readonly UnitFactors units = new UnitFactors("N")
        {
            { new UnitFactorSynonyms("N", "Newton", "newton"), 1 },

            { new UnitFactorSynonyms("kg", "kgf"), 0.101971621298 },

            { new UnitFactorSynonyms("lb", "lbf", "pound", "Pound", "lbs"), 0.224808943100 },

            // Metric Ton
            { new UnitFactorSynonyms("t", "tonne", "metric ton", "ton", "tonnes", "metric tonnes"), 0.000101971621 },

            // Long Ton (UK)
            { new UnitFactorSynonyms("long ton"), 0.000100361135 },

            // Short Ton (US)
            { new UnitFactorSynonyms("short ton", "US ton", "US tons", "US t"), 0.000112404472 },

        };

        public ForceConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public ForceConverter() : base()
        {
            Instantiate(units);
        }
    }
}
