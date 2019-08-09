using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConversion;

namespace UnitConversionTests
{
    [TestClass()]
    public class General
    {

        private UnitConverter converter = null;

        [TestCleanup()]
        public void Cleanup()
        {
            converter = null;
        }

        [TestMethod()]
        public void RegisterKnownUnitConverters()
        {
            converter = new UnitConverter();
            converter.RegisterKnownUnitConverters();

        }
    }
}
