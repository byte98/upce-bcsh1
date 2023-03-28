using SemestralProject.Data;
using SemestralProject.Handlers;
using SemestralProject.Persistence;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Forms.InformationSystems
{
    /// <summary>
    /// Class which displays all information systems
    /// </summary>
    internal partial class ControlISView : UserControl, IView
    {
        /// <summary>
        /// Class holding arguments of event 'information system changed'
        /// </summary>
        internal class ISChangedEventArgs: EventArgs
        {
            /// <summary>
            /// Selected information system or <c>null</c> if no system is selected
            /// </summary>
            public InformationSystem? SelectedSystem { get; init; }
        }

        /// <summary>
        /// Delegate which handles event 'information system changed'
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event</param>
        public delegate void ISChangedEventHandler(object sender, ISChangedEventArgs e);

        /// <summary>
        /// Event of change of selected information system
        /// </summary>
        public event ISChangedEventHandler? ISChanged;

        /// <summary>
        /// Size of small images
        /// </summary>
        private const int ImageSmall = 24;

        /// <summary>
        /// Size of large images
        /// </summary>
        private const int ImageLarge = 64;

        /// <summary>
        /// Reference to storage of data
        /// </summary>
        public DataStorage? DataStorage { private get; set; }

        /// <summary>
        /// Reference to storage of files
        /// </summary>
        public FileStorage? FileStorage { private get; set; }

        /// <summary>
        /// Selected information system
        /// </summary>
        public InformationSystem? SelectedSystem { get; private set; } = null;

        /// <summary>
        /// Attribute holding actual search phrase
        /// </summary>
        private string? search = null;

        /// <summary>
        /// Phrase which will be searched
        /// </summary>
        public string? Search
        {
            private get
            {
                return this.search;
            }
            set
            {
                this.search = value;
                this.SearchData();
            }
        }

        /// <summary>
        /// Counter of displayed information systems
        /// </summary>
        public int SystemsCount
        {
            get
            {
                return this.listViewContent.Items.Count;
            }
        }


        /// <summary>
        /// Creates new viewer of all information systems
        /// </summary>
        public ControlISView()
        {
            InitializeComponent();
            this.RefreshView();
        }

        /// <summary>
        /// Searches data
        /// </summary>
        private void SearchData()
        {
            if (this.Search == null)
            {
                this.RefreshView();
            }
            else
            {
                this.listViewContent.Items.Clear();
                List<InformationSystem> list = new List<InformationSystem>();
                FormWait wait = new FormWait(() => {
                    if (this.DataStorage!= null)
                    {
                        foreach (InformationSystem system in this.DataStorage.InformationSystems)
                        {
                            if (system.Name.ToLower().Trim().Contains(this.Search.ToLower().Trim()))
                            {
                                list.Add(system);
                            }
                        }
                    }
                });
                wait.ShowDialog();
                foreach (InformationSystem system in list)
                {
                    ListViewItem item = new ListViewItem(system.Name, system.Icon.Name);
                    item.SubItems.Add(system.Description);
                    this.listViewContent.Items.Add(item);
                    item.Tag = system.ID;
                }
                this.listViewContent.Refresh();
            }
        }

        /// <summary>
        /// Refreshes content of view and displays actual state
        /// </summary>
        public void RefreshView()
        {
            if (this.FileStorage != null && this.DataStorage!= null)
            {
                this.listViewContent.Items.Clear();

                // Create image lists
                ImageList largeImageList = new ImageList();
                ImageList smallImageList = new ImageList();
                largeImageList.ImageSize = new Size(ControlISView.ImageLarge, ControlISView.ImageLarge);
                smallImageList.ImageSize = new Size(ControlISView.ImageSmall, ControlISView.ImageSmall);
                foreach (Icon icon in this.FileStorage.GetAllIcons())
                {
                    largeImageList.Images.Add(icon.Name, icon.GetImage());
                    smallImageList.Images.Add(icon.Name, icon.GetImage());
                }
                this.listViewContent.SmallImageList = smallImageList;
                this.listViewContent.LargeImageList = largeImageList;

                // Show all information systems
                InformationSystemsHandler handler = new InformationSystemsHandler(this.DataStorage, this.FileStorage);
                foreach(InformationSystem system in handler)
                {
                    ListViewItem item = new ListViewItem(system.Name, system.Icon.Name);
                    item.SubItems.Add(system.Description);
                    this.listViewContent.Items.Add(item);
                    item.Tag = system.ID;
                }
            }
            this.listViewContent.Columns[0].Width = -2;
            this.listViewContent.Columns[1].Width = -2;
            this.listViewContent.SelectedIndices.Clear();
            this.SelectedSystem = null;
            this.ISChanged?.Invoke(this, new ISChangedEventArgs() { SelectedSystem = null });
        }

        private void listViewContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedSystem = null; 
            if (this.DataStorage != null && this.FileStorage != null && this.listViewContent.SelectedItems.Count > 0)
            {
                InformationSystemsHandler handler = new InformationSystemsHandler(this.DataStorage, this.FileStorage);
                string? id = this.listViewContent.SelectedItems[0].Tag.ToString();
                if (id != null)
                {
                    this.SelectedSystem = handler.GetByID(id);
                }
            }
            this.ISChanged?.Invoke(this, new ISChangedEventArgs() { SelectedSystem = this.SelectedSystem });
        }

        public void SetItemsSize(View itemsSize)
        {
            this.listViewContent.View = itemsSize;
        }
    }
}
