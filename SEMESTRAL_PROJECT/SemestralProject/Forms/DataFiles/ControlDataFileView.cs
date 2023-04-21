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

namespace SemestralProject.Forms.DataFiles
{
    /// <summary>
    /// Class representing viewer of data files
    /// </summary>
    internal partial class ControlDataFileView : UserControl, IControl, IView
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
        /// Attribute holding list with all visible data files
        /// </summary>
        private List<DataFile> visibleData;

        /// <summary>
        /// Attribute which holds actually selected data
        /// </summary>
        private string? selectedData;

        public string? SelectedData => this.selectedData;

        public event SelectedDataChangedEventHandler? SelectedDataChanged;

        /// <summary>
        /// All visible data files
        /// </summary>
        public List<DataFile> VisibleData
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
        /// Creates new viewer of data files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlDataFileView(Context context)
        {
            InitializeComponent();
            this.Context = context;
        }

        /// <summary>
        /// Refreshes actual state of viewer
        /// </summary>
        private void RefreshView()
        {
            this.listViewContent.Items.Clear();

            // Prepare image lists
            ImageList smallList = new ImageList();
            ImageList largeList = new ImageList();
            smallList.ImageSize = new Size(ControlDataFileView.SmallSize, ControlDataFileView.SmallSize);
            largeList.ImageSize = new Size(ControlDataFileView.LargeSize, ControlDataFileView.LargeSize);
            smallList.Images.Add("file", this.Context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.FILE).GetImage());
            largeList.Images.Add("file", this.Context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.FILE).GetImage());
            this.listViewContent.SmallImageList = smallList;
            this.listViewContent.LargeImageList = largeList;

            // Show items
            foreach(DataFile file in this.visibleData)
            {
                FileInfo fi = new FileInfo(file.OriginalPath);
                ListViewItem item = new ListViewItem(fi.Name, "file");
                item.Tag = file.Id;
                item.SubItems.Add(file.Description);
                item.SubItems.Add(file.InformationSystem.Name);
                item.SubItems.Add(file.Map.Name);
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
