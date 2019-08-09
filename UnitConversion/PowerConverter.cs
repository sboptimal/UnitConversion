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
    /// Converts between power units.
    /// </summary>
    public class PowerConverter : BaseUnitConverter
    {
        readonly UnitFactors units = new UnitFactors("W")
        {
            { new UnitFactorSynonyms("W", "Watts", "watts"), 1.0 },
            { new UnitFactorSynonyms("KW", "Kilowatt", "kilowatt"), 1E-3 },
            { new UnitFactorSynonyms("MW", "Megawatt", "megawatt"), 1E-6 },
            { new UnitFactorSynonyms("GW", "Gigawatt", "gigawatt"), 1E-9 },
            { new UnitFactorSynonyms("TW", "Terawatt", "terawatt"), 1E-12 },
            { new UnitFactorSynonyms("PW", "Petawatt", "petawatt"), 1E-15 },
            { new UnitFactorSynonyms("EW", "Exawatt", "exaawatt"), 1E-18 },
            { new UnitFactorSynonyms("HP", "Horsepower", "horsepower"), 0.00134102 },
        };

        public PowerConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public PowerConverter() : base()
        {
            Instantiate(units);
        }
    }
}
