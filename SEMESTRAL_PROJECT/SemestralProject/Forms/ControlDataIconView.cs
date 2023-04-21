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
    /// Class representing viewer of data with icons
    /// </summary>
    internal partial class ControlDataIconView : UserControl, IControl, IAbstractDataView
    {
        /// <summary>
        /// Size of small icons
        /// </summary>
        private const int SmallSize = 32;

        /// <summary>
        /// Size of large icons
        /// </summary>s
        private const int LargeSize = 64;

        /// <summary>
        /// Wrapper of all systems resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Attribute holding all visible data
        /// </summary>
        private List<AbstractIconData> visibleData;

        /// <summary>
        /// Attribute which holds actually selected data
        /// </summary>
        private string? selectedData;

        public string? SelectedData => this.selectedData;

        public event SelectedDataChangedEventHandler? SelectedDataChanged;

        /// <summary>
        /// All visible data
        /// </summary>
        public List<AbstractIconData> VisibleData
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
        /// Creates new viewer of data with icons
        /// </summary>
        /// <param name="context">Wrapper of program resources</param>
        public ControlDataIconView(Context context)
        {
            this.Context = context;
            this.InitializeComponent();
            this.visibleData = this.Context.DataStorage.InformationSystems.OfType<AbstractIconData>().ToList();
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
            largeList.ImageSize = new Size(ControlDataIconView.LargeSize, ControlDataIconView.LargeSize);
            smallList.ImageSize = new Size(ControlDataIconView.SmallSize, ControlDataIconView.SmallSize);
            foreach(AbstractIconData data in this.VisibleData)
            {
                largeList.Images.Add(data.Icon.Name, data.Icon.GetImage());
                smallList.Images.Add(data.Icon.Name, data.Icon.GetImage());
            }
            this.listViewContent.SmallImageList = smallList;
            this.listViewContent.LargeImageList = largeList;

            // Show items
            foreach(AbstractIconData data in this.VisibleData)
            {
                ListViewItem item = new ListViewItem(data.Name, data.Icon.Name);
                item.Tag = data.Id;
                item.SubItems.Add(data.Description);
                item.SubItems.Add(data.Updated.ToString());
                this.listViewContent.Items.Add(item);
            }

            // Set right size for columns
            foreach(ColumnHeader col in this.listViewContent.Columns)
            {
                col.Width = -2;
            }
        }

        public void SetItemsSize(View itemsSize)
        {
            this.listViewContent.View = itemsSize;
        }

        public void Unselect()
        {
            this.listViewContent.SelectedIndices.Clear();
        }

        private void listViewContent_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.listViewContent.SelectedItems.Count > 0)
            {
                this.selectedData = this.listViewContent.SelectedItems[0].Tag.ToString();
            }
            else
            {
                this.selectedData = null;
            }
            this.SelectedDataChanged?.Invoke(this, new SelectedDataChangedEventArgs() { SelectedData = this.SelectedData });
        }
    }
}
