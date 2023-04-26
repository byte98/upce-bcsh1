using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Forms.Manufacturers
{
    /// <summary>
    /// Class which represents dialog for adding manufacturer
    /// </summary>
    internal class FormManufacturerAdd: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlDataIcon content;

        /// <summary>
        /// Name of manufacturer
        /// </summary>
        public string? ManufacturerName => this.content.DataName;

        /// <summary>
        /// Description of manufacturer
        /// </summary>
        public string? ManufacturerDescription => this.content.DataDescripiton;

        /// <summary>
        /// Icon of manufacturer
        /// </summary>
        public Icon? ManufacturerIcon => this.content.DataIcon;

        /// <summary>
        /// Creates new dialog for creation of new manufacturer
        /// </summary>
        /// <param name="context">Wrapper of all system resources</param>
        public FormManufacturerAdd(Context context): base("Přidat výrobce", "Nový výrobce", SemestralProject.Resources.manufacturers_add, context)
        {
            this.content = new ControlDataIcon(context, Persistence.FileStorage.DefaultIconType.MANUFACTURER);
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.icon_manufacturer1;
        }
    }
}
