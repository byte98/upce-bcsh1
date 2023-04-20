using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class which represents one vehicle (or more likely one vehicle type)
    /// </summary>
    internal class Vehicle: AbstractPictureData
    {
        /// <summary>
        /// Manufacturer of vehicle
        /// </summary>
        public Manufacturer Manufacturer { get; private set; }

        /// <summary>
        /// Information system installed on vehicle
        /// </summary>
        public InformationSystem InformationSystem { get; private set; }

        /// <summary>
        /// Path to directory with vehicle
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// Creates new vehicle
        /// </summary>
        /// <param name="id">Identifier of vehicle</param>
        /// <param name="name">Name of vehicle</param>
        /// <param name="description">Description of vehicle</param>
        /// <param name="picture">Picture of vehicle</param>
        /// <param name="manufacturer">Manufacturer of vehicle</param>
        /// <param name="path">Path to directory with vehicle</param>
        /// <param name="informationSystem">Information system installed on vehicle</param>
        public Vehicle(string id, string name, string description, Picture picture, Manufacturer manufacturer, string path, InformationSystem informationSystem)
            : base(id, name, description, picture)
        {
            this.Manufacturer = manufacturer;
            this.Path = path;
            this.InformationSystem = informationSystem;
        }

        /// <summary>
        /// Creates new vehicle
        /// </summary>
        /// <param name="id">Identifier of vehicle</param>
        /// <param name="name">Name of vehicle</param>
        /// <param name="description">Description of vehicle</param>
        /// <param name="picture">Picture of vehicle</param>
        /// <param name="manufacturer">Manufacturer of vehicle</param>
        /// <param name="path">Path to directory with vehicle</param>
        /// <param name="informationSystem">Information system installed on vehicle</param>
        /// <param name="created">Date and time of creation of vehicle</param>
        /// <param name="updated">Date and time of last update of vehicle</param>
        public Vehicle(string id, string name, string description, Picture picture, Manufacturer manufacturer, string path, InformationSystem informationSystem, DateTime created, DateTime updated)
            : base(id, name, description, picture, created, updated)
        {
            this.Manufacturer = manufacturer;
            this.Path = path;
            this.InformationSystem = informationSystem;
        }

        /// <summary>
        /// Edits vehicle
        /// </summary>
        /// <param name="name">New name of vehicle</param>
        /// <param name="description">New description of vehicle</param>
        /// <param name="picture">New picture of vehicle</param>
        /// <param name="manufacturer">New manufacturer of vehicle</param>
        /// <param name="path">New path to directory with vehicle</param>
        /// <param name="informationSystem">New information system installed on vehicle</param>
        public void Edit(string name, string description, Picture picture, Manufacturer manufacturer, string path, InformationSystem informationSystem)
        {
            base.Edit(name, description, picture);
            this.Manufacturer = manufacturer;
            this.Path = path;
            this.InformationSystem = informationSystem;
        }
    }
}
