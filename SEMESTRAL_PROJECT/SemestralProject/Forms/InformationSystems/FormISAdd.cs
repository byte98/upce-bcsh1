using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.InformationSystems
{
    /// <summary>
    /// Form which enables adding information system
    /// </summary>
    internal class FormISAdd: FormDialog, IForm
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlDataIcon content;

        /// <summary>
        /// Name of new information system
        /// </summary>
        public string? ISName => this.content.DataName;

        /// <summary>
        /// Description of new information system
        /// </summary>
        public string? ISDescription => this.content.DataDescripiton;

        /// <summary>
        /// Icon of new information system
        /// </summary>
        public Visual.Icon? ISIcon => this.content.DataIcon;

        /// <summary>
        /// Creates new dialog for adding new information system
        /// </summary>
        /// <param name="context">Wrapper of all system resources</param>
        public FormISAdd(Context context): base("Přidat nový IS", "Nový informační systém", SemestralProject.Resources.is_add, context)
        {
            this.content = new ControlDataIcon(context, Persistence.FileStorage.DefaultIconType.IS);
            this.AddControl(content);
        }
    }
}
