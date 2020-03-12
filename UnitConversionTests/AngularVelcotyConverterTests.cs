using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitConversion;

namespace UnitConversionTests
{
    [TestClass()]
    public class AngularVelcotyConverterTests
    {
        AngularVelocityConverter converter = null;

        [TestCleanup()]
        public void Cleanup()
        {
            converter = null;
        }

        [TestMethod()]
        public void rad_s___rad_s()
        {
            converter = new AngularVelocityConverter("rad/s", "rad/s");
            double valL = 1;
            double valR = 1;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void rad_s___rpm()
        {
            converter = new AngularVelocityConverter("rad/s", "rpm");
            double valL = 1;
            double valR = 60 / (2 * Math.PI);

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void rad_s___rps()
        {
            converter = new AngularVelocityConverter("rad/s", "rps");
            double valL = 1;
            double valR = 2 * Math.PI;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void rad_s___deg_s()
        {
            converter = new AngularVelocityConverter("rad/s", "deg/s");
            double valL = 1;
            double valR = 360 / (2 * Math.PI);

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }
    }
}
