using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Forms.DataFiles
{
    /// <summary>
    /// Class representing control for creating and editing data files
    /// </summary>
    internal partial class ControlDataFile : UserControl, IControl
    {
        /// <summary>
        /// Structure holding all necessary information for showing all information systems in combobox
        /// </summary>
        private struct InformationSystemItem
        {
            /// <summary>
            /// Displayed name in combo box
            /// </summary>
            public string DisplayName { get; set; }

            /// <summary>
            /// Information system which combobox item represents
            /// </summary>
            public InformationSystem System { get; set; }
        }

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Creates new control for creating data files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlDataFile(Context context)
        {
            this.InitializeComponent();
            this.Context = context;
            this.InitializeContent();
        }

        /// <summary>
        /// Creates new control for editing data files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="dataFile">Data file which will be edited</param>
        public ControlDataFile(Context context, DataFile dataFile)
        {

        }

        private void InitializeContent()
        {

        }
    }
}
