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
    internal class DataFile: AbstractData
    {
        /// <summary>
        /// Path to physical location of file
        /// </summary>
        public string Path { get; private set; }

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
        /// <param name="name">Name of file</param>
        /// <param name="description">Description of file</param>
        /// <param name="path">Path to physical file</param>
        /// <param name="informationSystem">Information system which format of data file holds</param>
        /// <param name="map">Map which data file holds</param>
        public DataFile(
            string id,
            string name,
            string description,
            string path,
            InformationSystem informationSystem,
            Map map
        ) : base(id, name, description)
        {
            this.Path = path;
            this.InformationSystem = informationSystem;
            this.Map = map;
        }
    }
}
