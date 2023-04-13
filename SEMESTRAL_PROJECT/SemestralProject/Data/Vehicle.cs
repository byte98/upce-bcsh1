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
        /// Creates new vehicle
        /// </summary>
        /// <param name="id">Identifier of vehicle</param>
        /// <param name="name">Name of vehicle</param>
        /// <param name="description">Description of vehicle</param>
        /// <param name="picture">Picture of vehicle</param>
        /// <param name="manufacturer">Manufacturer of vehicle</param>
        public Vehicle(string id, string name, string description, Picture picture, Manufacturer manufacturer)
            : base(id, name, description, picture)
        {
            this.Manufacturer = manufacturer; 
        }

        /// <summary>
        /// Creates new vehicle
        /// </summary>
        /// <param name="id">Identifier of vehicle</param>
        /// <param name="name">Name of vehicle</param>
        /// <param name="description">Description of vehicle</param>
        /// <param name="picture">Picture of vehicle</param>
        /// <param name="manufacturer">Manufacturer of vehicle</param>
        /// <param name="created">Date and time of creation of vehicle</param>
        /// <param name="updated">Date and time of last update of vehicle</param>
        public Vehicle(string id, string name, string description, Picture picture, Manufacturer manufacturer, DateTime created, DateTime updated)
            : base(id, name, description, picture, created, updated)
        {
            this.Manufacturer = manufacturer;
        }
    }
}
