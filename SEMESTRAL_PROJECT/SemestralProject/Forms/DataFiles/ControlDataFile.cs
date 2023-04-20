using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Forms.DataFiles
{
    /// <summary>
    /// Class representing control for creating and editing data files
    /// </summary>
    internal partial class ControlDataFile : UserControl, IControl
    {
        /// <summary>
        /// Structure holding all necessary information for showing all information systems in combo box
        /// </summary>
        private struct InformationSystemItem
        {
            /// <summary>
            /// Displayed name in combo box
            /// </summary>
            public string DisplayName { get; set; }

            /// <summary>
            /// Information system which combo box item represents
            /// </summary>
            public InformationSystem System { get; set; }

            /// <summary>
            /// Creates new combo box item with information system
            /// </summary>
            /// <param name="system">Information system represented by combo box item</param>
            public InformationSystemItem(InformationSystem system) : this(system.Name, system) { }

            /// <summary>
            /// Creates new combo box item with information system
            /// </summary>
            /// <param name="name">Name displayed in combo box</param>
            /// <param name="system">Information system represented by combo box item</param>
            public InformationSystemItem(string name, InformationSystem system)
            {
                this.DisplayName = name;
                this.System = system;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = base.Equals(obj);
                if (obj != null && obj is InformationSystemItem)
                {
                    InformationSystemItem other = (InformationSystemItem)obj;
                    reti = (this.System.Id == other.System.Id);
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.System.Id.GetHashCode();
            }

            public override string ToString()
            {
                return this.DisplayName;
            }
        }

        /// <summary>
        /// Structure holding all necessary information for showing all maps in combo box
        /// </summary>
        private struct MapItem
        {
            /// <summary>
            /// Displayed name in combo box
            /// </summary>
            public string DisplayName { get; set; }

            /// <summary>
            /// Map which combo box item represents
            /// </summary>
            public Map Map { get; set; }

            /// <summary>
            /// Creates new map item in comb box
            /// </summary>
            /// <param name="map">Map which represents combo box item</param>
            public MapItem(Map map) : this(map.Name, map) { }

            /// <summary>
            /// Creates new map item in combo box
            /// </summary>
            /// <param name="name">Displayed name in combo box</param>
            /// <param name="map">Map which represents combo box item</param>
            public MapItem(string name, Map map)
            {
                this.DisplayName = name;
                this.Map = map;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = base.Equals(obj);
                if (obj != null && obj is MapItem)
                {
                    MapItem other = (MapItem)obj;
                    reti = (this.Map.Id == other.Map.Id);
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.Map.Id.GetHashCode();
            }

            public override string ToString()
            {
                return this.DisplayName;
            }
        }

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Path to data file
        /// </summary>
        public string FilePath => this.textBoxPath.Text;

        /// <summary>
        /// Information system in which format data file holds data
        /// </summary>
        public InformationSystem? FileSystem
        {
            get
            {
                InformationSystem? reti = null;
                if (this.comboBoxInformationSystem.SelectedItem != null && this.comboBoxInformationSystem.SelectedItem is InformationSystemItem)
                {
                    InformationSystemItem item = (InformationSystemItem)this.comboBoxInformationSystem.SelectedItem;
                    reti = item.System;
                }
                return reti;
            }
        }

        /// <summary>
        /// Map which data file holds data
        /// </summary>
        public Map? FileMap
        {
            get
            {
                Map? reti = null;
                if (this.comboBoxMap.SelectedItem != null && this.comboBoxMap.SelectedItem is MapItem)
                {
                    MapItem item = (MapItem)this.comboBoxMap.SelectedItem;
                    reti = item.Map;
                }
                return reti;
            }
        }

        /// <summary>
        /// Description of data file
        /// </summary>
        public string FileDescription => this.textBoxDescription.Text;

        /// <summary>
        /// Creates new control for creating data files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlDataFile(Context context)
        {
            this.InitializeComponent();
            this.Context = context;
            this.InitializeContent();
        }

        /// <summary>
        /// Creates new control for editing data files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="dataFile">Data file which will be edited</param>
        public ControlDataFile(Context context, DataFile dataFile)
        {
            this.InitializeComponent();
            this.Context = context;
            this.InitializeContent();
            this.textBoxPath.Text = dataFile.OriginalPath;
            this.textBoxDescription.Text = dataFile.Description;
            this.comboBoxInformationSystem.SelectedItem = new InformationSystemItem(dataFile.InformationSystem);
            this.comboBoxMap.SelectedItem = new MapItem(dataFile.Map);
        }

        private void InitializeContent()
        {
            // Browse button
            ControlBrowseButton browseButton = new ControlBrowseButton(this.Context);
            browseButton.FileFilter = "Všechny soubory (*.*)|*.*";
            browseButton.Dock = DockStyle.Fill;
            this.panelPathBrowse.Controls.Add(browseButton);

            // Information systems combo box
            this.comboBoxInformationSystem.Items.Clear();
            foreach(InformationSystem system in this.Context.DataStorage.InformationSystems)
            {
                this.comboBoxInformationSystem.Items.Add(new InformationSystemItem(system));
            }

            // Maps combo box
            this.comboBoxMap.Items.Clear();
            foreach(Map map in this.Context.DataStorage.Maps)
            {
                this.comboBoxMap.Items.Add(new MapItem(map));
            }
            
            browseButton.FileSelectedEvent += new ControlBrowseButton.FileSelectedHandler(delegate (object sender, ControlBrowseButton.FileSelectedArgs args)
            {
                if (args.SelectedFile.Length > 0)
                {
                    this.textBoxPath.Text = args.SelectedFile;
                }
            });
        }
    }
}
