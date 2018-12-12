using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConversion
{
    /// <summary>
    /// Indicates that a unit converter is missing
    /// </summary>
    public class UnitConverterMissingException
        : Exception
    {

        internal UnitConverterMissingException() { }
        internal UnitConverterMissingException(string name) : base($"{name} Unit Converter missing") { }

    }
}
