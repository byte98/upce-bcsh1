using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Data
{
    /// <summary>
    /// Class representing one data file
    /// </summary>
    internal class DataFile : AbstractData
    {
        /// <summary>
        /// Original path to file
        /// </summary>
        public string OriginalPath { get; private set; }

        /// <summary>
        /// Information system which format of data file holds
        /// </summary>
        public InformationSystem InformationSystem { get; private set; }

        /// <summary>
        /// Map which data file holds
        /// </summary>
        public Map Map { get; private set; }

        /// <summary>
        /// Creates new data file
        /// </summary>
        /// <param name="id">Identifier of file</param>
        /// <param name="name">Name of physical file</param>
        /// <param name="description">Description of file</param>
        /// <param name="originalPath">Original path to file</param>
        /// <param name="informationSystem">Information system which format of data file holds</param>
        /// <param name="map">Map which data file holds</param>
        public DataFile(
            string id,
            string name,
            string description,
            string originalPath,
            InformationSystem informationSystem,
            Map map
        ) : base(id, name, description)
        {
            this.OriginalPath = originalPath;
            this.InformationSystem = informationSystem;
            this.Map = map;
        }

        /// <summary>
        /// Creates new data file
        /// </summary>
        /// <param name="id">Identifier of file</param>
        /// <param name="name">Name of physical file</param>
        /// <param name="description">Description of file</param>
        /// <param name="originalPath">Original path to file</param>
        /// <param name="informationSystem">Information system which format of data file holds</param>
        /// <param name="map">Map which data file holds</param>
        /// <param name="created">Date and time of data file creation</param>
        /// <param name="updated">Date and time of last data file update</param>
        public DataFile(
            string id,
            string name,
            string description,
            string originalPath,
            InformationSystem informationSystem,
            Map map,
            DateTime created,
            DateTime updated
        ): base(id, name, description, created, updated)
        {
            this.OriginalPath = originalPath;
            this.InformationSystem = informationSystem;
            this.Map = map;
        }

        /// <summary>
        /// Edits data file
        /// </summary>
        /// <param name="name">New name of physical file of data file</param>
        /// <param name="description">New description of data file</param>
        /// <param name="path">New original path to data file</param>
        /// <param name="informationSystem">New information system of data file</param>
        /// <param name="map">New map of data file</param>
        public void Edit(string name, string description, string path, InformationSystem informationSystem, Map map)
        {
            base.Edit(name, description);
            this.OriginalPath = path;
            this.InformationSystem = informationSystem;
            this.Map = map;
        }
    }
}
