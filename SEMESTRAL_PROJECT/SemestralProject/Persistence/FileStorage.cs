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
            IS,

            /// <summary>
            /// Icon of map
            /// </summary>
            MAP,

            /// <summary>
            /// Icon of manufacturer
            /// </summary>
            MANUFACTURER,

            /// <summary>
            /// Icon of file
            /// </summary>
            FILE
        }

        /// <summary>
        /// Extension of default files
        /// </summary>
        private const string DefaultExt = ".BMP";

        /// <summary>
        /// Name of file with default icon
        /// </summary>
        private const string DefaultIcon = "__DEFAULT";

        /// <summary>
        /// Name of file with default icon of information system
        /// </summary>
        private const string DefaultISIcon = "__DEFAULT_IS";

        /// <summary>
        /// Name of file with default icon of map
        /// </summary>
        private const string DefaultMapIcon = "__DEFAULT_MAP";

        /// <summary>
        /// Name of file with default icon of manufacturer
        /// </summary>
        private const string DefaultManufacturerIcon = "__DEFAULT_MANUFACTURER";

        /// <summary>
        /// Name of file with default icon of file
        /// </summary>
        private const string DefaultFileIcon = "__DEFAULT_FILE";

        /// <summary>
        /// Name of file with default picture
        /// </summary>
        private const string DefaultPicture = "__DEFAULT";

        /// <summary>
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
        /// List with all stored icons
        /// </summary>
        private readonly List<Icon> icons;

        /// <summary>
        /// List with all stored pictures
        /// </summary>
        private readonly List<Picture> pictures;

        /// <summary>
        /// List with all available data files
        /// </summary>
        private readonly List<string> dataFiles;

        /// <summary>
        /// Path to file storage
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Reference to configuration of application
        /// </summary>
        private readonly Configuration configuration;

        /// <summary>
        /// Creates new storage of program files
        /// </summary>
        /// <param name="path">Path to file where files will be stored</param>
        /// <param name="configuration">Reference to configuration of system</param>
        public FileStorage(string path, Configuration configuration)
        {
            this.configuration = configuration;
            this.icons = new List<Icon>();
            this.pictures = new List<Picture>();
            this.dataFiles = new List<string>();
            this.path = path;
        }

        #region File manipulation
        /// <summary>
        /// Loads content of storage
        /// </summary>
        public void Load()
        {
            string output = this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS";
            this.configuration.CreateTemp();
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
                string picturesFolder = output + Path.DirectorySeparatorChar + "[PICTURES]";
                Directory.CreateDirectory(picturesFolder);
                string dataFilesFolder = output + Path.DirectorySeparatorChar + "[DATAFILES]";
                Directory.CreateDirectory(dataFilesFolder);
            }
        }

        /// <summary>
        /// Loads icons (this needs to be called after <see cref="Load"/> is called!)
        /// </summary>
        public void LoadIcons()
        {
            string output = this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS";
            this.icons.Clear();
            foreach (string file in Directory.GetFiles(output + Path.DirectorySeparatorChar + "[ICONS]"))
            {
                FileInfo fi = new FileInfo(file);
                this.icons.Add(new Icon(Path.GetFileNameWithoutExtension(fi.FullName), file));
            }
        }

        /// <summary>
        /// Loads pictures (this needs to be called after <see cref="Load"/> is called!)
        /// </summary>
        public void LoadPictures()
        {
            string output = this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[PICTURES]";
            this.pictures.Clear();
            foreach(string file in Directory.GetFiles(output))
            {
                this.pictures.Add(new Picture(file));
            }
        }

        /// <summary>
        /// Loads data files (this needs to be called after <see cref="Load"/> is called!)
        /// </summary>
        public void LoadDataFiles()
        {
            string output = this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[DATAFILES]";
            this.dataFiles.Clear();
            foreach (string file in Directory.GetFiles(output))
            {
                FileInfo fi = new FileInfo(file);
                this.dataFiles.Add(fi.Name);
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
            ZipFile.CreateFromDirectory(this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS", this.path);
        }
        #endregion

        #region Icons
        /// <summary>
        /// Adds icon to file storage
        /// </summary>
        /// <param name="path">Path to file containing icon</param>
        /// <returns>Icon added to file storage</returns>
        public Icon AddIcon(string path)
        {
            Icon reti = new Icon(FileStorage.DefaultIcon, this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultIcon + FileStorage.DefaultExt);
            if (File.Exists(path))
            {
                string name = this.GenerateUniqueIcon();
                name = name.ToUpper();
                FileInfo fi = new FileInfo(path);
                string destination = this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + name.ToUpper() + fi.Extension.ToUpper();
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
            Icon reti = new Icon(FileStorage.DefaultIcon, this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultIcon + FileStorage.DefaultExt);
            switch (type)
            {
                case DefaultIconType.IS:           reti = new Icon(FileStorage.DefaultISIcon,  this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultISIcon + FileStorage.DefaultExt);                    break;
                case DefaultIconType.MAP:          reti = new Icon(FileStorage.DefaultMapIcon, this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultMapIcon + FileStorage.DefaultExt);                   break;
                case DefaultIconType.MANUFACTURER: reti = new Icon(FileStorage.DefaultManufacturerIcon, this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultManufacturerIcon + FileStorage.DefaultExt); break;
                case DefaultIconType.FILE:         reti = new Icon(FileStorage.DefaultFileIcon, this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]" + Path.DirectorySeparatorChar + FileStorage.DefaultFileIcon + FileStorage.DefaultExt);                 break;
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
        /// Generates unique icon name
        /// </summary>
        /// <returns>Unique name for icon</returns>
        private string GenerateUniqueIcon()
        {
            Random random = new Random();
            uint length = (uint)random.Next(FileStorage.NameMin, FileStorage.NameMax + 1);
            string reti;
            do
            {
                reti = StringUtils.Random(FileStorage.NameAlphabet, length);
            }
            while(this.GetIcon(reti) != null);
            return reti;
        }
        #endregion

        #region Pictures
        /// <summary>
        /// Gets all available pictures
        /// </summary>
        /// <returns>Array with all available pictures</returns>
        public Picture[] GetPictures()
        {
            return this.pictures.ToArray();
        }

        /// <summary>
        /// Gets picture
        /// </summary>
        /// <param name="name">Name of picture</param>
        /// <returns>Picture with defined name or <c>null</c>, if there is no such picture</returns>
        public Picture? GetPicture(string name)
        {
            Picture? reti = null;
            foreach(Picture picture in this.pictures)
            {
                if (picture.Name == name)
                {
                    reti = picture;
                    break;
                }
            }
            return reti;
        }

        /// <summary>
        /// Gets picture with no <c>null</c> return option
        /// </summary>
        /// <param name="name">Name of picture</param>
        /// <returns>Picture with defined name or default picture</returns>
        public Picture GetPictureChecked(string? name)
        {
            Picture reti = new Picture(this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[PICTURES]" + Path.DirectorySeparatorChar + FileStorage.DefaultPicture + FileStorage.DefaultExt);
            if (name != null)
            {
                foreach (Picture picture in this.pictures)
                {
                    if (picture.Name == name)
                    {
                        reti = picture;
                        break;
                    }
                }
            }
            return reti;
        }
        
        /// <summary>
        /// Adds picture to file storage
        /// </summary>
        /// <param name="path">Path to file with picture</param>
        /// <returns>Picture added to file storage</returns>
        public Picture AddPicture(string path)
        {
            string destination = this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[PICTURES]" + Path.DirectorySeparatorChar;
            string name = this.GenerateUniquePicture();
            destination += name;
            FileInfo fi = new FileInfo(path);
            destination += fi.Extension.ToUpper();
            if (File.Exists(path))
            {
                File.Copy(path, destination, true);
            }
            this.Save();
            Picture reti = new Picture(destination, name);
            this.pictures.Add(reti);
            return reti;
        }

        /// <summary>
        /// Generates unique name for picture
        /// </summary>
        /// <returns>Pseudo-random unique name for picture</returns>
        private string GenerateUniquePicture()
        {
            string reti;
            do
            {
                reti = StringUtils.Random(
                        FileStorage.NameAlphabet,
                        FileStorage.NameMin,
                        FileStorage.NameMax
                    );
            }
            while(this.GetPicture(reti) != null);
            return reti;
        }
        #endregion

        #region Data files
        /// <summary>
        /// Adds data file to file storage
        /// </summary>
        /// <param name="path">Path to file</param>
        /// <returns>Name of added file in file storage</returns>
        public string AddDataFile(string path)
        {
            string reti = string.Empty;
            if (File.Exists(path))
            {
                reti = this.GenerateUniqueDataFile();
                string destination = this.configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[DATAFILES]" + Path.DirectorySeparatorChar + reti;
                File.Copy(path, destination, false);
                this.Save();
            }
            return reti;
        }

        /// <summary>
        /// Generates unique name for data file
        /// </summary>
        /// <returns>Pseudo-random unique name for data file</returns>
        private string GenerateUniqueDataFile()
        {
            string reti = string.Empty;
            do
            {
                reti = StringUtils.Random(FileStorage.NameAlphabet, FileStorage.NameMin, FileStorage.NameMax);
            }
            while (this.dataFiles.Contains(reti));
            return reti;
        }
        #endregion
    }
}
