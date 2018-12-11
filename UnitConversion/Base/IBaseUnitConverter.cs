using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConversion.Base
{
    public interface IBaseUnitConverter
    {

        /// <summary>
        /// The Unit to convert on the left
        /// </summary>
        string UnitLeft { get; set; }

        /// <summary>
        /// The Unit to convert on the right
        /// </summary>
        string UnitRight { get; set; }

        /// <summary>
        /// Convert the Unit on the Left to the Unit on the Right
        /// </summary>
        /// <param name="value">the Unit's value</param>
        /// <returns>The converted value</returns>
        double LeftToRight(double value);

        /// <summary>
        /// Convert the Unit on the Left to the Unit on the Right
        /// </summary>
        /// <param name="value">the Unit's value</param>
        /// <param name="decimals">how many decimal places to round to</param>
        /// <returns>The converted value</returns>
        double LeftToRight(double value, int decimals);

        /// <summary>
        /// Convert the Unit on the Right to the Unit on the Left
        /// </summary>
        /// <param name="value">the Unit's value</param>
        /// <returns>The converted value</returns>
        double RightToLeft(double value);

        /// <summary>
        /// Convert the Unit on the Right to the Unit on the Left
        /// </summary>
        /// <param name="value">the Unit's value</param>
        /// <param name="decimals">how many decimal places to round to</param>
        /// <returns>The converted value</returns>
        double RightToLeft(double value, int decimals);

        /// <summary>
        /// Get an enumerable of all the UnitFactorKeys, which contain synonyms for each unit
        /// </summary>
        IEnumerable<UnitFactorSynonyms> SupportedUnits { get; }

        /// <summary>
        /// Add a new synonym to an existing unit's list of names
        /// </summary>
        /// <param name="existingSynonym">Some synonym from an existing unit</param>
        /// <param name="newSynonym">New synonym to append to the unit</param>
        void AddSynonym(string existingSynonym, string newSynonym);

        /// <summary>
        /// Add a new unit with a new set of synonyms
        /// </summary>
        /// <param name="synonyms">Object of synonyms</param>
        /// <param name="factor"></param>
        void AddUnit(UnitFactorSynonyms synonyms, double factor);

        /// <summary>
        /// Add a new unit
        /// </summary>
        /// <param name="name"></param>
        /// <param name="factor"></param>
        void AddUnit(string name, double factor);

        /// <summary>
        /// Checks to see if the unit is supported
        /// </summary>
        /// <param name="name">name of the unit</param>
        /// <returns>true if supported otherwise false</returns>
        bool IsUnitSupported(string name);
    }
}
