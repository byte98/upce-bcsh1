using SemestralProject.Forms;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class which holds configuration of program
    /// </summary>
    internal static class Configuration
    {
        /// <summary>
        /// Name of file where configuration is saved
        /// </summary>
        private const string ConfigFile = "CONFIG.INI";

        /// <summary>
        /// Flag, whether configuration will be saved after any change
        /// </summary>
        private const bool AutoSave = true;

        /// <summary>
        /// Actual accent color of system
        /// </summary>
        public static Color AccentColor
        {
            get
            {
                var uiSettings = new UISettings();
                var accent = uiSettings.GetColorValue(UIColorType.Accent);
                return Color.FromArgb(accent.A, accent.R, accent.G, accent.B);
            }
        }

        /// <summary>
        /// Actual text color according to accent color
        /// </summary>
        public static Color TextColor
        {
            get
            {
                Color accent = Configuration.AccentColor;
                int colorNr = accent.R * accent.G * accent.B;
                Color reti = Color.Black;
                if (colorNr < (127 * 127 * 127))
                {
                    reti = Color.White;
                }
                return reti;
            }
        }

        /// <summary>
        /// Separator of each configuration item in configuration file
        /// </summary>
        private static readonly string Separator = Environment.NewLine;

        /// <summary>
        /// Separator of values in configuration files
        /// </summary>
        private const string ValueSeparator = "=";

        /// <summary>
        /// Directory for temporary files
        /// </summary>
        public const string TempDir = "./~$TMP";

        /// <summary>
        /// Flag, whether configuration represents actual state of configuration file
        /// </summary>
        public static bool Loaded { get; private set; } = false;

        /// <summary>
        /// Delegate of configuration change event
        /// </summary>
        public delegate void ConfigurationChangedEventHandler();

        /// <summary>
        /// Configuration change event
        /// </summary>
        public static event ConfigurationChangedEventHandler? ConfigurationChanged = delegate
        {
            Configuration.Loaded = false;
            if (Configuration.AutoSave == true)
            {
                Configuration.Save();
            }
        };

        /// <summary>
        /// File containing file storage
        /// </summary>
        private static string storageFile = "fs.dat";

        /// <summary>
        /// Property handler of file containing file storage
        /// </summary>
        public static string StorageFile
        {
            get
            { 
                return Configuration.storageFile;
            }
            set
            {
                Configuration.storageFile = value;
                ConfigurationChanged?.Invoke();
            }
        }

        /// <summary>
        /// File containing data storage
        /// </summary>
        private static string dataFile = "db.dat";

        /// <summary>
        /// Path to file containing data storage
        /// </summary>
        public static string DataFile
        {
            get
            {
                return Configuration.dataFile;
            }
            set
            {
                Configuration.dataFile = value;
                ConfigurationChanged?.Invoke();
            }
        }

        /// <summary>
        /// Saves configuration into file
        /// </summary>
        public static void Save()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("STORAGE_FILE").Append(Configuration.ValueSeparator).Append(Configuration.StorageFile).Append(Configuration.Separator);
            sb.Append("DATA_FILE").Append(Configuration.ValueSeparator).Append(Configuration.DataFile).Append(Configuration.Separator);
            File.WriteAllText(sb.ToString(), Configuration.ConfigFile);
            Configuration.Loaded = true;
        }

        /// <summary>
        /// Loads configuration from file
        /// </summary>
        public static void Load()
        {
            if (File.Exists(Configuration.ConfigFile))
            {
                string content = File.ReadAllText(Configuration.ConfigFile);

                foreach (string item in content.Split(Configuration.Separator))
                {
                    string[] parts = item.Split(Configuration.ValueSeparator);
                    if (parts.Length == 2)
                    {
                        switch(parts[0].Trim().ToUpper())
                        {
                            case "STORAGE_FILE": Configuration.StorageFile = parts[1]; break;
                            case "DATA_FILE":    Configuration.DataFile    = parts[1]; break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Creates temporary directory
        /// </summary>
        public static void CreateTemp()
        {
            if (Directory.Exists(Configuration.TempDir) == false)
            {
                DirectoryInfo di = Directory.CreateDirectory(Configuration.TempDir);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
        }

        /// <summary>
        /// Deletes temporary directory
        /// </summary>
        public static void DeleteTemp()
        {
            if (Directory.Exists(Configuration.TempDir))
            {
                Directory.Delete(Configuration.TempDir, true);
            }
        }
    }
}
