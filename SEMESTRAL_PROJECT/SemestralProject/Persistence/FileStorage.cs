using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class representing storage of program files
    /// </summary>
    internal class FileStorage
    {
        /// <summary>
        /// Reference to instance of storage of files
        /// </summary>
        private static FileStorage? instance = null;

        /// <summary>
        /// Dictionary with all stored icons
        /// </summary>
        private readonly List<Icon> icons;

        /// <summary>
        /// Path to file storage
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Default instance of storage of files
        /// </summary>
        public static FileStorage Instance
        {
            get
            {
                if (FileStorage.instance == null)
                {
                    FileStorage.instance = new FileStorage(Configuration.StorageFile);
                }
                return FileStorage.instance;
            }
        }

        /// <summary>
        /// Creates new storage of program files
        /// </summary>
        /// <param name="path">Path to file where files will be stored</param>
        public FileStorage(string path)
        {
            this.icons = new List<Icon>();
            this.path = path;
        }

        /// <summary>
        /// Adds icon to file storage
        /// </summary>
        /// <param name="name">Name of icon</param>
        /// <param name="path">Path to file containing icon</param>
        public void AddIcon(string name, string path)
        {
            if (File.Exists(path))
            {
                FileInfo fi = new FileInfo(path);
                string destination = Configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + name + fi.Extension;
                File.Copy(path, destination, true);
                this.Save();
                this.icons.Add(new Icon(name, destination));
            }
        }

        /// <summary>
        /// Gets icon stored in storage
        /// </summary>
        /// <param name="name">Name of icon</param>
        /// <returns>Icon stored in storage or NULL if there is no such icon</returns>
        public Icon? GetIcon(string name)
        {
            Icon? reti = null;
            foreach(Icon icon in this.icons)
            {
                if (icon.Name == name)
                {
                    reti = icon;
                    break;
                }
            }
            return reti;
        }
        
        /// <summary>
        /// Gets all available icons
        /// </summary>
        /// <returns>All icons stored in file storage</returns>
        public Icon[] GetAllIcons()
        {
            return this.icons.ToArray();
        }

        /// <summary>
        /// Loads content of storage
        /// </summary>
        public async void Load()
        {
            if (File.Exists(Configuration.StorageFile))
            {
                string output = Configuration.TempDir + Path.DirectorySeparatorChar + "_FS";
                Task task = new Task(async () => {
                    Configuration.CreateTemp();
                    await Task.Run(() => {
                        ZipFile.ExtractToDirectory(Configuration.StorageFile, output);
                    }); 
                    this.icons.Clear();

                    // Load icons
                    foreach (string file in Directory.GetFiles(output + Path.DirectorySeparatorChar + "[ICONS]"))
                    {
                        FileInfo fi = new FileInfo(file);
                        this.icons.Add(new Icon(fi.Name, file));
                    }
                });
                await task;
            }
        }

        /// <summary>
        /// Saves content of storage
        /// </summary>
        private void Save()
        {
            if (File.Exists(Configuration.StorageFile))
            {
                File.Delete(Configuration.StorageFile);
            }
            ZipFile.CreateFromDirectory(Configuration.TempDir + Path.DirectorySeparatorChar + "_FS", Configuration.StorageFile);
        }
    }
}
