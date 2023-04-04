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
using Color = System.Drawing.Color;
namespace SemestralProject.Forms
{
    internal partial class FormMain : Form, IForm
    {
        public Context Context { get; init; }

        /// <summary>
        /// Viewer of information systems
        /// </summary>
        private ControlDataIconView isView;

        /// <summary>
        /// Controller of information systems data
        /// </summary>
        private readonly InformationSystemsController informationSystemsController;

        public FormMain(Context context)
        {
            this.Context = context;
            this.InitializeComponent();
            this.InitializeTopPanel();
            this.tabControlContent.Appearance = TabAppearance.FlatButtons;
            this.tabControlContent.ItemSize = new Size(0, 1);
            this.tabControlContent.SizeMode = TabSizeMode.Fixed;
            this.isView = new ControlDataIconView(this.Context);
            this.InitializeIS();
            this.InitializeMaps();
            this.informationSystemsController = new InformationSystemsController(this.Context);
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
            this.isView.SelectedDataChanged += new ControlDataIconView.SelectedDataChangedEventHandler(delegate (object sender, ControlDataIconView.SelectedDataChangedEventArgs args)
            {
                this.buttonInfoIS.Enabled = (args.SelectedData != null);
                this.buttonRemoveIS.Enabled = (args.SelectedData != null);
                this.buttonEditIS.Enabled = (args.SelectedData != null);
            });
            isSizeButton.DataView= this.isView;
        }

        /// <summary>
        /// Initializes maps page
        /// </summary>
        private void InitializeMaps()
        {
            /*
            this.mapsView = new ControlMapsView();
            this.mapsView.Dock = DockStyle.Fill;
            this.panelMapsContent.Controls.Add(this.mapsView);
            this.mapsView?.RefreshView();
            if (this.mapsView!= null) // Why is there this condition only Visual Studio knows (yes, without this line, warning 'it may be null' shows up)
            {
                this.mapsView.MapChangedEvent += new ControlMapsView.MapChangedEventHandler(delegate (object sender, ControlMapsView.MapChangedEventArgs args)
                {
                    this.buttonMapInfo.Enabled = (args.SelectedMap != null);
                    this.buttonMapRemove.Enabled = (args.SelectedMap != null);
                    this.buttonMapEdit.Enabled = (args.SelectedMap != null);
                });
            }
            this.controlViewSizeButtonMaps.DataView = this.mapsView;
            */
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
            this.isView.RefreshView();
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
            /*
            if (this.isView?.SelectedSystem != null)
            {
                if (MessageBox.Show(
                    "Opravdu chcete odstranit informační systém " + this.isView.SelectedSystem.Name + " ?" + Environment.NewLine + "Tato akce je nevratná.",
                    "Smazat vybraný IS",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    InformationSystemsHandler systemsHandler = InformationSystemsHandler.Instance;
                    systemsHandler.RemoveInformationSystem(this.isView.SelectedSystem);
                    this.isView.RefreshView();
                }
            }
            */
        }

        private void buttonDeleteIS_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show(
                    "Opravdu chcete odstranit všechny informační systémy? Bude odstraněno " + this.isView?.SystemsCount + " informačních systémů." + Environment.NewLine + "Tato akce je nevratná.",
                    "Smazat všechny IS",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes)
            {
                InformationSystemsHandler systemsHandler = InformationSystemsHandler.Instance;
                systemsHandler.DeleteSystems();
                this.isView?.RefreshView();
            }
            */
        }

        private void buttonEditIS_Click(object sender, EventArgs e)
        {
            if (this.isView.SelectedData != null)
            {
                this.informationSystemsController.Edit(this.isView.SelectedData);
                this.isView.RefreshView();
            }
        }

        private void buttonISSearch_Click(object sender, EventArgs e)
        {
            /*
            if (this.isView != null)
            {
                this.isView.Search = this.textBoxISSearch.Text;
                this.buttonISCancelSearch.Enabled = true;
            }
            */

        }

        private void buttonISCancelSearch_Click(object sender, EventArgs e)
        {
            /*
            if (this.isView != null)
            {
                this.isView.Search = null;
                this.isView.RefreshView();
                this.buttonISCancelSearch.Enabled = false;
            }
            */
        }

        private void buttonMapAdd_Click(object sender, EventArgs e)
        {
            /*
            FormAddMap dialog = new FormAddMap();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MapsHandler handler = MapsHandler.Instance;
                handler.CreateMap(dialog.MapName, dialog.MapDescription, dialog.MapPicture);
                this.mapsView?.RefreshView();
            }
            */
        }

        private void buttonMapInfo_Click(object sender, EventArgs e)
        {
            /*
            if (this.mapsView?.SelectedMap != null)
            {
                FormInfoMap dialog = new FormInfoMap(this.mapsView?.SelectedMap);
                dialog.ShowDialog();
            }
            */
        }

        private void buttonMapEdit_Click(object sender, EventArgs e)
        {
            /*
            if (this.mapsView?.SelectedMap != null)
            {
                FormEditMap dialog = new FormEditMap(this.mapsView.SelectedMap);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    MapsHandler handler = MapsHandler.Instance;
                    if (dialog.MapName != null && dialog.MapDescription != null && dialog.MapPicture != null)
                    {
                        handler.UpdateMap(this.mapsView.SelectedMap, dialog.MapName, dialog.MapDescription, dialog.MapPicture);
                        this.mapsView.RefreshView();
                    }
                }
            }
            */
        }

        private void buttonMapRemove_Click(object sender, EventArgs e)
        {
            /*
            if (this.mapsView?.SelectedMap != null)
            {
                if (MessageBox.Show("Opravdu chcete odstranit oblast " + this.mapsView.SelectedMap.Name + "?" + Environment.NewLine + "Tato akce je nevratná.", "Odstranit oblast", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MapsHandler handler = MapsHandler.Instance;
                    handler.RemoveMap(this.mapsView.SelectedMap);
                    this.mapsView.RefreshView();
                }
            }
            */
        }

        private void buttonMapDelete_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("Opravdu chcete odstranit všechny oblasti?" + Environment.NewLine + "Počet oblastí k odstranění: " + this.mapsView?.MapsCount + Environment.NewLine + "Tato akce je nevratná.", "Smazat všechny oblasti", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MapsHandler handler = MapsHandler.Instance;
                handler.DeleteMaps();
                this.mapsView?.RefreshView();
            }
            */
        }

        private void buttonMapSearch_Click(object sender, EventArgs e)
        {
            /*
            if (this.mapsView != null)
            {
                this.mapsView.Search = this.textBoxMapSearch.Text;
                this.buttonMapCancelSearch.Enabled = true;
            }
            */
        }

        private void buttonMapCancelSearch_Click(object sender, EventArgs e)
        {
            /*
            if (this.mapsView != null)
            {
                this.mapsView.Search = null;
                this.buttonMapCancelSearch.Enabled = false;
            }
            */
        }
    }
}