using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Maps
{
    /// <summary>
    /// Class which represents form for editing maps
    /// </summary>
    internal class FormMapEdit: FormDialog
    {
        /// <summary>
        /// Content of form
        /// </summary>
        private readonly ControlDataPicture content;

        /// <summary>
        /// Name of map
        /// </summary>
        public string? MapName => this.content.DataName;

        /// <summary>
        /// Description of map
        /// </summary>
        public string? MapDescription => this.content.DataDescripiton;

        /// <summary>
        /// Picture of map
        /// </summary>
        public Picture? MapPicture => this.content.DataPicture;

        public FormMapEdit(Map map, Context context): base("Upravit oblast", "Úprava oblasti", SemestralProject.Resources.map_edit, context)
        {
            this.content = new ControlDataPicture(context, map);
            this.AddControl(this.content);
        }
    }
}
