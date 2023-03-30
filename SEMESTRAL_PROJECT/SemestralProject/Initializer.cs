using SemestralProject.Persistence;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject
{
    /// <summary>
    /// Class which wraps all resources needed for application to run
    /// </summary>
    internal class Initializer
    {
        /// <summary>
        /// Path to file with configuration
        /// </summary>
        private const string Configuration = "CONFIG.INI";

        /// <summary>
        /// Path to file which contains all appliactions files
        /// </summary>
        private const string FileStorage = "FS.DAT";

        /// <summary>
        /// Path to file which contains all applications data
        /// </summary>
        private const string DataStorage = "DB.DAT";

        /// <summary>
        /// Context of application
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Creates new wrapper for all needed resources
        /// </summary>
        public Initializer()
        {
            Configuration config = new Configuration(Initializer.Configuration);
            FileStorage fileStorage = new FileStorage(Initializer.FileStorage, config);
            DataStorage dataStorage = new DataStorage(Initializer.DataStorage, fileStorage, config);
            this.Context = new Context(fileStorage, dataStorage, config);
        }
    }
}
