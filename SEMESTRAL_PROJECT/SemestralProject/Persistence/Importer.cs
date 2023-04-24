using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class which has ability to import data from file
    /// </summary>
    internal class Importer : AbstractExporterImporter
    {
        #region Utility structures
        /// <summary>
        /// Structure which holds raw information about information system from file
        /// </summary>
        private struct InformationSystem
        {
            /// <summary>
            /// Identifier of information system
            /// </summary>
            public string Id { get; init; }

            /// <summary>
            /// Name of information system
            /// </summary>
            public string Name { get; init; }

            /// <summary>
            /// Description of information system
            /// </summary>
            public string Description { get; init; }

            /// <summary>
            /// Name of icon of information system
            /// </summary>
            public string Icon { get; init; }

            /// <summary>
            /// Date and time of creation of information system
            /// </summary>
            public DateTime Created { get; init; }

            /// <summary>
            /// Date and time of last update of information system
            /// </summary>
            public DateTime Updated { get; init; }

            /// <summary>
            /// Creates new structure with information about information system
            /// </summary>
            /// <param name="id">Identifier of information system</param>
            /// <param name="name">Name of information system</param>
            /// <param name="description">Description of information system</param>
            /// <param name="icon">Identifier of icon of information system</param>
            /// <param name="created">Date and time of creation of information system</param>
            /// <param name="updated">Date and time of last update of information system</param>
            public InformationSystem(string id, string name, string description, string icon, DateTime created, DateTime updated)
            {
                this.Id = id; ;
                this.Name = name;
                this.Description = description;
                this.Icon = icon;
                this.Created = created;
                this.Updated = updated;
            }
        }

        /// <summary>
        /// Structure which holds raw data from file of map
        /// </summary>
        private struct Map
        {
            /// <summary>
            /// Identifier of map
            /// </summary>
            public string Id { get; init; }

            /// <summary>
            /// Name of map
            /// </summary>
            public string Name { get; init; }

            /// <summary>
            /// Description of map
            /// </summary>
            public string Description { get; init; }

            /// <summary>
            /// Identifier of picture of map
            /// </summary>
            public string Picture { get; init; }

            /// <summary>
            /// Date and time of creation of map
            /// </summary>
            public DateTime Created { get; init; }

            /// <summary>
            /// Date and time of last update of map
            /// </summary>
            public DateTime Updated { get; init; }

            /// <summary>
            /// Creates new structure which holds information about map
            /// </summary>
            /// <param name="id">Identifier of map</param>
            /// <param name="name">Name of map</param>
            /// <param name="description">Description of map</param>
            /// <param name="picture">Identifier of picture of map</param>
            /// <param name="created">Date and time of creation of map</param>
            /// <param name="updated">Date and time of last update of map</param>
            public Map(string id, string name, string description, string picture, DateTime created, DateTime updated)
            {
                this.Id = id; ;
                this.Name = name;
                this.Description = description;
                this.Picture = picture;
                this.Created = created;
                this.Updated = updated;
            }
        }

        #endregion

        /// <summary>
        /// Path to file from which data will be imported from
        /// </summary>
        public string InputPath { private get; set; } = string.Empty;

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        private readonly Context context;

        /// <summary>
        /// Temporary directory for imported data
        /// </summary>
        private string tempDir => this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_IMPORT" + Path.DirectorySeparatorChar;

        /// <summary>
        /// Actual progress of import
        /// </summary>
        private ushort progress;

        /// <summary>
        /// Creates new importer of data
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public Importer(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Starts importing process
        /// (this needs to be called as FIRST function call).
        /// BEFORE this function call, property <see cref="InputPath"/> must be set to some existing <c>.EXDAT</c> file.
        /// </summary>
        public void Import()
        {
            // Initial event invoke
            this.progress = 0;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji import dat..."));

            // Make temporary directory
            if (Directory.Exists(this.tempDir))
            {
                Directory.Delete(this.tempDir);
            }
            Directory.CreateDirectory(this.tempDir);
            this.progress += 2;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji import dat..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Vytvořen adresář " + this.tempDir));

            // Unzip file
            ZipFile.ExtractToDirectory(this.InputPath, tempDir, true);
            this.progress = 10;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji import dat..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Rozbalen soubor " + this.InputPath));
        }

        /// <summary>
        /// Loads information about information systems
        /// </summary>
        public void LoadInformationIS()
        {

        }

    }
}
