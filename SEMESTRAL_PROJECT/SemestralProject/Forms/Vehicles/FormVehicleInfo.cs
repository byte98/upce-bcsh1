using SemestralProject.Data;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Vehicles
{
    /// <summary>
    /// Class which represents dialog with detail information about vehicle
    /// </summary>
    internal class FormVehicleInfo: FormDialog
    {

        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlVehicleView content;

        /// <summary>
        /// Creates new dialog for viewing detail information about vehicle
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="vehicle">Vehicle which detail will be viewed</param>
        public FormVehicleInfo(Context context, Vehicle vehicle)
            : base("Informace o vozidlu", "Detail vozidla", SemestralProject.Resources.vehicle_info, context)
        {
            this.content = new ControlVehicleView(context, vehicle);
            this.AddControl(this.content);
            this.HideCancelButton();
            this.Icon = SemestralProject.Resources.icon_vehicle1;
        }
    }
}
