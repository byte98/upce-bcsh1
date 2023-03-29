using SemestralProject.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Utils
{
    /// <summary>
    /// Class which holds all necessary resources for
    /// all components to work with
    /// </summary>
    internal class Context
    {
        /// <summary>
        /// Configuration of system
        /// </summary>
        //public Configuration Configuration { get; set; }

        /// <summary>
        /// Storage of files
        /// </summary>
        public FileStorage FileStorage { get; init; }

        /// <summary>
        /// Storage of data
        /// </summary>
        public DataStorage DataStorage { get; init; }

        /// <summary>
        /// Creates new context
        /// </summary>
        /// <param name="fileStorage">Storage of files</param>
        /// <param name="dataStorage">Storage of data</param>
        public Context(FileStorage fileStorage, DataStorage dataStorage)
        {
            this.FileStorage = fileStorage;
            this.DataStorage = dataStorage;
        }
    }
}
