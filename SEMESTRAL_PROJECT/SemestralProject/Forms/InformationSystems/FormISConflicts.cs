using SemestralProject.Data;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.InformationSystems
{
    /// <summary>
    /// Class representing dialog with information about conflicts when removing information system
    /// </summary>
    internal class FormISConflicts: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlISConflicts content;

        /// <summary>
        /// Creates new dialog for informing about conflicts when removing information system
        /// </summary>
        /// <param name="vehicles">List of conflict vehicles</param>
        /// <param name="files">List of conflict files</param>
        /// <param name="context">Wrapper of all program resources</param>
        public FormISConflicts(List<Vehicle> vehicles, List<DataFile> files, Context context)
            : base("Smazat informační systém", "Konflikty při mazání informačního systému", SemestralProject.Resources.is_remove, context)
        {
            this.content = new ControlISConflicts(vehicles, files, this.Context);
            this.AddControl(this.content);
            this.TopMost = true;
            this.Load+= new EventHandler(this.FormISConflicts_Load);
        }

        private void FormISConflicts_Load(object? sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
        }
    }
}
