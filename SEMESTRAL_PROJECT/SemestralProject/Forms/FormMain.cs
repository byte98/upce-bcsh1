using SemestralProject.Forms;
using SemestralProject.Handlers;
using SemestralProject.Persistence;
using System.Transactions;
using System.Windows.Forms;
using Windows.UI;
using Windows.UI.ViewManagement;
using Color = System.Drawing.Color;

namespace SemestralProject.Forms
{
    internal partial class FormMain : Form
    {

        /// <summary>
        /// Viewer of information systems
        /// </summary>
        private readonly ControlISView isView;

        public FormMain()
        {
            this.InitializeComponent();
            this.InitializeTopPanel();
            this.tabControlContent.Appearance = TabAppearance.FlatButtons;
            this.tabControlContent.ItemSize = new Size(0, 1);
            this.tabControlContent.SizeMode = TabSizeMode.Fixed;
            this.isView = new ControlISView();
            this.isView.Dock = DockStyle.Fill;
            this.isView.DataStorage = DataStorage.Instance;
            this.isView.FileStorage = FileStorage.Instance;
            this.panelISContent.Controls.Add(this.isView);
            this.isView.RefreshView();
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
        /// Sets correct color for selected item in top panel
        /// </summary>
        private void DisplaySelectedItem()
        {
            foreach (Control control in this.panelItemsControl.Controls)
            {
                control.ForeColor = Configuration.TextColor;
                if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked)
                    {
                        rb.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                        rb.ForeColor = Color.Black;
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
            Forms.FormAddIS dialog = new Forms.FormAddIS();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                InformationSystemsHandler.Instance.CreateInformationSystem(dialog.ISName, dialog.ISIcon.Name, dialog.ISDescription);
                this.isView.RefreshView();
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
            this.isView.RefreshView();
        }
    }
}