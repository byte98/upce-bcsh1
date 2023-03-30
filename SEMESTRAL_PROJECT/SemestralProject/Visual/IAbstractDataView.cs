using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Visual
{
    /// <summary>
    /// Interface abstracting all views of data
    /// </summary>
    internal interface IAbstractDataView: IView
    {
        /// <summary>
        /// Class which holds arguments of selected data changed event
        /// </summary>
        public class SelectedDataChangedEventArgs : EventArgs
        {
            /// <summary>
            /// Identifier of actually selected data or <c>NULL</c> if not data is selected
            /// </summary>
            public string? SelectedData { get; set; }
        }

        /// <summary>
        /// Handler of selected data changed event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">rguments of event</param>
        public delegate void SelectedDataChangedEventHandler(object sender, SelectedDataChangedEventArgs e);

        /// <summary>
        /// Event triggered when selected data has changed
        /// </summary>
        public event SelectedDataChangedEventHandler? SelectedDataChanged;
    }
}
