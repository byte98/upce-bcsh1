using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Interface abstracting methods for all mutable objects
    /// (this simplifies using these objects in GUI)
    /// </summary>
    internal interface IMutable
    {
        /// <summary>
        /// Class representgin arguments of object changed event
        /// </summary>
        public class MutableObjectChangedEventArgs: EventArgs
        {
            /// <summary>
            /// Object which has been changed
            /// </summary>
            IMutable? target { get; init; }

            /// <summary>
            /// Name of property which has been changed
            /// </summary>
            string? property { get; init; }
        }

        /// <summary>
        /// Delegate of change object event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public delegate void MutableObjectChangedEventHandler(object sender, MutableObjectChangedEventArgs args);

        /// <summary>
        /// Change object event
        /// </summary>
        public event MutableObjectChangedEventHandler? MutableObjectChanged;

        /// <summary>
        /// Array of properties of object
        /// </summary>
        public abstract string[] Properties { get; }

        /// <summary>
        /// Checks, whether property is read only
        /// </summary>
        /// <param name="property">Name of property which will be checked</param>
        /// <returns>TRUE if property is read only, FALSE otherwise</returns>
        public abstract bool IsReadOnly(string property);

        /// <summary>
        /// Gets data type of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <returns>Data type of property or NULL if there is no such a property</returns>
        public abstract DataType? GetDataType(string property);

        /// <summary>
        /// Sets value of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <param name="value">Value of property</param>
        public abstract void Set(string property, int value);

        /// <summary>
        /// Sets value of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <param name="value">Value of property</param>
        public abstract void Set(string property, string value);

        /// <summary>
        /// Sets value of enumeration
        /// </summary>
        /// <param name="enumName">Name of enumeration</param>
        /// <param name="value">Value of enumeration</param>
        public abstract void SetEnum(string enumName, string value);
    }
}
