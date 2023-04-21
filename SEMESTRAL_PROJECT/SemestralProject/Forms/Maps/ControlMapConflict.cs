using SemestralProject.Data;
using SemestralProject.Forms.InformationSystems;
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

namespace SemestralProject.Forms.Maps
{
    /// <summary>
    /// Class representing control which solve conflict when deleting map
    /// </summary>
    internal partial class ControlMapConflict : UserControl, IControl
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Size of icons
        /// </summary>
        private const int IconSize = 32;

        /// <summary>
        /// List of conflict data files
        /// </summary>
        private readonly List<DataFile> dataFiles;

        /// <summary>
        /// Creates new control for solving conflicts when deleting map
        /// </summary>
        /// <param name="files">Files in conflict</param>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlMapConflict(List<DataFile> files, Context context)
        {
            InitializeComponent();
            this.Context = context;
            this.dataFiles = files;
            this.InitializeFiles();
        }

        /// <summary>
        /// Initializes view of files
        /// </summary>
        private void InitializeFiles()
        {
            // Simple image list
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(ControlMapConflict.IconSize, ControlMapConflict.IconSize);
            imageList.Images.Add("file", this.Context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.FILE).GetImage());
            this.listViewFiles.SmallImageList = imageList;
            this.listViewFiles.LargeImageList = imageList;

            // Prepare data
            this.listViewFiles.Items.Clear();
            foreach (DataFile file in this.dataFiles)
            {
                FileInfo fi = new FileInfo(file.OriginalPath);
                ListViewItem item = new ListViewItem(fi.Name, "file");
                item.SubItems.Add(file.Map.Name);
                item.SubItems.Add(file.Description);
                item.SubItems.Add(Path.GetDirectoryName(file.OriginalPath));
                item.SubItems.Add(file.Created.ToString());
                item.SubItems.Add(file.Updated.ToString());
                this.listViewFiles.Items.Add(item);
            }

            // Set column width
            foreach (ColumnHeader col in this.listViewFiles.Columns)
            {
                col.Width = -2;
            }
        }
    }
}
