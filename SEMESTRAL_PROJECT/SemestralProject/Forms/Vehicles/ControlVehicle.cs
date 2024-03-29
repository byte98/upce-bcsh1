﻿using SemestralProject.Data;
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
        /// Structure holding all necessary information for showing all information systems in combo box
        /// </summary>
        private struct InformationSystemItem
        {
            /// <summary>
            /// Displayed name in combo box
            /// </summary>
            public string DisplayName { get; set; }

            /// <summary>
            /// Information system which combo box item represents
            /// </summary>
            public InformationSystem System { get; set; }

            /// <summary>
            /// Creates new combo box item with information system
            /// </summary>
            /// <param name="system">Information system represented by combo box item</param>
            public InformationSystemItem(InformationSystem system) : this(system.Name, system) { }

            /// <summary>
            /// Creates new combo box item with information system
            /// </summary>
            /// <param name="name">Name displayed in combo box</param>
            /// <param name="system">Information system represented by combo box item</param>
            public InformationSystemItem(string name, InformationSystem system)
            {
                this.DisplayName = name;
                this.System = system;
            }

            public override bool Equals([NotNullWhen(true)] object? obj)
            {
                bool reti = base.Equals(obj);
                if (obj != null && obj is InformationSystemItem)
                {
                    InformationSystemItem other = (InformationSystemItem)obj;
                    reti = (this.System.Id == other.System.Id);
                }
                return reti;
            }

            public override int GetHashCode()
            {
                return this.System.Id.GetHashCode();
            }

            public override string ToString()
            {
                return this.DisplayName;
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

        /// <summary>
        /// Manufacturer of vehicle
        /// </summary>
        public Manufacturer? VehicleManufacturer {get; private set; }
        
        /// <summary>
        /// Information system installed on vehicle
        /// </summary>
        public InformationSystem? VehicleInformationSystem { get; private set; }

        /// <summary>
        /// Attribute holding path to vehicle
        /// </summary>
        private string vehiclePath = string.Empty;

        /// <summary>
        /// Maximal length of visible path
        /// </summary>
        private const int PathMaxLength = 36;

        /// <summary>
        /// Path to directory with vehicle
        /// </summary>
        public string VehiclePath
        {
            get
            {
                return this.vehiclePath;
            }
            private set
            {
                this.vehiclePath = value;
                string displayName = this.vehiclePath;
                if (this.vehiclePath.StartsWith(this.rootPath))
                {
                    this.vehiclePath = this.vehiclePath.Substring(this.rootPath.Length);
                    if (this.vehiclePath.Length <= 0)
                    {
                        this.vehiclePath = new string(Path.DirectorySeparatorChar, 1);
                    }    
                }
                if (displayName.StartsWith(this.rootPath) == false)
                {
                    displayName = rootPath + this.vehiclePath;
                }
                if (displayName.Length > ControlVehicle.PathMaxLength)
                {
                    displayName = "..." + displayName.Substring(
                        displayName.Length - ControlVehicle.PathMaxLength
                    );
                }
                this.buttonPath.Text = displayName;
            }
        }

        /// <summary>
        /// Path to root directory with vehicles
        /// </summary>
        private readonly string rootPath;

        /// <summary>
        /// Creates new control for creating vehicles
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="path">Root path for vehicles</param>
        public ControlVehicle(Context context, string path)
        {
            this.InitializeComponent();
            this.Context = context;
            this.InitializeManufacturers();
            this.InitializeInformationSystems();
            this.VehiclePicture = this.Context.FileStorage.GetPictureChecked(null);
            this.buttonPicture.BackgroundImage = this.VehiclePicture.GetImage();
            this.rootPath = path;
            this.VehiclePath = this.rootPath;
        }

        /// <summary>
        /// Creates new control for editing vehicles
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="path">Path to root directory with vehicles</param>
        /// <param name="vehicle">Vehicle which will be edited</param>
        public ControlVehicle(Context context, string path, Vehicle vehicle)
        {
            this.InitializeComponent();
            this.Context = context;
            this.rootPath = path;
            this.InitializeManufacturers();
            this.InitializeInformationSystems();
            this.textBoxName.Text = vehicle.Name;
            this.textBoxDescription.Text = vehicle.Description;
            this.VehicleManufacturer = vehicle.Manufacturer;
            this.comboBoxManufacturer.SelectedItem = new ManufacturerItem(this.VehicleManufacturer);
            this.VehicleInformationSystem = vehicle.InformationSystem;
            this.comboBoxInformationSystem.SelectedItem = new InformationSystemItem(this.VehicleInformationSystem);
            this.VehiclePicture = vehicle.Picture;
            this.buttonPicture.BackgroundImage = this.VehiclePicture.GetImage();
            this.VehiclePath = vehicle.Path;
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

        /// <summary>
        /// Initializes combo box with all available information systems
        /// </summary>
        private void InitializeInformationSystems()
        {
            this.comboBoxInformationSystem.Items.Clear();
            foreach(InformationSystem system in this.Context.DataStorage.InformationSystems)
            {
                this.comboBoxInformationSystem.Items.Add(new InformationSystemItem(system));
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
                    wait.ShowDialog();
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
            if (this.comboBoxManufacturer.SelectedItem != null && this.comboBoxManufacturer.SelectedItem is ManufacturerItem)
            {
                ManufacturerItem item = (ManufacturerItem)this.comboBoxManufacturer.SelectedItem;
                this.VehicleManufacturer = item.Manufacturer;
            }
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            FormFolder dialog = new FormFolder(this.Context, this.rootPath);
            if (dialog.ShowDialog() == DialogResult.OK && dialog.SelectedPath != null && dialog.SelectedPath.Length > 0)
            {
                this.VehiclePath = dialog.SelectedPath;
            }
        }

        private void comboBoxInformationSystem_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBoxInformationSystem.SelectedItem != null && this.comboBoxInformationSystem.SelectedItem is InformationSystemItem)
            {
                InformationSystemItem item = (InformationSystemItem)this.comboBoxInformationSystem.SelectedItem;
                this.VehicleInformationSystem = item.System;
            }
        }
    }
}
