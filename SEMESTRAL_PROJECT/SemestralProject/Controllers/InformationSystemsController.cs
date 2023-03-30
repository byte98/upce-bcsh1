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
                
            }
        }
    }
}
