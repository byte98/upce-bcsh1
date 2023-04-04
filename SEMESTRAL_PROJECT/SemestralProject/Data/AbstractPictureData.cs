using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class representing data with picture
    /// </summary>
    internal class AbstractPictureData: AbstractData
    {
        /// <summary>
        /// Picture of data
        /// </summary>
        public Picture Picture { get; private set; }

        /// <summary>
        /// Creates new data with picture
        /// </summary>
        /// <param name="id">Identifier of data</param>
        /// <param name="name">Name of data</param>
        /// <param name="description">Description of data</param>
        /// <param name="picture">Picture of data</param>
        public AbstractPictureData(string id, string name, string description, Picture picture) : this(id, name, description, picture, DateTime.Now, DateTime.Now) { }

        /// <summary>
        /// Creates new data with picture
        /// </summary>
        /// <param name="id">Identifier of data</param>
        /// <param name="name">Name of data</param>
        /// <param name="description">Description of data</param>
        /// <param name="picture">Picture of data</param>
        /// <param name="created">Date and time of creation of data</param>
        /// <param name="updated">Date and time of last update of data</param>
        public AbstractPictureData(string id, string name, string description, Picture picture, DateTime created, DateTime updated): base(id, name, description, created, updated)
        {
            this.Picture = picture;
        }

        /// <summary>
        /// Edits data with picture
        /// </summary>
        /// <param name="name">New name of data</param>
        /// <param name="description">New description of data</param>
        /// <param name="picture">New picture of data</param>
        public void Edit(string name, string description, Picture picture)
        {
            base.Edit(name, description);
            this.Picture = picture;
        }
    }
}
