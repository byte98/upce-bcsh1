using SemestralProject.Controllers;
using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Windows.Devices.Pwm;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class which has ability to import data from file
    /// </summary>
    internal class Importer : AbstractProgress
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
            /// <param name="context">Wrapper of all program resources</param>
            /// <returns><c>TRUE</c> if raw data equals to information system, <c>FALSE</c> otherwise</returns>
            public bool EqualsTo(Data.InformationSystem informationSystem, Context context)
            {
                bool reti = false;
                if (this.Name == informationSystem.Name)
                {
                    string? path = context.FileStorage.GetIconPath(informationSystem.Icon);
                    if (path != null)
                    {
                        reti = this.IconChecksum == FileUtils.GenerateChecksum(path);
                    }
                }
                return reti;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = base.Equals(obj);
                if (obj != null && obj is InformationSystem informationSystem)
                {
                    reti = this.Id == informationSystem.Id;
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.Id.GetHashCode();
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

            /// <summary>
            /// Checks, whether raw data equals to map object
            /// </summary>
            /// <param name="map">Map object which will be checked</param>
            /// <param name="context">Wrapper of all program resources</param>
            /// <returns><c>TRUE</c> if raw data equals to map object, <c>FALSE</c> otherwise</returns>
            public bool EqualsTo(Data.Map map, Context context)
            {
                bool reti = false;
                if (this.Name == map.Name)
                {
                    string? path = context.FileStorage.GetPicturePath(map.Picture);
                    if (path != null)
                    {
                        reti = this.PictureChecksum == FileUtils.GenerateChecksum(path);
                    }
                }
                return reti;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = base.Equals(obj);
                if (obj != null && obj is Map map)
                {
                    reti = this.Id == map.Id;
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.Id.GetHashCode();
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

            /// <summary>
            /// Checks, whether raw data of manufacturer equals to manufacturer object
            /// </summary>
            /// <param name="manufacturer">Manufacturer which will be checked if equals to raw data</param>
            /// <param name="context">Wrapper of all program resources</param>
            /// <returns><c>TRUE</c> if raw data equals to manufacturer, <c>FALSE</c> otherwise</returns>
            public bool EqualsTo(Data.Manufacturer manufacturer, Context context)
            {
                bool reti = false;
                if (manufacturer.Name == this.Name)
                {
                    string? path = context.FileStorage.GetIconPath(manufacturer.Icon);
                    if (path != null)
                    {
                        reti = this.IconChecksum == FileUtils.GenerateChecksum(path);
                    }
                }
                return reti;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = base.Equals(obj);
                if (obj != null && obj is Manufacturer manufacturer)
                {
                    reti = this.Id == manufacturer.Id;
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.Id.GetHashCode();
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
            /// Checksum of picture file
            /// </summary>
            public string PictureChecksum { get; set; } = string.Empty;

            /// <summary>
            /// Path to vehicle
            /// </summary>
            public string Path { get; init; }

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
            /// <param name="path">Path to vehicle</param>
            /// <param name="created">Date and time of creation of vehicle</param>
            /// <param name="updated">Date and time of last update of vehicle</param>
            public Vehicle(string id, string name, string description, string picture, InformationSystem informationSystem, Manufacturer manufacturer, string path, DateTime created, DateTime updated)
            {
                this.Id = id;
                this.Name = name;
                this.Description = description;
                this.Picture = picture;
                this.Path = path;
                this.Manufacturer = manufacturer;
                this.InformationSystem = informationSystem;
                this.Created = created;
                this.Updated = updated;
            }

            /// <summary>
            /// Checks, whether raw data of vehicle equals to vehicle object
            /// </summary>
            /// <param name="vehicle">Vehicle which will be checked</param>
            /// <param name="context">Wrapper of all program resources</param>
            /// <returns><c>TRUE</c>, if raw data equals to vehicle object, <c>FALSE</c> otherwise</returns>
            public bool EqualsTo(Data.Vehicle vehicle, Context context)
            {
                bool reti = false;
                if (vehicle.Name == this.Name)
                {
                    string? path = context.FileStorage.GetPicturePath(vehicle.Picture);
                    if (path != null)
                    {
                        reti = this.PictureChecksum == FileUtils.GenerateChecksum(path);
                    }
                }
                return reti;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = base.Equals(obj);
                if (obj != null && obj is Vehicle vehicle)
                {
                    reti = this.Id == vehicle.Id;
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.Id.GetHashCode();
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

            /// <summary>
            /// Checks, whether raw data of data file equals to data file object
            /// </summary>
            /// <param name="dataFile">Data file which will be checked</param>
            /// <param name="context">Wrapper of all program resources</param>
            /// <returns><c>TRUE</c> if raw data of data file equals to data file object, <c>FALSE</c> otherwise</returns>
            public bool EqualsTo(Data.DataFile dataFile, Context context)
            {
                return (
                    this.Name == dataFile.Name
                 );
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = base.Equals(obj);
                if (obj != null && obj is DataFile dataFile)
                {
                    reti = this.Id == dataFile.Id;
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.Id.GetHashCode();
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
        /// Dictionary which stores map object relevant to its raw data
        /// </summary>
        private readonly Dictionary<Map, Data.Map> mapsDictionary;

        /// <summary>
        /// Dictionary which stores manufacturer object relevant to its raw data
        /// </summary>
        private readonly Dictionary<Manufacturer, Data.Manufacturer> manufacturersDictionary;

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
            this.mapsDictionary = new Dictionary<Map, Data.Map>();
            this.manufacturersDictionary = new Dictionary<Manufacturer, Data.Manufacturer>();
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
            this.OnProgress(new ProgressEventArgs(this.progress, "Připravuji import dat..."));

            // Make temporary directory
            if (Directory.Exists(this.tempDir))
            {
                Directory.Delete(this.tempDir, true);
            }
            Directory.CreateDirectory(this.tempDir);
            this.progress += 2;
            this.OnProgress(new ProgressEventArgs(this.progress, "Připravuji import dat..."));
            this.OnProgressLog(new ProgressLogEventArgs("Vytvořen adresář " + this.tempDir));

            // Unzip file
            ZipFile.ExtractToDirectory(this.InputPath, tempDir, true);
            this.progress = 10;
            this.OnProgress(new ProgressEventArgs(this.progress, "Připravuji import dat..."));
            this.OnProgressLog(new ProgressLogEventArgs("Rozbalen soubor " + this.InputPath));
        }

        /// <summary>
        /// Loads information about information systems
        /// </summary>
        private void LoadInformationIS()
        {
            this.progress = 10;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o informačních systémech..."));
            this.loadedInformationSystems.Clear();
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.ISFile;
            this.OnProgressLog(new ProgressLogEventArgs("Čtení ze souboru " + file));
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
                                    this.OnProgressLog(new ProgressLogEventArgs("Načteny informace o systému " + nameElement.InnerText));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 15;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o informačních systémech..."));
        }

        /// <summary>
        /// Loads information about maps
        /// </summary>
        private void LoadInformationMaps()
        {
            this.progress = 15;
            this.loadedMaps.Clear();
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o oblastech..."));
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.MapFile;
            this.OnProgressLog(new ProgressLogEventArgs("Čtení ze souboru " + file));
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
                                    this.OnProgressLog(new ProgressLogEventArgs("Načteny informace o oblasti " + nameElem.InnerText));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 20;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o oblastech..."));
        }

        /// <summary>
        /// Loads information about manufacturers
        /// </summary>
        private void LoadInformationManufacturers()
        {
            this.progress = 20;
            this.loadedManufacturers.Clear();
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.ManufacturerFile;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o výrobcích..."));
            this.OnProgressLog(new ProgressLogEventArgs("Čtení ze souboru " + file));
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
                                    this.OnProgressLog(new ProgressLogEventArgs("Načteny informace o výrobci " + nameElement.InnerText));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 25;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o výrobcích..."));
        }

        /// <summary>
        /// Loads information about vehicles
        /// </summary>
        private void LoadInformationVehicles()
        {
            this.progress = 25;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o vozidlech..."));
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.VehicleFile;
            this.OnProgressLog(new ProgressLogEventArgs("Čtení ze souboru " + file));
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
                                                pathElement.InnerText,
                                                DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                                DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null)
                                            ));
                                            this.OnProgressLog(new ProgressLogEventArgs("Načteny informace o vozidle " + nameElement.InnerText));
                                        }
                                        else
                                        {
                                            this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze načíst informace o vozidle " + nameElement.InnerText + " (neznámý výrobce " + manuElement.InnerText + ")!"));
                                        }
                                    }
                                    else
                                    {
                                        this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze načíst informace o vozidle " + nameElement.InnerText + " (neznámý informační systém " + infsElement.InnerText + ")!"));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 30;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o vozidlech..."));
        }

        /// <summary>
        /// Loads information about data files
        /// </summary>
        private void LoadInformationDataFiles()
        {
            this.progress = 30;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o datových souborech..."));
            string file = this.tempDir + "DB" + Path.DirectorySeparatorChar + DataStorage.DataFileFile;
            this.OnProgressLog(new ProgressLogEventArgs("Čtení ze souboru " + file));
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
                                            this.OnProgressLog(new ProgressLogEventArgs("Načteny informace o datovém souboru " + nameElement.InnerText));
                                        }
                                        else
                                        {
                                            this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze načíst informace o datovém souboru " + nameElement.InnerText + " (neznámá oblast " + mapsElement.InnerText + ")!"));
                                        }
                                    }
                                    else
                                    {
                                        this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze načíst informace o datovém souboru " + nameElement.InnerText + " (neznámý informační systém " + infsElement.InnerText + ")!"));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 35;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o datových souborech..."));
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
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o ikonách..."));
            string file = this.tempDir + Path.DirectorySeparatorChar + "ICONS" + Path.DirectorySeparatorChar + "ICONS.XML";
            this.OnProgressLog(new ProgressLogEventArgs("Čtení ze souboru " + file));
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
                                this.OnProgressLog(new ProgressLogEventArgs("Načteny informace o ikoně " + iconChecked.Name));
                                this.loadedIcons.Add(iconChecked);
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 40;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o ikonách..."));
        }

        /// <summary>
        /// Loads information about pictures
        /// </summary>
        private void LoadInformationPictures()
        {
            this.progress = 40;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o obrázcích..."));
            string file = this.tempDir + Path.DirectorySeparatorChar + "PICTURES" + Path.DirectorySeparatorChar + "PICTURES.XML";
            this.OnProgressLog(new ProgressLogEventArgs("Čtení ze souboru " + file));
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
                                this.OnProgressLog(new ProgressLogEventArgs("Načteny informace o obrázku " + pictureChecked.Name));
                                this.loadedPictures.Add(pictureChecked);
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 45;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o obrázcích..."));
        }

        /// <summary>
        /// Loads information about content of data files
        /// </summary>
        private void LoadInformationDataFileContents()
        {
            this.progress = 45;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o obsahu datových souborů..."));
            string file = this.tempDir + Path.DirectorySeparatorChar + "DATAFILES" + Path.DirectorySeparatorChar + "DATAFILES.XML";
            this.OnProgressLog(new ProgressLogEventArgs("Čtení ze souboru " + file));
            this.loadedDataFilesContent.Clear();
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
                                this.OnProgressLog(new ProgressLogEventArgs("Načteny informace o obsahu datového souboru " + dataFileChecked.Name));
                                this.loadedDataFilesContent.Add(dataFileChecked);
                            }
                        }
                    }
                }
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Soubor neexistuje!"));
            }
            this.progress = 50;
            this.OnProgress(new ProgressEventArgs(this.progress, "Načítám informace o obsahu datových souborů..."));
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
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji ikony..."));
            this.iconsDictionary.Clear();
            double step = 5f / (double)this.loadedIcons.Count;
            int counter = 0;
            foreach (FileWrapper icon in this.loadedIcons)
            {
                Visual.Icon? inSystem = this.GetIcon(icon.Checksum);
                if (inSystem == null)
                {
                    Visual.Icon newIcon = this.context.FileStorage.AddIcon(this.tempDir + Path.DirectorySeparatorChar + "DATAFILES" + Path.DirectorySeparatorChar + icon.Path);
                    this.iconsDictionary.Add(icon.Name, newIcon.Name);
                    this.OnProgressLog(new ProgressLogEventArgs("Importována ikona " + icon.Name));
                }
                else
                {
                    this.iconsDictionary.Add(icon.Name, inSystem.Name);
                    this.OnProgressLog(new ProgressLogEventArgs("Ikona " + icon.Name + " je již v systému"));
                }
                this.progress = (ushort)(50 + (ushort)Math.Round((double)counter * step));
                counter++;
                this.OnProgress(new ProgressEventArgs(this.progress, "Importuji ikony..."));
            }
            this.progress = 55;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji ikony..."));
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
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji obrázky..."));
            this.picturesDictionary.Clear();
            double step = 5f / (double)this.loadedPictures.Count;
            int counter = 0;
            foreach (FileWrapper picture in this.loadedPictures)
            {
                Visual.Picture? inSystem = this.GetPicture(picture.Checksum);
                if (inSystem == null)
                {
                    
                    Picture newPict = this.context.FileStorage.AddPicture(this.tempDir + Path.DirectorySeparatorChar + "PICTURES" + Path.DirectorySeparatorChar + picture.Path);
                    this.picturesDictionary.Add(picture.Name, newPict.Name);
                    this.OnProgressLog(new ProgressLogEventArgs("Importován obrázek " + picture.Name));
                }
                else
                {
                    this.picturesDictionary.Add(picture.Name, inSystem.Name);
                    this.OnProgressLog(new ProgressLogEventArgs("Obrázek " + picture.Name + " je již v systému"));
                }
                this.progress = (ushort)(55 + (ushort)Math.Round((double)counter * step));
                counter++;
                this.OnProgress(new ProgressEventArgs(this.progress, "Importuji obrázky..."));
            }
            this.progress = 60;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji obrázky..."));
        }

        /// <summary>
        /// Gets data file by checksum of its content
        /// </summary>
        /// <param name="checksum">Searched checksum</param>
        /// <returns>Name of data file with searched checksum or <c>NULL</c>, if there is no such data file</returns>
        private string? GetDataFileContent(string checksum)
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
        /// Imports content of data files to system
        /// </summary>
        private void ImportDataFilesContent()
        {
            this.progress = 60;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji obsah datových souborů..."));
            this.dataFilesDictionary.Clear();
            double step = 5f / (double)this.loadedDataFilesContent.Count;
            int counter = 0;
            foreach (FileWrapper dataFile in this.loadedDataFilesContent)
            {
                string? inSystem = this.GetDataFileContent(dataFile.Checksum);
                if (inSystem == null)
                {
                    this.dataFilesDictionary.Add(dataFile.Name, this.context.FileStorage.AddDataFile(this.tempDir + Path.DirectorySeparatorChar + "DATAFILES" + Path.DirectorySeparatorChar + dataFile.Path));
                    this.OnProgressLog(new ProgressLogEventArgs("Importován obsah datového souboru " + dataFile.Name));
                }
                else
                {
                    this.dataFilesDictionary.Add(dataFile.Name, inSystem);
                    this.OnProgressLog(new ProgressLogEventArgs("Obsah datového souboru " + dataFile.Name + " je již v systému"));
                }
                this.progress = (ushort)(60 + (ushort)Math.Round((double)counter * step));
                counter++;
                this.OnProgress(new ProgressEventArgs(this.progress, "Importuji obsah datových souborů..."));
            }
            this.progress = 65;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji obsah datových souborů..."));
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
                if (informationSystem.EqualsTo(system, this.context))
                {
                    reti = system;
                    break;
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
        /// Gets map by its raw data
        /// </summary>
        /// <param name="rawMap">Raw data of map</param>
        /// <returns>Map with searched raw data or <c>NULL</c> if there is no such map</returns>
        private Data.Map? GetMap(Map rawMap)
        {
            Data.Map? reti = null;
            foreach(Data.Map map in this.context.DataStorage.Maps)
            {
                if (rawMap.EqualsTo(map, this.context))
                {
                    reti = map;
                    break;
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets map by its identifier
        /// </summary>
        /// <param name="id">Searched identifier of map</param>
        /// <returns>Map with searched identifier or <c>NULL</c>, if there is no such map</returns>
        private Data.Map? GetMap(string id)
        {
            Data.Map? reti = null;
            foreach(Data.Map map in this.context.DataStorage.Maps)
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
        /// Gets manufacturer by its raw data
        /// </summary>
        /// <param name="rawManufacturer">Raw data of manufacturer</param>
        /// <returns>Manufacturer object which has searched raw data or <c>NULL</c>, if there is no such manufacturer</returns>
        private Data.Manufacturer? GetManufacturer(Manufacturer rawManufacturer)
        {
            Data.Manufacturer? reti = null;
            foreach(Data.Manufacturer manufacturer in this.context.DataStorage.Manufacturers)
            {
                if (rawManufacturer.EqualsTo(manufacturer, this.context))
                {
                    reti = manufacturer;
                    break;
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets manufacturer by its identifier
        /// </summary>
        /// <param name="id">Searched identifier of manufacturer</param>
        /// <returns>Manufacturer with searched identifier or <c>NULL</c>, if there is no such manufacturer</returns>
        private Data.Manufacturer? GetManufacturer(string id)
        {
            Data.Manufacturer? reti = null;
            foreach(Data.Manufacturer manufacturer in this.context.DataStorage.Manufacturers)
            {
                if (manufacturer.Id == id)
                {
                    reti = manufacturer;
                    break;
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets vehicle by its raw data
        /// </summary>
        /// <param name="rawVehicle">Raw data of vehicle</param>
        /// <returns>Vehicle with searched raw data or <c>NULL</c>, if there is no such vehicle</returns>
        private Data.Vehicle? GetVehicle(Vehicle rawVehicle)
        {
            Data.Vehicle? reti = null;
            foreach(Data.Vehicle vehicle in this.context.DataStorage.Vehicles)
            {
                if(rawVehicle.EqualsTo(vehicle, this.context))
                {
                    InformationSystem rawInformationSystem = rawVehicle.InformationSystem;
                    rawInformationSystem.IconChecksum = this.GetIconChecksum(this.iconsDictionary[rawInformationSystem.Icon]);
                    Manufacturer rawManufacturer = rawVehicle.Manufacturer;
                    rawManufacturer.IconChecksum = this.GetIconChecksum(this.iconsDictionary[rawManufacturer.Icon]);
                    if (rawInformationSystem.EqualsTo(vehicle.InformationSystem, this.context) && rawManufacturer.EqualsTo(vehicle.Manufacturer, this.context))
                    {
                        reti = vehicle;
                        break;
                    }
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets vehicle by its identifier
        /// </summary>
        /// <param name="id">Searched identifier of vehicle</param>
        /// <returns>Vehicle with searched identifier or <c>NULL</c>, if there is no such vehicle</returns>
        private Data.Vehicle? GetVehicle(string id)
        {
            Data.Vehicle? reti = null;
            foreach(Data.Vehicle vehicle in this.context.DataStorage.Vehicles)
            {
                if(vehicle.Id == id)
                {
                    reti = vehicle;
                    break;
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets data file by its raw data
        /// </summary>
        /// <param name="rawDataFile">Raw data of data file</param>
        /// <returns>Data file object with searched raw data or <c>NULL</c>, if there is no such data file</returns>
        private Data.DataFile? GetDataFile(DataFile rawDataFile)
        {
            Data.DataFile? reti = null;
            foreach(Data.DataFile dataFile in this.context.DataStorage.DataFiles)
            {
                if (rawDataFile.EqualsTo(dataFile, this.context))
                {
                    InformationSystem rawInformationSystem = rawDataFile.InformationSystem;
                    rawInformationSystem.IconChecksum = this.GetIconChecksum(this.iconsDictionary[rawInformationSystem.Icon]);
                    Map rawMap = rawDataFile.Map;
                    rawMap.PictureChecksum = this.GetPictureChecksum(this.picturesDictionary[rawMap.Picture]);
                    if (rawInformationSystem.EqualsTo(dataFile.InformationSystem, this.context) && rawMap.EqualsTo(dataFile.Map, this.context))
                    {
                        reti = dataFile;
                        break;
                    }
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets data file by its identifier
        /// </summary>
        /// <param name="id">Searched identifier of data file</param>
        /// <returns>Data file with searched identifier or <c>NULL</c>, if there is no such data file</returns>
        private Data.DataFile? GetDataFile(string id)
        {
            Data.DataFile? reti = null;
            foreach(Data.DataFile dataFile in this.context.DataStorage.DataFiles)
            {
                if (dataFile.Id == id)
                {
                    reti = dataFile;
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
        /// Gets checksum of picture file
        /// </summary>
        /// <param name="name">Name of picture</param>
        /// <returns>Checksum of picture file</returns>
        private string GetPictureChecksum(string name)
        {
            string reti = string.Empty;
            Picture? picture = this.context.FileStorage.GetPicture(name);
            if (picture != null)
            {
                string? path = this.context.FileStorage.GetPicturePath(picture);
                if (path != null)
                {
                    reti = FileUtils.GenerateChecksum(path);
                }
            }
            return reti;
        }

        /// <summary>
        /// Generates identifier for defined set of data
        /// </summary>
        /// <param name="prefix">Prefix of identifier</param>
        /// <param name="data">Data in which identifier should be unique</param>
        /// <returns>Pseudo-random unique identifier for defined set of data</returns>
        private string GenerateIdentifier(string prefix, List<AbstractData> data)
        {
            Func<string, bool> isUnique = (string id) =>
            {
                bool reti = true;
                foreach(AbstractData item in data)
                {
                    if (item.Id == id)
                    {
                        reti = false;
                        break;
                    }
                }
                return reti;
            };
            string reti = string.Empty;
            do
            {
                reti = prefix + StringUtils.Random(AbstractController<Data.InformationSystem>.IdAlphabet, AbstractController<Data.InformationSystem>.IdMinLength, AbstractController<Data.InformationSystem>.IdMaxLength);
            }
            while (isUnique(reti) == false);
            return reti;
        }

        /// <summary>
        /// Imports information systems
        /// </summary>
        private void ImportInformationSystems()
        {
            this.progress = 65;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji informační systémy..."));
            this.informationSystemsDictionary.Clear();
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
                        this.GenerateIdentifier(InformationSystemsController.IdPrefix, this.context.DataStorage.InformationSystems.OfType<AbstractData>().ToList()),
                        system.Name,
                        system.Description,
                        this.context.FileStorage.GetIcon(this.iconsDictionary[system.Icon], FileStorage.DefaultIconType.IS),
                        system.Created,
                        system.Updated
                    );
                    this.context.DataStorage.InformationSystems.Add(newSystem);
                    this.informationSystemsDictionary.Add(system, newSystem);
                    this.OnProgressLog(new ProgressLogEventArgs("Importován informační systém " + system.Name));
                    
                }
                else
                {
                    this.informationSystemsDictionary.Add(system, informationSystem);
                    this.OnProgressLog(new ProgressLogEventArgs("Informační systém " + system.Name + " je již v systému"));
                }
                this.progress = (ushort)(65 + (ushort)Math.Round((double)idx * step));
                this.OnProgress(new ProgressEventArgs(this.progress, "Importuji informační systémy..."));
            }
            this.progress = 70;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji informační systémy..."));
        }

        /// <summary>
        /// Import maps into system
        /// </summary>
        private void ImportMaps()
        {
            this.progress = 70;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji oblasti..."));
            this.mapsDictionary.Clear();
            double step = 5f / (double)this.loadedMaps.Count;
            int idx = 0;
            for (; idx < this.loadedMaps.Count; idx++)
            {
                Map rawMap = this.loadedMaps[idx];
                rawMap.PictureChecksum = this.GetPictureChecksum(this.picturesDictionary[rawMap.Picture]);
                Data.Map? map = this.GetMap(rawMap);
                if (map == null)
                {
                    Data.Map newMap = new Data.Map(
                        this.GenerateIdentifier(MapsController.IdPrefix, this.context.DataStorage.Maps.OfType<AbstractData>().ToList()),
                        rawMap.Created,
                        rawMap.Updated,
                        rawMap.Name,
                        rawMap.Description,
                        this.context.FileStorage.GetPictureChecked(this.picturesDictionary[rawMap.Picture])
                    ) ;
                    this.context.DataStorage.Maps.Add(newMap);
                    this.mapsDictionary.Add(rawMap, newMap);
                    this.OnProgressLog(new ProgressLogEventArgs("Importována oblast " + rawMap.Name));

                }
                else
                {
                    this.mapsDictionary.Add(rawMap, map);
                    this.OnProgressLog(new ProgressLogEventArgs("Oblast " + rawMap.Name + " je již v systému"));
                }
                this.progress = (ushort)(70 + (ushort)Math.Round((double)idx * step));
                this.OnProgress(new ProgressEventArgs(this.progress, "Importuji oblasti..."));
            }
            this.progress = 75;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji oblasti..."));
        }

        /// <summary>
        /// Import manufacturers into system
        /// </summary>
        private void ImportManufacturers()
        {
            this.progress = 75;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji výrobce..."));
            this.manufacturersDictionary.Clear();
            double step = 5f / (double)this.loadedManufacturers.Count;
            int idx = 0;
            for (; idx < this.loadedManufacturers.Count; idx++)
            {
                Manufacturer rawManufacturer = this.loadedManufacturers[idx];
                rawManufacturer.IconChecksum = this.GetIconChecksum(this.iconsDictionary[rawManufacturer.Icon]);
                Data.Manufacturer? manufacturer = this.GetManufacturer(rawManufacturer);
                if (manufacturer == null)
                {
                    Data.Manufacturer newManufacturer = new Data.Manufacturer(
                        this.GenerateIdentifier(ManufacturersController.IdPrefix, this.context.DataStorage.Manufacturers.OfType<AbstractData>().ToList()),
                        rawManufacturer.Name,
                        rawManufacturer.Description,
                        this.context.FileStorage.GetIcon(this.iconsDictionary[rawManufacturer.Icon], FileStorage.DefaultIconType.MANUFACTURER),
                        rawManufacturer.Created,
                        rawManufacturer.Updated
                    );
                    this.context.DataStorage.Manufacturers.Add(newManufacturer);
                    this.manufacturersDictionary.Add(rawManufacturer, newManufacturer);
                    this.OnProgressLog(new ProgressLogEventArgs("Importován výrobce " + rawManufacturer.Name));

                }
                else
                {
                    this.manufacturersDictionary.Add(rawManufacturer, manufacturer);
                    this.OnProgressLog(new ProgressLogEventArgs("Výrobce " + rawManufacturer.Name + " je již v systému"));
                }
                this.progress = (ushort)(75 + (ushort)Math.Round((double)idx * step));
                this.OnProgress(new ProgressEventArgs(this.progress, "Importuji výrobce..."));
            }
            this.progress = 80;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji výrobce..."));
        }

        /// <summary>
        /// Import vehicles into system
        /// </summary>
        private void ImportVehicles()
        {
            this.progress = 80;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji vozidla..."));
            double step = 5f / (double)this.loadedVehicles.Count;
            int idx = 0;
            for (; idx < this.loadedVehicles.Count; idx++)
            {
                Vehicle rawVehicle = this.loadedVehicles[idx];
                rawVehicle.PictureChecksum = this.GetPictureChecksum(this.picturesDictionary[rawVehicle.Picture]);
                Data.Vehicle? vehicle = this.GetVehicle(rawVehicle);
                if (vehicle == null)
                {
                    Data.Vehicle newVehicle = new Data.Vehicle(
                        this.GenerateIdentifier(VehiclesController.IdPrefix, this.context.DataStorage.Vehicles.OfType<AbstractData>().ToList()),
                        rawVehicle.Name,
                        rawVehicle.Description,
                        this.context.FileStorage.GetPictureChecked(this.picturesDictionary[rawVehicle.Picture]),
                        this.manufacturersDictionary[rawVehicle.Manufacturer],
                        rawVehicle.Path,
                        this.informationSystemsDictionary[rawVehicle.InformationSystem],
                        rawVehicle.Created,
                        rawVehicle.Updated
                    );
                    this.context.DataStorage.Vehicles.Add(newVehicle);
                    this.OnProgressLog(new ProgressLogEventArgs("Importováno vozidlo " + rawVehicle.Name));

                }
                else
                {
                    this.OnProgressLog(new ProgressLogEventArgs("Vozidlo " + rawVehicle.Name + " je již v systému"));
                }
                this.progress = (ushort)(80 + (ushort)Math.Round((double)idx * step));
                this.OnProgress(new ProgressEventArgs(this.progress, "Importuji vozidla..."));
            }
            this.progress = 85;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji vozidla..."));
        }

        /// <summary>
        /// Import data files into system
        /// </summary>
        private void ImportDataFiles()
        {
            this.progress = 85;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji datové soubory..."));
            double step = 5f / (double)this.loadedDataFiles.Count;
            int idx = 0;
            for (; idx < this.loadedDataFiles.Count; idx++)
            {
                DataFile rawDataFile = this.loadedDataFiles[idx];
                Data.DataFile? dataFile = this.GetDataFile(rawDataFile);
                FileInfo fi = new FileInfo(rawDataFile.OriginalPath);
                if (dataFile == null)
                {
                    Data.DataFile newDataFile = new Data.DataFile(
                        this.GenerateIdentifier(FilesController.IdPrefix, this.context.DataStorage.DataFiles.OfType<AbstractData>().ToList()),
                        this.dataFilesDictionary[rawDataFile.Name],
                        rawDataFile.Description,
                        this.InputPath + Path.DirectorySeparatorChar + "DATAFILES" + Path.DirectorySeparatorChar + fi.Name,
                        this.informationSystemsDictionary[rawDataFile.InformationSystem],
                        this.mapsDictionary[rawDataFile.Map],
                        rawDataFile.Created,
                        rawDataFile.Updated
                    );
                    this.context.DataStorage.DataFiles.Add(newDataFile);
                    this.OnProgressLog(new ProgressLogEventArgs("Importován datový soubor " + fi.Name));

                }
                else
                {
                    this.OnProgressLog(new ProgressLogEventArgs("Datový soubor " + fi.Name + " je již v systému"));
                }
                this.progress = (ushort)(85 + (ushort)Math.Round((double)idx * step));
                this.OnProgress(new ProgressEventArgs(this.progress, "Importuji datové soubory..."));
            }
            this.progress = 90;
            this.OnProgress(new ProgressEventArgs(this.progress, "Importuji datové soubory..."));
        }

        /// <summary>
        /// Finishes import
        /// </summary>
        private void FinishImport()
        {
            this.progress = 90;
            this.OnProgress(new ProgressEventArgs(this.progress, "Dokončuji import..."));
            this.context.DataStorage.Save();
            this.OnProgressLog(new ProgressLogEventArgs("Úložiště dat uloženo"));
            this.progress = 95;
            this.OnProgress(new ProgressEventArgs(this.progress, "Dokončuji import..."));
            Directory.Delete(this.tempDir, true);
            this.OnProgressLog(new ProgressLogEventArgs("Smazán adresář " + this.tempDir));
            this.progress = 100;
            this.OnProgress(new ProgressEventArgs(this.progress, "Hotovo"));
            this.OnProgressLog(new ProgressLogEventArgs("Hotovo"));
            this.OnProcessDone();
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
            reti.Add(new Action(() => { this.ImportDataFilesContent(); }));
            reti.Add(new Action(() => { this.ImportInformationSystems(); }));
            reti.Add(new Action(() => { this.ImportMaps(); }));
            reti.Add(new Action(() => { this.ImportManufacturers(); }));
            reti.Add(new Action(() => { this.ImportVehicles(); }));
            reti.Add(new Action(() => { this.ImportDataFiles(); }));
            reti.Add(new Action(() => { this.FinishImport(); }));
            return reti;
        }
    }
}
