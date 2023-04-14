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

        }

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Creates new control for creating vehicles
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlVehicle(Context context)
        {
            this.InitializeComponent();
            this.Context = context;
            this.InitializeManufacturers();
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
            this.buttonPicture.Image = vehicle.Picture.GetImage();
            this.comboBoxManufacturer.SelectedItem = new ManufacturerItem(vehicle.Manufacturer);
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
    }
}
