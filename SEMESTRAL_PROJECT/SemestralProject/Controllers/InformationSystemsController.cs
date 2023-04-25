using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Forms.InformationSystems;
using SemestralProject.Persistence;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Controllers
{
    /// <summary>
    /// Controller of information systems
    /// </summary>
    internal class InformationSystemsController: AbstractController<InformationSystem>
    {
        /// <summary>
        /// Prefix of identifier
        /// </summary>
        public const string IdPrefix = "IS_";

        /// <summary>
        /// Creates new controller of information systems
        /// </summary>
        /// <param name="context">Wrapper of all programs resources</param>
        public InformationSystemsController(Context context) : base(context) { }

        public override void Create()
        {
            FormISAdd dialog = new FormISAdd(context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FormWait wait = new FormWait(() =>
                {
                    if (dialog.ISName != null && dialog.ISDescription != null && dialog.ISIcon != null)
                    {
                        this.context.DataStorage.InformationSystems.Add(new InformationSystem(
                                this.GenerateId(),
                                dialog.ISName,
                                dialog.ISDescription,
                                dialog.ISIcon
                            ));
                        this.context.DataStorage.Save();
                    }
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
                reti = this.GenerateIdentifier(InformationSystemsController.IdPrefix);
            }
            while(this.GetById(reti) != null );
            return reti;
        }

        /// <summary>
        /// Gets information system by its identifier
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        /// <returns>Information system defined by identifer or <c>NULL</c>, if there is no such information system</returns>
        public InformationSystem? GetById(string id)
        {
            InformationSystem? reti = null;
            foreach(InformationSystem system in this.context.DataStorage.InformationSystems)
            {
                if (system.Id == id)
                {
                    reti = system;
                    break;
                }     
            }
            return reti;
        }

        public override void Edit(string id)
        {
            InformationSystem? system = this.GetById(id);
            if (system != null)
            {
                FormISEdit dialog = new FormISEdit(system, this.context);
                if (dialog.ShowDialog() == DialogResult.OK && dialog.ISName != null && dialog.ISDescription != null && dialog.ISIcon != null)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        system.Edit(dialog.ISName, dialog.ISDescription, dialog.ISIcon);
                        this.context.DataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        public override void Info(string id)
        {
            InformationSystem? system = this.GetById(id);
            if (system != null)
            {
                FormISInfo dialog = new FormISInfo(system, this.context);
                dialog.ShowDialog();
            }
        }

        public override void Remove(string id)
        {
            InformationSystem? system = this.GetById(id);
            if (system != null)
            {
                if (MessageBox.Show(
                        "Opravdu chcete odstranit informační systém " + system.Name + "?" + Environment.NewLine + 
                        "Tato akce je nevratná.",
                        "Ostranit informační systém",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    
                    FormWait wait = new FormWait(() =>
                    {
                        this.RemoveSystem(system);
                        this.context.DataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        public override void Delete()
        {
            if (MessageBox.Show(
                        "Opravdu chcete smazat všechny informační systémy?" + Environment.NewLine +
                        "Počet informačních systémů, které budou smazány: " + this.context.DataStorage.InformationSystems.Count + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Smazat všechny informační systémy",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
            {
                FormWait wait = new FormWait(() =>
                {
                    while(this.context.DataStorage.InformationSystems.Count > 0)
                    {
                        this.RemoveSystem(this.context.DataStorage.InformationSystems.First());
                    }
                    this.context.DataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        /// <summary>
        /// Removes information system with check for conflicts
        /// </summary>
        /// <param name="system">System which will be removed</param>
        private void RemoveSystem(InformationSystem system)
        {
            List<Vehicle> conflictVehicles = this.GetVehicles(system);
            List<DataFile> conflictFiles = this.GetFiles(system);
            if (conflictVehicles.Count > 0 || conflictFiles.Count > 0)
            {
                FormISConflicts dialog = new FormISConflicts(conflictVehicles, conflictFiles, this.context);
                dialog.BringToFront();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (Vehicle vehicle in conflictVehicles)
                    {
                        this.context.DataStorage.Vehicles.Remove(vehicle);
                    }
                    foreach (DataFile dataFile in conflictFiles)
                    {
                        this.context.FileStorage.RemoveDataFile(dataFile.Name);
                        this.context.DataStorage.DataFiles.Remove(dataFile);
                    }
                    this.context.DataStorage.InformationSystems.Remove(system);
                    this.context.DataStorage.Save();
                }
            }
            else
            {
                this.context.DataStorage.InformationSystems.Remove(system);
                this.context.DataStorage.Save();
            }
        }

        /// <summary>
        /// Searches for vehicles with installed information system
        /// </summary>
        /// <param name="system">Searched information system</param>
        /// <returns>List of vehicles with installed searched information system</returns>
        private List<Vehicle> GetVehicles(InformationSystem system)
        {
            List<Vehicle> reti = new List<Vehicle>();
            foreach(Vehicle vehicle in this.context.DataStorage.Vehicles)
            {
                if (vehicle.InformationSystem.Id == system.Id)
                {
                    reti.Add(vehicle);
                }
            }   
            return reti;
        }

        /// <summary>
        /// Searches for data files which has data stored in information system format
        /// </summary>
        /// <param name="system">Searched information system</param>
        /// <returns>List of data files which holds data in searched information system format</returns>
        private List<DataFile> GetFiles(InformationSystem system)
        {
            List<DataFile> reti = new List<DataFile>();
            foreach(DataFile file in this.context.DataStorage.DataFiles)
            {
                if (file.InformationSystem.Id == system.Id)
                {
                    reti.Add(file);
                }
            }
            return reti;
        }

        public override List<InformationSystem> Search(string phrase)
        {
            List<InformationSystem> reti = new List<InformationSystem>();
            FormWait wait = new FormWait(() =>
            {
                foreach (InformationSystem system in this.context.DataStorage.InformationSystems)
                {
                    if (system.Matches(phrase))
                    {
                        reti.Add(system);
                    }
                }
            }, this.context);
            wait.ShowDialog();
            return reti;
        }
    }
}
