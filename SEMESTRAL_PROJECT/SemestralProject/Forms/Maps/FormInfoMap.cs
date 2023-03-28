using SemestralProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Maps
{
    /// <summary>
    /// Class representing dialog with information about map
    /// </summary>
    internal class FormInfoMap: FormDialog
    {

        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlInfoMap content;

        /// <summary>
        /// Creates new dialog with information about map
        /// </summary>
        /// <param name="map">Map which informaiton will be displayed</param>
        public FormInfoMap(Map? map): base("Informace o oblasti", "Informace o oblasti", SemestralProject.Resources.map_info)
        {
            this.content = new ControlInfoMap();
            this.AddControl(content);
            if (map != null)
            {
                this.content.MapName = map.Name;
                this.content.MapDescription = map.Description;
                this.content.MapUpdated = map.Updated;
                this.content.MapCreated = map.Created;
                this.content.MapPicture = map.Picture;
            }
        }

    }
}
