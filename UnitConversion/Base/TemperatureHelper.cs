using System;
using System.Linq;
using System.Collections.Generic;

namespace UnitConversion.Base
{
    public static class TemperatureHelper
    {
        private const string CELSIUS_KEY = "Celsius";
        private const string FAHRENHEIT_KEY = "Fahrenheit";
        private const string KELVIN_KEY = "Kelvin";
        
        //Reference: https://www.thoughtco.com/temperature-conversion-formulas-609324
        public static double AToB(IBaseUnitConverter unitConverter, double value, string startUnit, string endUnit)
        {
            UnitFactorSynonyms startUnitSyn = unitConverter.SupportedUnits.SingleOrDefault(r => r.Contains(startUnit));
            UnitFactorSynonyms endUnitSyn = unitConverter.SupportedUnits.SingleOrDefault(r => r.Contains(endUnit));

            if (startUnitSyn is default(UnitFactorSynonyms) || endUnitSyn is default(UnitFactorSynonyms))
                return value;

            if(startUnitSyn.Contains(CELSIUS_KEY) && endUnitSyn.Contains(FAHRENHEIT_KEY))
            {
                //Celsius to Fahrenheit : °F = 9/5 (°C) + 32
                return (((9d / 5) * value) + 32);
            }
            else if (startUnitSyn.Contains(KELVIN_KEY) && endUnitSyn.Contains(FAHRENHEIT_KEY))
            {
                //Kelvin to Fahrenheit: °F = 9 / 5(K - 273.15) + 32
                return ((9d / 5) * (value - 273.15) + 32);
            }
            else if (startUnitSyn.Contains(FAHRENHEIT_KEY) && endUnitSyn.Contains(CELSIUS_KEY))
            {
                //Fahrenheit to Celsius: °C = 5/9 (°F - 32)
                return ((5d / 9) * (value - 32));
            }
            else if (startUnitSyn.Contains(CELSIUS_KEY) && endUnitSyn.Contains(KELVIN_KEY))
            {
                //Celsius to Kelvin: K = °C + 273.15
                return value + 273.15;
            }
            else if (startUnitSyn.Contains(KELVIN_KEY) && endUnitSyn.Contains(CELSIUS_KEY))
            {
                //Kelvin to Celsius: °C = K - 273.15
                return value - 273.15;
            }
            else if (startUnitSyn.Contains(FAHRENHEIT_KEY) && endUnitSyn.Contains(KELVIN_KEY))
            {
                //Fahrenheit to Kelvin: K = 5 / 9(°F - 32) + 273.15
                return ((5d / 9) * (value - 32) + 273.15);
            }
            //Used "else" for corner case "both units are same"
            else
            {
                return value;
            }
        }
    }
}
