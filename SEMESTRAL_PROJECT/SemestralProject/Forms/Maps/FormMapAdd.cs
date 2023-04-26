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
    /// Class which represents form for adding maps
    /// </summary>
    internal class FormMapAdd: FormDialog, IForm
    {
        /// <summary>
        /// Content of dialog
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

        /// <summary>
        /// Creates new form for adding new map
        /// </summary>
        /// <param name="context">Wrapper of system resources</param>
        public FormMapAdd(Context context): base("Přidat oblast", "Nová oblast", SemestralProject.Resources.map_add, context)
        {
            this.content = new ControlDataPicture(context);
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.icon_map1;
        }
    }
}
