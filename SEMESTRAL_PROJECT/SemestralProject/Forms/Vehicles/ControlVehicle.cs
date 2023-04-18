using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Forms.Vehicles
{
    /// <summary>
    /// Class which represents control for creating and editing vehicles
    /// </summary>
    internal partial class ControlVehicle : UserControl, IControl
    {
        /// <summary>
        /// Struct which holds manufacturer to be displayed in combo box
        /// </summary>
        private struct ManufacturerItem
        {
            /// <summary>
            /// Name of manufacturer which will be displayed
            /// </summary>
            public string Name { private get; init; }

            /// <summary>
            /// Reference to manufacturer which will be displayed
            /// </summary>
            public Manufacturer Manufacturer { get; init; }

            /// <summary>
            /// Creates new item for combo box which contains manufacturer
            /// </summary>
            /// <param name="manufacturer"></param>
            public ManufacturerItem(Manufacturer manufacturer)
            {
                this.Name = manufacturer.Name;
                this.Manufacturer = manufacturer;
            }

            public override string ToString()
            {
                return this.Name;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = false;
                if (obj != null && obj is ManufacturerItem)
                {
                    ManufacturerItem item = (ManufacturerItem)obj;
                    reti = item.Manufacturer.Id == this.Manufacturer.Id;
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.Manufacturer.Id.GetHashCode();
            }
        }

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Name of vehicle
        /// </summary>
        public string VehicleName => this.textBoxName.Text;

        /// <summary>
        /// Description of vehicle
        /// </summary>
        public string VehicleDescription => this.textBoxDescription.Text;

        /// <summary>
        /// Picture of vehicle
        /// </summary>
        public Picture VehiclePicture { get; private set; }

        public Manufacturer? VehicleManufacturer {get; private set; }

        /// <summary>
        /// Creates new control for creating vehicles
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlVehicle(Context context)
        {
            this.InitializeComponent();
            this.Context = context;
            this.InitializeManufacturers();
            this.VehiclePicture = this.Context.FileStorage.GetPictureChecked(null);
            this.buttonPicture.BackgroundImage = this.VehiclePicture.GetImage();
        }

        /// <summary>
        /// Creates new control for editing vehicles
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="vehicle">Vehicle which will be edited</param>
        public ControlVehicle(Context context, Vehicle vehicle)
        {
            this.InitializeComponent();
            this.Context = context;
            this.InitializeManufacturers();
            this.textBoxName.Text = vehicle.Name;
            this.textBoxDescription.Text = vehicle.Description;
            this.VehicleManufacturer = vehicle.Manufacturer;
            this.comboBoxManufacturer.SelectedItem = new ManufacturerItem(this.VehicleManufacturer);
            this.VehiclePicture = vehicle.Picture;
            this.buttonPicture.BackgroundImage = this.VehiclePicture.GetImage();
        }

        /// <summary>
        /// Initializes combo box with all available manufacturers
        /// </summary>
        private void InitializeManufacturers()
        {
            this.comboBoxManufacturer.Items.Clear();
            foreach(Manufacturer manufacturer in this.Context.DataStorage.Manufacturers)
            {
                this.comboBoxManufacturer.Items.Add(new ManufacturerItem(manufacturer));
            }
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            FormPictureChooser dialog = new FormPictureChooser(this.Context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.SelectedIsPath)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        this.VehiclePicture = this.Context.FileStorage.AddPicture(dialog.SelectedPicture);
                    }, this.Context);
                }
                else
                {
                    this.VehiclePicture = this.Context.FileStorage.GetPictureChecked(dialog.SelectedPicture);
                }
                this.buttonPicture.BackgroundImage = this.VehiclePicture.GetImage();
            }
        }

        private void comboBoxManufacturer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBoxManufacturer.SelectedItem is ManufacturerItem)
            {
                ManufacturerItem item = (ManufacturerItem)this.comboBoxManufacturer.SelectedItem;
                this.VehicleManufacturer = item.Manufacturer;
            }
        }
    }
}
