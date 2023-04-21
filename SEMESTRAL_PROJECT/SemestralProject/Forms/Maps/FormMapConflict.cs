using SemestralProject.Data;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Maps
{
    /// <summary>
    /// Class represents dialog informing about conflict when removing map
    /// </summary>
    internal class FormMapConflict: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private ControlMapConflict content;

        /// <summary>
        /// Creates new dialog which informs about conflict when removing map
        /// </summary>
        /// <param name="files">Files in conflict</param>
        /// <param name="context">Wrapper of all program resources</param>
        public FormMapConflict(List<DataFile> files, Context context)
            : base("Smazat oblast", "Konflikty při mazání oblasti", SemestralProject.Resources.map_remove,context)
        {
            this.content = new ControlMapConflict(files, context);
            this.AddControl(content);
            this.Load += this.FormMapConflict_OnLoad;
        }

        private void FormMapConflict_OnLoad(object? sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
        }
    }
}
