using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitConversion;
using UnitConversion.Base;

namespace UnitConversionTests {
    [TestClass()]
    public class FlowConverterTests
    {
        FlowConverter converter = null;
        
        [TestCleanup()]
        public void Cleanup() {
            converter = null;
        }

        [TestMethod()]
        public void m3_s___m3_s() {
            converter = new FlowConverter("m3/s", "m3/s");
            double valL = 1;
            double valR = 1;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___cm3_s() {
            converter = new FlowConverter("m3/s", "cm3/s");
            double valL = 1;
            double valR = 1_000_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___cm3_min()
        {
            converter = new FlowConverter("m3/s", "cm3/min");
            double valL = 1;
            double valR = 60_000_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___cm3_hour()
        {
            converter = new FlowConverter("m3/s", "cm3/hour");
            double valL = 1;
            double valR = 3_600_000_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___ft3_s()
        {
            converter = new FlowConverter("m3/s", "ft3/s");
            double valL = 1;
            double valR = 35.314666721489;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___ft3_min()
        {
            converter = new FlowConverter("m3/s", "ft3/min");
            double valL = 1;
            double valR = 2_118.880003289315;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___ft3_hour()
        {
            converter = new FlowConverter("m3/s", "ft3/hour");
            double valL = 1;
            double valR = 127_132.800197358925;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___in3_s()
        {
            converter = new FlowConverter("m3/s", "in3/s");
            double valL = 1;
            double valR = 61_023.744094732284;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___in3_min()
        {
            converter = new FlowConverter("m3/s", "in3/min");
            double valL = 1;
            double valR = 3_661_424.645683937040;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___in3_hour()
        {
            converter = new FlowConverter("m3/s", "in3/hour");
            double valL = 1;
            double valR = 219_685_478.741036222000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___imp_fl_oz_s()
        {
            converter = new FlowConverter("m3/s", "imp fl oz/s");
            double valL = 1;
            double valR = 35_195.079727854046;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___imp_fl_oz_min()
        {
            converter = new FlowConverter("m3/s", "imp fl oz/min");
            double valL = 1;
            double valR = 2_111_704.783671242760;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___imp_fl_oz_hour()
        {
            converter = new FlowConverter("m3/s", "imp fl oz/hour");
            double valL = 1;
            double valR = 126_702_287.020274566000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }        

        [TestMethod()]
        public void m3_s___imp_gal_s()
        {
            converter = new FlowConverter("m3/s", "imp gal/s");
            double valL = 1;
            double valR = 219.969248299088;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___imp_gal_min()
        {
            converter = new FlowConverter("m3/s", "imp gal/min");
            double valL = 1;
            double valR = 13_198.154897945267;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___imp_gal_hour()
        {
            converter = new FlowConverter("m3/s", "imp gal/hour");
            double valL = 1;
            double valR = 791_889.293876716035;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___l_s()
        {
            converter = new FlowConverter("m3/s", "l/s");
            double valL = 1;
            double valR = 1_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___l_min()
        {
            converter = new FlowConverter("m3/s", "l/min");
            double valL = 1;
            double valR = 60_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___l_hour()
        {
            converter = new FlowConverter("m3/s", "l/hour");
            double valL = 1;
            double valR = 3_600_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___ml_s()
        {
            converter = new FlowConverter("m3/s", "ml/s");
            double valL = 1;
            double valR = 1_000_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___ml_min()
        {
            converter = new FlowConverter("m3/s", "ml/min");
            double valL = 1;
            double valR = 60_000_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___ml_hour()
        {
            converter = new FlowConverter("m3/s", "ml/hour");
            double valL = 1;
            double valR = 3_600_000_000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___us_fl_oz_s()
        {
            converter = new FlowConverter("m3/s", "us fl oz/s");
            double valL = 1;
            double valR = 33_814.022701801936;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___us_fl_oz_min()
        {
            converter = new FlowConverter("m3/s", "us fl oz/min");
            double valL = 1;
            double valR = 2_028_841.362108116170;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___us_fl_oz_hour()
        {
            converter = new FlowConverter("m3/s", "us fl oz/hour");
            double valL = 1;
            double valR = 121_730_481.726486970000;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___us_gal_s()
        {
            converter = new FlowConverter("m3/s", "us gal/s");
            double valL = 1;
            double valR = 264.172052357828;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___us_gal_min()
        {
            converter = new FlowConverter("m3/s", "us gal/min");
            double valL = 1;
            double valR = 15_850.323141469658;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }

        [TestMethod()]
        public void m3_s___us_gal_hour()
        {
            converter = new FlowConverter("m3/s", "us gal/hour");
            double valL = 1;
            double valR = 951_019.388488179454;

            Assert.AreEqual(valR, converter.LeftToRight(valL));
            Assert.AreEqual(valL, converter.RightToLeft(valR));
        }
    }
}
