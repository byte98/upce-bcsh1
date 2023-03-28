using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Maps
{
    /// <summary>
    /// Class representing add new map dialog
    /// </summary>
    internal class FormAddMap: FormDialog
    {
        /// <summary>
        /// Control representing content of dialog
        /// </summary>
        private readonly ControlAddMap content;

        /// <summary>
        /// Name of map
        /// </summary>
        public string MapName => this.content.MapName;

        /// <summary>
        /// Description of map
        /// </summary>
        public string MapDescription => this.content.MapDescription;

        /// <summary>
        /// Picture of map
        /// </summary>
        public Picture MapPicture => this.content.MapPicture;

        /// <summary>
        /// Creates new dialog for adding new map
        /// </summary>
        public FormAddMap() : base("Přidat oblast", "Nová oblast", SemestralProject.Resources.map_add)
        {
            this.content = new ControlAddMap();
            this.AddControl(content);
        }
    }
}
