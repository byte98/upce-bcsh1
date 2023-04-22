using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Forms.Manufacturers;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Controllers
{
    /// <summary>
    /// Class which controls operations over manufacturers
    /// </summary>
    internal class ManufacturersController : AbstractController<Manufacturer>
    {
        /// <summary>
        /// Creates new controller of operations over manufacturers
        /// </summary>
        /// <param name="context">Wrapper of all system resources</param>
        public ManufacturersController(Context context) : base(context) { }

        public override void Create()
        {
            FormManufacturerAdd dialog = new FormManufacturerAdd(this.context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FormWait wait = new FormWait(() =>
                {
                    if (dialog.ManufacturerName != null && dialog.ManufacturerDescription != null && dialog.ManufacturerIcon != null)
                    {
                        this.context.DataStorage.Manufacturers.Add(new Data.Manufacturer(
                            this.GenerateId(),
                            dialog.ManufacturerName,
                            dialog.ManufacturerDescription,
                            dialog.ManufacturerIcon
                        ));
                    }
                    this.context.DataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        /// <summary>
        /// Generates new identifier of information system
        /// </summary>
        /// <returns>Pseudo-random unique identifier</returns>
        private string GenerateId()
        {
            string reti = string.Empty;
            do
            {
                reti = this.GenerateIdentifier("MAN_");
            }
            while (this.GetById(reti) != null);
            return reti;
        }

        /// <summary>
        /// Gets manufacturer by its identifier
        /// </summary>
        /// <param name="id">Identifier of manufacturer</param>
        /// <returns>Manufacturer defined by identifer or <c>NULL</c>, if there is no such manufacturer</returns>
        public Manufacturer? GetById(string id)
        {
            Manufacturer? reti = null;
            foreach (Manufacturer manufacturer in this.context.DataStorage.Manufacturers)
            {
                if (manufacturer.Id == id)
                {
                    reti = manufacturer;
                    break;
                }
            }
            return reti;
        }

        public override void Edit(string id)
        {
            Manufacturer? man = this.GetById(id);
            if (man != null)
            {
                FormManufacturerEdit dialog = new FormManufacturerEdit(man, this.context);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        if (dialog.ManufacturerName != null && dialog.ManufacturerDescription != null && dialog.ManufacturerIcon != null)
                        {
                            man.Edit(dialog.ManufacturerName, dialog.ManufacturerDescription, dialog.ManufacturerIcon);
                        }
                        this.context.DataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        public override void Info(string id)
        {
            Manufacturer? man = this.GetById(id);
            if (man != null)
            {
                FormManufacturerInfo dialog = new FormManufacturerInfo(man, this.context);
                dialog.ShowDialog();
            }
        }

        public override void Remove(string id)
        {
            Manufacturer? man = this.GetById(id);
            if (man != null)
            {
                if (MessageBox.Show(
                        "Opravdu chcete odstranit výrobce " + man.Name + "?" + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Ostranit výrobce",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        this.RemoveManufacturer(man);
                        this.context.DataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Removes manufacturer with conflict check
        /// </summary>
        /// <param name="manufacturer">Manufacturer which will be removed</param>
        private void RemoveManufacturer(Manufacturer manufacturer)
        {
            List<Vehicle> conflicts = this.GetVehicles(manufacturer);
            if (conflicts.Count > 0)
            {
                FormManufacturersConflicts dialog = new FormManufacturersConflicts(conflicts, this.context);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach(Vehicle vehicle in conflicts)
                    {
                        this.context.DataStorage.Vehicles.Remove(vehicle);
                    }
                    this.context.DataStorage.Manufacturers.Remove(manufacturer);
                }
            }
            else
            {
                this.context.DataStorage.Manufacturers.Remove(manufacturer);
            }
        }

        /// <summary>
        /// Gets vehicles made by defined manufacturer
        /// </summary>
        /// <param name="manufacturer">Manufacturer which vehicles will be searched</param>
        /// <returns>List of vehicles made by searched manufacturer</returns>
        private List<Vehicle> GetVehicles(Manufacturer manufacturer)
        {
            List<Vehicle> reti = new List<Vehicle>();
            foreach (Vehicle vehicle in this.context.DataStorage.Vehicles)
            {
                if (vehicle.Manufacturer.Id == manufacturer.Id)
                {
                    reti.Add(vehicle);
                }
            }
            return reti;
        }

        public override void Delete()
        {
            if (MessageBox.Show(
                        "Opravdu chcete smazat všechny výrobce?" + Environment.NewLine +
                        "Počet výrobců, kteří budou smazáni: " + this.context.DataStorage.Manufacturers.Count + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Smazat výrobce",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
            {
                FormWait wait = new FormWait(() =>
                {
                    foreach(Manufacturer manufacturer in this.context.DataStorage.Manufacturers)
                    {
                        this.RemoveManufacturer(manufacturer);
                    }
                    this.context.DataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        public override List<Manufacturer> Search(string phrase)
        {
            List<Manufacturer> reti = new List<Manufacturer>();
            FormWait wait = new FormWait(() =>
            {
                foreach (Manufacturer m in this.context.DataStorage.Manufacturers)
                {
                    if (m.Matches(phrase))
                    {
                        reti.Add(m);
                    }
                }
            }, this.context);
            wait.ShowDialog();
            return reti;
        }
    }
}
