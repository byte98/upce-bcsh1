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
        /// Creates new dialog for adding new map
        /// </summary>
        public FormAddMap() : base("Přidat oblast", "Nová oblast", SemestralProject.Resources.map_add)
        {
            this.content = new ControlAddMap();
            this.AddControl(content);
        }
    }
}
