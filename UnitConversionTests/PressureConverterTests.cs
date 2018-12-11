using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitConversion;
using UnitConversion.Base;

namespace UnitConversionTests
{
    [TestClass()]
    public class PressureConverterTests
    {
        PressureConverter converter = null;
        
        [TestCleanup()]
        public void Cleanup() {
            converter = null;
        }

        [TestMethod()]
        public void pa_pa() {
            converter = new PressureConverter("pa", "pa");
            double valL = 1;
            double valR = 1;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa_at() {
            converter = new PressureConverter("pa", "at");
            double valL = 1;
            double valR = 0.0000101972;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa_atm()
        {
            converter = new PressureConverter("pa", "atm");
            double valL = 1;
            double valR = 0.000009869233;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa_bar()
        {
            converter = new PressureConverter("pa", "bar");
            double valL = 1;
            double valR = 0.000010000000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa_mbar()
        {
            converter = new PressureConverter("pa", "mbar");
            double valL = 1;
            double valR = 0.010000000000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___kg_m2()
        {
            converter = new PressureConverter("pa", "kg/m2");
            double valL = 1;
            double valR = 0.101971621298;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___kg_cm2()
        {
            converter = new PressureConverter("pa", "kg/cm2");
            double valL = 1;
            double valR = 0.0000101971621298;
            
            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___kg_mm2()
        {
            converter = new PressureConverter("pa", "kg/mm2");
            double valL = 1;
            double valR = 0.000000101971621298;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___n_m2()
        {
            converter = new PressureConverter("pa", "n/m2");
            double valL = 1;
            double valR = 1;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___lb_in2()
        {
            converter = new PressureConverter("pa", "lb/in2");
            double valL = 1;
            double valR = 0.000145037738;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___lb_ft2()
        {
            converter = new PressureConverter("pa", "lb/ft2");
            double valL = 1;
            double valR = 0.020885434233;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___t_m2()
        {
            converter = new PressureConverter("pa", "t/m2");
            double valL = 1;
            double valR = 0.000101971621;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___long_ton_ft2()
        {
            converter = new PressureConverter("pa", "long ton/ft2");
            double valL = 1;
            double valR = 0.000009323855;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___long_ton_in2()
        {
            converter = new PressureConverter("pa", "long ton/in2");
            double valL = 1;
            double valR = 0.000000064749;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___short_ton_ft2()
        {
            converter = new PressureConverter("pa", "short ton/ft2");
            double valL = 1;
            double valR = 0.000010442717;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void pa___short_ton_in2()
        {
            converter = new PressureConverter("pa", "short ton/in2");
            double valL = 1;
            double valR = 0.000000072519;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }
    }
}
