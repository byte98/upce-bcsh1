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
    /// Class representing dialog for creating new vehicle
    /// </summary>
    internal class FormVehicleAdd: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlVehicle content;

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
        /// Path to directory with vehicle
        /// </summary>
        public string VehiclePath => this.content.VehiclePath;

        /// <summary>
        /// Information system installed on vehicle
        /// </summary>
        public InformationSystem? VehicleInformationSystem => this.content.VehicleInformationSystem;

        /// <summary>
        /// Creates new dialog for creating new vehicle
        /// </summary>
        /// <param name="context">Wrapper of all system resources</param>
        public FormVehicleAdd(Context context): base("Přidat vozidlo", "Nové vozidlo", SemestralProject.Resources.vehicle_add, context)
        {
            this.content = new ControlVehicle(this.Context, this.Context.Configuration.VehiclesRoot);
            this.AddControl(this.content);
        }
    }
}
