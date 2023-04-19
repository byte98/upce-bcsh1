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
        /// Character defining line comment in file
        /// </summary>
        private const string Comment = "#";

        /// <summary>
        /// Directory for temporary files
        /// </summary>
        public string TempDir => "./~$TMP";

        /// <summary>
        /// Path to file with configuration
        /// </summary>
        private readonly string configFile;

        /// <summary>
        /// Path to directory with vehicles
        /// </summary>
        public string VehiclesRoot { get; set; } = string.Empty;

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
            StringBuilder content = new StringBuilder();
            content.Append("VEHICLES_ROOT").Append(Configuration.ValueSeparator).Append(this.VehiclesRoot).Append(Configuration.Separator);
            if (File.Exists(this.configFile))
            {
                File.Delete(this.configFile);
            }
            File.WriteAllText(this.configFile, content.ToString());
        }

        /// <summary>
        /// Loads configuration from file
        /// </summary>
        public void Load()
        {
            if (File.Exists(this.configFile)) 
            {
                string content = File.ReadAllText(this.configFile);
                string[] items = content.Split(Configuration.Separator, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                foreach (string item in items)
                {
                    if (item.StartsWith(Configuration.Comment) == false)
                    {
                        string[] values = item.Split(Configuration.ValueSeparator);
                        if (values.Length >= 2)
                        {
                            switch(values[0].ToUpper().Trim())
                            {
                                case "VEHICLES_ROOT": this.VehiclesRoot = values[1]; break;
                            }
                        }
                    }
                }
            }
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
