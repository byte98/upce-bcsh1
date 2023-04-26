using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Forms.Manufacturers
{
    /// <summary>
    /// Class which represents dialog for editing manufacturers
    /// </summary>
    internal class FormManufacturerEdit: FormDialog
    {
        /// <summary>
        /// Name of manufacturer
        /// </summary>
        public string? ManufacturerName => this.content.DataName;

        /// <summary>
        /// Descripiton of manufacturer
        /// </summary>
        public string? ManufacturerDescription => this.content.DataDescripiton;
        
        /// <summary>
        /// Icon of manufacturer
        /// </summary>
        public Icon? ManufacturerIcon => this.content.DataIcon;

        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlDataIcon content;

        /// <summary>
        /// Creates new dialog for editing manufacturers
        /// </summary>
        /// <param name="manufacturer">Manufacturer which will be edited</param>
        /// <param name="context">Wrapper of all available system resources</param>
        public FormManufacturerEdit(Manufacturer manufacturer, Context context)
            : base("Editovat výrobce", "Úprava výrobce", SemestralProject.Resources.manufacturers_edit, context)
        {
            this.content = new ControlDataIcon(this.Context, manufacturer);
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.icon_manufacturer1;
        }
    }
}
