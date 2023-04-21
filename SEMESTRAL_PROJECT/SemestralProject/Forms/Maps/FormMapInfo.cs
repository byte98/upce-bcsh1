using SemestralProject.Data;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Maps
{
    /// <summary>
    /// Class which represents form which displays information about map
    /// </summary>
    internal class FormMapInfo: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private ControlDataView content;

        public FormMapInfo(Map map, Context context)
            : base ("Informace o oblasti", "Detail oblasti", SemestralProject.Resources.map_info, context)
        {
            this.content = new ControlDataView(
                map.Name,
                map.Description,
                new Bitmap(map.Picture.GetImage()),
                map.Created,
                map.Updated,
                context
            );
            this.AddControl(this.content);
            this.HideCancelButton();
        }
    }
}
