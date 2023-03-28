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

namespace SemestralProject.Forms.Maps
{
    /// <summary>
    /// Class which can display all maps
    /// </summary>
    internal partial class ControlMapsView : UserControl, IView
    {
        /// <summary>
        /// Class representing event arguments for selected map changed event
        /// </summary>
        internal class MapChangedEventArgs: EventArgs
        {
            /// <summary>
            /// Actually selected map or <c>null</c> if no map is selected
            /// </summary>
            public Map? SelectedMap { get; set; }
        }

        /// <summary>
        /// Delegate which handles selected map changed event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event</param>
        public delegate void MapChangedEventHandler(object sender, MapChangedEventArgs e);

        /// <summary>
        /// Selected map has changed event
        /// </summary>
        public event MapChangedEventHandler? MapChangedEvent;

        /// <summary>
        /// Aspect ratio of images
        /// </summary>
        private const double AspectRatio = (16 / 9);

        /// <summary>
        /// Width of large images
        /// </summary>
        private const int LargeWidth = 300;

        /// <summary>
        /// Height of large images
        /// </summary>
        private static readonly int LargeHeight = (int)Math.Round((double)ControlMapsView.LargeWidth * ControlMapsView.AspectRatio);

        /// <summary>
        /// Width of small images
        /// </summary>
        private const int SmallWidth = 100;

        /// <summary>
        /// Height of small images
        /// </summary>
        private static readonly int SmallHeight = (int)Math.Round((double)ControlMapsView.SmallWidth * ControlMapsView.AspectRatio);

        /// <summary>
        /// Actually selected map
        /// </summary>
        public Map? SelectedMap { get; set; }

        /// <summary>
        /// Number of maps in view
        /// </summary>
        public int MapsCount => this.listViewContent.Items.Count;

        /// <summary>
        /// List of displayed maps
        /// </summary>
        private readonly List<Map> mapList;

        public ControlMapsView()
        {
            InitializeComponent();
            this.mapList = new List<Map>();
        }

        /// <summary>
        /// Refreshes view to its default state
        /// </summary>
        public void RefreshView()
        {
            this.mapList.Clear();
            DataStorage ds = DataStorage.Instance;
            this.mapList.AddRange(ds.Maps);
            this.DisplayMaps();
        }

        /// <summary>
        /// Displays all listed maps
        /// </summary>
        private void DisplayMaps()
        {
            // Generate image lists
            ImageList smallList = new ImageList();
            smallList.ImageSize = new Size(ControlMapsView.SmallWidth, ControlMapsView.SmallHeight);
            ImageList largeList = new ImageList();
            largeList.ImageSize = new Size(ControlMapsView.LargeWidth, ControlMapsView.LargeHeight);
            foreach(Map map in this.mapList)
            {
                smallList.Images.Add(map.Picture.Name, map.Picture.GetImage());
                largeList.Images.Add(map.Picture.Name, map.Picture.GetImage());
            }
            this.listViewContent.LargeImageList = largeList;
            this.listViewContent.SmallImageList = smallList;

            // Show maps
            this.listViewContent.Items.Clear();
            foreach(Map map in this.mapList)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = map.ID;
                item.Text = map.Name;
                item.ImageKey = map.Picture.Name;
                item.SubItems.Add(map.Description);
                this.listViewContent.Items.Add(item);
            }

            this.listViewContent.Columns[0].Width = -2;
            this.listViewContent.Columns[1].Width = -2;
            this.listViewContent.SelectedIndices.Clear();
            this.SelectedMap = null;
            this.MapChangedEvent?.Invoke(this, new MapChangedEventArgs() { SelectedMap = this.SelectedMap });
        }

        private void listViewContent_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.SelectedMap = null;
            if (this.listViewContent.SelectedItems.Count > 0)
            {
                MapsHandler handler = MapsHandler.Instance;
                string? id = this.listViewContent.SelectedItems[0].Tag.ToString();
                if (id != null)
                {
                    this.SelectedMap = handler.GetMapById(id);
                }
            }
            this.MapChangedEvent?.Invoke(this, new MapChangedEventArgs() { SelectedMap = this.SelectedMap });
        }

        public void SetItemsSize(View itemsSize)
        {
            this.listViewContent.View = itemsSize;
        }
    }
}
