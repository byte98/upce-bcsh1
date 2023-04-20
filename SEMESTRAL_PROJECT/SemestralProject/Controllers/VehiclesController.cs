using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Forms.Vehicles;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Controllers
{
    /// <summary>
    /// Class which controls operations over vehicles
    /// </summary>
    internal class VehiclesController: AbstractController<Vehicle>
    {
        /// <summary>
        /// Creates new controller of vehicles
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public VehiclesController(Context context) : base(context) { }

        /// <summary>
        /// Gets vehicle by its identifier
        /// </summary>
        /// <param name="id">Identifier of vehicle</param>
        /// <returns>Vehicle with defined identifier of <c>NULL</c> if there is no such vehicle</returns>
        private Vehicle? GetById(string id)
        {
            Vehicle? reti = null;
            foreach(Vehicle vehicle in this.context.DataStorage.Vehicles)
            {
                if (vehicle.Id == id)
                {
                    reti = vehicle;
                    break;
                }
            }
            return reti;
        }

        /// <summary>
        /// Creates new vehicle
        /// </summary>
        public override void Create()
        {
            FormVehicleAdd dialog = new FormVehicleAdd(this.context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.VehicleManufacturer != null && dialog.VehicleInformationSystem != null)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        this.context.DataStorage.Vehicles.Add(new Vehicle(
                            this.GenerateId(),
                            dialog.VehicleName,
                            dialog.VehicleDescription,
                            dialog.VehiclePicture,
                            dialog.VehicleManufacturer,
                            dialog.VehiclePath,
                            dialog.VehicleInformationSystem));
                        this.context.DataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Generates new identifier for vehicle
        /// </summary>
        /// <returns>Pseudo-random string with unique identifier of vehicle</returns>
        private string GenerateId()
        {
            string reti = string.Empty;
            do
            {
                reti = this.GenerateIdentifier("V_");
            }
            while(this.GetById(reti) != null);
            return reti;
        }

        public override void Info(string id)
        {
            Vehicle? vehicle = this.GetById(id);
            if (vehicle != null)
            {
                FormVehicleInfo dialog = new FormVehicleInfo(this.context, vehicle);
                dialog.ShowDialog();
            }
        }

        public override void Edit(string id)
        {
            Vehicle? vehicle = this.GetById(id);
            if (vehicle != null)
            {
                FormVehicleEdit dialog = new FormVehicleEdit(this.context, vehicle);
                if (dialog.ShowDialog() == DialogResult.OK && dialog.VehicleManufacturer != null && dialog.VehicleInformationSystem != null)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        vehicle.Edit(
                            dialog.VehicleName,
                            dialog.VehicleDescription,
                            dialog.VehiclePicture,
                            dialog.VehicleManufacturer,
                            dialog.VehiclePath,
                            dialog.VehicleInformationSystem
                        );
                        this.context.DataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        public override void Remove(string id)
        {
            Vehicle? vehicle = this.GetById(id);
            if (vehicle != null)
            {
                if (MessageBox.Show(
                        "Opravdu chcete odstranit vozidlo " + vehicle.Name + "?" + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Ostranit vozidlo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        if (this.context.DataStorage.Vehicles.Contains(vehicle))
                        {
                            this.context.DataStorage.Vehicles.Remove(vehicle);
                        }
                        this.context.DataStorage.Save();
                        vehicle = null;
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        public override void Delete()
        {
            if (MessageBox.Show(
                        "Opravdu chcete smazat všechna vozidla?" + Environment.NewLine +
                        "Počet vozidel, která budou smazána: " + this.context.DataStorage.Vehicles.Count + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Smazat vozdila",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
            {
                FormWait wait = new FormWait(() =>
                {
                    this.context.DataStorage.Vehicles.Clear();
                    this.context.DataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        public override List<Vehicle> Search(string phrase)
        {
            List<Vehicle> reti = new List<Vehicle>();
            FormWait wait = new FormWait(() =>
            {
                foreach (Vehicle vehicle in this.context.DataStorage.Vehicles)
                {
                    if (vehicle.Matches(phrase))
                    {
                        reti.Add(vehicle);
                    }
                }
            }, this.context);
            wait.ShowDialog();
            return reti;
        }
    }
}
