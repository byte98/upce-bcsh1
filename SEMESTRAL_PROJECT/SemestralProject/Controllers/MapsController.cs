using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Forms.InformationSystems;
using SemestralProject.Forms.Maps;
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
    /// Controller of maps
    /// </summary>
    internal class MapsController: AbstractController<Map>
    {
        /// <summary>
        /// Creates new controller of maps
        /// </summary>
        /// <param name="context">Wrapper of all programs resources</param>
        public MapsController(Context context) : base(context) { }

        /// <summary>
        /// Prefix used in identifier
        /// </summary>
        public const string IdPrefix = "MAP_";

        public override void Create()
        {
            FormMapAdd dialog = new FormMapAdd(this.context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FormWait wait = new FormWait(() =>
                {
                    if (dialog.MapName != null && dialog.MapDescription != null && dialog.MapPicture != null)
                    {
                        this.context.DataStorage.Maps.Add(new Map(
                                this.GenerateId(),
                                dialog.MapName,
                                dialog.MapDescription,
                                dialog.MapPicture
                            ));
                        this.context.DataStorage.Save();
                    }
                }, this.context);
                wait.ShowDialog();
            }
        }

        /// <summary>
        /// Generates new identifier of map
        /// </summary>
        /// <returns>Pseudo-random unique identifier</returns>
        private string GenerateId()
        {
            string reti = string.Empty;
            do
            {
                reti = this.GenerateIdentifier(MapsController.IdPrefix);
            }
            while(this.GetById(reti) != null );
            return reti;
        }

        /// <summary>
        /// Gets map by its identifier
        /// </summary>
        /// <param name="id">Identifier of map</param>
        /// <returns>Map defined by identifer or <c>NULL</c>, if there is no such imap</returns>
        public Map? GetById(string id)
        {
            Map? reti = null;
            foreach(Map map in this.context.DataStorage.Maps)
            {
                if (map.Id == id)
                {
                    reti = map;
                    break;
                }     
            }
            return reti;
        }

        public override void Edit(string id)
        {
            Map? map = this.GetById(id);
            if (map != null)
            {
                FormMapEdit dialog = new FormMapEdit(map, this.context);
                if (dialog.ShowDialog() == DialogResult.OK && dialog.MapName!= null && dialog.MapDescription != null && dialog.MapPicture != null)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        map.Edit(dialog.MapName, dialog.MapDescription, dialog.MapPicture);
                        this.context.DataStorage.Save();
                    }, this.context);
                }
            }
        }

        public override void Info(string id)
        {
            Map? map = this.GetById(id);
            if (map != null )
            {
                FormMapInfo dialog = new FormMapInfo(map, this.context);
                dialog.ShowDialog();
            }
        }

        public override void Remove(string id)
        {
            Map? map = this.GetById(id);
            if (map != null)
            {
                if (MessageBox.Show(
                        "Opravdu chcete odstranit oblast " + map.Name + "?" + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Ostranit oblast",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        this.RemoveMap(map);
                        this.context.DataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        public override void Delete()
        {
            if (MessageBox.Show(
                        "Opravdu chcete smazat všechny oblasti?" + Environment.NewLine +
                        "Počet oblastí, které budou smazány: " + this.context.DataStorage.Maps.Count + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Smazat oblasti",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
            {
                FormWait wait = new FormWait(() =>
                {
                    foreach (Map map in this.context.DataStorage.Maps)
                    {
                        this.RemoveMap(map);
                    }
                    this.context.DataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }
        
        /// <summary>
        /// Removes map with checking for conflicts
        /// </summary>
        /// <param name="map">Map which will be removed</param>
        private void RemoveMap(Map map)
        {
            List<DataFile> conflicts = this.GetDataFiles(map);
            if (conflicts.Count > 0)
            {
                FormMapConflict dialog = new FormMapConflict(conflicts, context);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataFile file in conflicts)
                    {
                        this.context.FileStorage.RemoveDataFile(file.Name);
                        this.context.DataStorage.DataFiles.Remove(file);
                    }
                    this.context.DataStorage.Maps.Remove(map);
                }
            }
            else
            {
                this.context.DataStorage.Maps.Remove(map);
            }
        }

        /// <summary>
        /// Gets data files which holds data of map
        /// </summary>
        /// <param name="map">Map which data will be searched across files</param>
        /// <returns>List of files which holds data of map</returns>
        private List<DataFile> GetDataFiles(Map map)
        {
            List<DataFile> reti = new List<DataFile>();
            foreach(DataFile file in this.context.DataStorage.DataFiles)
            {
                if (file.Map.Id == map.Id)
                {
                    reti.Add(file);
                }
            }
            return reti;
        }

        public override List<Map> Search(string phrase)
        {
            List<Map> reti = new List<Map>();
            FormWait wait = new FormWait(() =>
            {
                foreach (Map map in this.context.DataStorage.Maps)
                {
                    if (map.Matches(phrase))
                    {
                        reti.Add(map);
                    }
                }
            }, this.context);
            wait.ShowDialog();
            return reti;
        }
    }
}
