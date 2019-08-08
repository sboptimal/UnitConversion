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
    /// Converts between rotationl force units.
    /// </summary>
    public class RotationalForceConverter : BaseUnitConverter
    {
        readonly UnitFactors units = new UnitFactors("Nm")
        {
            { new UnitFactorSynonyms("Nn", "Newton meter", "Newton meters"), 1.0 },

            { new UnitFactorSynonyms("lb.ft", "Pound Foot", "pound foot", "Lb-Ft", "lb-ft"), 0.73756214927727 },

            { new UnitFactorSynonyms("lb.in", "Pound Inch", "pound inch", "Lb-In", "lb-in"), 8.8507457673787 },

            { new UnitFactorSynonyms("ft.lb", "Foot Pound", "foot pound", "Ft-Lb", "ft-lb"), 0.73756214927727 },

            { new UnitFactorSynonyms("kg.m", "Kilogram Meter", "kilogram meter", "Kg.m", "kg.m"), 0.10197162129779283 },

            { new UnitFactorSynonyms("kg.cm", "Kilogram Centimeter", "kilogram centimeter", "Kg.cm", "kg.cm"), 10.197162129779 },

        };

        public RotationalForceConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public RotationalForceConverter() : base()
        {
            Instantiate(units);
        }
    }
}
