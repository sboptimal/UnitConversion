using UnitConversion.Base;

namespace UnitConversion
{
    public class TemperatureConverter: BaseUnitConverter
    {
        UnitFactors units = new UnitFactors("celsius")
        {
            { new UnitFactorSynonyms("celsius", "Celsius", "°C", "°c", "C", "1/°C", "degC"),1 },
            { new UnitFactorSynonyms("fahrenheit", "Fahrenheit", "°F", "°f", "F", "1/°F", "degF"),1 },
            { new UnitFactorSynonyms("Kelvin", "kelvin", "°K", "°k", "K", "1/°K", "degK"),1 },
        };
        
        public TemperatureConverter(string leftUnit, string rightUnit)
        {
            Instantiate(units, leftUnit, rightUnit);
        }
        public TemperatureConverter() : base()
        {
            Instantiate(units);
        }
    }
}
