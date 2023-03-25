using SemestralProject.Data;
using SemestralProject.Handlers;
using SemestralProject.Persistence;
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

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class which displays all information systems
    /// </summary>
    internal partial class ControlISView : UserControl
    {
        /// <summary>
        /// Size of small images
        /// </summary>
        private const int ImageSmall = 16;

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
        /// Creates new viewer of all information systems
        /// </summary>
        public ControlISView()
        {
            InitializeComponent();
            this.RefreshView();
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

                // Show all information systems
                InformationSystemsHandler handler = new InformationSystemsHandler(this.DataStorage, this.FileStorage);
                foreach(InformationSystem system in handler)
                {
                    string[] data = new string[] { system.Name, system.Updated.ToString()};
                    ListViewItem item = new ListViewItem(data, system.Icon.Name);
                    this.listViewContent.Items.Add(item);
                }
            }
        }
    }
}
