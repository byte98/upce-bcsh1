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
    internal class Map
    {
        /// <summary>
        /// Date and time of creation of map
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// Date and time of last update of map
        /// </summary>
        public DateTime Updated { get; private set;}

        /// <summary>
        /// Name of map
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Description of map
        /// </summary>
        public string Description { get; private set; }


        /// <summary>
        /// Image of map
        /// </summary>
        public Picture Image { get; private set; }

        /// <summary>
        /// Creates new map
        /// </summary>
        /// <param name="name">Name of map</param>
        /// <param name="description">Description of map</param>
        /// <param name="image">Image of map</param>
        public Map(string name, string description, Picture image): this(DateTime.Now, DateTime.Now, name, description, image) { }

        /// <summary>
        /// Creates new map
        /// </summary>
        /// <param name="created">Date and time of creation of map</param>
        /// <param name="updated">Date and time of last update of map</param>
        /// <param name="name">Name of map</param>
        /// <param name="description">Description of map</param>
        /// <param name="image">Image of map</param>
        public Map(DateTime created, DateTime updated, string name, string description, Picture image)
        {
            this.Created = created;
            this.Updated = updated;
            this.Name = name;
            this.Description = description;
            this.Image = image;
        }
    }
}
