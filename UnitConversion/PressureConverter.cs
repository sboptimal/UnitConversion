//-----------------------------------------------------------------------
// <copyright file="PressureConverter.cs" company="George Kampolis">
//     Copyright (c) George Kampolis. All rights reserved.
//     Licensed under the MIT License, Version 2.0. See LICENSE.md in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------

namespace UnitConversion
{
    using System;
    using UnitConversion.Base;

    /// <summary>
    /// Converts between pressure units.
    /// </summary>
    public class PressureConverter : BaseUnitConverter
    {
        readonly UnitFactors units = new UnitFactors("pa")
        {
            { new UnitFactorSynonyms("pa", "Pa", "pascal", "Pascal"), 1 },
            
            // Technical Atmosphere
            { new UnitFactorSynonyms("at"), 0.0000101972 },

            // Standard Atmosphere
            { new UnitFactorSynonyms("atm", "atmosphere", "Atmosphere"), 0.000009869233 },

            { new UnitFactorSynonyms("bar", "Bar"), 0.0000100 },
            { new UnitFactorSynonyms("mbar", "millibar"), 0.0100 },

            { new UnitFactorSynonyms("kg/m2", "kg per square meter", "kgf/m2"), 0.101971621298 },
            { new UnitFactorSynonyms("kg/cm2", "kg per square centimetre", "kgf/cm2"), 0.101971621298E-4 },
            { new UnitFactorSynonyms("kg/mm2", "kg per square millimetre", "kgf/mm2"), 0.101971621298E-6 },

            { new UnitFactorSynonyms("n/m2", "Newton per square meter", "N/m2", "N.m-2"), 1.0 },

            { new UnitFactorSynonyms("lb/ft2", "psf", "pounds per square foot", "pounds/ft2", "lbf/ft2"), 0.020885434233 },

            { new UnitFactorSynonyms("lb/in2", "psi", "pounds per square inch", "pounds/in2", "lbf/in2"), 0.000145037738 },

            // Metric Ton
            { new UnitFactorSynonyms("t/m2", "tonne per square meter", "ton/m2"), 0.000101971621 },

            // Long Tonnes (UK)
            { new UnitFactorSynonyms("long ton/ft2", "long ton per square foot"), 0.000009323855 },
            { new UnitFactorSynonyms("long ton/in2", "long ton per square inch"), 0.000000064749 },

            // Short Ton (US)
            { new UnitFactorSynonyms("short ton/ft2", "short ton per square foot"), 0.000010442717 },
            { new UnitFactorSynonyms("short ton/in2", "short ton per square inch"), 0.000000072519 },
        };

        public PressureConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public PressureConverter() : base()
        {
            Instantiate(units);
        }
    }
}
