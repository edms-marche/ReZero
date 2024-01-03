﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
namespace ReZero.SuperAPI
{
    /// <summary>
    /// Provides utility methods for common operations.
    /// </summary>
    internal class PubMethod
    {
        /// <summary>
        /// Get the types derived from the base type.
        /// </summary>
        /// <param name="baseType">The base type</param>
        /// <returns>The types derived from the base type</returns>
        public static List<Type> GetTypesDerivedFromDbBase(Type baseType)
        {
            Assembly assembly = baseType.Assembly;
            List<Type> derivedTypes = new List<Type>();
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.IsSubclassOf(baseType))
                {
                    derivedTypes.Add(type);
                }
            }
            return derivedTypes;
        }

        /// <summary>
        /// Checks if the given string is a valid property name.
        /// </summary>
        /// <param name="str">The string to check</param>
        /// <returns>True if the string is a valid property name, otherwise false</returns>
        public static bool CheckIsPropertyName(string str)
        {
            return Regex.IsMatch(str, @"^[a-z,A-Z,_]\w*$");
        }
    }
}
 