using SemestralProject.Utils;
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
        /// Enumeration of all available default icons
        /// </summary>
        public enum DefaultIconType
        {
            /// <summary>
            /// Icon of information system
            /// </summary>
            IS
        }

        /// <summary>
        /// Extension of default icons files
        /// </summary>
        private const string DefaultIconExt = ".BMP";

        /// <summary>
        /// Name of file with default icon
        /// </summary>
        private const string DefaultIcon = "__DEFAULT";

        /// <summary>
        /// Name of file with default icon of information system
        /// </summary>
        private const string DefaultISIcon = "__DEFAULT_IS";

        /// <summary>
        /// Reference to instance of storage of files
        /// </summary>
        private static FileStorage? instance = null;

        /// <summary>č
        /// Alphabet used to generating unique names
        /// </summary>
        private const string NameAlphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Minimal length of generated name
        /// </summary>
        private const int NameMin = 8;

        /// <summary>
        /// Maximal length of generated name
        /// </summary>
        private const int NameMax = 64;

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
        /// <returns>Icon added to file storage</returns>
        public Icon AddIcon(string name, string path)
        {
            Icon reti = new Icon(FileStorage.DefaultIcon, Configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultIcon + FileStorage.DefaultIconExt);
            if (File.Exists(path))
            {
                name = name.ToUpper();
                FileInfo fi = new FileInfo(path);
                string destination = Configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + name.ToUpper() + fi.Extension.ToUpper();
                File.Copy(path, destination, true);
                this.Save();
                reti = new Icon(name, destination);
                this.icons.Add(reti);
            }
            return reti;
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
        /// Gets icon stored in storage
        /// </summary>
        /// <param name="type">Type of data for which icon is requested</param>
        /// <returns>Default icon for requested type of data</returns>
        public Icon GetIcon(FileStorage.DefaultIconType type)
        {
            Icon reti = new Icon(FileStorage.DefaultIcon, Configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultIcon + FileStorage.DefaultIconExt);
            switch (type)
            {
                case DefaultIconType.IS: reti = new Icon(FileStorage.DefaultISIcon, Configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultISIcon + FileStorage.DefaultIconExt); break;
            }
            return reti;
        }

        /// <summary>
        /// Gets icon stored in storage
        /// </summary>
        /// <param name="name">Name of icon</param>
        /// <param name="type">Type of data for which icon is requested</param>
        /// <returns>Icon from storage with specified name or default icon for specified type</returns>
        public Icon GetIcon(string name, FileStorage.DefaultIconType type)
        {
            Icon? reti = this.GetIcon(name);
            if (reti == null)
            {
                reti = this.GetIcon(type);
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
        public void Load()
        {
            string output = Configuration.TempDir + Path.DirectorySeparatorChar + "_FS";
            Configuration.CreateTemp();
            if (Directory.Exists(output))
            {
                Directory.Delete(output, true);
            }
            if (File.Exists(this.path))
            {
                ZipFile.ExtractToDirectory(this.path, output);
            }
            else
            {
                Directory.CreateDirectory(output);
                string iconsFolder = output + Path.DirectorySeparatorChar + "[ICONS]";
                Directory.CreateDirectory(iconsFolder);
            }
        }

        /// <summary>
        /// Loads icons (this needs to be called after <see cref="Load"/> is called!)
        /// </summary>
        public void LoadIcons()
        {
            string output = Configuration.TempDir + Path.DirectorySeparatorChar + "_FS";
            this.icons.Clear();
            foreach (string file in Directory.GetFiles(output + Path.DirectorySeparatorChar + "[ICONS]"))
            {
                FileInfo fi = new FileInfo(file);
                this.icons.Add(new Icon(Path.GetFileNameWithoutExtension(fi.FullName), file));
            }
        }

        /// <summary>
        /// Saves content of storage
        /// </summary>
        private void Save()
        {
            if (File.Exists(this.path))
            {
                File.Delete(this.path);
            }
            ZipFile.CreateFromDirectory(Configuration.TempDir + Path.DirectorySeparatorChar + "_FS", this.path);
        }

        /// <summary>
        /// Generates unique icon name
        /// </summary>
        /// <returns>Unique name for icon</returns>
        public string GenerateUniqueIcon()
        {
            Random random = new Random();
            int length = random.Next(FileStorage.NameMin, FileStorage.NameMax + 1);
            string reti;
            do
            {
                reti = StringUtils.Random(FileStorage.NameAlphabet, length);
            }
            while(this.GetIcon(reti) != null);
            return reti;
        }

    }
}
