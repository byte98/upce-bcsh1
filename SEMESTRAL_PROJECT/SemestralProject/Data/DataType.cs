using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class representing data type
    /// </summary>
    public class DataType
    {
        /// <summary>
        /// Enumeration of all available data types
        /// </summary>
        public enum EDataType
        {
            /// <summary>
            /// Text string data type
            /// </summary>
            String,

            /// <summary>
            /// Integer data type
            /// </summary>
            Integer,

            /// <summary>
            /// Double precision real number
            /// </summary>
            Double,

            /// <summary>
            /// Enumeration data type
            /// </summary>
            Enum,

            /// <summary>
            /// Date and time data type
            /// </summary>
            DateTime
        }

        /// <summary>
        /// Identifier of type of data type
        /// </summary>
        public DataType.EDataType Type { get; init; }

        /// <summary>
        /// Array of allowed values of enumeration (used only if <see cref="DataType.Type"/> is <see cref="EDataType.Integer"/>
        /// </summary>
        public string[]? AllowedValues { get; init; }

        /// <summary>
        /// Maximal allowed value for integer (used only if <see cref="DataType.Type"/> is <see cref="EDataType.Integer"/>
        /// </summary>
        public int? MaxInt { get; init; }

        /// <summary>
        /// Minimal allowed value for integer (used only if <see cref="DataType.Type"/> is <see cref="EDataType.Integer"/>
        /// </summary>
        public int? MinInt { get; init;}

        /// <summary>
        /// Maximal allowed value for double precision number (used only if <see cref="DataType.Type"/> is <see cref="EDataType.Double"/>
        /// </summary>
        public double? MaxDouble { get; init; }

        /// <summary>
        /// Minimal allowed value for double precision number (used only if <see cref="DataType.Type"/> is <see cref="EDataType.Double"/>
        /// </summary>
        public double? MinDouble { get; init; }

        /// <summary>
        /// Minimal length of string (used only if <see cref="DataType.Type"/> is <see cref="EDataType.String"/>
        /// </summary>
        public uint? MinLength { get; init; }

        /// <summary>
        /// Maximal length of string (used only if <see cref="DataType.Type"/> is <see cref="EDataType.String"/>
        /// </summary>
        public uint? MaxLength { get; init; }

        /// <summary>
        /// Minimal allowed value for date time (used only if <see cref="DataType.Type"/> is <see cref="EDataType.DateTime"/>
        /// </summary>
        public DateTime? MinDateTime { get; init; }

        /// <summary>
        /// Maximal allowed value for date time (used only if <see cref="DataType.Type"/> is <see cref="EDataType.DateTime"/>
        /// </summary>
        public DateTime? MaxDateTime { get; init; }

        /// <summary>
        /// Creates new integer data type
        /// </summary>
        /// <returns>Integer data type</returns>
        public static DataType CreateInt()
        {
            return DataType.CreateInt(int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Creates new integer data type
        /// </summary>
        /// <param name="min">Minimal allowed value</param>
        /// <param name="max">Maximal allowed value</param>
        /// <returns>Integer data type</returns>
        public static DataType CreateInt(int min, int max)
        {
            return new DataType
            {
                Type = EDataType.Integer,
                MinInt = min,
                MaxInt = max,
            };
        }

        /// <summary>
        /// Creates new double precision number data type
        /// </summary>
        /// <returns>Double precision number data type</returns>
        public static DataType CreateDouble()
        {
            return DataType.CreateDouble(double.MinValue, double.MaxValue);
        }

        /// <summary>
        /// Creates new double precision number data type
        /// </summary>
        /// <param name="min">Minimal allowed value</param>
        /// <param name="max">Maximal allowed value</param>
        /// <returns>Double precision number data type</returns>
        public static DataType CreateDouble(double min, double max)
        {
            return new DataType
            {
                Type = EDataType.Double,
                MinDouble = min,
                MaxDouble = max,
            };
        }

        /// <summary>
        /// Creates new textual string data type
        /// </summary>
        /// <returns>Textual string data type</returns>
        public static DataType CreateString()
        {
            return DataType.CreateString(uint.MinValue, uint.MaxValue);
        }

        /// <summary>
        /// Creates new textual string data type
        /// </summary>
        /// <param name="min">Minimal allowed length</param>
        /// <param name="max">Maximal allowed length</param>
        /// <returns>Textual string data type</returns>
        public static DataType CreateString(uint min, uint max)
        {
            return new DataType
            {
                Type = EDataType.String,
                MinLength = min,
                MaxLength = max
            };
        }


        /// <summary>
        /// Creates new enumeration data type
        /// </summary>
        /// <param name="allowedValues">Allowed values of enumeration</param>
        /// <returns>Enumeration data type</returns>
        public static DataType CreateEnum(string[] allowedValues)
        {
            return new DataType
            {
                Type = EDataType.DateTime,
                AllowedValues = allowedValues
            };
        }
    }
}
