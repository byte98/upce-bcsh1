﻿using SemestralProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
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
            /// Class which holds names of XML elements used to store information systems
            /// </summary>
            internal static class InformationSystem
            {
                /// <summary>
                /// Root element holding all information systems
                /// </summary>
                public const string _Root = "INFORMATION_SYSTEMS";

                /// <summary>
                /// XML element holding all information about information system
                /// </summary>
                public const string _Element = "INFORMATION_SYSTEM";

                /// <summary>
                /// XML element holding identifier of information system
                /// </summary>
                public const string Id = "ID";

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

            /// <summary>
            /// Class which holds definitions of XML elements for storing maps
            /// </summary>
            internal static class Map
            {
                /// <summary>
                /// Root element holding all maps
                /// </summary>
                public const string _Root = "MAPS";

                /// <summary>
                /// Root element holding all information about map
                /// </summary>
                public const string _Element = "MAP";

                /// <summary>
                /// XML element holding identifier of map
                /// </summary>
                public const string Id = "ID";

                /// <summary>
                /// XML element holding name of map
                /// </summary>
                public const string Name = "NAME";

                /// <summary>
                /// XML element holding desription of map
                /// </summary>
                public const string Description = "DESCRIPITON";

                /// <summary>
                /// XML element holding picture of map
                /// </summary>
                public const string Picture = "PICTURE";

                /// <summary>
                /// XML element holding date and time of creation of map
                /// </summary>
                public const string Created = "CREATED";

                /// <summary>
                /// XML element holding date and time of last update of map
                /// </summary>
                public const string Updated = "UPDATED";
            }

            /// <summary>
            /// Class which holds definitions of XML elements for storing manufacturers
            /// </summary>
            internal static class Manufacturer
            {
                /// <summary>
                /// Root element holding all manufacturers
                /// </summary>
                public const string _Root = "MANUFACTURERS";

                /// <summary>
                /// Root element holding all information about manufacturer
                /// </summary>
                public const string _Element = "MANUFACTURER";

                /// <summary>
                /// XML element holding identifier of manufacturer
                /// </summary>
                public const string Id = "ID";

                /// <summary>
                /// XML element holding name of manufacturer
                /// </summary>
                public const string Name = "NAME";

                /// <summary>
                /// XML element holding desription of manufacturer
                /// </summary>
                public const string Description = "DESCRIPITON";

                /// <summary>
                /// XML element holding icon of manufacturer
                /// </summary>
                public const string Icon = "ICON";

                /// <summary>
                /// XML element holding date and time of creation of manufacturer
                /// </summary>
                public const string Created = "CREATED";

                /// <summary>
                /// XML element holding date and time of last update of manufacturer
                /// </summary>
                public const string Updated = "UPDATED";
            }

            /// <summary>
            /// Class which holds definitions of XML elements for storing vehicles
            /// </summary>
            internal static class Vehicle
            {
                /// <summary>
                /// Root element holding all vehicles
                /// </summary>
                public const string _Root = "VEHICLES";

                /// <summary>
                /// Root element holding all information about vehicles
                /// </summary>
                public const string _Element = "VEHICLE";

                /// <summary>
                /// XML element holding identifier of vehicle
                /// </summary>
                public const string Id = "ID";

                /// <summary>
                /// XML element holding name of vehicle
                /// </summary>
                public const string Name = "NAME";

                /// <summary>
                /// XML element holding desription of vehicle
                /// </summary>
                public const string Description = "DESCRIPITON";

                /// <summary>
                /// XML element holding picture of vehicle
                /// </summary>
                public const string Picture = "PICTURE";

                /// <summary>
                /// XML element holding identifier of vehicles manufacturer
                /// </summary>
                public const string Manufacturer = "MANUFACTURER";

                /// <summary>
                /// XML element holding path to directory with vehicle
                /// </summary>
                public const string Path = "PATH";

                /// <summary>
                /// XML element holding date and time of creation of vehicle
                /// </summary>
                public const string Created = "CREATED";

                /// <summary>
                /// XML element holding date and time of last update of vehicle
                /// </summary>
                public const string Updated = "UPDATED";
            }


        }
        #endregion

        /// <summary>
        /// File containing something like a database of information systems
        /// </summary>
        private const string ISFile = "INFORMATION_SYSTEMS.XML";

        /// <summary>
        /// File containing something like a database of maps
        /// </summary>
        private const string MapFile = "MAPS.XML";

        /// <summary>
        /// File containing kind of a database with vehicles
        /// </summary>
        private const string ManufacturerFile = "MANUFACTURERS.XML";

        /// <summary>
        /// File with database like structure with vehicles
        /// </summary>
        private const string VehicleFile = "VEHICLES.XML";

        /// <summary>
        /// Path to file with data storage
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Reference to storage of files
        /// </summary>
        private readonly FileStorage fileStorage;

        /// <summary>
        /// Reference to configuration of system
        /// </summary>
        private readonly Configuration configuration;

        /// <summary>
        /// List of all available information systems
        /// </summary>
        public List<InformationSystem> InformationSystems { get; set; }

        /// <summary>
        /// List of all available maps
        /// </summary>
        public List<Map> Maps { get; set; }

        /// <summary>
        /// List of all available vehicles
        /// </summary>
        public List<Manufacturer> Manufacturers { get; set; }
        
        /// <summary>
        /// List of all available vehicles
        /// </summary>
        public List<Vehicle> Vehicles { get; set; }

        /// <summary>
        /// Creates new data storage
        /// </summary>
        /// <param name="path">Path to file with data</param>
        /// <param name="fileStorage">Storage of data</param>
        /// <param name="configuration">Configuration of application</param>
        public DataStorage(string path, FileStorage fileStorage, Configuration configuration)
        {
            this.configuration = configuration;
            this.path = path;
            this.InformationSystems = new List<InformationSystem>();
            this.Maps = new List<Map>();
            this.Manufacturers = new List<Manufacturer>();
            this.Vehicles = new List<Vehicle>();
            this.fileStorage = fileStorage;
        }

        /// <summary>
        /// Loads content of storage
        /// </summary>
        public void Load()
        {
            string output = this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB";
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
            string file = this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.ISFile;
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
                                    this.InformationSystems.Add(new InformationSystem(
                                        idenElement.InnerText,
                                        nameElement.InnerText,
                                        descElement.InnerText,
                                        this.fileStorage.GetIcon(iconElement.InnerText, FileStorage.DefaultIconType.IS),
                                        DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                        DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null)
                                    ));
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Loads maps from storage
        /// (this needs to be called AFTER <see cref="Load"/>!)
        /// </summary>
        public void LoadMaps()
        {
            this.Maps = new List<Map>();
            string file = this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.MapFile;
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
                                    this.Maps.Add(new Map(
                                            idenElem.InnerText,
                                            DateTime.ParseExact(credElem.InnerText, DataStorage.XML._Date, null),
                                            DateTime.ParseExact(updtElem.InnerText, DataStorage.XML._Date, null),
                                            nameElem.InnerText,
                                            descElem.InnerText,
                                            this.fileStorage.GetPictureChecked(pictElem.InnerText)
                                        ));
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Loads manufacturers from storage
        /// (this needs to be called AFTER <see cref="Load"/>!)
        /// </summary>
        public void LoadManufacturers()
        {
            this.Manufacturers = new List<Manufacturer>();
            string file = this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.ManufacturerFile;
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
                                    this.Manufacturers.Add(new Manufacturer(
                                        idenElement.InnerText,
                                        nameElement.InnerText,
                                        descElement.InnerText,
                                        this.fileStorage.GetIcon(iconElement.InnerText, FileStorage.DefaultIconType.IS),
                                        DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                        DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null)
                                    ));
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Loads vehicles from storage
        /// (this needs to be called AFTER <see cref="Load"/>!)
        /// </summary>
        public void LoadVehicles()
        {
            this.Vehicles = new List<Vehicle>();
            string file = this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.VehicleFile;
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
                            if (
                                    idenList != null && idenList.Count >= 1 &&
                                    nameList != null && nameList.Count >= 1 &&
                                    pictList != null && pictList.Count >= 1 &&
                                    descList != null && descList.Count >= 1 &&
                                    credList != null && credList.Count >= 1 &&
                                    updtList != null && updtList.Count >= 1 &&
                                    manuList != null && manuList.Count >= 1 &&
                                    pathList != null && pathList.Count >= 1
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
                                if (
                                        idenElement != null &&
                                        nameElement != null &&
                                        pictElement != null &&
                                        descElement != null &&
                                        credElement != null &&
                                        updtElement != null &&
                                        manuElement != null &&
                                        pathElement != null
                                   )
                                {
                                    Manufacturer? manufacturer = this.GetManufacturerById(manuElement.InnerText);
                                    if (manufacturer != null )
                                    {
                                        this.Vehicles.Add(new Vehicle(
                                            idenElement.InnerText,
                                            nameElement.InnerText,
                                            descElement.InnerText,
                                            this.fileStorage.GetPictureChecked(pictElement.InnerText),
                                            manufacturer,
                                            pathElement.InnerText,
                                            DateTime.ParseExact(credElement.InnerText, DataStorage.XML._Date, null),
                                            DateTime.ParseExact(updtElement.InnerText, DataStorage.XML._Date, null)
                                        ));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gets manufacturer by its identifier
        /// </summary>
        /// <param name="id">Searched identifier of manufacturer</param>
        /// <returns>Manufactuer with searched identifier or <c>NULL</c>, if there is no such manufacturer</returns>
        public Manufacturer? GetManufacturerById(string id)
        {
            Manufacturer? reti = null;
            foreach(Manufacturer manufacturer in this.Manufacturers)
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
        /// Saves information systems into XML
        /// </summary>
        private void SaveInformationSystems()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration(DataStorage.XML._Version, DataStorage.XML._Charset, null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement iss = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem._Root, string.Empty);
            doc.AppendChild(iss);
            foreach (InformationSystem informationSystem in this.InformationSystems)
            {
                XmlElement infS = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem._Element, string.Empty);
                XmlElement id = doc.CreateElement(string.Empty, DataStorage.XML.InformationSystem.Id, string.Empty);
                id.InnerText = informationSystem.Id;
                infS.AppendChild(id);
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
            doc.Save(this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.ISFile);
        }

        /// <summary>
        /// Saves maps into XML
        /// </summary>
        private void SaveMaps()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration(DataStorage.XML._Version, DataStorage.XML._Charset, null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement maps = doc.CreateElement(string.Empty, DataStorage.XML.Map._Root, string.Empty);
            doc.AppendChild(maps);
            foreach(Map map in this.Maps)
            {
                XmlElement mapElem = doc.CreateElement(string.Empty, DataStorage.XML.Map._Element, string.Empty);
                XmlElement id = doc.CreateElement(string.Empty, DataStorage.XML.Map.Id, string.Empty);
                id.InnerText = map.Id;
                mapElem.AppendChild(id);
                XmlElement name = doc.CreateElement(string.Empty, DataStorage.XML.Map.Name, string.Empty);
                name.InnerText = map.Name;
                mapElem.AppendChild(name);
                XmlElement description = doc.CreateElement(string.Empty, DataStorage.XML.Map.Description, string.Empty);
                description.InnerText = map.Description;
                mapElem.AppendChild(description);
                XmlElement created = doc.CreateElement(string.Empty, DataStorage.XML.Map.Created, string.Empty);
                created.InnerText = map.Created.ToString(DataStorage.XML._Date);
                mapElem.AppendChild(created);
                XmlElement updated = doc.CreateElement(string.Empty, DataStorage.XML.Map.Updated, string.Empty);
                updated.InnerText = map.Updated.ToString(DataStorage.XML._Date);
                mapElem.AppendChild(updated);
                XmlElement picture = doc.CreateElement(string.Empty, DataStorage.XML.Map.Picture, string.Empty);
                picture.InnerText = map.Picture.Name;
                mapElem.AppendChild(picture);
                maps.AppendChild(mapElem);
            }
            doc.Save(this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.MapFile);
        }

        /// <summary>
        /// Saves vehicles into XML
        /// </summary>
        private void SaveManufacturers()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration(DataStorage.XML._Version, DataStorage.XML._Charset, null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement manufacturers = doc.CreateElement(string.Empty, DataStorage.XML.Manufacturer._Root, null);
            doc.AppendChild(manufacturers);
            foreach(Manufacturer manufacturer in this.Manufacturers)
            {
                XmlElement manElem = doc.CreateElement(string.Empty, DataStorage.XML.Manufacturer._Element, string.Empty);
                XmlElement id = doc.CreateElement(string.Empty, DataStorage.XML.Manufacturer.Id, string.Empty);
                id.InnerText = manufacturer.Id;
                manElem.AppendChild(id);
                XmlElement created = doc.CreateElement(string.Empty, DataStorage.XML.Manufacturer.Created, string.Empty);
                created.InnerText = manufacturer.Created.ToString(DataStorage.XML._Date);
                manElem.AppendChild(created);
                XmlElement updated = doc.CreateElement(string.Empty, DataStorage.XML.Manufacturer.Updated, string.Empty);
                updated.InnerText = manufacturer.Updated.ToString(DataStorage.XML._Date);
                manElem.AppendChild(updated);
                XmlElement icon = doc.CreateElement(string.Empty, DataStorage.XML.Manufacturer.Icon, string.Empty);
                icon.InnerText = manufacturer.Icon.Name;
                manElem.AppendChild(icon);
                XmlElement name = doc.CreateElement(string.Empty, DataStorage.XML.Manufacturer.Name, string.Empty);
                name.InnerText = manufacturer.Name;
                manElem.AppendChild(name);
                XmlElement desc = doc.CreateElement(string.Empty, DataStorage.XML.Manufacturer.Description, string.Empty);
                desc.InnerText = manufacturer.Description;
                manElem.AppendChild(desc);
                manufacturers.AppendChild(manElem);
            }
            doc.Save(this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.ManufacturerFile);
        }

        /// <summary>
        /// Saves vehicles into XML
        /// </summary>
        private void SaveVehicles()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration(DataStorage.XML._Version, DataStorage.XML._Charset, null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement vehicles = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle._Root, null);
            doc.AppendChild(vehicles);
            foreach (Vehicle vehicle in this.Vehicles)
            {
                XmlElement vehicleElem = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle._Element, string.Empty);
                XmlElement id = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle.Id, string.Empty);
                id.InnerText = vehicle.Id;
                vehicleElem.AppendChild(id);
                XmlElement created = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle.Created, string.Empty);
                created.InnerText = vehicle.Created.ToString(DataStorage.XML._Date);
                vehicleElem.AppendChild(created);
                XmlElement updated = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle.Updated, string.Empty);
                updated.InnerText = vehicle.Updated.ToString(DataStorage.XML._Date);
                vehicleElem.AppendChild(updated);
                XmlElement picture = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle.Picture, string.Empty);
                picture.InnerText = vehicle.Picture.Name;
                vehicleElem.AppendChild(picture);
                XmlElement name = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle.Name, string.Empty);
                name.InnerText = vehicle.Name;
                vehicleElem.AppendChild(name);
                XmlElement desc = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle.Description, string.Empty);
                desc.InnerText = vehicle.Description;
                vehicleElem.AppendChild(desc);
                XmlElement man = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle.Manufacturer, string.Empty);
                man.InnerText = vehicle.Manufacturer.Id;
                vehicleElem.AppendChild(man);
                XmlElement path = doc.CreateElement(string.Empty, DataStorage.XML.Vehicle.Path, string.Empty);
                path.InnerText = vehicle.Path;
                vehicleElem.AppendChild(path);
                vehicles.AppendChild(vehicleElem);
            }
            doc.Save(this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.VehicleFile);
        }

        /// <summary>
        /// Saves content of storage
        /// </summary>
        public void Save()
        {
            if (File.Exists(this.path))
            {
                File.Delete(this.path);
            }
            this.SaveInformationSystems();
            this.SaveMaps();
            this.SaveManufacturers();
            this.SaveVehicles();
            ZipFile.CreateFromDirectory(this.configuration.TempDir + Path.DirectorySeparatorChar + "_DB", this.path);
        }
    }
}
