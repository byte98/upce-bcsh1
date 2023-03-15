using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class which abstracts all mutable objects
    /// </summary>
    internal class AbstractMutable : IMutable
    {
        public string[] Properties => new string[0];

        public event IMutable.MutableObjectChangedEventHandler? MutableObjectChanged;

        public virtual DataType? GetDataType(string property)
        {
            return null;
        }

        public virtual bool IsReadOnly(string property)
        {
            return true;
        }

        public virtual void Set(string property, int value)
        {
            // NOP
        }

        public virtual void Set(string property, string value)
        {
            // NOP
        }

        public virtual void SetEnum(string enumName, string value)
        {
            // NOP
        }
    }
}
