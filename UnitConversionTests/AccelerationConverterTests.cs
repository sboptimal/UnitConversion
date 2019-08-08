using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitConversion;
using UnitConversion.Base;

namespace UnitConversionTests {
    [TestClass()]
    public class AccelerationConverterTests
    {
        LinearAccelerationConverter converter = null;
        
        [TestCleanup()]
        public void Cleanup() {
            converter = null;
        }

        [TestMethod()]
        public void m_s2___m_s2() {
            converter = new LinearAccelerationConverter("m/s2", "m/s2");
            double valL = 1;
            double valR = 1;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s2___cm_s2() {
            converter = new LinearAccelerationConverter("m/s2", "cm/s2");
            double valL = 1;
            double valR = 100;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s2___ft_s2()
        {
            converter = new LinearAccelerationConverter("m/s2", "ft/s2");
            double valL = 1;
            double valR = 3.280839895013;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s2___in_s2()
        {
            converter = new LinearAccelerationConverter("m/s2", "in/s2");
            double valL = 1;
            double valR = 39.370078740157;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s2___mm_s2()
        {
            converter = new LinearAccelerationConverter("m/s2", "mm/s2");
            double valL = 1;
            double valR = 1_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }
    }
}
