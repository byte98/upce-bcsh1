using SemestralProject.Forms;
using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Printing.Workflow;
using Windows.UI.ViewManagement;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class which holds configuration of program
    /// </summary>
    internal class Configuration
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
        public Color AccentColor
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
        public Color TextColor
        {
            get
            {
                Color accent = this.AccentColor;
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
        public string TempDir => "./~$TMP";

        /// <summary>
        /// Flag, whether configuration represents actual state of configuration file
        /// </summary>
        public bool Loaded { get; private set; } = false;

        /// <summary>
        /// Delegate of configuration change event
        /// </summary>
        public delegate void ConfigurationChangedEventHandler();

        /// <summary>
        /// Configuration change event
        /// </summary>
        public event ConfigurationChangedEventHandler? ConfigurationChanged;

        /// <summary>
        /// Path to file with configuration
        /// </summary>
        private readonly string configFile;
        
        /// <summary>
        /// Creates new handler of configuration
        /// </summary>
        /// <param name="path">Path to file with configuration</param>
        public Configuration(string path)
        {
            this.configFile = path;
        }

        /// <summary>
        /// Saves configuration into file
        /// </summary>
        public void Save()
        {
            // TODO
        }

        /// <summary>
        /// Loads configuration from file
        /// </summary>
        public void Load()
        {
            // TODO
        }

        /// <summary>
        /// Creates temporary directory
        /// </summary>
        public void CreateTemp()
        {
            if (Directory.Exists(this.TempDir) == false)
            {
                DirectoryInfo di = Directory.CreateDirectory(this.TempDir);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
        }

        /// <summary>
        /// Deletes temporary directory
        /// </summary>
        public void DeleteTemp()
        {
            if (Directory.Exists(this.TempDir))
            {
                Directory.Delete(this.TempDir, true);
            }
        }
    }
}
