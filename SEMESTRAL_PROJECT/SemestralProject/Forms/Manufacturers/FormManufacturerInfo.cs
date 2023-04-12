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
    /// Class which represents dialog which shows more information about manufacturer
    /// </summary>
    internal class FormManufacturerInfo: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlDataView content;

        /// <summary>
        /// Creates new dialog for displaying more information about manufacturer
        /// </summary>
        /// <param name="manufacturer">Manufacturer which information will be displayed</param>
        /// <param name="context">Wrapper of all available system resources</param>
        public FormManufacturerInfo(Manufacturer manufacturer, Context context): base("Detail výrobce", "Informace o výrobci", SemestralProject.Resources.manufacturers_info, context)
        {
            this.content = new ControlDataView(
                manufacturer.Name,
                manufacturer.Description,
                new Bitmap(manufacturer.Icon.GetImage()),
                manufacturer.Created,
                manufacturer.Updated,
                this.Context
            );
            this.AddControl(this.content);
        }
    }
}
