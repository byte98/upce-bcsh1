using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class which abstractcs all common properties of mutable objects 
    /// </summary>
    public abstract class AbstractMutable : IMutable
    {
        public event IMutable.MutableObjectChangedEventHandler? MutableObjectChanged;

        

        /// <summary>
        /// Invokes event which informs about object change
        /// </summary>
        /// <param name="property">Name of property which has been changed</param>
        protected void InvokeEvent(string property)
        {
            IMutable.MutableObjectChangedEventArgs args = new IMutable.MutableObjectChangedEventArgs
            {
                Target = this,
                Property = property
            };
            this.MutableObjectChanged?.Invoke(this, args);
        }

        public void Set(string property, int value)
        {
           
        }

        public void Set(string property, string value)
        {
            
        }

        public void Set(string property, double value)
        {
            
        }

        public void SetEnum(string enumName, string value)
        {
            
        }
    }
}
