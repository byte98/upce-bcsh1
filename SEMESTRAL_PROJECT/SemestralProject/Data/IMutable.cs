using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.AtomPub;

namespace SemestralProject.Data
{
    /// <summary>
    /// Interface abstracting methods for all mutable objects
    /// (this simplifies using these objects in GUI)
    /// </summary>
    public interface IMutable
    {
        /// <summary>
        /// Class representgin arguments of object changed event
        /// </summary>
        public class MutableObjectChangedEventArgs: EventArgs
        {
            /// <summary>
            /// Object which has been changed
            /// </summary>
            public IMutable? Target { get; init; }

            /// <summary>
            /// Name of property which has been changed
            /// </summary>
            public string? Property { get; init; }
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
        public virtual string[] Properties => new string[0];

        /// <summary>
        /// Checks, whether property is read only
        /// </summary>
        /// <param name="property">Name of property which will be checked</param>
        /// <returns>TRUE if property is read only, FALSE otherwise</returns>
        public bool IsReadOnly(string property)
        {
            return true;
        }

        /// <summary>
        /// Gets data type of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <returns>Data type of property or NULL if there is no such a property</returns>
        public DataType? GetDataType(string property)
        {
            return null;
        }

        /// <summary>
        /// Sets value of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <param name="value">Value of property</param>
        public void Set(string property, int value)
        {
            // NOP
        }

        /// <summary>
        /// Sets value of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <param name="value">Value of property</param>
        public void Set(string property, string value)
        {
            // NOP
        }

        /// <summary>
        /// Sets value of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <param name="value">Value of property</param>
        public void Set(string property, double value)
        {
            // NOP
        }

        /// <summary>
        /// Sets value of enumeration
        /// </summary>
        /// <param name="enumName">Name of enumeration</param>
        /// <param name="value">Value of enumeration</param>
        public void SetEnum(string enumName, string value)
        {
            // NOP
        }

        /// <summary>
        /// Gets integer value of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <returns>Integer value of property</returns>
        public int GetInt(string property)
        {
            return int.MinValue;
        }

        /// <summary>
        /// Gets double precision number value of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <returns>Double precision value of property</returns>
        public double GetDouble(string property)
        {
            return double.NaN;
        }

        /// <summary>
        /// Gets text string value of property
        /// </summary>
        /// <param name="property">Name of property</param>
        /// <returns>Text string value of property</returns>
        public string GetString(string property)
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets enumeration value of property
        /// </summary>
        /// <param name="enumName">Name of enumeration</param>
        /// <returns>String representation of enumeration value</returns>
        public string GetEnum(string enumName)
        {
            return string.Empty;
        }

        /// <summary>
        /// Gets date and time of creation of object
        /// </summary>
        /// <returns>Date and time of creation of object</returns>
        public DateTime GetCreationDate()
        {
            return new DateTime(1970, 1, 1, 0, 0, 0);
        }

        /// <summary>
        /// Gets date and time of last modification of object
        /// </summary>
        /// <returns>Date and time of last modification of object</returns>
        public DateTime GetModificationDate()
        {
            return new DateTime(1970, 1, 1, 0, 0, 0);
        }
    }
}
