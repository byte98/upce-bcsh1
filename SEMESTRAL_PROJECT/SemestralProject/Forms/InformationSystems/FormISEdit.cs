using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.InformationSystems
{
    /// <summary>
    /// Class representing dialog for editing information system
    /// </summary>
    internal class FormISEdit: FormDialog, IForm
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlDataIcon content;

        /// <summary>
        /// Name of information system
        /// </summary>
        public string? ISName => this.content.DataName;

        /// <summary>
        /// Description of information system
        /// </summary>
        public string? ISDescription => this.content.DataDescripiton;

        /// <summary>
        /// Icon of information system
        /// </summary>
        public Visual.Icon? ISIcon => this.content.DataIcon;

        /// <summary>
        /// Creates new dialog for editing information system
        /// </summary>
        /// <param name="system">System which will be edited</param>
        /// <param name="context">Wrapper of all program resources</param>
        public FormISEdit(InformationSystem system, Context context) : base("Upravit informační systém", "Úprava informačního systému", SemestralProject.Resources.is_edit, context)
        {
            this.content = new ControlDataIcon(context, system);
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.icon_is1;
        }
    }
}
