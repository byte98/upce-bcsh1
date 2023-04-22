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

namespace SemestralProject.Forms.Manufacturers
{
    /// <summary>
    /// Creates control for showing conflicts when removing manufacturer
    /// </summary>
    internal partial class ControlManufacturerConflict : UserControl, IControl
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
        private Size PictureSize => new Size(ControlManufacturerConflict.PictureWidth, (int)Math.Round(ControlManufacturerConflict.PictureWidth * ControlManufacturerConflict.AspectRatio));

        /// <summary>
        /// Creates new control for showing conflicts when removing manufacturer
        /// </summary>
        /// <param name="vehicles">List of conflict vehicles</param>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlManufacturerConflict(List<Vehicle> vehicles, Context context)
        {
            InitializeComponent();
            this.vehicles = vehicles;
            this.Context = context;
            this.InitializeVehicles();
        }

        /// <summary>
        /// Initializes viewer of conflict vehicles
        /// </summary>
        private void InitializeVehicles()
        {
            // Initialize image list
            ImageList imageList = new ImageList();
            foreach(Vehicle vehicle in this.vehicles)
            {
                imageList.Images.Add(vehicle.Picture.Name, vehicle.Picture.GetImage());
            }
            imageList.ImageSize = this.PictureSize;
            this.listViewFiles.LargeImageList = imageList;
            this.listViewFiles.SmallImageList = imageList;

            // Initialize data
            this.listViewFiles.Items.Clear();
            foreach(Vehicle vehicle in this.vehicles)
            {
                ListViewItem item = new ListViewItem(vehicle.Name, vehicle.Picture.Name);
                item.SubItems.Add(vehicle.Manufacturer.Name);
                item.SubItems.Add(vehicle.Description);
                item.SubItems.Add(vehicle.Path);
                item.SubItems.Add(vehicle.Created.ToString());
                item.SubItems.Add(vehicle.Updated.ToString());
                this.listViewFiles.Items.Add(item);
            }

            // Set columns width
            foreach(ColumnHeader col in this.listViewFiles.Columns)
            {
                col.Width = -2;
            }
        }
    }
}
