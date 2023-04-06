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
    internal class MapsController
    {
        /// <summary>
        /// Alphabet with valid characters for identifiers
        /// </summary>
        private const string IdAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTVUWXYZ";

        /// <summary>
        /// Minimal length of identifiers
        /// </summary>
        private const int IdMinLength = 8;

        /// <summary>
        /// Maximal length of identifiers
        /// </summary>
        private const int IdMaxLength = 16;

        /// <summary>
        /// Reference to storage of files
        /// </summary>
        private readonly FileStorage fileStorage;

        /// <summary>
        /// Reference to storage of data
        /// </summary>
        private readonly DataStorage dataStorage;

        /// <summary>
        /// Wrapper of all programs resources
        /// </summary>
        private readonly Context context;

        /// <summary>
        /// Creates new controller of maps
        /// </summary>
        /// <param name="context">Wrapper of all programs resources</param>
        public MapsController(Context context)
        {
            this.context = context;
            this.fileStorage = this.context.FileStorage;
            this.dataStorage = this.context.DataStorage;
        }

        /// <summary>
        /// Performs creation of new map
        /// </summary>
        public void Create()
        {
            FormMapAdd dialog = new FormMapAdd(this.context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FormWait wait = new FormWait(() =>
                {
                    if (dialog.MapName != null && dialog.MapDescription != null && dialog.MapPicture != null)
                    {
                        this.dataStorage.Maps.Add(new Map(
                                this.GenerateId(),
                                dialog.MapName,
                                dialog.MapDescription,
                                dialog.MapPicture
                            ));
                        this.dataStorage.Save();
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
                reti = StringUtils.Random(
                        MapsController.IdAlphabet,
                        MapsController.IdMinLength,
                        MapsController.IdMaxLength
                    );
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
            foreach(Map map in this.dataStorage.Maps)
            {
                if (map.Id == id)
                {
                    reti = map;
                    break;
                }     
            }
            return reti;
        }

        /// <summary>
        /// Edits map
        /// </summary>
        /// <param name="id">Identifier of map which will be edited</param>
        public void Edit(string id)
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
                        this.dataStorage.Save();
                    }, this.context);
                }
            }
        }

        /// <summary>
        /// Shows information about information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        public void Info(string id)
        {
            Map? map = this.GetById(id);
            if (map != null )
            {
                FormMapInfo dialog = new FormMapInfo(map, this.context);
                dialog.ShowDialog();
            }
        }

        /// <summary>
        /// Removes map
        /// </summary>
        /// <param name="id">Identifier of map</param>
        public void Remove(string id)
        {
            Map? map = this.GetById(id);
            if (map != null)
            {
                if (MessageBox.Show(
                        "Opravdu chcete odstranit oblast " + map.Name + "?" + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Ostranit oblst",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        if (this.dataStorage.Maps.Contains(map))
                        {
                            this.dataStorage.Maps.Remove(map);
                        }
                        this.dataStorage.Save();
                        map = null;
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Deletes all maps
        /// </summary>
        public void Delete()
        {
            if (MessageBox.Show(
                        "Opravdu chcete smazat všechny oblasti?" + Environment.NewLine +
                        "Počet oblastí, které budou smazány: " + this.dataStorage.InformationSystems.Count + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Smazat oblasti",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
            {
                FormWait wait = new FormWait(() =>
                {
                    this.dataStorage.Maps.Clear();
                    this.dataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        /// <summary>
        /// Searches maps
        /// </summary>
        /// <param name="phrase">Phrase which will be searched</param>
        /// <returns>List of maps which matches phrase</returns>
        public List<Map> Search(string phrase)
        {
            List<Map> reti = new List<Map>();
            FormWait wait = new FormWait(() =>
            {
                foreach (Map map in this.dataStorage.Maps)
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
