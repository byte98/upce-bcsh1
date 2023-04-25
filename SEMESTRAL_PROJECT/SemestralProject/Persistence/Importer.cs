using SemestralProject.Controllers;
using SemestralProject.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            /// Checksum of icon file
            /// </summary>
            public string IconChecksum { get; set; } = string.Empty;

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

            /// <summary>
            /// Checks, whether stored raw data equals to information system
            /// </summary>
            /// <param name="informationSystem">Information to which raw data will be compared</param>
            /// <returns><c>TRUE</c> if raw data equals to information system, <c>FALSE</c> otherwise</returns>
            public bool EqualsTo(Data.InformationSystem informationSystem)
            {
                return false;
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
            /// Checksum of picture file
            /// </summary>
            public string PictureChecksum { get; set; } = string.Empty;

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

        /// <summary>
        /// Structure holding raw data about manufacturer from file
        /// </summary>
        private struct Manufacturer
        {
            /// <summary>
            /// Identifier of manufacturer
            /// </summary>
            public string Id { get; init; }

            /// <summary>
            /// Name of manufacturer
            /// </summary>
            public string Name { get; init; }

            /// <summary>
            /// Description of manufacturer
            /// </summary>
            public string Description { get; init; }

            /// <summary>
            /// Identifier of icon of manufacturer
            /// </summary>
            public string Icon { get; init; }

            /// <summary>
            /// Date and time of creation of manufacturer
            /// </summary>
            public DateTime Created { get; init; }

            /// <summary>
            /// Date and time of last update of manufacturer
            /// </summary>
            public DateTime Updated { get; init; }

            /// <summary>
            /// Checksum of icon file
            /// </summary>
            public string IconChecksum { get; set; } = string.Empty;

            /// <summary>
            /// Creates new structure holding information about manufacturer
            /// </summary>
            /// <param name="id">Identifier of manufacturer</param>
            /// <param name="name">Name of manufacturer</param>
            /// <param name="description">Description of manufacturer</param>
            /// <param name="icon">Name of icon of manufacturer</param>
            /// <param name="created">Date and time of creation of manufacturer</param>
            /// <param name="updated">Date and time of last update of manufacturer</param>
            public Manufacturer(string id, string name, string description, string icon, DateTime created, DateTime updated)
            {
                this.Id = id;
                this.Name = name;
                this.Description = description;
                this.Icon = icon;
                this.Created = created;
                this.Updated = updated;
            }
        }

        /// <summary>
        /// Structure holding raw data about vehicle from file
        /// </summary>
        private struct Vehicle
        {
            /// <summary>
            /// Identifier of vehicle
            /// </summary>
            public string Id { get; init; }

            /// <summary>
            /// Name of vehicle
            /// </summary>
            public string Name { get; init; }

            /// <summary>
            /// Description of vehicle
            /// </summary>
            public string Description { get; init; }

            /// <summary>
            /// Name of picture of vehicle
            /// </summary>
            public string Picture { get; init; }

            /// <summary>
            /// Raw data of information system installed on vehicle
            /// </summary>
            public InformationSystem InformationSystem { get; init; }

            /// <summary>
            /// Raw data of manufacturer of vehicle
            /// </summary>
            public Manufacturer Manufacturer { get; init; }

            /// <summary>
            /// Date and time of creation of vehicle
            /// </summary>
            public DateTime Created { get; init; }

            /// <summary>
            /// Date and time of last update of vehicle
            /// </summary>
            public DateTime Updated { get; init; }

            /// <summary>
            /// Creates new holder of raw data from file about vehicle
            /// </summary>
            /// <param name="id">Identifier of vehicle</param>
            /// <param name="name">Name of vehicle</param>
            /// <param name="description">Description of vehicle</param>
            /// <param name="picture">Picture of vehicle</param>
            /// <param name="informationSystem">Information system of vehicle</param>
            /// <param name="manufacturer">Manufacturer of vehicle</param>
            /// <param name="created">Date and time of creation of vehicle</param>
            /// <param name="updated">Date and time of last update of vehicle</param>
            public Vehicle(string id, string name, string description, string picture, InformationSystem informationSystem, Manufacturer manufacturer, DateTime created, DateTime updated)
            {
                this.Id = id;
                this.Name = name;
                this.Description = description;
                this.Picture = picture;
                this.Manufacturer = manufacturer;
                this.InformationSystem = informationSystem;
                this.Created = created;
                this.Updated = updated;
            }
        }

        /// <summary>
        /// Structure holding raw data from file about data file
        /// </summary>
        private struct DataFile
        {
            /// <summary>
            /// Identifier of data file
            /// </summary>
            public string Id { get; init; }

            /// <summary>
            /// Name of physical data file
            /// </summary>
            public string Name { get; init; }

            /// <summary>
            /// Description of data file
            /// </summary>
            public string Description { get; init; }

            /// <summary>
            /// Path to original file
            /// </summary>
            public string OriginalPath { get; init; }

            /// <summary>
            /// Raw data of information system in which format are data stored in file
            /// </summary>
            public InformationSystem InformationSystem { get; init; }

            /// <summary>
            /// Raw data of map which data data file stores
            /// </summary>
            public Map Map { get; init; }

            /// <summary>
            /// Date and time of creation of data file
            /// </summary>
            public DateTime Created { get; init; }

            /// <summary>
            /// Date and time of last modification of data file
            /// </summary>
            public DateTime Updated { get; init; }

            /// <summary>
            /// Creates new structure holding raw information about data file
            /// </summary>
            /// <param name="id">Identifier of data file</param>
            /// <param name="name">Name of data file</param>
            /// <param name="description">Description of data file</param>
            /// <param name="originalPath">Original path to file</param>
            /// <param name="informationSystem">Raw data of information system which format data file stores</param>
            /// <param name="map">Raw data of map which data are stored in data file</param>
            /// <param name="created">Date and time of creation of data file</param>
            /// <param name="updated">Date and time of last update of data file</param>
            public DataFile(string id, string name, string description, string originalPath, InformationSystem informationSystem, Map map, DateTime created, DateTime updated)
            {
                this.Id = id;
                this.Name = name;
                this.Description = description;
                this.OriginalPath = originalPath;
                this.InformationSystem = informationSystem;
                this.Map = map;
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
        /// List with all loaded information systems
        /// </summary>
        private readonly List<InformationSystem> loadedInformationSystems;

        /// <summary>
        /// List with all loaded maps
        /// </summary>
        private readonly List<Map> loadedMaps;

        /// <summary>
        /// List with all loaded manufacturers
        /// </summary>
        private readonly List<Manufacturer> loadedManufacturers;

        /// <summary>
        /// List with all loaded vehicles
        /// </summary>
        private readonly List<Vehicle> loadedVehicles;

        /// <summary>
        /// List with all loaded data files
        /// </summary>
        private readonly List<DataFile> loadedDataFiles;

        /// <summary>
        /// List with all loaded icons
        /// </summary>
        private readonly List<FileWrapper> loadedIcons;

        /// <summary>
        /// List with all loaded pictures
        /// </summary>
        private readonly List<FileWrapper> loadedPictures;

        /// <summary>
        /// List with all loaded contents of data files
        /// </summary>
        private readonly List<FileWrapper> loadedDataFilesContent;

        /// <summary>
        /// Dictionary containing new names of imported icons
        /// </summary>
        private readonly Dictionary<string, string> iconsDictionary;

        /// <summary>
        /// Dictionary containing new names of imported pictures
        /// </summary>
        private readonly Dictionary<string, string> picturesDictionary;

        /// <summary>
        /// Dictionary containing new names of imported data files
        /// </summary>
        private readonly Dictionary<string, string> dataFilesDictionary;

        /// <summary>
        /// Dictionary which stores information system object relevant to its raw data
        /// </summary>
        private readonly Dictionary<InformationSystem, Data.InformationSystem> informationSystemsDictionary;

        /// <summary>
        /// Creates new importer of data
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public Importer(Context context)
        {
            this.context = context;
            this.loadedInformationSystems = new List<InformationSystem>();
            this.loadedMaps = new List<Map>();
            this.loadedManufacturers = new List<Manufacturer>();
            this.loadedVehicles = new List<Vehicle>();
            this.loadedDataFiles = new List<DataFile>();
            this.loadedIcons = new List<FileWrapper>();
            this.loadedPictures = new List<FileWrapper>();
            this.loadedDataFilesContent = new List<FileWrapper>();
            this.iconsDictionary = new Dictionary<string, string>();
            this.picturesDictionary = new Dictionary<string, string>();
            this.dataFilesDictionary = new Dictionary<string, string>();
            this.informationSystemsDictionary = new Dictionary<InformationSystem, Data.InformationSystem>();
        }

        /// <summary>
        /// Starts importing process
        /// (this needs to be called as FIRST function call).
        /// BEFORE this function call, property <see cref="InputPath"/> must be set to some existing <c>.EXDAT</c> file.
        /// </summary>
        private void Import()
        {
            // Initial event invoke
            this.progress = 0;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji import dat..."));

            // Make temporary directory
            if (Directory.Exists(this.tempDir))
            {
                Directory.Delete(this.tempDir, true);
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
        private void LoadInformationIS()
        {
            this.progress = 10;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o informačních systémech..."));
            this.loadedInformationSystems.Clear();
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.ISFile;
            this.OnExportImportLog(new ExportImportLogEventArgs("Čtení ze souboru " + file));
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach (XmlElement isElem in root.ChildNodes)
                    {
                        if (isElem.Name == DataStorage.XML.InformationSystem._Element)
                        {
                            XmlNodeList? idenList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Id);
                            XmlNodeList? nameList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Name);
                            XmlNodeList? iconList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Icon);
                            XmlNodeList? descList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Description);
                            XmlNodeList? credList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Created);
                            XmlNodeList? updtList = isElem.GetElementsByTagName(DataStorage.XML.InformationSystem.Updated);
                            if (
                                    idenList != null && idenList.Count >= 1 &&
                                    nameList != null && nameList.Count >= 1 &&
                                    iconList != null && iconList.Count >= 1 &&
                                    descList != null && descList.Count >= 1 &&
                                    credList != null && credList.Count >= 1 &&
                                    updtList != null && credList.Count >= 1
                               )
                            {
                                XmlElement? idenElement = (XmlElement?)idenList[0];
                                XmlElement? nameElement = (XmlElement?)nameList[0];
                                XmlElement? iconElement = (XmlElement?)iconList[0];
                                XmlElement? descElement = (XmlElement?)descList[0];
                                XmlElement? credElement = (XmlElement?)credList[0];
                                XmlElement? updtElement = (XmlElement?)updtList[0];
                                if (
                                        idenElement != null &&
                                        nameElement != null &&
                                        iconElement != null &&
                                        descElement != null &&
                                        credElement != null &&
                                        updtElement != null
                                   )
                                {
                                    this.loadedInformationSystems.Add(
                                        new InformationSystem(
                                            idenElement.InnerText,
                                            nameElement.InnerText,
                                            descElement.InnerText,
                                            iconElement.InnerText,
                                            DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                            DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null)
                                        )
                                    );
                                    this.OnExportImportLog(new ExportImportLogEventArgs("Načteny informace o systému " + nameElement.InnerText));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 15;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o informačních systémech..."));
        }

        /// <summary>
        /// Loads information about maps
        /// </summary>
        private void LoadInformationMaps()
        {
            this.progress = 15;
            this.loadedMaps.Clear();
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o oblastech..."));
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.MapFile;
            this.OnExportImportLog(new ExportImportLogEventArgs("Čtení ze souboru " + file));
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach (XmlElement mapElem in root.ChildNodes)
                    {
                        if (mapElem.Name == DataStorage.XML.Map._Element)
                        {
                            XmlNodeList? idenList = mapElem.GetElementsByTagName(DataStorage.XML.Map.Id);
                            XmlNodeList? nameList = mapElem.GetElementsByTagName(DataStorage.XML.Map.Name);
                            XmlNodeList? descList = mapElem.GetElementsByTagName(DataStorage.XML.Map.Description);
                            XmlNodeList? pictList = mapElem.GetElementsByTagName(DataStorage.XML.Map.Picture);
                            XmlNodeList? credList = mapElem.GetElementsByTagName(DataStorage.XML.Map.Created);
                            XmlNodeList? updtList = mapElem.GetElementsByTagName(DataStorage.XML.Map.Updated);
                            if (idenList != null && idenList.Count >= 1 &&
                                nameList != null && nameList.Count >= 1 &&
                                descList != null && descList.Count >= 1 &&
                                pictList != null && pictList.Count >= 1 &&
                                credList != null && credList.Count >= 1 &&
                                updtList != null && updtList.Count >= 1)
                            {
                                XmlElement? idenElem = (XmlElement?)idenList[0];
                                XmlElement? nameElem = (XmlElement?)nameList[0];
                                XmlElement? descElem = (XmlElement?)descList[0];
                                XmlElement? pictElem = (XmlElement?)pictList[0];
                                XmlElement? credElem = (XmlElement?)credList[0];
                                XmlElement? updtElem = (XmlElement?)updtList[0];
                                if (idenElem != null &&
                                    nameElem != null &&
                                    descElem != null &&
                                    pictElem != null &&
                                    credElem != null &&
                                    updtElem != null)
                                {
                                    this.loadedMaps.Add(new Map(
                                        idenElem.InnerText,
                                        nameElem.InnerText,
                                        descElem.InnerText,
                                        pictElem.InnerText,
                                        DateTime.ParseExact(credElem.InnerText, DataStorage.XML._Date, null),
                                        DateTime.ParseExact(updtElem.InnerText, DataStorage.XML._Date, null)
                                    ));
                                    this.OnExportImportLog(new ExportImportLogEventArgs("Načteny informace o oblasti " + nameElem.InnerText));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 20;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o oblastech..."));
        }

        /// <summary>
        /// Loads information about manufacturers
        /// </summary>
        private void LoadInformationManufacturers()
        {
            this.progress = 20;
            this.loadedManufacturers.Clear();
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.ManufacturerFile;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o výrobcích..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Čtení ze souboru " + file));
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach (XmlElement manElem in root.ChildNodes)
                    {
                        if (manElem.Name == DataStorage.XML.Manufacturer._Element)
                        {
                            XmlNodeList? idenList = manElem.GetElementsByTagName(DataStorage.XML.Manufacturer.Id);
                            XmlNodeList? nameList = manElem.GetElementsByTagName(DataStorage.XML.Manufacturer.Name);
                            XmlNodeList? iconList = manElem.GetElementsByTagName(DataStorage.XML.Manufacturer.Icon);
                            XmlNodeList? descList = manElem.GetElementsByTagName(DataStorage.XML.Manufacturer.Description);
                            XmlNodeList? credList = manElem.GetElementsByTagName(DataStorage.XML.Manufacturer.Created);
                            XmlNodeList? updtList = manElem.GetElementsByTagName(DataStorage.XML.Manufacturer.Updated);
                            if (
                                    idenList != null && idenList.Count >= 1 &&
                                    nameList != null && nameList.Count >= 1 &&
                                    iconList != null && iconList.Count >= 1 &&
                                    descList != null && descList.Count >= 1 &&
                                    credList != null && credList.Count >= 1 &&
                                    updtList != null && updtList.Count >= 1
                               )
                            {
                                XmlElement? idenElement = (XmlElement?)idenList[0];
                                XmlElement? nameElement = (XmlElement?)nameList[0];
                                XmlElement? iconElement = (XmlElement?)iconList[0];
                                XmlElement? descElement = (XmlElement?)descList[0];
                                XmlElement? credElement = (XmlElement?)credList[0];
                                XmlElement? updtElement = (XmlElement?)updtList[0];
                                if (
                                        idenElement != null &&
                                        nameElement != null &&
                                        iconElement != null &&
                                        descElement != null &&
                                        credElement != null &&
                                        updtElement != null
                                   )
                                {
                                    this.loadedManufacturers.Add(new Manufacturer(
                                        idenElement.InnerText,
                                        nameElement.InnerText,
                                        descElement.InnerText,
                                        iconElement.InnerText,
                                        DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                        DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null)
                                    ));
                                    this.OnExportImportLog(new ExportImportLogEventArgs("Načteny informace o výrobci " + nameElement.InnerText));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 25;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o výrobcích..."));
        }

        /// <summary>
        /// Loads information about vehicles
        /// </summary>
        private void LoadInformationVehicles()
        {
            this.progress = 25;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o vozidlech..."));
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.VehicleFile;
            this.OnExportImportLog(new ExportImportLogEventArgs("Čtení ze souboru " + file));
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach (XmlElement vehicleElem in root.ChildNodes)
                    {
                        if (vehicleElem.Name == DataStorage.XML.Vehicle._Element)
                        {
                            XmlNodeList? idenList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.Id);
                            XmlNodeList? nameList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.Name);
                            XmlNodeList? pictList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.Picture);
                            XmlNodeList? descList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.Description);
                            XmlNodeList? credList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.Created);
                            XmlNodeList? updtList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.Updated);
                            XmlNodeList? manuList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.Manufacturer);
                            XmlNodeList? pathList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.Path);
                            XmlNodeList? infsList = vehicleElem.GetElementsByTagName(DataStorage.XML.Vehicle.InformationSystem);
                            if (
                                    idenList != null && idenList.Count >= 1 &&
                                    nameList != null && nameList.Count >= 1 &&
                                    pictList != null && pictList.Count >= 1 &&
                                    descList != null && descList.Count >= 1 &&
                                    credList != null && credList.Count >= 1 &&
                                    updtList != null && updtList.Count >= 1 &&
                                    manuList != null && manuList.Count >= 1 &&
                                    pathList != null && pathList.Count >= 1 &&
                                    infsList != null && infsList.Count >= 1
                               )
                            {
                                XmlElement? idenElement = (XmlElement?)idenList[0];
                                XmlElement? nameElement = (XmlElement?)nameList[0];
                                XmlElement? pictElement = (XmlElement?)pictList[0];
                                XmlElement? descElement = (XmlElement?)descList[0];
                                XmlElement? credElement = (XmlElement?)credList[0];
                                XmlElement? updtElement = (XmlElement?)updtList[0];
                                XmlElement? manuElement = (XmlElement?)manuList[0];
                                XmlElement? pathElement = (XmlElement?)pathList[0];
                                XmlElement? infsElement = (XmlElement?)infsList[0];
                                if (
                                        idenElement != null &&
                                        nameElement != null &&
                                        pictElement != null &&
                                        descElement != null &&
                                        credElement != null &&
                                        updtElement != null &&
                                        manuElement != null &&
                                        pathElement != null &&
                                        infsElement != null
                                   )
                                {
                                    InformationSystem? informationSystem = this.GetRawInformationSystem(infsElement.InnerText);
                                    Manufacturer? manufacturer = this.GetRawManufacturer(manuElement.InnerText);
                                    if (informationSystem != null)
                                    {
                                        if (manufacturer != null)
                                        {
                                            this.loadedVehicles.Add(new Vehicle(
                                                idenElement.InnerText,
                                                nameElement.InnerText,
                                                descElement.InnerText,
                                                pictElement.InnerText,
                                                (InformationSystem)informationSystem,
                                                (Manufacturer)manufacturer,
                                                DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                                DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null)
                                            ));
                                            this.OnExportImportLog(new ExportImportLogEventArgs("Načteny informace o vozidle " + nameElement.InnerText));
                                        }
                                        else
                                        {
                                            this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Nelze načíst informace o vozidle " + nameElement.InnerText + " (neznámý výrobce " + manuElement.InnerText + ")!"));
                                        }
                                    }
                                    else
                                    {
                                        this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Nelze načíst informace o vozidle " + nameElement.InnerText + " (neznámý informační systém " + infsElement.InnerText + ")!"));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 30;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o vozidlech..."));
        }

        /// <summary>
        /// Loads information about data files
        /// </summary>
        private void LoadInformationDataFiles()
        {
            this.progress = 30;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o datových souborech..."));
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.DataFileFile;
            this.OnExportImportLog(new ExportImportLogEventArgs("Čtení ze souboru " + file));
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach (XmlElement dataFileElem in root.ChildNodes)
                    {
                        if (dataFileElem.Name == DataStorage.XML.DataFile._Element)
                        {
                            XmlNodeList? idenList = dataFileElem.GetElementsByTagName(DataStorage.XML.DataFile.Id);
                            XmlNodeList? nameList = dataFileElem.GetElementsByTagName(DataStorage.XML.DataFile.Name);
                            XmlNodeList? descList = dataFileElem.GetElementsByTagName(DataStorage.XML.DataFile.Description);
                            XmlNodeList? credList = dataFileElem.GetElementsByTagName(DataStorage.XML.DataFile.Created);
                            XmlNodeList? updtList = dataFileElem.GetElementsByTagName(DataStorage.XML.DataFile.Updated);
                            XmlNodeList? origList = dataFileElem.GetElementsByTagName(DataStorage.XML.DataFile.OriginalPath);
                            XmlNodeList? infsList = dataFileElem.GetElementsByTagName(DataStorage.XML.DataFile.InformationSystem);
                            XmlNodeList? mapsList = dataFileElem.GetElementsByTagName(DataStorage.XML.DataFile.Map);
                            if (
                                    idenList != null && idenList.Count >= 1 &&
                                    nameList != null && nameList.Count >= 1 &&
                                    descList != null && descList.Count >= 1 &&
                                    credList != null && credList.Count >= 1 &&
                                    updtList != null && updtList.Count >= 1 &&
                                    origList != null && origList.Count >= 1 &&
                                    infsList != null && infsList.Count >= 1 &&
                                    mapsList != null && mapsList.Count >= 1
                               )
                            {
                                XmlElement? idenElement = (XmlElement?)idenList[0];
                                XmlElement? nameElement = (XmlElement?)nameList[0];
                                XmlElement? descElement = (XmlElement?)descList[0];
                                XmlElement? credElement = (XmlElement?)credList[0];
                                XmlElement? updtElement = (XmlElement?)updtList[0];
                                XmlElement? origElement = (XmlElement?)origList[0];
                                XmlElement? infsElement = (XmlElement?)infsList[0];
                                XmlElement? mapsElement = (XmlElement?)mapsList[0];
                                if (
                                        idenElement != null &&
                                        nameElement != null &&
                                        descElement != null &&
                                        credElement != null &&
                                        updtElement != null &&
                                        origElement != null &&
                                        infsElement != null &&
                                        mapsElement != null
                                   )
                                {
                                    InformationSystem? informationSystem = this.GetRawInformationSystem(infsElement.InnerText);
                                    Map? map = this.GetRawMap(mapsElement.InnerText);
                                    if (informationSystem != null)
                                    {
                                        if (map != null)
                                        {
                                            this.loadedDataFiles.Add(new DataFile(
                                                idenElement.InnerText,
                                                nameElement.InnerText,
                                                descElement.InnerText,
                                                origElement.InnerText,
                                                (InformationSystem)informationSystem,
                                                (Map)map,
                                                DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                                DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null)
                                            ));
                                            this.OnExportImportLog(new ExportImportLogEventArgs("Načteny informace o datovém souboru " + nameElement.InnerText));
                                        }
                                        else
                                        {
                                            this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Nelze načíst informace o datovém souboru " + nameElement.InnerText + " (neznámá oblast " + mapsElement.InnerText + ")!"));
                                        }
                                    }
                                    else
                                    {
                                        this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Nelze načíst informace o datovém souboru " + nameElement.InnerText + " (neznámý informační systém " + infsElement.InnerText + ")!"));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 35;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o datových souborech..."));
        }

        /// <summary>
        /// Gets raw data of information system by its identifier
        /// </summary>
        /// <param name="id">Identifier of searched information system</param>
        /// <returns>Raw data of information system with searched identifier or <c>NULL</c>, if there is no such information system</returns>
        private InformationSystem? GetRawInformationSystem(string id)
        {
            InformationSystem? reti = null;
            foreach (InformationSystem system in this.loadedInformationSystems)
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
        /// Gets raw data of map by its identifier
        /// </summary>
        /// <param name="id">Searched identifier of map</param>
        /// <returns>Raw data of map with searched identifier or <c>NULL</c>, if there is no such map</returns>
        private Map? GetRawMap(string id)
        {
            Map? reti = null;
            foreach (Map map in this.loadedMaps)
            {
                if (map.Id == id)
                {
                    reti = map;
                    break;
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets raw data of manufacturer by its identifier
        /// </summary>
        /// <param name="id">Identifier of searched manufacturer</param>
        /// <returns>Manufactuer with searched identifier or <c>NULL</c>, if there is no such manufacturer</returns>
        private Manufacturer? GetRawManufacturer(string id)
        {
            Manufacturer? reti = null;
            foreach (Manufacturer man in this.loadedManufacturers)
            {
                if (man.Id == id)
                {
                    reti = man;
                    break;
                }
            }
            return reti;
        }

        /// <summary>
        /// Loads information about icons
        /// </summary>
        private void LoadInformationIcons()
        {
            this.progress = 35;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o ikonách..."));
            string file = this.tempDir + Path.DirectorySeparatorChar + "ICONS" + Path.DirectorySeparatorChar + "ICONS.XML";
            this.OnExportImportLog(new ExportImportLogEventArgs("Čtení ze souboru " + file));
            this.loadedIcons.Clear();
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach (XmlElement iconElem in root.ChildNodes)
                    {
                        if (iconElem.Name == "ICON")
                        {
                            FileWrapper? icon = FileWrapper.FromXml(iconElem);
                            if (icon != null)
                            {
                                FileWrapper iconChecked = (FileWrapper)icon;
                                this.OnExportImportLog(new ExportImportLogEventArgs("Načteny informace o ikoně " + iconChecked.Name));
                                this.loadedIcons.Add(iconChecked);
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 40;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o ikonách..."));
        }

        /// <summary>
        /// Loads information about pictures
        /// </summary>
        private void LoadInformationPictures()
        {
            this.progress = 40;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o obrázcích..."));
            string file = this.tempDir + Path.DirectorySeparatorChar + "PICTURES" + Path.DirectorySeparatorChar + "PICTURES.XML";
            this.OnExportImportLog(new ExportImportLogEventArgs("Čtení ze souboru " + file));
            this.loadedPictures.Clear();
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach (XmlElement pictElem in root.ChildNodes)
                    {
                        if (pictElem.Name == "PICTURE")
                        {
                            FileWrapper? picture = FileWrapper.FromXml(pictElem);
                            if (picture != null)
                            {
                                FileWrapper pictureChecked = (FileWrapper)picture;
                                this.OnExportImportLog(new ExportImportLogEventArgs("Načteny informace o obrázku " + pictureChecked.Name));
                                this.loadedPictures.Add(pictureChecked);
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 45;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o obrázcích..."));
        }

        /// <summary>
        /// Loads information about content of data files
        /// </summary>
        private void LoadInformationDataFileContents()
        {
            this.progress = 45;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o obsahu datových souborů..."));
            string file = this.tempDir + Path.DirectorySeparatorChar + "DATAFILES" + Path.DirectorySeparatorChar + "DATAFILES.XML";
            this.OnExportImportLog(new ExportImportLogEventArgs("Čtení ze souboru " + file));
            this.loadedPictures.Clear();
            if (File.Exists(file))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement? root = doc.DocumentElement;
                if (root != null)
                {
                    foreach (XmlElement fileElem in root.ChildNodes)
                    {
                        if (fileElem.Name == "DATAFILE")
                        {
                            FileWrapper? dataFile = FileWrapper.FromXml(fileElem);
                            if (dataFile != null)
                            {
                                FileWrapper dataFileChecked = (FileWrapper)dataFile;
                                this.OnExportImportLog(new ExportImportLogEventArgs("Načteny informace o obsahu datového souboru " + dataFileChecked.Name));
                                this.loadedDataFilesContent.Add(dataFileChecked);
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 50;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Načítám informace o obsahu datových souborů..."));
        }

        /// <summary>
        /// Gets icon by checksum of file
        /// </summary>
        /// <param name="checksum">Checksum which represents content of file</param>
        /// <returns>Icon with content represented by checksum or <c>NULL</c>, if there is no such icon</returns>
        private Visual.Icon? GetIcon(string checksum)
        {
            Visual.Icon? reti = null;
            foreach (Visual.Icon icon in this.context.FileStorage.GetAllIcons())
            {
                string? path = this.context.FileStorage.GetIconPath(icon);
                if (path != null)
                {
                    string otherChecksum = FileUtils.GenerateChecksum(path);
                    if (checksum == otherChecksum)
                    {
                        reti = icon;
                        break;
                    }
                }
            }
            return reti;
        }

        /// <summary>
        /// Import icons to system
        /// </summary>
        private void ImportIcons()
        {
            this.progress = 50;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji ikony..."));
            this.iconsDictionary.Clear();
            double step = 5f / (double)this.loadedIcons.Count;
            int counter = 0;
            foreach (FileWrapper icon in this.loadedIcons)
            {
                Visual.Icon? inSystem = this.GetIcon(icon.Checksum);
                if (inSystem == null)
                {
                    this.iconsDictionary.Add(icon.Name, icon.Name);
                    this.context.FileStorage.AddIcon(icon.Path);
                    this.OnExportImportLog(new ExportImportLogEventArgs("Importována ikona " + icon.Name));
                }
                else
                {
                    this.iconsDictionary.Add(icon.Name, inSystem.Name);
                    this.OnExportImportLog(new ExportImportLogEventArgs("Ikona " + icon.Name + " je již v systému"));
                }
                this.progress = (ushort)(50 + (ushort)Math.Round((double)counter * step));
                counter++;
                this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji ikony..."));
            }
            this.progress = 55;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji ikony..."));
        }

        /// <summary>
        /// Gets picture by its checksum of file
        /// </summary>
        /// <param name="checksum">Checksum of file which will be searched</param>
        /// <returns>Picture with searchec checksum of file or <c>NULL</c>, if there is no such picture</returns>
        private Visual.Picture? GetPicture(string checksum)
        {
            Visual.Picture? reti = null;
            foreach (Visual.Picture picture in this.context.FileStorage.GetPictures())
            {
                string? path = this.context.FileStorage.GetPicturePath(picture);
                if (path != null)
                {
                    string otherChecksum = FileUtils.GenerateChecksum(path);
                    if (checksum == otherChecksum)
                    {
                        reti = picture;
                        break;
                    }
                }
            }
            return reti;
        }

        /// <summary>
        /// Import pictures to system 
        /// </summary>
        private void ImportPictures()
        {
            this.progress = 55;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji obrázky..."));
            this.picturesDictionary.Clear();
            double step = 5f / (double)this.loadedPictures.Count;
            int counter = 0;
            foreach (FileWrapper picture in this.loadedPictures)
            {
                Visual.Picture? inSystem = this.GetPicture(picture.Checksum);
                if (inSystem == null)
                {
                    this.picturesDictionary.Add(picture.Name, picture.Name);
                    this.context.FileStorage.AddPicture(picture.Path);
                    this.OnExportImportLog(new ExportImportLogEventArgs("Importován obrázek " + picture.Name));
                }
                else
                {
                    this.picturesDictionary.Add(picture.Name, inSystem.Name);
                    this.OnExportImportLog(new ExportImportLogEventArgs("Obrázek " + picture.Name + " je již v systému"));
                }
                this.progress = (ushort)(55 + (ushort)Math.Round((double)counter * step));
                counter++;
                this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji obrázky..."));
            }
            this.progress = 60;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji obrázky..."));
        }

        /// <summary>
        /// Gets data file by checksum of its content
        /// </summary>
        /// <param name="checksum">Searched checksum</param>
        /// <returns>Name of data file with searched checksum or <c>NULL</c>, if there is no such data file</returns>
        private string? GetDataFile(string checksum)
        {
            string? reti = null;
            foreach(string dataFile in this.context.FileStorage.GetDataFiles())
            {
                string? path = this.context.FileStorage.GetDataFilePath(dataFile);
                if (path != null)
                {
                    string otherChecksum = FileUtils.GenerateChecksum(path);
                    if(checksum == otherChecksum)
                    {
                        reti = dataFile;
                        break;
                    }
                }
            }
            return reti;
        }

        /// <summary>
        /// Imports data files to system
        /// </summary>
        private void ImportDataFiles()
        {
            this.progress = 60;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji obsah datových souborů..."));
            this.dataFilesDictionary.Clear();
            double step = 5f / (double)this.loadedDataFilesContent.Count;
            int counter = 0;
            foreach (FileWrapper dataFile in this.loadedDataFilesContent)
            {
                string? inSystem = this.GetDataFile(dataFile.Checksum);
                if (inSystem == null)
                {
                    this.dataFilesDictionary.Add(dataFile.Name, dataFile.Name);
                    this.context.FileStorage.AddDataFile(dataFile.Path);
                    this.OnExportImportLog(new ExportImportLogEventArgs("Importován obsah datového souboru " + dataFile.Name));
                }
                else
                {
                    this.dataFilesDictionary.Add(dataFile.Name, inSystem);
                    this.OnExportImportLog(new ExportImportLogEventArgs("Obsah datového souboru " + dataFile.Name + " je již v systému"));
                }
                this.progress = (ushort)(60 + (ushort)Math.Round((double)counter * step));
                counter++;
                this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji obsah datových souborů..."));
            }
            this.progress = 65;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji obsah datových souborů..."));
        }

        /// <summary>
        /// Gets information system by its raw data
        /// </summary>
        /// <param name="informationSystem">Raw data of information system which will be checked</param>
        /// <returns>Information system with searched raw data or <c>NULL</c>, if there is no such information system</returns>
        private Data.InformationSystem? GetInformationSystem(InformationSystem informationSystem)
        {
            Data.InformationSystem? reti = null;
            foreach(Data.InformationSystem system in this.context.DataStorage.InformationSystems)
            {
                if (system.Name == informationSystem.Name)
                {
                    string? path = this.context.FileStorage.GetIconPath(system.Icon);
                    if (path != null)
                    {
                        string checksum = FileUtils.GenerateChecksum(path);
                        if (checksum == informationSystem.IconChecksum)
                        {
                            reti = system;
                            break;
                        }
                    }
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets information system by its identifier
        /// </summary>
        /// <param name="id">Searched identifier of information system</param>
        /// <returns>Information system with searched identifier or <c>NULL</c>, if there is no such information system</returns>
        private Data.InformationSystem? GetInformationSystem(string id)
        {
            Data.InformationSystem? reti = null;
            foreach(Data.InformationSystem system in this.context.DataStorage.InformationSystems)
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
        /// Gets checksum of icon file
        /// </summary>
        /// <param name="name">Name of icon</param>
        /// <returns>Checksum of icon file</returns>
        private string GetIconChecksum(string name)
        {
            string reti = string.Empty;
            Visual.Icon? icon = this.context.FileStorage.GetIcon(name);
            if (icon != null)
            {
                string? path = this.context.FileStorage.GetIconPath(icon);
                if (path != null)
                {
                    reti = FileUtils.GenerateChecksum(path);
                }
            }
            return reti;
        }

        /// <summary>
        /// Generates identifier for information system
        /// </summary>
        /// <returns>Pseudo-random unique identifier of information system</returns>
        private string GenerateInformationSystemId()
        {
            string reti = string.Empty;
            do
            {
                reti = InformationSystemsController.IdPrefix + StringUtils.Random(AbstractController<Data.InformationSystem>.IdAlphabet, AbstractController<Data.InformationSystem>.IdMinLength, AbstractController<Data.InformationSystem>.IdMaxLength);
            }
            while (this.GetInformationSystem(reti) != null);
            return reti;
        }

        /// <summary>
        /// Imports information systems
        /// </summary>
        private void ImportInformationSystems()
        {
            this.progress = 65;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji informační systémy..."));
            this.dataFilesDictionary.Clear();
            double step = 5f / (double)this.loadedInformationSystems.Count;
            int idx = 0;
            for(; idx < this.loadedInformationSystems.Count;idx++)
            {
                InformationSystem system = this.loadedInformationSystems[idx];
                system.IconChecksum = this.GetIconChecksum(this.iconsDictionary[system.Icon]);
                Data.InformationSystem? informationSystem = this.GetInformationSystem(system);
                if (informationSystem == null)
                {
                    Data.InformationSystem newSystem = new Data.InformationSystem(
                        this.GenerateInformationSystemId(),
                        system.Name,
                        system.Description,
                        this.context.FileStorage.GetIcon(this.iconsDictionary[system.Icon], FileStorage.DefaultIconType.IS),
                        system.Created,
                        system.Updated
                    );
                    this.context.DataStorage.InformationSystems.Add(newSystem);
                    this.informationSystemsDictionary.Add(system, newSystem);
                    this.OnExportImportLog(new ExportImportLogEventArgs("Importován informační systém " + system.Name));
                    
                }
                else
                {
                    this.informationSystemsDictionary.Add(system, informationSystem);
                    this.OnExportImportLog(new ExportImportLogEventArgs("Informační systém " + system.Name + " je již v systému"));
                }
                this.progress = (ushort)(65 + (ushort)Math.Round((double)idx * step));
                this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji informační systémy..."));
            }
            this.progress = 70;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Importuji informační systémy..."));
        }

        /// <summary>
        /// Gets all necessary actions to successfull import of data
        /// </summary>
        /// <returns>List with all necessary actions to successfull import of data</returns>
        public List<Action> GetImportSequence()
        {
            List<Action> reti = new List<Action>();
            reti.Add(new Action(() => { this.Import(); }));
            reti.Add(new Action(() => { this.LoadInformationIS(); }));
            reti.Add(new Action(() => { this.LoadInformationMaps(); }));
            reti.Add(new Action(() => { this.LoadInformationManufacturers(); }));
            reti.Add(new Action(() => { this.LoadInformationVehicles(); }));
            reti.Add(new Action(() => { this.LoadInformationDataFiles(); }));
            reti.Add(new Action(() => { this.LoadInformationIcons(); }));
            reti.Add(new Action(() => { this.LoadInformationPictures(); }));
            reti.Add(new Action(() => { this.LoadInformationDataFileContents(); }));
            reti.Add(new Action(() => { this.ImportIcons(); }));
            reti.Add(new Action(() => { this.ImportPictures(); }));
            reti.Add(new Action(() => { this.ImportDataFiles(); }));
            reti.Add(new Action(() => { this.ImportInformationSystems(); }));
            return reti;
        }
    }
}
