using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnitConversion.Base;

namespace UnitConversion
{
    public class UnitConverter
    {
        private readonly Dictionary<int, IBaseUnitConverter> _unitConverters;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public UnitConverter()
        {
            _unitConverters = new Dictionary<int, IBaseUnitConverter>();
        }

        /// <summary>
        /// Register a unit converter 
        /// </summary>
        /// 
        /// <typeparam name="T">type of unit converter</typeparam>
        /// 
        /// <exception cref="UnitConverterAlreadyExistsException">occurs if the type converter has already been registered</exception>
        public void Register<T>()
            where T : class, IBaseUnitConverter, IUnitConverter
        {
            if (Contains<T>())
                throw new UnitConverterAlreadyExistsException(typeof(T).Name);

            if (Activator.CreateInstance(typeof(T)) is IBaseUnitConverter converter)
            {
                _unitConverters.Add(typeof(T).Name.GetHashCode(), converter);
            }
        }

        /// <summary>
        /// Registers all found unit converters within the assembly
        /// </summary>
        public void RegisterKnownUnitConverters()
        {

#if NETSTANDARD1_3

            foreach (var ti in typeof(UnitConverter).GetTypeInfo().Assembly.DefinedTypes)
            {
                if (!ti.IsAbstract && ti.ImplementedInterfaces.Contains(typeof(IUnitConverter))
                    && Activator.CreateInstance(ti.AsType()) is IBaseUnitConverter baseConverter)
                {
                    _unitConverters.Add(ti.Name.GetHashCode(), baseConverter);
                }
            }

#else

            foreach (var converter in typeof(UnitConverter).Assembly.GetExportedTypes().Where(t => !t.IsAbstract && typeof(IUnitConverter).IsAssignableFrom(t)).ToList())
            {
                if (Activator.CreateInstance(converter) is IBaseUnitConverter baseConverter)
                {
                    _unitConverters.Add(converter.Name.GetHashCode(), baseConverter);
                }
            }
#endif


        }

        /// <summary>
        /// Gets the number of registered unit converters
        /// </summary>
        public int Count => _unitConverters.Count;

        /// <summary>
        /// Determines if the unit converter contains the specified type
        /// </summary>
        /// 
        /// <typeparam name="T">type of unit converter</typeparam>
        /// 
        /// <returns>true if successful otherwise false</returns>
        public bool Contains<T>()
            where T : class, IBaseUnitConverter, IUnitConverter
        {
            return _unitConverters.ContainsKey(typeof(T).Name.GetHashCode());
        }

        /// <summary>
        /// Gets the converter for the specified type
        /// </summary>
        /// 
        /// <typeparam name="T">type of unit converter</typeparam>
        /// 
        /// <returns>the unit converter if successful otherwise null</returns>
        public IUnitConverter Get<T>()
            where T : class, IBaseUnitConverter, IUnitConverter
        {

            return Contains<T>()
                ? _unitConverters[typeof(T).Name.GetHashCode()] as IUnitConverter
                : default(IUnitConverter);
        }

        /// <summary>
        /// Add a new synonym to a unit converter
        /// </summary>
        /// 
        /// <typeparam name="T">type of unit converter</typeparam>
        /// 
        /// <param name="existingSynonym">name of an existing synonym</param>
        /// <param name="newSynonym">new synonym to add</param>
        /// 
        /// <exception cref="UnitConverterMissingException">occurs if the specified unit converter is not registered</exception>
        public void AddSynonym<T>(string existingSynonym, string newSynonym)
            where T : class, IBaseUnitConverter, IUnitConverter
        {
            if (!Contains<T>())
                throw new UnitConverterMissingException(typeof(T).Name);

            _unitConverters[typeof(T).Name.GetHashCode()].AddSynonym(existingSynonym, newSynonym);
        }

        /// <summary>
        /// Converts a value between units using the registered unit converters
        /// </summary>
        /// 
        /// <param name="fromUnit">Unit to convert from</param>
        /// <param name="toUnit">Unit to convert to</param>
        /// <param name="value">value to convert</param>
        /// 
        /// <returns></returns>
        /// 
        /// /// <exception cref="UnitNotSupportedException">occurs if either the from or to units are not found in a unit converter</exception>
        public double Convert(string fromUnit, string toUnit, double value)
        {
            if (string.IsNullOrEmpty(fromUnit))
                throw new ArgumentNullException(nameof(fromUnit), "Invalid From Unit parameter");

            if (string.IsNullOrEmpty(toUnit))
                throw new ArgumentNullException(nameof(toUnit), "Invalid To Unit parameter");

            if (FindUnitConverter(fromUnit, toUnit) is IBaseUnitConverter unitConverter)
            {
                unitConverter.UnitLeft = fromUnit;
                unitConverter.UnitRight = toUnit;

                return unitConverter.LeftToRight(value);
            }

            // This is unlikely to be hit as FindUnitConverter will throw an exception
            // if it doesn't find the supplied units
            return value;
        }

        /// <summary>
        /// Finds the specified units and returns the associated unit converter
        /// </summary>
        /// 
        /// <param name="fromUnit">unit converting from</param>
        /// <param name="toUnit">unit converting to</param>
        /// 
        /// <returns>the base unit converter if successful otherwise null</returns>
        /// 
        /// <exception cref="UnitNotSupportedException">occurs if either the from or to units are not found in a unit converter</exception>
        private IBaseUnitConverter FindUnitConverter(string fromUnit, string toUnit)
        {
            if (Count > 0)
            {
                foreach (var converter in _unitConverters.Values)
                {
                    if (converter.IsUnitSupported(fromUnit))
                    {
                        if (converter.IsUnitSupported(toUnit))
                        {
                            return converter;
                        }
                        else
                        {
                            throw new UnitNotSupportedException(toUnit);
                        }
                    }
                }

                throw new UnitNotSupportedException(fromUnit);
            }

            return default(IBaseUnitConverter);
        }
    }
}
