using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Persistence;
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
        public InformationSystem CreateInformationSystem(string name, string icon, string description)
        {
            InformationSystem reti = null;
            FormWait wait = new FormWait(() => {
                Icon i = this.fileStorage.GetIcon(icon, FileStorage.DefaultIconType.IS);
                InformationSystem system = new InformationSystem(i, name, description);
                this.dataStorage.InformationSystems.Add(system);
                this.dataStorage.Save();
                reti = system;
            });
            wait.ShowDialog();
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
