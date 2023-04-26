using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.Vehicles
{
    /// <summary>
    /// Class which represents form for editing vehicles
    /// </summary>
    internal class FormVehicleEdit: FormDialog
    {
        /// <summary>
        /// Name of vehicle
        /// </summary>
        public string VehicleName => this.content.VehicleName;

        /// <summary>
        /// Description of vehicle
        /// </summary>
        public string VehicleDescription => this.content.VehicleDescription;

        /// <summary>
        /// Picture of vehicle
        /// </summary>
        public Picture VehiclePicture => this.content.VehiclePicture;

        /// <summary>
        /// Manufacturer of vehicle
        /// </summary>
        public Manufacturer? VehicleManufacturer => this.content.VehicleManufacturer;

        /// <summary>
        /// Information system installed on vehcile
        /// </summary>
        public InformationSystem? VehicleInformationSystem => this.content.VehicleInformationSystem;

        /// <summary>
        /// Path to directory with vehicle
        /// </summary>
        public string VehiclePath => this.content.VehiclePath;

        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlVehicle content;

        /// <summary>
        /// Creates new dialog for editing vehicle
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="vehicle">Vehicle which will be edited</param>
        public FormVehicleEdit(Context context, Vehicle vehicle)
            : base("Upravit vozidlo", "Úprava vozidla", SemestralProject.Resources.vehicle_edit, context)
        {
            this.content = new ControlVehicle(this.Context, this.Context.Configuration.VehiclesRoot, vehicle);
            this.AddControl(content);
            this.Icon = SemestralProject.Resources.icon_vehicle1;
        }
    }
}
