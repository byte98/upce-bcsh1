using SemestralProject.Data;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Manufacturers
{
    /// <summary>
    /// Class representing dialog which informs about conflicts when deleting manufacturer
    /// </summary>
    internal class FormManufacturersConflicts: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private ControlManufacturerConflict content;

        /// <summary>
        /// Creates new dialog which informs about conflicts when deleting manufacturer
        /// </summary>
        /// <param name="vehicles">List of conflict vehicles</param>
        /// <param name="context">Wrapper of all program resources</param>
        public FormManufacturersConflicts(List<Vehicle> vehicles, Context context)
            : base("Smazat výrobce", "Konflikty při smazání výrobce", SemestralProject.Resources.manufacturers_remove, context)
        {
            this.content = new ControlManufacturerConflict(vehicles, context);
            this.AddControl(this.content);
            this.Load += this.FormManufacturerConflicts_Load;
        }

        private void FormManufacturerConflicts_Load(object? sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
        }
    }
}
