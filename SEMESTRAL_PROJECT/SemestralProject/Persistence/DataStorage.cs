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
        #region XML DEFINITIONS
        /// <summary>
        /// Class which holds names of XML elements used in XML files
        /// </summary>
        private static class XML
        {
            /// <summary>
            /// Format of date and time used to store data in XML files
            /// </summary>
            public const string _Date = "dd-MM-yyyy HH:mm:ss";

            /// <summary>
            /// Definition of version of XML standard
            /// </summary>
            public const string _Version = "1.0";

            /// <summary>
            /// Character set of XML file
            /// </summary>
            public const string _Charset = "UTF-8";

            /// <summary>
            /// XML element holding all information systems
            /// </summary>
            public const string InformationSystems = "INFORMATION_SYSTEMS";

            /// <summary>
            /// Class which holds names of XML elements used to store information systems
            /// </summary>
            internal static class InformationSystem
            {
                /// <summary>
                /// XML element holding all information about information system
                /// </summary>
                public const string _Root = "INFORMATION_SYSTEM";

                /// <summary>
                /// XML element holding name of information system
                /// </summary>
                public const string Name = "NAME";

                /// <summary>
                /// XML element holding icon of information system
                /// </summary>
                public const string Icon = "ICON";

                /// <summary>
                /// XML element holding description of information system
                /// </summary>
                public const string Description = "DESCRIPTION";

                /// <summary>
                /// XML element holding date and time of creation of information system
                /// </summary>
                public const string Created = "CREATED";

                /// <summary>
                /// XML element holding date and time of last update of information system
                /// </summary>
                public const string Updated = "UPDATED";
            }
        }
        #endregion

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
                    DataStorage.instance = new DataStorage(Configuration.DataFile, FileStorage.Instance);
                }
                return DataStorage.instance;
            }
        }

        /// <summary>
        /// Path to file with data storage
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Reference to storage of files
        /// </summary>
        private readonly FileStorage fileStorage;

        /// <summary>
        /// List of all available information systems
        /// </summary>
        public List<InformationSystem> InformationSystems { get; set; }

        /// <summary>
        /// Creates new data storage
        /// </summary>
        /// <param name="path">Path to file with data</param>
        /// <param name="fileStorage">Storage of data</param>
        public DataStorage(string path, FileStorage fileStorage)
        {
            this.path = path;
            this.InformationSystems = new List<InformationSystem>();
            this.fileStorage = fileStorage;
        }

        /// <summary>
        /// Loads content of storage
        /// </summary>
        public void Load()
        {
            string output = Configuration.TempDir + Path.DirectorySeparatorChar + "_DB";
            if (Directory.Exists(output))
            {
                Directory.Delete(output, true);
            }
            Directory.CreateDirectory(output);
            if (File.Exists(this.path))
            {
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
            string file = Configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.ISFile;
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach(XmlElement isElem in root.ChildNodes)
                    {
                        if (isElem.Name == DataStorage.XML.InformationSystem._Root)
                        {
                            XmlNodeList? nameList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Name);
                            XmlNodeList? iconList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Icon);
                            XmlNodeList? descList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Description);
                            XmlNodeList? credList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Created);
                            XmlNodeList? updtList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Updated);
                            if (
                                    nameList != null && nameList.Count >= 1 &&
                                    iconList != null && iconList.Count >= 1 &&
                                    descList != null && descList.Count >= 1 &&
                                    credList != null && credList.Count >= 1 &&
                                    updtList != null && credList.Count >= 1
                               )
                            {
                                XmlElement? nameElement = (XmlElement?)nameList[0];
                                XmlElement? iconElement = (XmlElement?)iconList[0];
                                XmlElement? descElement = (XmlElement?)descList[0];
                                XmlElement? credElement = (XmlElement?)credList[0];
                                XmlElement? updtElement = (XmlElement?)updtList[0];
                                if (
                                        nameElement != null &&
                                        iconElement != null &&
                                        descElement != null &&
                                        credElement != null &&
                                        updtElement != null
                                   )
                                {
                                    this.InformationSystems.Add(new InformationSystem(
                                        DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                        DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null),
                                        this.fileStorage.GetIcon(iconElement.InnerText, FileStorage.DefaultIconType.IS),
                                        nameElement.InnerText,
                                        descElement.InnerText
                                    ));
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Saves information systems into XML
        /// </summary>
        private void SaveInformationSystems()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration(DataStorage.XML._Version, DataStorage.XML._Charset, null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement iss = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystems, string.Empty);
            doc.AppendChild(iss);
            foreach(InformationSystem informationSystem in this.InformationSystems)
            {
                XmlElement infS = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem._Root, string.Empty);
                XmlElement created = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem.Created, string.Empty);
                created.InnerText = informationSystem.Created.ToString(DataStorage.XML._Date);
                infS.AppendChild(created);
                XmlElement updated = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem.Updated, string.Empty);
                updated.InnerText = informationSystem.Updated.ToString(DataStorage.XML._Date);
                infS.AppendChild(updated);
                XmlElement icon = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem.Icon, string.Empty);
                icon.InnerText = informationSystem.Icon.Name;
                infS.AppendChild(icon);
                XmlElement name = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem.Name, string.Empty);
                name.InnerText = informationSystem.Name;
                infS.AppendChild(name);
                XmlElement desc = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem.Description, string.Empty);
                desc.InnerText = informationSystem.Description;
                infS.AppendChild(desc);
                iss.AppendChild(infS);
            }
            doc.Save(Configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.ISFile);
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
            this.SaveInformationSystems();
            ZipFile.CreateFromDirectory(Configuration.TempDir + Path.DirectorySeparatorChar + "_DB", this.path);
        }
    }
}
