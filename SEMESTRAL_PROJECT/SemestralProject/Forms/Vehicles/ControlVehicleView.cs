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
        /// Creates new detail viewer of vehcile
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="vehicle">Vehicle which will be viewed</param>
        public ControlVehicleView(Context context, Vehicle vehicle)
        {
            InitializeComponent();
            this.Context = context;
            this.pictureBoxImage.Image = vehicle.Picture.GetImage();
            this.pictureBoxManufacturerIcon.Image = vehicle.Manufacturer.Icon.GetImage();
            this.textBoxManufacturer.Text = vehicle.Manufacturer.Name;
            this.textBoxPath.Text = vehicle.Path;
            this.labelName.Text = vehicle.Name;
            this.textBoxDescription.Text = vehicle.Description;
            this.textBoxCreated.Text = vehicle.Created.ToString();
            this.textBoxUpdated.Text = vehicle.Updated.ToString();
        }

        private void textBoxPath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.GetFullPath(this.textBoxPath.Text));
        }
    }
}
