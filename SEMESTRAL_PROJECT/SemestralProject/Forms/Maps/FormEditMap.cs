using SemestralProject.Data;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Maps
{
    /// <summary>
    /// Class representing dialog used for editing map
    /// </summary>
    internal class FormEditMap: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlEditMap content;
        
        /// <summary>
        /// Name of map
        /// </summary>
        public string? MapName => this.content.MapName;

        /// <summary>
        /// Description of map
        /// </summary>
        public string? MapDescription => this.content.MapDescription;

        /// <summary>
        /// Picture of map
        /// </summary>
        public Picture? MapPicture => this.content.MapPicture;

        /// <summary>
        /// Creates new dialog for editing map
        /// </summary>
        /// <param name="map">Map which will be edited</param>
        public FormEditMap(Map map) : base("Upravit oblast", "Úprava oblasti", SemestralProject.Resources.map_edit)
        {
            this.content = new ControlEditMap(map);
            this.AddControl(this.content);
        }
    }
}
