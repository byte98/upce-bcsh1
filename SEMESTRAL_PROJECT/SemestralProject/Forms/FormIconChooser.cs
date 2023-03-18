using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Form which enables selecting icon
    /// </summary>
    internal class FormIconChooser: FormDialog
    {
        /// <summary>
        /// Reference to content of dialog
        /// </summary>
        private ControlIconsChooser content;

        public FormIconChooser(): base("Výběr ikony", "Vyberte ikonu", SemestralProject.Resources.icons_chooser)
        {
            this.content = new ControlIconsChooser();
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.iconchooser;
        }
    }
}
