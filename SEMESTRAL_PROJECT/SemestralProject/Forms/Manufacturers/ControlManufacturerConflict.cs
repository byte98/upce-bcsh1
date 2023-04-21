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

namespace SemestralProject.Forms.Manufacturers
{
    /// <summary>
    /// Creates control for showing conflicts when removing manufacturer
    /// </summary>
    internal partial class ControlManufacturerConflict : UserControl, IControl
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// List of conflict vehicles
        /// </summary>
        private readonly List<Vehicle> vehicles;

        /// <summary>
        /// Creates new control for showing conflicts when removing manufacturer
        /// </summary>
        /// <param name="vehicles">List of conflict vehicles</param>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlManufacturerConflict(List<Vehicle> vehicles, Context context)
        {
            InitializeComponent();
            this.vehicles = vehicles;
            this.Context = context;
        }

        /// <summary>
        /// Initializes viewer of conflict vehicles
        /// </summary>
        private void InitializeVehicles()
        {

        }
    }
}
