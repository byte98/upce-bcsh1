using SemestralProject.Controllers;
using SemestralProject.Data;
using SemestralProject.Forms;
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
        private ControlDataPictureView mapsView;

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
            this.InitializeIS();
            this.InitializeMaps();
            this.informationSystemsController = new InformationSystemsController(this.Context);
            this.mapsController = new MapsController(this.Context);
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
            this.isView.VisibleData = this.Context.DataStorage.InformationSystems.OfType<AbstractIconData>().ToList();
            this.mapsView.VisibleData = this.Context.DataStorage.Maps.OfType<AbstractPictureData>().ToList(); 
        }

        /// <summary>
        /// Refreshes viewer of information systems
        /// </summary>
        private void RefreshIsView()
        {
            this.isView.VisibleData = this.Context.DataStorage.InformationSystems.OfType<AbstractIconData>().ToList();
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
            }
        }

        private void buttonDeleteIS_Click(object sender, EventArgs e)
        {
            this.informationSystemsController.Delete();
            this.RefreshIsView();
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

        /// <summary>
        /// Refresehes viewer of maps
        /// </summary>
        private void RefreshMapView()
        {
            this.mapsView.VisibleData = this.Context.DataStorage.Maps.OfType<AbstractPictureData>().ToList();
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
            }
        }

        private void buttonDeleteMap_Click(object sender, EventArgs e)
        {
            this.mapsController.Delete();
            this.RefreshMapView();
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
    }
}