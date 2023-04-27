using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Forms.Vehicles
{
    /// <summary>
    /// Class which represents viewer of details of vehicle
    /// </summary>
    internal partial class ControlVehicleView : UserControl, IControl
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Maximal length of displayed path
        /// </summary>
        private const int PathMaxLength = 16;

        /// <summary>
        /// Path to vehicle
        /// </summary>
        private readonly string path;

        /// <summary>
        /// Creates new detail viewer of vehcile
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="vehicle">Vehicle which will be viewed</param>
        public ControlVehicleView(Context context, Vehicle vehicle)
        {
            InitializeComponent();
            this.Context = context;
            this.pictureBoxImage.Image = vehicle.Picture.GetImage();
            this.pictureBoxManufacturer.Image = vehicle.Manufacturer.Icon.GetImage();
            this.textBoxManufacturer.Text = vehicle.Manufacturer.Name;
            this.pictureBoxInformationSystem.Image = vehicle.InformationSystem.Icon.GetImage();
            this.textBoxInformationSystem.Text = vehicle.InformationSystem.Name;
            string vehiclePath = vehicle.Path;
            if (vehiclePath.StartsWith(this.Context.Configuration.VehiclesRoot) == false)
            {
                vehiclePath = Path.GetFullPath(this.Context.Configuration.VehiclesRoot + Path.DirectorySeparatorChar + vehicle.Path);
            }
            this.path = vehiclePath;
            this.textBoxPath.Text = this.path;
            if (this.textBoxPath.Text.Length > ControlVehicleView.PathMaxLength)
            {
                this.textBoxPath.Text = "..." + this.textBoxPath.Text.Substring(this.textBoxPath.Text.Length - ControlVehicleView.PathMaxLength);
            }
            this.labelName.Text = vehicle.Name;
            this.textBoxDescription.Text = vehicle.Description;
            this.textBoxCreated.Text = vehicle.Created.ToString();
            this.textBoxUpdated.Text = vehicle.Updated.ToString();
            
        }

        private void buttonExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", this.path);
        }
    }
}
