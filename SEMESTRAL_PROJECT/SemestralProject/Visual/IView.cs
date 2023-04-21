using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Visual
{
    /// <summary>
    /// Interface abstracting some kind of data view
    /// </summary>
    internal interface IView
    {
        /// <summary>
        /// Sets size of items in view
        /// </summary>
        /// <param name="itemsSize">New size of items in view</param>
        public abstract void SetItemsSize(View itemsSize);

        /// <summary>
        /// Unselects any selected data
        /// </summary>
        public abstract void Unselect();
    }
}
