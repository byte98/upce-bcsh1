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
            FormISAdd dialog = new FormISAdd(context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FormWait wait = new FormWait(() =>
                {
                    if (dialog.ISName != null && dialog.ISDescription != null && dialog.ISIcon != null)
                    {
                        this.dataStorage.InformationSystems.Add(new InformationSystem(
                                this.GenerateId(),
                                dialog.ISName,
                                dialog.ISDescription,
                                dialog.ISIcon
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
            /*
            Map? system = this.GetById(id);
            if (system != null)
            {
                FormISEdit dialog = new FormISEdit(system, this.context);
                if (dialog.ShowDialog() == DialogResult.OK && dialog.ISName != null && dialog.ISDescription != null && dialog.ISIcon != null)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        system.Edit(dialog.ISName, dialog.ISDescription, dialog.ISIcon);
                        this.dataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
            */
        }

        /// <summary>
        /// Shows information about information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        public void Info(string id)
        {
            /*
            InformationSystem? system = this.GetById(id);
            if (system != null)
            {
                FormISInfo dialog = new FormISInfo(system, this.context);
                dialog.ShowDialog();
            }
            */
        }
    }
}
