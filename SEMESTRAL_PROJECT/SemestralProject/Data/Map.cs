using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Picture = SemestralProject.Visual.Picture;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class representing map
    /// </summary>
    internal class Map: AbstractPictureData
    {
        /// <summary>
        /// Creates new map
        /// </summary>
        /// <param name="id">Identifier of map</param>
        /// <param name="name">Name of map</param>
        /// <param name="description">Description of map</param>
        /// <param name="picture">Picture of map</param>
        public Map(string id, string name, string description, Picture picture): base(id, name, description, picture) { }

        /// <summary>
        /// Creates new map
        /// </summary>
        /// <param name="id">Identifier of map</param>
        /// <param name="created">Date and time of creation of map</param>
        /// <param name="updated">Date and time of last update of map</param>
        /// <param name="name">Name of map</param>
        /// <param name="description">Description of map</param>
        /// <param name="picture">Picture of map</param>
        public Map(string id, DateTime created, DateTime updated, string name, string description, Picture picture) : base(id, name, description, picture, created, updated) { }
    }
}
