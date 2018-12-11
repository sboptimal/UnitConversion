using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConversion.Base
{
    /// <summary>
    /// Indicates that a unit converter already exists
    /// </summary>
    public class UnitConverterAlreadyExistsException
        : Exception
    {

        internal UnitConverterAlreadyExistsException() { }
        internal UnitConverterAlreadyExistsException(string name) : base($"{name} Unit Converter already exists") { }

    }
}
