using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Forms.InformationSystems
{
    /// <summary>
    /// Class representing control for solving confilcts when deleting information system
    /// </summary>
    internal partial class ControlISConflicts : UserControl, IControl
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// List of conflict vehicles
        /// </summary>
        private readonly List<Vehicle> vehicles;

        /// <summary>
        /// List of conflict data files
        /// </summary>
        private readonly List<DataFile> dataFiles;

        /// <summary>
        /// Size of icons
        /// </summary>
        private const int IconSize = 32;

        /// <summary>
        /// Aspect ration of pictures
        /// </summary>
        private const double AspectRatio = (9f / 16f);

        /// <summary>
        /// Width of pictures
        /// </summary>
        private const int PictureWidth = 100;

        /// <summary>
        /// Size of pictures
        /// </summary>
        private Size PictureSize => new Size(ControlISConflicts.PictureWidth, (int)Math.Round(ControlISConflicts.PictureWidth * ControlISConflicts.AspectRatio));

        /// <summary>
        /// Creates new control for solving conflicts when deleting information system
        /// </summary>
        /// <param name="vehicles">List of conflict vehicles</param>
        /// <param name="dataFiles">List of conflict data files</param>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlISConflicts(List<Vehicle> vehicles, List<DataFile> dataFiles, Context context)
        {
            InitializeComponent();
            this.vehicles = vehicles;
            this.dataFiles = dataFiles;
            this.Context = context;
            this.InitializeVehicles();
            this.InitializeFiles();
        }

        /// <summary>
        /// Initializes view of vehicles
        /// </summary>
        private void InitializeVehicles()
        {
            // Prepare image list
            ImageList imageList = new ImageList();
            foreach(Vehicle vehicle in this.vehicles)
            {
                if (imageList.Images.ContainsKey(vehicle.Picture.Name) == false)
                {
                    imageList.Images.Add(vehicle.Picture.Name, vehicle.Picture.GetImage());
                }
            }
            imageList.ImageSize = this.PictureSize;
            this.listViewVehicles.SmallImageList = imageList;
            this.listViewVehicles.LargeImageList = imageList;

            // Insert data
            this.listViewVehicles.Items.Clear();
            foreach(Vehicle vehicle in this.vehicles)
            {
                ListViewItem item = new ListViewItem(vehicle.Name, vehicle.Picture.Name);
                item.SubItems.Add(vehicle.InformationSystem.Name);
                item.SubItems.Add(vehicle.Description);
                item.SubItems.Add(vehicle.Path);
                item.SubItems.Add(vehicle.Created.ToString());
                item.SubItems.Add(vehicle.Updated.ToString());
                this.listViewVehicles.Items.Add(item);
            }

            // Set column width
            foreach(ColumnHeader col in this.listViewVehicles.Columns)
            {
                col.Width = -2;
            }
        }

        /// <summary>
        /// Initializes view of files
        /// </summary>
        private void InitializeFiles()
        {
            // Simple image list
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(ControlISConflicts.IconSize, ControlISConflicts.IconSize);
            imageList.Images.Add("file", this.Context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.FILE).GetImage());
            this.listViewFiles.SmallImageList = imageList;
            this.listViewFiles.LargeImageList = imageList;

            // Prepare data
            this.listViewFiles.Items.Clear();
            foreach(DataFile file in this.dataFiles)
            {
                FileInfo fi = new FileInfo(file.OriginalPath);
                ListViewItem item = new ListViewItem(fi.Name, "file");
                item.SubItems.Add(file.InformationSystem.Name);
                item.SubItems.Add(file.Description);
                item.SubItems.Add(Path.GetDirectoryName(file.OriginalPath));
                item.SubItems.Add(file.Created.ToString());
                item.SubItems.Add(file.Updated.ToString());
                this.listViewFiles.Items.Add(item);
            }

            // Set column width
            foreach(ColumnHeader col in this.listViewFiles.Columns)
            {
                col.Width = -2;
            }
        }
    }
}
