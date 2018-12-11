using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitConversion;
using UnitConversion.Base;

namespace UnitConversionTests {
    [TestClass()]
    public class VelocityConverterTests
    {
        VelocityConverter converter = null;
        
        [TestCleanup()]
        public void Cleanup() {
            converter = null;
        }

        [TestMethod()]
        public void m_s___m_s() {
            converter = new VelocityConverter("m/s", "m/s");
            double valL = 1;
            double valR = 1;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___cm_s() {
            converter = new VelocityConverter("m/s", "cm/s");
            double valL = 1;
            double valR = 100;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___cm_min()
        {
            converter = new VelocityConverter("m/s", "cm/min");
            double valL = 1;
            double valR = 6_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___cm_hour()
        {
            converter = new VelocityConverter("m/s", "cm/hour");
            double valL = 1;
            double valR = 360_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___ft_s()
        {
            converter = new VelocityConverter("m/s", "ft/s");
            double valL = 1;
            double valR = 3.280839895013;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___ft_min()
        {
            converter = new VelocityConverter("m/s", "ft/min");
            double valL = 1;
            double valR = 196.850393700787;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___ft_hour()
        {
            converter = new VelocityConverter("m/s", "ft/hour");
            double valL = 1;
            double valR = 11_811.023622047244;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___in_s()
        {
            converter = new VelocityConverter("m/s", "in/s");
            double valL = 1;
            double valR = 39.370078740157;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___in_min()
        {
            converter = new VelocityConverter("m/s", "in/min");
            double valL = 1;
            double valR = 2_362.204724409449;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___in_hour()
        {
            converter = new VelocityConverter("m/s", "in/hour");
            double valL = 1;
            double valR = 141_732.283464566929;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___kph()
        {
            converter = new VelocityConverter("m/s", "kph");
            double valL = 1;
            double valR = 3.6;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___knots_uk()
        {
            converter = new VelocityConverter("m/s", "knots (UK)");
            double valL = 1;
            double valR = 1.941747572816;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___knots_us()
        {
            converter = new VelocityConverter("m/s", "knots (US)");
            double valL = 1;
            double valR = 1.943844492441;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___m_min()
        {
            converter = new VelocityConverter("m/s", "m/min");
            double valL = 1;
            double valR = 60;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___m_hour()
        {
            converter = new VelocityConverter("m/s", "m/hour");
            double valL = 1;
            double valR = 3600;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___mm_s()
        {
            converter = new VelocityConverter("m/s", "mm/s");
            double valL = 1;
            double valR = 1000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___mm_min()
        {
            converter = new VelocityConverter("m/s", "mm/min");
            double valL = 1;
            double valR = 60_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___mm_hour()
        {
            converter = new VelocityConverter("m/s", "mm/hour");
            double valL = 1;
            double valR = 3_600_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m_s___mph()
        {
            converter = new VelocityConverter("m/s", "mph");
            double valL = 1;
            double valR = 2.236936292054;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        
    }
}
