using SemestralProject.Controllers;
using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Forms.DataFiles;
using SemestralProject.Forms.Manufacturers;
using SemestralProject.Persistence;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Windows.Forms;
using Windows.UI;
using Windows.UI.ViewManagement;
using static SemestralProject.Visual.IAbstractDataView;
using Color = System.Drawing.Color;
namespace SemestralProject.Forms
{
    internal partial class FormMain : Form, IForm
    {
        public Context Context { get; init; }

        /// <summary>
        /// Viewer of information systems
        /// </summary>
        private readonly ControlDataIconView isView;

        /// <summary>
        /// Controller of information systems data
        /// </summary>
        private readonly InformationSystemsController informationSystemsController;

        /// <summary>
        /// Controller of maps data
        /// </summary>
        private readonly MapsController mapsController;

        /// <summary>
        /// Viewer of maps
        /// </summary>
        private readonly ControlDataPictureView mapsView;

        /// <summary>
        /// Controller of manufacturers data
        /// </summary>
        private readonly ManufacturersController manufacturersController;

        /// <summary>
        /// Viewer of manufacturers
        /// </summary>
        private readonly ControlDataIconView manView;

        /// <summary>
        /// Controller of vehicles data
        /// </summary>
        private readonly VehiclesController vehiclesController;

        /// <summary>
        /// Viewer of vehicles
        /// </summary>
        private readonly ControlDataPictureView vehicleView;

        /// <summary>
        /// Controller of data files
        /// </summary>
        private readonly FilesController filesController;

        /// <summary>
        /// Viewer of data files
        /// </summary>
        private readonly ControlDataFileView fileView;

        /// <summary>
        /// Controller of actions page
        /// </summary>
        private readonly ActionsController actionsController;

        /// <summary>
        /// Creates new main form of application
        /// </summary>
        /// <param name="context">Wrapper of all application resources</param>
        public FormMain(Context context)
        {
            this.Context = context;
            this.InitializeComponent();
            this.InitializeTopPanel();
            this.tabControlContent.Appearance = TabAppearance.FlatButtons;
            this.tabControlContent.ItemSize = new Size(0, 1);
            this.tabControlContent.SizeMode = TabSizeMode.Fixed;
            this.isView = new ControlDataIconView(this.Context);
            this.mapsView = new ControlDataPictureView(this.Context);
            this.manView = new ControlDataIconView(this.Context);
            this.vehicleView = new ControlDataPictureView(this.Context);
            this.fileView = new ControlDataFileView(this.Context);
            this.InitializeIS();
            this.InitializeMaps();
            this.InitializeManufacturers();
            this.InitializeVehicles();
            this.InitializeDataFiles();
            this.informationSystemsController = new InformationSystemsController(this.Context);
            this.mapsController = new MapsController(this.Context);
            this.manufacturersController = new ManufacturersController(this.Context);
            this.vehiclesController = new VehiclesController(this.Context);
            this.filesController = new FilesController(this.Context);
            this.actionsController = new ActionsController(this.Context, this);
        }

        /// <summary>
        /// Initializes top panel
        /// </summary>
        private void InitializeTopPanel()
        {
            if (this.Context != null)
            {
                this.panelItemsControl.BackColor = this.Context.Configuration.AccentColor;
            }
            this.DisplaySelectedItem();
        }

        /// <summary>
        /// Initializes information systems page
        /// </summary>
        private void InitializeIS()
        {
            this.isView.Dock = DockStyle.Fill;
            this.panelISContent.Controls.Add(this.isView);
            ControlViewSizeButton isSizeButton = new ControlViewSizeButton(this.Context);
            this.panelISSizeButton.Controls.Add(isSizeButton);
            isSizeButton.Dock = DockStyle.Fill;
            this.isView.SelectedDataChanged += new SelectedDataChangedEventHandler(delegate (object sender, SelectedDataChangedEventArgs args)
            {
                this.buttonInfoIS.Enabled = (args.SelectedData != null);
                this.buttonRemoveIS.Enabled = (args.SelectedData != null);
                this.buttonEditIS.Enabled = (args.SelectedData != null);
            });
            isSizeButton.DataView = this.isView;
        }

        /// <summary>
        /// Initializes maps page
        /// </summary>
        private void InitializeMaps()
        {
            this.mapsView.Dock = DockStyle.Fill;
            this.panelMapContent.Controls.Add(this.mapsView);
            ControlViewSizeButton mapSizeButton = new ControlViewSizeButton(this.Context);
            this.panelMapSizeButton.Controls.Add(mapSizeButton);
            mapSizeButton.Dock = DockStyle.Fill;
            this.mapsView.SelectedDataChanged += new SelectedDataChangedEventHandler(delegate (object sender, SelectedDataChangedEventArgs args)
            {
                this.buttonInfoMap.Enabled = (args.SelectedData != null);
                this.buttonRemoveMap.Enabled = (args.SelectedData != null);
                this.buttonEditMap.Enabled = (args.SelectedData != null);
            });
            mapSizeButton.DataView = this.mapsView;
        }

        /// <summary>
        /// Initializes manufacturers page
        /// </summary>
        private void InitializeManufacturers()
        {
            this.manView.Dock = DockStyle.Fill;
            this.panelManufacturerContent.Controls.Add(this.manView);
            ControlViewSizeButton manSizeButton = new ControlViewSizeButton(this.Context);
            this.panelManufacturerSizeControl.Controls.Add(manSizeButton);
            manSizeButton.Dock = DockStyle.Fill;
            this.manView.SelectedDataChanged += new SelectedDataChangedEventHandler(delegate (object sender, SelectedDataChangedEventArgs args)
            {
                this.buttonInfoManufacturer.Enabled = (args.SelectedData != null);
                this.buttonRemoveManufacturer.Enabled = (args.SelectedData != null);
                this.buttonEditManufacturer.Enabled = (args.SelectedData != null);
            });
            manSizeButton.DataView = this.manView;
        }

        /// <summary>
        /// Initializes vehicles page
        /// </summary>
        private void InitializeVehicles()
        {
            this.vehicleView.Dock = DockStyle.Fill;
            this.panelVehicleContent.Controls.Add(this.vehicleView);
            ControlViewSizeButton vehicleSizeButton = new ControlViewSizeButton(this.Context);
            this.panelVehicleSizeButton.Controls.Add(vehicleSizeButton);
            vehicleSizeButton.Dock = DockStyle.Fill;
            this.vehicleView.SelectedDataChanged += new SelectedDataChangedEventHandler(delegate (object sender, SelectedDataChangedEventArgs args)
            {
                this.buttonInfoVehicle.Enabled = (args.SelectedData != null);
                this.buttonRemoveVehicle.Enabled = (args.SelectedData != null);
                this.buttonEditVehicle.Enabled = (args.SelectedData!= null);
            });
            vehicleSizeButton.DataView = this.vehicleView;
        }

        /// <summary>
        /// Initializes data files page
        /// </summary>
        private void InitializeDataFiles()
        {
            this.fileView.Dock = DockStyle.Fill;
            this.panelFileContent.Controls.Add(this.fileView);
            ControlViewSizeButton fileSizeButton = new ControlViewSizeButton(this.Context);
            this.panelFileSizeControl.Controls.Add(fileSizeButton);
            fileSizeButton.Dock = DockStyle.Fill;
            this.fileView.SelectedDataChanged += new SelectedDataChangedEventHandler(delegate (object sender, SelectedDataChangedEventArgs args)
            {
                this.buttonInfoFile.Enabled = (args.SelectedData != null);
                this.buttonRemoveFile.Enabled = (args.SelectedData != null);
                this.buttonEditFile.Enabled = (args.SelectedData != null);
            });
            fileSizeButton.DataView = this.fileView;
        }

        /// <summary>
        /// Sets correct color for selected item in top panel
        /// </summary>
        private void DisplaySelectedItem()
        {
            foreach (Control control in this.panelItemsControl.Controls)
            {
                control.ForeColor = this.Context.Configuration.TextColor;
                control.BackColor = this.Context.Configuration.AccentColor;
                if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked)
                    {
                        rb.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                        rb.ForeColor = Color.Black;
                        switch (rb.Text.Trim().ToUpper())
                        {
                            case "INFORMAČNÍ SYSTÉMY": this.tabControlContent.SelectedTab = this.tabPageIS; break;
                            case "OBLASTI": this.tabControlContent.SelectedTab = this.tabPageMaps; break;
                            case "VÝROBCI": this.tabControlContent.SelectedTab = this.tabPageManufacturers; break;
                            case "VOZIDLA": this.tabControlContent.SelectedTab = this.tabPageVehicles; break;
                            case "SOUBORY": this.tabControlContent.SelectedTab = this.tabPageFiles; break;
                            case "AKCE":    this.tabControlContent.SelectedTab = this.tabPageActions; break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles click on item in top panel
        /// </summary>
        private void PanelItemsControlItemClicked(object sender, EventArgs e)
        {
            this.DisplaySelectedItem();
        }

        private void buttonAddIS_Click(object sender, EventArgs e)
        {
            this.informationSystemsController.Create();
            this.RefreshIsView();
        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            this.panelItemsControl.BackColor = Color.White;
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            
            this.panelItemsControl.BackColor = this.Context.Configuration.AccentColor;
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLoad form = new FormLoad(this, this.Context);
            this.Hide();
            form.ShowDialog();
            this.RefreshIsView();
            this.RefreshMapView();
            this.RefreshManView();
            this.RefreshVehicleView();
            this.RefreshFileView();
            this.textBoxActionsGeneralVehiclesFolderActual.Text = Path.GetFullPath(this.Context.Configuration.VehiclesRoot);
        }

        /// <summary>
        /// Refreshes all data views
        /// </summary>
        public void RefreshViews()
        {
            this.RefreshIsView();
            this.RefreshMapView();
            this.RefreshManView();
            this.RefreshVehicleView();
            this.RefreshFileView();
        }

        #region Information Systems
        /// <summary>
        /// Refreshes viewer of information systems
        /// </summary>
        private void RefreshIsView()
        {
            this.isView.VisibleData = this.Context.DataStorage.InformationSystems.OfType<AbstractIconData>().ToList();
            this.isView.Unselect();
        }
        

        private void buttonInfoIS_Click(object sender, EventArgs e)
        {
            if (this.isView.SelectedData != null)
            {
                this.informationSystemsController.Info(this.isView.SelectedData);
            }
        }

        private void buttonRemoveIS_Click(object sender, EventArgs e)
        {
            if (this.isView.SelectedData != null)
            {
                this.informationSystemsController.Remove(this.isView.SelectedData);
                this.RefreshIsView();
                this.RefreshFileView();
                this.RefreshVehicleView();
            }
        }

        private void buttonDeleteIS_Click(object sender, EventArgs e)
        {
            this.informationSystemsController.Delete();
            this.RefreshIsView();
            this.RefreshFileView();
            this.RefreshVehicleView();
        }

        private void buttonEditIS_Click(object sender, EventArgs e)
        {
            if (this.isView.SelectedData != null)
            {
                this.informationSystemsController.Edit(this.isView.SelectedData);
                this.RefreshIsView();
            }
        }

        private void buttonISSearch_Click(object sender, EventArgs e)
        {
            this.isView.VisibleData = this.informationSystemsController.Search(this.textBoxISSearch.Text).OfType<AbstractIconData>().ToList();
            this.buttonISCancelSearch.Enabled = true;
        }

        private void buttonISCancelSearch_Click(object sender, EventArgs e)
        {
            this.isView.VisibleData = this.Context.DataStorage.InformationSystems.OfType<AbstractIconData>().ToList();
            this.buttonISCancelSearch.Enabled = false;
            this.textBoxISSearch.Text = string.Empty;
        }
        #endregion

        #region Maps
        /// <summary>
        /// Refresehes viewer of maps
        /// </summary>
        private void RefreshMapView()
        {
            this.mapsView.VisibleData = this.Context.DataStorage.Maps.OfType<AbstractPictureData>().ToList();
            this.mapsView.Unselect();
        }

        private void buttonAddMap_Click(object sender, EventArgs e)
        {
            this.mapsController.Create();
            this.RefreshMapView();
        }

        private void buttonInfoMap_Click(object sender, EventArgs e)
        {
            if (this.mapsView.SelectedData != null)
            {
                this.mapsController.Info(this.mapsView.SelectedData);
            }
        }

        private void buttonEditMap_Click(object sender, EventArgs e)
        {
            if (this.mapsView.SelectedData != null)
            {
                this.mapsController.Edit(this.mapsView.SelectedData);
                this.RefreshMapView();
            }
        }

        private void buttonRemoveMap_Click(object sender, EventArgs e)
        {
            if (this.mapsView.SelectedData != null)
            {
                this.mapsController.Remove(this.mapsView.SelectedData);
                this.RefreshMapView();
                this.RefreshFileView();
            }
        }

        private void buttonDeleteMap_Click(object sender, EventArgs e)
        {
            this.mapsController.Delete();
            this.RefreshMapView();
            this.RefreshFileView();
        }

        private void buttonMapSearch_Click(object sender, EventArgs e)
        {
            this.mapsView.VisibleData = this.mapsController.Search(this.textBoxMapSearch.Text).OfType<AbstractPictureData>().ToList();
            this.buttonMapCancelSearch.Enabled = true;
        }

        private void buttonMapCancelSearch_Click(object sender, EventArgs e)
        {
            this.RefreshMapView();
            this.textBoxMapSearch.Text = string.Empty;
            this.buttonMapCancelSearch.Enabled = false;
        }
        #endregion

        #region Manufacturers
        /// <summary>
        /// Refreshes viewer of all available manufacturers
        /// </summary>
        private void RefreshManView()
        {
            this.manView.VisibleData = this.Context.DataStorage.Manufacturers.OfType<AbstractIconData>().ToList();
            this.manView.Unselect();
        }

        private void buttonAddManufacturer_Click(object sender, EventArgs e)
        {
            this.manufacturersController.Create();
            this.RefreshManView();
        }

        private void buttonInfoManufacturer_Click(object sender, EventArgs e)
        {
            if (this.manView.SelectedData != null)
            {
                this.manufacturersController.Info(this.manView.SelectedData);
            }
        }

        private void buttonEditManufacturer_Click(object sender, EventArgs e)
        {
            if (this.manView.SelectedData != null)
            {
                this.manufacturersController.Edit(this.manView.SelectedData);
                this.RefreshManView();
            }
        }

        private void buttonRemoveManufacturer_Click(object sender, EventArgs e)
        {
            if (this.manView.SelectedData != null)
            {
                this.manufacturersController.Remove(this.manView.SelectedData);
                this.RefreshManView();
                this.RefreshVehicleView();
            }
        }

        private void buttonDeleteManufacturer_Click(object sender, EventArgs e)
        {
            this.manufacturersController.Delete();
            this.RefreshManView();
            this.RefreshVehicleView();
        }

        private void buttonManufacturerSearch_Click(object sender, EventArgs e)
        {
            this.manView.VisibleData = this.manufacturersController.Search(this.textBoxManufacturerSearch.Text).OfType<AbstractIconData>().ToList();
            this.buttonManufacturerCancelSearch.Enabled = true;
        }

        private void buttonManufacturerCancelSearch_Click(object sender, EventArgs e)
        {
            this.textBoxManufacturerSearch.Text = string.Empty;
            this.buttonManufacturerCancelSearch.Enabled = false;
            this.RefreshManView();
        }
        #endregion

        #region Vehicles
        /// <summary>
        /// Refreshes viewer of vehicles
        /// </summary>
        private void RefreshVehicleView()
        {
            this.vehicleView.VisibleData = this.Context.DataStorage.Vehicles.OfType<AbstractPictureData>().ToList();
            this.vehicleView.Unselect();
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            this.vehiclesController.Create();
            this.RefreshVehicleView();
        }

        private void buttonEditVehicle_Click(object sender, EventArgs e)
        {
            if (this.vehicleView.SelectedData != null)
            {
                this.vehiclesController.Edit(this.vehicleView.SelectedData);
                this.RefreshVehicleView();
            }
        }

        private void buttonInfoVehicle_Click(object sender, EventArgs e)
        {
            if (this.vehicleView.SelectedData != null)
            {
                this.vehiclesController.Info(this.vehicleView.SelectedData);
            }
        }

        private void buttonRemoveVehicle_Click(object sender, EventArgs e)
        {
            if (this.vehicleView.SelectedData != null)
            {
                this.vehiclesController.Remove(this.vehicleView.SelectedData);
                this.RefreshVehicleView();
            }
        }

        private void buttonDeleteVehicle_Click(object sender, EventArgs e)
        {
            this.vehiclesController.Delete();
            this.RefreshVehicleView();
        }

        private void buttonVehicleSearch_Click(object sender, EventArgs e)
        {
            this.vehicleView.VisibleData = this.vehiclesController.Search(this.textBoxVehicleSearch.Text).OfType<AbstractPictureData>().ToList();
            this.buttonVehicleCancelSearch.Enabled = true;
        }

        private void buttonVehicleCancelSearch_Click(object sender, EventArgs e)
        {
            this.textBoxVehicleSearch.Text = string.Empty;
            this.buttonVehicleCancelSearch.Enabled = false;
            this.RefreshVehicleView();
        }
        #endregion

        #region Files
        /// <summary>
        /// Refreshes data files viewer to show all available data files
        /// </summary>
        private void RefreshFileView()
        {
            this.fileView.VisibleData = this.Context.DataStorage.DataFiles;
            this.fileView.Unselect();
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            this.filesController.Create();
            this.RefreshFileView();
        }

        private void buttonInfoFile_Click(object sender, EventArgs e)
        {
            if (this.fileView.SelectedData != null)
            {
                this.filesController.Info(this.fileView.SelectedData);
            }
        }
        
        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            if (this.fileView.SelectedData != null)
            {
                this.filesController.Edit(this.fileView.SelectedData);
                this.RefreshFileView();
            }
        }

        private void buttonRemoveFile_Click(object sender, EventArgs e)
        {
            if (this.fileView.SelectedData != null)
            {
                this.filesController.Remove(this.fileView.SelectedData);
                this.RefreshFileView();
            }
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            this.filesController.Delete();
            this.RefreshFileView();
        }

        private void buttonFileSearch_Click(object sender, EventArgs e)
        {
            this.fileView.VisibleData = this.filesController.Search(this.textBoxFileSearch.Text);
            this.buttonFileCancelSearch.Enabled = true;
        }

        private void buttonFileCancelSearch_Click(object sender, EventArgs e)
        {
            this.buttonFileCancelSearch.Enabled = false;
            this.textBoxFileSearch.Text = string.Empty;
            this.RefreshFileView();
        }
        #endregion

        private void buttonActionsExport_Click(object sender, EventArgs e)
        {
            this.saveFileDialogExport.InitialDirectory = Directory.GetCurrentDirectory();
            if (this.saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                this.actionsController.Export(this.saveFileDialogExport.FileName);
            }
        }

        private void buttonActionsImport_Click(object sender, EventArgs e)
        {
            this.openFileDialogImport.InitialDirectory = Directory.GetCurrentDirectory();
            if (this.openFileDialogImport.ShowDialog() == DialogResult.OK)
            {
                this.actionsController.Import(this.openFileDialogImport.FileName);
            }
        }

        private void buttonActionCopy_Click(object sender, EventArgs e)
        {
            this.actionsController.Copy();
        }

        private void buttonActionCopyReplace_Click(object sender, EventArgs e)
        {
            this.actionsController.Copy(true);
        }

        private void buttonActionsGeneralVehiclesFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialogVehicles.SelectedPath = Path.GetFullPath(this.Context.Configuration.VehiclesRoot);
            this.folderBrowserDialogVehicles.InitialDirectory = Path.GetFullPath(this.Context.Configuration.VehiclesRoot);

            if (this.folderBrowserDialogVehicles.ShowDialog() == DialogResult.OK)
            {
                this.actionsController.SetVehiclesFolder(this.folderBrowserDialogVehicles.SelectedPath);
                this.textBoxActionsGeneralVehiclesFolderActual.Text = Path.GetFullPath(this.Context.Configuration.VehiclesRoot);
            }
        }

        private void buttonActionsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete smazat všechna uložená data a soubory?" + Environment.NewLine + 
                "Tato akce je nevratná.", "Smazat vše", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.actionsController.DeleteAll();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Context.Configuration.DeleteTemp();
        }
    }
}