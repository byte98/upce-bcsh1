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
    internal class InformationSystemsController
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
        /// Creates new controller of information systems
        /// </summary>
        /// <param name="context">Wrapper of all programs resources</param>
        public InformationSystemsController(Context context)
        {
            this.context = context;
            this.fileStorage = this.context.FileStorage;
            this.dataStorage = this.context.DataStorage;
        }

        /// <summary>
        /// Performs creation of new information system
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
        /// Generates new identifier of information system
        /// </summary>
        /// <returns>Pseudo-random unique identifier</returns>
        private string GenerateId()
        {
            string reti = string.Empty;
            do
            {
                reti = StringUtils.Random(
                        InformationSystemsController.IdAlphabet,
                        InformationSystemsController.IdMinLength,
                        InformationSystemsController.IdMaxLength
                    );
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
            foreach(InformationSystem system in this.dataStorage.InformationSystems)
            {
                if (system.Id == id)
                {
                    reti = system;
                    break;
                }     
            }
            return reti;
        }

        /// <summary>
        /// Edits information system
        /// </summary>
        /// <param name="id">Identifier of information system which will be edited</param>
        public void Edit(string id)
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
                        this.dataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Shows information about information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        public void Info(string id)
        {
            InformationSystem? system = this.GetById(id);
            if (system != null)
            {
                FormISInfo dialog = new FormISInfo(system, this.context);
                dialog.ShowDialog();
            }
        }

        /// <summary>
        /// Removes information system
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        public void Remove(string id)
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
                        if (this.dataStorage.InformationSystems.Contains(system))
                        {
                            this.dataStorage.InformationSystems.Remove(system);
                        }
                        this.dataStorage.Save();
                        system = null;
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Deletes all information systems
        /// </summary>
        public void Delete()
        {
            if (MessageBox.Show(
                        "Opravdu chcete smazat všechny informační systémy?" + Environment.NewLine +
                        "Počet informačních systémů, které budou smazány: " + this.dataStorage.InformationSystems.Count + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Smazat všechny informační systémy",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
            {
                FormWait wait = new FormWait(() =>
                {
                    this.dataStorage.InformationSystems.Clear();
                    this.dataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        /// <summary>
        /// Searches information systems
        /// </summary>
        /// <param name="phrase">Phrase which will be searched</param>
        /// <returns>List of information systems which matches phrase</returns>
        public List<InformationSystem> Search(string phrase)
        {
            List<InformationSystem> reti = new List<InformationSystem>();
            FormWait wait = new FormWait(() =>
            {
                foreach (InformationSystem system in this.dataStorage.InformationSystems)
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
