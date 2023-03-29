using SemestralProject.Forms;
using SemestralProject.Handlers;
using SemestralProject.Persistence;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Windows.Forms;
using Windows.UI;
using Windows.UI.ViewManagement;
using Color = System.Drawing.Color;
using SemestralProject.Forms.InformationSystems;
using SemestralProject.Forms.Maps;

namespace SemestralProject.Forms
{
    internal partial class FormMain : Form
    {

        /// <summary>
        /// Viewer of information systems
        /// </summary>
        private ControlISView? isView;

        /// <summary>
        /// Viewer of maps
        /// </summary>
        private ControlMapsView? mapsView;

        public FormMain()
        {
            this.InitializeComponent();
            this.InitializeTopPanel();
            this.tabControlContent.Appearance = TabAppearance.FlatButtons;
            this.tabControlContent.ItemSize = new Size(0, 1);
            this.tabControlContent.SizeMode = TabSizeMode.Fixed;
            this.InitializeIS();
            this.InitializeMaps();
        }

        /// <summary>
        /// Initializes top panel
        /// </summary>
        private void InitializeTopPanel()
        {
            this.panelItemsControl.BackColor = Configuration.AccentColor;
            this.DisplaySelectedItem();
        }

        /// <summary>
        /// Initializes information systems page
        /// </summary>
        private void InitializeIS()
        {
            this.isView = new ControlISView();
            this.isView.Dock = DockStyle.Fill;
            this.isView.DataStorage = DataStorage.Instance;
            this.isView.FileStorage = FileStorage.Instance;
            this.panelISContent.Controls.Add(this.isView);
            this.isView.RefreshView();
            this.isView.ISChanged += new ControlISView.ISChangedEventHandler(delegate (object sender, ControlISView.ISChangedEventArgs args)
            {
                this.buttonInfoIS.Enabled = (args.SelectedSystem != null);
                this.buttonRemoveIS.Enabled = (args.SelectedSystem != null);
                this.buttonEditIS.Enabled = (args.SelectedSystem != null);
            });
            this.controlViewSizeButtonIS.DataView = this.isView;
        }

        /// <summary>
        /// Initializes maps page
        /// </summary>
        private void InitializeMaps()
        {
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
        }

        /// <summary>
        /// Sets correct color for selected item in top panel
        /// </summary>
        private void DisplaySelectedItem()
        {
            foreach (Control control in this.panelItemsControl.Controls)
            {
                control.ForeColor = Configuration.TextColor;
                control.BackColor = Configuration.AccentColor;
                if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked)
                    {
                        rb.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                        rb.ForeColor = Color.Black;
                        switch(rb.Text.Trim().ToUpper())
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
            FormAddIS dialog = new FormAddIS();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                InformationSystemsHandler.Instance.CreateInformationSystem(dialog.ISName, dialog.ISIcon.Name, dialog.ISDescription);
                this.isView?.RefreshView();
            }
        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            this.panelItemsControl.BackColor = Color.White;
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            this.panelItemsControl.BackColor = Configuration.AccentColor;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLoad form = new FormLoad(this);
            this.Hide();
            form.ShowDialog();
            this.isView?.RefreshView();
            this.mapsView?.RefreshView();
        }

        private void buttonInfoIS_Click(object sender, EventArgs e)
        {
            if (this.isView?.SelectedSystem != null)
            {
                FormISInfo dialog = new FormISInfo(this.isView.SelectedSystem);
                dialog.ShowDialog();
            }
        }

        private void buttonRemoveIS_Click(object sender, EventArgs e)
        {
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
        }

        private void buttonDeleteIS_Click(object sender, EventArgs e)
        {
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
        }

        private void buttonEditIS_Click(object sender, EventArgs e)
        {
            if (this.isView?.SelectedSystem != null)
            {
                FormEditIS form = new FormEditIS(this.isView.SelectedSystem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    InformationSystemsHandler systemsHandler = InformationSystemsHandler.Instance;
                    systemsHandler.EditInformationSystem(this.isView.SelectedSystem, form.ISName, form.ISIcon, form.ISDescription);
                    this.isView?.RefreshView();
                }
            }
        }

        private void buttonISSearch_Click(object sender, EventArgs e)
        {
            if (this.isView != null)
            {
                this.isView.Search = this.textBoxISSearch.Text;
                this.buttonISCancelSearch.Enabled = true;
            }

        }

        private void buttonISCancelSearch_Click(object sender, EventArgs e)
        {
            if (this.isView != null)
            {
                this.isView.Search = null;
                this.isView.RefreshView();
                this.buttonISCancelSearch.Enabled = false;
            }
        }

        private void buttonMapAdd_Click(object sender, EventArgs e)
        {
            FormAddMap dialog = new FormAddMap();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MapsHandler handler = MapsHandler.Instance;
                handler.CreateMap(dialog.MapName, dialog.MapDescription, dialog.MapPicture);
                this.mapsView?.RefreshView();
            }
        }

        private void buttonMapInfo_Click(object sender, EventArgs e)
        {
            if (this.mapsView?.SelectedMap != null)
            {
                FormInfoMap dialog = new FormInfoMap(this.mapsView?.SelectedMap);
                dialog.ShowDialog();
            }
        }

        private void buttonMapEdit_Click(object sender, EventArgs e)
        {
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
        }

        private void buttonMapRemove_Click(object sender, EventArgs e)
        {
            if (this.mapsView?.SelectedMap != null)
            {
                if (MessageBox.Show("Opravdu chcete odstranit oblast " + this.mapsView.SelectedMap.Name + "?" + Environment.NewLine + "Tato akce je nevratná.", "Odstranit oblast", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MapsHandler handler = MapsHandler.Instance;
                    handler.RemoveMap(this.mapsView.SelectedMap);
                    this.mapsView.RefreshView();
                }
            }
        }

        private void buttonMapDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu chcete odstranit všechny oblasti?" + Environment.NewLine + "Počet oblastí k odstranění: " + this.mapsView?.MapsCount + Environment.NewLine + "Tato akce je nevratná.", "Smazat všechny oblasti", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MapsHandler handler = MapsHandler.Instance;
                handler.DeleteMaps();
                this.mapsView?.RefreshView();
            }
        }

        private void buttonMapSearch_Click(object sender, EventArgs e)
        {
            if (this.mapsView != null)
            {
                this.mapsView.Search = this.textBoxMapSearch.Text;
                this.buttonMapCancelSearch.Enabled = true;
            }
        }

        private void buttonMapCancelSearch_Click(object sender, EventArgs e)
        {
            if (this.mapsView != null)
            {
                this.mapsView.Search = null;
                this.buttonMapCancelSearch.Enabled = false;
            }
        }
    }
}