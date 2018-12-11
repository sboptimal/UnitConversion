using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitConversion;
using UnitConversion.Base;

namespace UnitConversionTests {
    [TestClass()]
    public class ForceConverterTests
    {
        ForceConverter converter = null;
        
        [TestCleanup()]
        public void Cleanup() {
            converter = null;
        }

        [TestMethod()]
        public void n_n() {
            converter = new ForceConverter("n", "n");
            double valL = 1;
            double valR = 1;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void n_kg() {
            converter = new ForceConverter("n", "kg");
            double valL = 1;
            double valR = 0.101971621298;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void n_lb()
        {
            converter = new ForceConverter("n", "lb");
            double valL = 1;
            double valR = 0.224808943100;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void n_t()
        {
            converter = new ForceConverter("n", "t");
            double valL = 1;
            double valR = 0.000101971621;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void n_long_ton()
        {
            converter = new ForceConverter("n", "long ton");
            double valL = 1;
            double valR = 0.000100361135;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void n_short_ton()
        {
            converter = new ForceConverter("n", "short ton");
            double valL = 1;
            double valR = 0.000112404472;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }
    }
}
