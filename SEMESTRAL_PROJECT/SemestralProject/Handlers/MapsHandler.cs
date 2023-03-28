using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Persistence;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Handlers
{
    /// <summary>
    /// Class which can manipulate with maps
    /// </summary>
    internal class MapsHandler
    {
        /// <summary>
        /// Reference to storage of data (where maps will be saved)
        /// </summary>
        private readonly DataStorage dataStorage;

        /// <summary>
        /// Reference to storage of files
        /// </summary>
        private readonly FileStorage fileStorage;

        /// <summary>
        /// Reference to default instance of handler of maps
        /// </summary>
        private static MapsHandler? instance;

        /// <summary>
        /// Alphabet containing valid characters for generating identifiers
        /// </summary>
        private const string IDAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Minimal length of identifier
        /// </summary>
        private const int IDMinLength = 8;

        /// <summary>
        /// Maximal length of identifier
        /// </summary>
        private const int IDMaxLength = 16;

        /// <summary>
        /// Default instance of handler of maps
        /// </summary>
        public static MapsHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MapsHandler(DataStorage.Instance, FileStorage.Instance);
                }
                return instance;
            }
        }

        /// <summary>
        /// Creates new maps handler
        /// </summary>
        /// <param name="dataStorage">Storage of data</param>
        /// <param name="fileStorage">Storage of files</param>
        public MapsHandler(DataStorage dataStorage, FileStorage fileStorage)
        {
            this.dataStorage = dataStorage;
            this.fileStorage = fileStorage;
        }

        /// <summary>
        /// Gets map by its identifier
        /// </summary>
        /// <param name="id">Identifier of map</param>
        /// <returns>Map defined by its identifier or <c>null</c>, if there is no such map</returns>
        public Map? GetMapById(string id)
        {
            Map? reti = null;
            foreach(Map map in this.dataStorage.Maps)
            {
                if (map.ID == id)
                {
                    reti = map;
                    break;
                }
            }
            return reti;
        }
        
        /// <summary>
        /// Creates new map
        /// </summary>
        /// <param name="name">Name of new map</param>
        /// <param name="description">Description of new map</param>
        /// <param name="picture">Picture of new map</param>
        /// <returns>Newly created map</returns>
        public Map? CreateMap(string name, string description, Picture picture)
        {
            Map? reti = null;
            FormWait wait = new FormWait(() =>
            { 
                reti = new Map(this.GenerateIdentifier(), name, description, picture);
                this.dataStorage.Maps.Add(reti);
                this.dataStorage.Save();
            });
            wait.ShowDialog();
            return reti;
        }

        /// <summary>
        /// Generates identifier of map
        /// </summary>
        /// <returns>Pseudo-random unique identifier of map</returns>
        private string GenerateIdentifier()
        {
            string reti = string.Empty;
            do
            {
                reti = "MAP_" + StringUtils.Random(MapsHandler.IDAlphabet, MapsHandler.IDMinLength, MapsHandler.IDMaxLength);
            }
            while(this.GetMapById(reti) != null);
            return reti;
        }

        /// <summary>
        /// Updates map
        /// </summary>
        /// <param name="map">Map which will be updated</param>
        /// <param name="name">New name of map</param>
        /// <param name="description">New descripiton of map</param>
        /// <param name="picture">New picture of map</param>
        public void UpdateMap(Map map, string name, string description, Picture picture)
        {
            FormWait wait = new FormWait(() =>
            {
                map.Edit(name, description, picture);
                this.dataStorage.Save();
            });
            wait.ShowDialog();
        }

        /// <summary>
        /// Removes map from system
        /// </summary>
        /// <param name="map">Map which will be removed</param>
        public void RemoveMap(Map map)
        {
            FormWait wait = new FormWait(() =>
            {
                if (this.dataStorage.Maps.Contains(map))
                {
                    this.dataStorage.Maps.Remove(map);
                    this.dataStorage.Save();
                }
            });
            wait.ShowDialog();
        }

        /// <summary>
        /// Deletes every single map
        /// </summary>
        public void DeleteMaps()
        {
            FormWait wait = new FormWait(() => 
            {
                this.dataStorage.Maps = new List<Map>();
                this.dataStorage.Save();
            });
        }
    }
}