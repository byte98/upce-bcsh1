using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Persistence;
using SemestralProject.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Handlers
{
    /// <summary>
    /// Class which enables manipulation with information systems handler
    /// </summary>
    internal class InformationSystemsHandler: IEnumerable
    {
        /// <summary>
        /// Reference to storage of data (where information systems will be saved)
        /// </summary>
        private readonly DataStorage dataStorage;

        /// <summary>
        /// Reference to storage of files
        /// </summary>
        private readonly FileStorage fileStorage;

        /// <summary>
        /// Reference to default instance of handler of information systems
        /// </summary>
        private static InformationSystemsHandler? instance;

        /// <summary>
        /// Alphabet containing valid characters for generating identifiers
        /// </summary>
        private const string IDAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Minimal length of identifier
        /// </summary>
        private const int IDMinLength = 8;

        /// <summary>
        /// Maximal length of identifier
        /// </summary>
        private const int IDMaxLength = 16;

        /// <summary>
        /// Default instance of handler of information systems
        /// </summary>
        public static InformationSystemsHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InformationSystemsHandler(DataStorage.Instance, FileStorage.Instance);
                }
                return instance;
            }
        }

        /// <summary>
        /// Creates new information systems handler
        /// </summary>
        /// <param name="dataStorage">Storage of data</param>
        /// <param name="fileStorage">Storage of files</param>
        public InformationSystemsHandler(DataStorage dataStorage, FileStorage fileStorage)
        {
            this.dataStorage = dataStorage;
            this.fileStorage = fileStorage;
        }

        /// <summary>
        /// Creates new information system
        /// </summary>
        /// <param name="name">Name of information system</param>
        /// <param name="icon">Icon of information system</param>
        /// <param name="description">Description of information system</param>
        /// <returns></returns>
        public InformationSystem? CreateInformationSystem(string name, string icon, string description)
        {
            InformationSystem? reti = null;
            FormWait wait = new FormWait(() => {
                Icon i = this.fileStorage.GetIcon(icon, FileStorage.DefaultIconType.IS);
                InformationSystem system = new InformationSystem(this.GenerateIdentifier(), i, name, description);
                this.dataStorage.InformationSystems.Add(system);
                this.dataStorage.Save();
                reti = system;
            });
            wait.ShowDialog();
            return reti;
        }

        /// <summary>
        /// Edits information system
        /// </summary>
        /// <param name="system">Information system which will be edited</param>
        /// <param name="name">New name of information system</param>
        /// <param name="icon">new icon of information system</param>
        /// <param name="description">New description of information system</param>
        public void EditInformationSystem(InformationSystem system, string name, Icon icon, string description)
        {
            FormWait wait = new FormWait(() =>
            {
                system.Edit(name, icon, description);
                if (this.dataStorage.InformationSystems.Contains(system) == false)
                {
                    this.dataStorage.InformationSystems.Add(system);
                }
                this.dataStorage.Save();
            });
            wait.ShowDialog();
        }

        /// <summary>
        /// Removes information system from application
        /// </summary>
        /// <param name="system">Information system which will be removed</param>
        public void RemoveInformationSystem(InformationSystem system)
        {
            FormWait wait = new FormWait(() =>
            {
                List<InformationSystem> systems = this.dataStorage.InformationSystems;
                if (systems.Contains(system))
                {
                    systems.Remove(system);
                }
                this.dataStorage.InformationSystems = systems;
                this.dataStorage.Save();
            });
            wait.ShowDialog();
        }

        /// <summary>
        /// Deletes all available information systems
        /// </summary>
        public void DeleteSystems()
        {
            FormWait wait = new FormWait(() =>
            {
                this.dataStorage.InformationSystems = new List<InformationSystem>();
                this.dataStorage.Save();
            });
            wait.ShowDialog();
        }

        /// <summary>
        /// Generates identifier of information system
        /// </summary>
        /// <returns>Unique identifier of information system</returns>
        private string GenerateIdentifier()
        {
            string reti;
            do
            {
                reti = "IS_" + StringUtils.Random(InformationSystemsHandler.IDAlphabet, InformationSystemsHandler.IDMinLength, InformationSystemsHandler.IDMaxLength);
            }
            while(this.GetByID(reti) != null);
            return reti;
        }

        /// <summary>
        /// Gets information system by its identifier
        /// </summary>
        /// <param name="id">Identifier of information system</param>
        /// <returns>Information system with defined identifier or <c>null</c>, if there is no such system</returns>
        public InformationSystem? GetByID(string id)
        {
            InformationSystem? reti = null;
            List<InformationSystem> systems = this.dataStorage.InformationSystems;
            foreach (InformationSystem system in systems)
            {
                if (system.ID == id)
                {
                    reti = system;
                    break;
                }
            }
            return reti;
        }

        public IEnumerator GetEnumerator()
        {
            foreach(InformationSystem system in this.dataStorage.InformationSystems)
            {
                yield return system;
            }
        }
    }
}
