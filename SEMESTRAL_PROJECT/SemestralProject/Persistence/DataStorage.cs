using SemestralProject.Data;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class which stores all data (something like a database)
    /// </summary>
    internal class DataStorage
    {
        /// <summary>
        /// Reference to instance of data storage
        /// </summary>
        private static DataStorage? instance;

        /// <summary>
        /// File containing something like a database of information systems
        /// </summary>
        private const string ISFile = "INFORMATION_SYSTEMS.XML";

        /// <summary>
        /// Reference to default instance of data storage
        /// </summary>
        public static DataStorage Instance
        {
            get
            {
                if (DataStorage.instance == null)
                {
                    DataStorage.instance = new DataStorage(Configuration.DataFile);
                }
                return DataStorage.instance;
            }
        }

        /// <summary>
        /// Path to file with data storage
        /// </summary>
        private readonly string path;

        /// <summary>
        /// List of all available information systems
        /// </summary>
        public List<InformationSystem> InformationSystems { get; set; }

        /// <summary>
        /// Creates new data storage
        /// </summary>
        /// <param name="path">Path to file with data</param>
        public DataStorage(string path)
        {
            this.path = path;
            this.InformationSystems = new List<InformationSystem>();
        }

        /// <summary>
        /// Loads content of storage
        /// </summary>
        public void Load()
        {
            if (File.Exists(this.path))
            {
                string output = Configuration.TempDir + Path.DirectorySeparatorChar + "_DB";
                ZipFile.ExtractToDirectory(this.path, output);
            }
        }

        /// <summary>
        /// Loads information systems from storage
        /// (this needs to be called AFTER <see cref="Load"/>!)
        /// </summary>
        public void LoadInformationSystems()
        {
            this.InformationSystems = new List<InformationSystem>();
            string file = Configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + DataStorage.ISFile;
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
            }
        }

        /// <summary>
        /// Saves information systems into XML
        /// </summary>
        private void SaveInformationSystems()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement iss = doc.CreateElement(string.Empty, "INFORMATION-SYSTEMS", string.Empty);
            doc.AppendChild(iss);
            foreach(InformationSystem informationSystem in this.InformationSystems)
            {
                XmlElement infS = doc.CreateElement(string.Empty, "INFORMATION-SYSTEM", string.Empty);
                XmlElement created = doc.CreateElement(string.Empty, "CREATED", string.Empty);
                created.Value = informationSystem.Created.ToString("dd-MM-yyyy HH:mm:ss");
                infS.AppendChild(created);
            }
        }

        /// <summary>
        /// Saves content of storage
        /// </summary>
        public void Save()
        {
            if (File.Exists(Configuration.DataFile))
            {
                File.Delete(Configuration.DataFile);
            }
        }
    }
}
