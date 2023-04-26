﻿using SemestralProject.Utils;
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

        /// <summary>
        /// Name or path to selected icon
        /// </summary>
        public string SelectedIcon => content.SelectedIcon;

        /// <summary>
        /// Flag, whether <see cref="SelectedIcon"/> contains path (TRUE) or name (FALSE)
        /// </summary>
        public bool IsPath => content.SelectedIsPath;

        public FormIconChooser(Context context): base("Výběr ikony", "Vyberte ikonu", SemestralProject.Resources.icons_chooser, context)
        {
            this.content = new ControlIconsChooser(this.Context);
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.icon_icons1;
        }
    }
}
