using SemestralProject.Data;
using SemestralProject.Utils;
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
using static SemestralProject.Visual.IAbstractDataView;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class representing data viewer of data with pictures
    /// </summary>
    internal partial class ControlDataPictureView : UserControl, IControl, IAbstractDataView
    {
        /// <summary>
        /// Width of small pictures
        /// </summary>
        private const int SmallWidth = 100;

        /// <summary>
        /// Width of large pictures
        /// </summary>
        private const int LargeWidth = 300;

        /// <summary>
        /// Aspect ration of images
        /// </summary>
        private const double AspectRatio = (9f / 16f);

        /// <summary>
        /// Size of small pictures
        /// </summary>
        private Size SmallSize => new Size(ControlDataPictureView.SmallWidth, (int)Math.Round(ControlDataPictureView.SmallWidth * ControlDataPictureView.AspectRatio));

        /// <summary>
        /// Size of large pictures
        /// </summary>
        private Size LargeSize => new Size(ControlDataPictureView.LargeWidth, (int)Math.Round(ControlDataPictureView.LargeWidth * ControlDataPictureView.AspectRatio));

        /// <summary>
        /// Wrapper of all systems resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Attribute holding all visible data
        /// </summary>
        private List<AbstractPictureData> visibleData;

        public event IAbstractDataView.SelectedDataChangedEventHandler? SelectedDataChanged;

        /// <summary>
        /// All visible data
        /// </summary>
        public List<AbstractPictureData> VisibleData
        {
            get
            {
                return this.visibleData;
            }
            set
            {
                this.visibleData = value;
                this.RefreshView();
            }
        }

        /// <summary>
        /// Identifier of actually selected data in view
        /// or <c>NULL</c> if no data is selected
        /// </summary>
        public string? SelectedData { get; private set; }

        /// <summary>
        /// Creates new viewer of data with icons
        /// </summary>
        /// <param name="context">Wrapper of program resources</param>
        public ControlDataPictureView(Context context)
        {
            this.Context = context;
            this.InitializeComponent();
            this.visibleData = new List<AbstractPictureData>();
        }

        /// <summary>
        /// Refreshes view with actual data
        /// </summary>
        public void RefreshView()
        {
            this.listViewContent.Items.Clear();

            // Generate image lists
            ImageList largeList = new ImageList();
            ImageList smallList = new ImageList();
            largeList.ImageSize = this.LargeSize;
            smallList.ImageSize = this.SmallSize;
            foreach (AbstractPictureData data in this.VisibleData)
            {
                largeList.Images.Add(data.Picture?.Name, data.Picture?.GetImage());
                smallList.Images.Add(data.Picture?.Name, data.Picture?.GetImage());
            }
            this.listViewContent.SmallImageList = smallList;
            this.listViewContent.LargeImageList = largeList;

            // Show items
            foreach (AbstractPictureData data in this.VisibleData)
            {
                ListViewItem item = new ListViewItem(data.Name, data.Picture?.Name);
                item.Tag = data.Id;
                item.SubItems.Add(data.Description);
                item.SubItems.Add(data.Updated.ToString());
                this.listViewContent.Items.Add(item);
            }

            // Set right size for columns
            foreach (ColumnHeader col in this.listViewContent.Columns)
            {
                col.Width = -2;
            }
        }

        public void SetItemsSize(View itemsSize)
        {
            this.listViewContent.View = itemsSize;
        }

        private void listViewContent_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.listViewContent.SelectedItems.Count > 0)
            {
                this.SelectedData = this.listViewContent.SelectedItems[0].Tag.ToString();
            }
            else
            {
                this.SelectedData = null;
            }
            this.SelectedDataChanged?.Invoke(this, new SelectedDataChangedEventArgs() { SelectedData = this.SelectedData });
        }
    }
}
