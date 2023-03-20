using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class which stores all data (something like a database)
    /// </summary>
    internal class DataStorage
    {
        /// <summary>
        /// Reference to instance of data storage
        /// </summary>
        private static DataStorage? instance;

        /// <summary>
        /// Reference to default instance of data storage
        /// </summary>
        public static DataStorage Instance
        {
            get
            {
                if (DataStorage.instance == null)
                {
                    DataStorage.instance = new DataStorage(Configuration.DataFile);
                }
                return DataStorage.instance;
            }
        }

        /// <summary>
        /// Path to file with data storage
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Creates new data storage
        /// </summary>
        /// <param name="path">Path to file with data</param>
        public DataStorage(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Loads content of storage
        /// </summary>
        public async void Load()
        {
            if (File.Exists(Configuration.DataFile))
            {
                string output = Configuration.TempDir + Path.DirectorySeparatorChar + "_db";
                await Task.Run(() => {
                    ZipFile.ExtractToDirectory(Configuration.DataFile, output);
                }); 
            }
        }

        /// <summary>
        /// Saves content of storage
        /// </summary>
        public async void Save()
        {
            if (File.Exists(Configuration.DataFile))
            {
                File.Delete(Configuration.DataFile);
            }
            await Task.Run(() => {
                ZipFile.CreateFromDirectory(Configuration.TempDir + Path.DirectorySeparatorChar + "_db", Configuration.DataFile);
            });
        }
    }
}
