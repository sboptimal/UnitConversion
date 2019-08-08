//-----------------------------------------------------------------------
// <copyright file="FlowConverter.cs" company="George Kampolis">
//     Copyright (c) George Kampolis. All rights reserved.
//     Licensed under the MIT License, Version 2.0. See LICENSE.md in the project root for license information.
// </copyright>
//-----------------------------------------------------------------------

namespace UnitConversion
{
    using System;
    using UnitConversion.Base;

    /// <summary>
    /// Converts between flow units.
    /// </summary>
    public class FlowConverter : BaseUnitConverter
    {
        UnitFactors units = new UnitFactors("m3/s")
        {
            { new UnitFactorSynonyms("m3/s", "cubic meter per second", "cumecs", "Cumsec"), 1 },

            { new UnitFactorSynonyms("cm3/s", "cubic centimetre per second"), 1_000_000.0 },
            { new UnitFactorSynonyms("cm3/min", "cubic centimetre per minute"), 60_000_000.0 },
            { new UnitFactorSynonyms("cm3/hour", "cubic centimetre per hour"), 3_600_000_000.0 },

            { new UnitFactorSynonyms("ft3/s", "cubic feet per second", "cusec", "Cusec"), 35.314666721489 },
            { new UnitFactorSynonyms("ft3/min", "cubic feet per minute"), 2_118.880003289315 },
            { new UnitFactorSynonyms("ft3/hour", "cubic feet per hour"), 127_132.800197358925 },

            { new UnitFactorSynonyms("in3/s", "cubic inch per second"), 61_023.744094732284 },
            { new UnitFactorSynonyms("in3/min", "cubic inch per minute"), 3_661_424.645683937040 },
            { new UnitFactorSynonyms("in3/hour", "cubic inch per hour"), 219_685_478.741036222000 },

            { new UnitFactorSynonyms("imp fl oz/s", "imperial fluid ounce per second"), 35_195.079727854046 },
            { new UnitFactorSynonyms("imp fl oz/min", "imperial fluid ounce per minute"), 2_111_704.783671242760 },
            { new UnitFactorSynonyms("imp fl oz/hour", "imperial fluid ounce per hour"), 126_702_287.020274566000 },

            { new UnitFactorSynonyms("imp gal/s", "imperial gallon per second"), 219.969248299088 },
            { new UnitFactorSynonyms("imp gal/min", "imperial gallon per minute"), 13_198.154897945267 },
            { new UnitFactorSynonyms("imp gal/hour", "imperial gallon per hour"), 791_889.293876716035 },

            { new UnitFactorSynonyms("l/s", "litres per second"), 1000.0 },         
            { new UnitFactorSynonyms("l/min", "litres per minute"), 60_000.0 },         
            { new UnitFactorSynonyms("l/hour", "litres per hour"), 3_600_000.0 },

            { new UnitFactorSynonyms("ml/s", "millilitres per second"), 1_000_000.0 },
            { new UnitFactorSynonyms("ml/min", "millilitres per minute"), 60_000_000.0 },
            { new UnitFactorSynonyms("ml/hour", "millilitres per hour"), 3_600_000_000.0 },

            { new UnitFactorSynonyms("us fl oz/s", "US fl oz/s", "US fluid ounce per second"), 33_814.022701801936 },
            { new UnitFactorSynonyms("us fl oz/min", "US fl oz/min", "US fluid ounce per minute"), 2_028_841.362108116170 },
            { new UnitFactorSynonyms("us fl oz/hour", "US fl oz/hour", "US fluid ounce per hour"), 121_730_481.726486970000 },


            { new UnitFactorSynonyms("us gal/s", "US gal/s", "US gallon per second", "US GPS"), 264.172052357828 },
            { new UnitFactorSynonyms("us gal/min", "US gal/min", "US gallon per minute", "US GPM"), 15_850.323141469658 },
            { new UnitFactorSynonyms("us gal/hour", "US gal/hour", "US gallon per hour", "US GPH"), 951_019.388488179454 },

        };

        public FlowConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public FlowConverter() : base()
        {
            Instantiate(units);
        }
    }
}
