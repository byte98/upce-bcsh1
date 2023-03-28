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
        /// Picture of map
        /// </summary>
        public Picture Picture { get; private set; }
        
        /// <summary>
        /// Identifier of map
        /// </summary>
        public string ID { get; init; }

        /// <summary>
        /// Creates new map
        /// </summary>
        /// <param name="id">Identifier of map</param>
        /// <param name="name">Name of map</param>
        /// <param name="description">Description of map</param>
        /// <param name="image">Image of map</param>
        public Map(string id, string name, string description, Picture image): this(id, DateTime.Now, DateTime.Now, name, description, image) { }

        /// <summary>
        /// Creates new map
        /// </summary>
        /// <param name="id">Identifier of map</param>
        /// <param name="created">Date and time of creation of map</param>
        /// <param name="updated">Date and time of last update of map</param>
        /// <param name="name">Name of map</param>
        /// <param name="description">Description of map</param>
        /// <param name="image">Image of map</param>
        public Map(string id, DateTime created, DateTime updated, string name, string description, Picture image)
        {
            this.ID = id;
            this.Created = created;
            this.Updated = updated;
            this.Name = name;
            this.Description = description;
            this.Picture = image;
        }

        /// <summary>
        /// Edits map
        /// </summary>
        /// <param name="name">New name of map</param>
        /// <param name="description">New description of map</param>
        /// <param name="picture">New picture of map</param>
        public void Edit(string name, string description, Picture picture)
        {
            this.Name = name;
            this.Description = description;
            this.Picture = picture;
            this.Updated = DateTime.Now;
        }
    }
}
