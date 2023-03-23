using SemestralProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class which enables manipulation with information systems handler
    /// </summary>
    internal class InformationSystemsHandler
    {
        /// <summary>
        /// Reference to storage of data (where information systems will be saved)
        /// </summary>
        private readonly DataStorage dataStorage;

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
                if (InformationSystemsHandler.instance == null)
                {
                    InformationSystemsHandler.instance = new InformationSystemsHandler(Configuration.DataFile);
                }
                return InformationSystemsHandler.instance;
            }
        }

        /// <summary>
        /// Creates new information systems handler
        /// </summary>
        /// <param name="dataFile">Path to file which contains all data</param>
        public InformationSystemsHandler(string dataFile)
        {
            this.dataStorage = new DataStorage(dataFile);
        }
    }
}
