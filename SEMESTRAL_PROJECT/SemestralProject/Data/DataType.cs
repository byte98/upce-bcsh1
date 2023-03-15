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
    internal class DataType
    {
        /// <summary>
        /// Enumeration of all available data types
        /// </summary>
        internal enum EDataType
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
            /// Enumeration data type
            /// </summary>
            Enum
        }

        /// <summary>
        /// Identifier of type of data type
        /// </summary>
        public int Type { get; init; }

        /// <summary>
        /// Array of allowed values (used only if Type is Enum)
        /// </summary>
        public string[]? AllowedValues { get; init; }

        /// <summary>
        /// Maximal allowed value (used only if Type is Integer)
        /// </summary>
        public int? MaxValue { get; init; }

        /// <summary>
        /// Minimal allowed value (used only if Type is Integer)
        /// </summary>
        public int? MinValue { get; init;}
    }
}
