using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitConversion;
using UnitConversion.Base;

namespace UnitConversionTests
{
    [TestClass()]
    public class UnitConverterTests
    {
        [TestInitialize()]
        public void Initialize()
        {
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod()]
        public void RegisterSingleConverter()
        {
            UnitConverter converter = new UnitConverter();
            converter.Register<MassConverter>();

            int count = converter.Count;

            Assert.AreEqual(count, 1);
        }

        [TestMethod()]
        public void RegisterMultipleConverters()
        {
            UnitConverter converter = new UnitConverter();
            converter.Register<MassConverter>();
            converter.Register<ForceConverter>();
            converter.Register<PressureConverter>();

            int count = converter.Count;

            Assert.AreEqual(count, 3);
        }

        [TestMethod()]
        [ExpectedException(typeof(UnitConverterAlreadyExistsException))]
        public void DuplicateRegistration()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();
            converter.Register<MassConverter>();

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an UnitConverterAlreadyExistsException");
        }

        [TestMethod]
        public void RegisterAllKnownUnitConverters()
        {
            UnitConverter converter = new UnitConverter();

            converter.RegisterKnownUnitConverters();

            Assert.IsTrue(converter.Count > 0);
        }

        [TestMethod]
        public void CountCheck()
        {
            UnitConverter converter = new UnitConverter();

            int initCount = converter.Count;

            converter.Register<MassConverter>();
            converter.Register<ForceConverter>();

            int lastCount = converter.Count;

            Assert.AreEqual(initCount, 0);
            Assert.AreEqual(lastCount, 2);
        }

        [TestMethod()]
        public void ValidContainsCheck()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            bool contains = converter.Contains<MassConverter>();

            Assert.IsTrue(contains);
        }

        [TestMethod()]
        public void InvalidContainsCheck()
        {
            UnitConverter converter = new UnitConverter();

            bool contains = converter.Contains<MassConverter>();

            Assert.IsFalse(contains);
        }

        [TestMethod()]
        public void GetValidConverter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            IUnitConverter unitConverter = converter.Get<MassConverter>();

            Assert.IsNotNull(unitConverter);
        }

        [TestMethod()]
        public void GetInvalidConverter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            IUnitConverter unitConverter = converter.Get<ForceConverter>();

            Assert.IsNull(unitConverter);
        }

        [TestMethod()]
        public void AddCustomSynonymToExistingConverter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();
            converter.Register<TemperatureConverter>();
            converter.Register<PressureConverter>();

            converter.AddSynonym<TemperatureConverter>("°C", "1/C");
            converter.AddSynonym<TemperatureConverter>("°F", "1/F");

            double value = converter.Convert("1/C", "1/F", 1.0);

            Assert.AreEqual(33.8, value);
        }

        [TestMethod()]
        [ExpectedException(typeof(UnitConverterMissingException))]
        public void AddCustomSynonymToMissingConverter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();
            converter.Register<PressureConverter>();

            converter.AddSynonym<TemperatureConverter>("°C", "1/°C");
            converter.AddSynonym<TemperatureConverter>("°F", "1/°F");

            double value = converter.Convert("1/°C", "1/°F", 1.0);

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an UnitConverterMissingException");
        }

        [TestMethod()]
        [ExpectedException(typeof(UnitNotSupportedException))]
        public void ConvertCustomSynonymWithMissingSynonym()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();
            converter.Register<TemperatureConverter>();
            converter.Register<PressureConverter>();

            converter.AddSynonym<TemperatureConverter>("°C", "1/C");

            double value = converter.Convert("1/C", "1/F", 1.0);

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an UnitNotSupportedException");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConvertWithNullFromParameter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            double value = converter.Convert(null, "gram", 1.0);

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an ArgumentNullException");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConvertWithEmptyFromParameter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            double value = converter.Convert(string.Empty, "gram", 1.0);

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an ArgumentNullException");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConvertWithNullToParameter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            double value = converter.Convert("kg", null, 1.0);

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an ArgumentNullException");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConvertWithEmptyToParameter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            double value = converter.Convert("kg", string.Empty, 1.0);

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an ArgumentNullException");
        }

        [TestMethod]
        public void ConvertBaseToDerived_SingleConverter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            double expected = 1000.0;
            double value = converter.Convert("kg", "gram", 1.0);

            Assert.AreEqual(value, expected);
        }

        [TestMethod]
        public void ConvertDerivedToBase_SingleConverter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();

            double expected = 1.0;
            double value = converter.Convert("gram", "kg", 1000.0);

            Assert.AreEqual(value, expected);
        }

        [TestMethod]
        public void ConvertBaseToDerived_MultipleConverter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();
            converter.Register<PressureConverter>();
            converter.Register<ForceConverter>();

            double expected = 0.000010000000;
            double value = converter.Convert("Pa", "Bar", 1.0);

            Assert.AreEqual(value, expected);
        }

        [TestMethod]
        public void ConvertDerivedToBase_MultipleConverter()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();
            converter.Register<PressureConverter>();
            converter.Register<ForceConverter>();

            double expected = 1.0;
            double value = converter.Convert("Bar", "Pa", 0.000010000000);

            Assert.AreEqual(value, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(UnitNotSupportedException))]
        public void ConvertBaseToDerived_MissingFromArgument()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();
            converter.Register<PressureConverter>();
            converter.Register<ForceConverter>();

            double value = converter.Convert("InvalidPascals", "Bar", 1.0);

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an UnitNotSupportedException");
        }

        [TestMethod]
        [ExpectedException(typeof(UnitNotSupportedException))]
        public void ConvertBaseToDerived_MissingToArgument()
        {
            UnitConverter converter = new UnitConverter();

            converter.Register<MassConverter>();
            converter.Register<PressureConverter>();
            converter.Register<ForceConverter>();

            double value = converter.Convert("Pa", "MissingBar", 1.0);

            // This shouldn't run if the exception is raised
            Assert.Fail("Should have raised an UnitNotSupportedException");
        }
    }
}
