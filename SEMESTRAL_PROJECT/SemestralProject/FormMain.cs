using System.Transactions;
using System.Windows.Forms;
using Windows.UI;
using Windows.UI.ViewManagement;
using Color = System.Drawing.Color;

namespace SemestralProject
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Actual accent color of system
        /// </summary>
        public static Color AccentColor
        {
            get
            {
                var uiSettings = new UISettings();
                var accent = uiSettings.GetColorValue(UIColorType.Accent);
                return Color.FromArgb(accent.A, accent.R, accent.G, accent.B);
            }
        }

        /// <summary>
        /// Actual text color according to accent color
        /// </summary>
        public static Color TextColor
        {
            get
            {
                Color accent = FormMain.AccentColor;
                int colorNr = accent.R * accent.G * accent.B;
                Color reti = Color.Black;
                if (colorNr < (127 * 127 * 127))
                {
                    reti = Color.White;
                }
                return reti;
            }
        }

        public FormMain()
        {
            this.InitializeComponent();
            this.InitializeTopPanel();
            this.tabControlContent.Appearance = TabAppearance.FlatButtons;
            this.tabControlContent.ItemSize = new Size(0, 1);
            this.tabControlContent.SizeMode = TabSizeMode.Fixed;
        }

        /// <summary>
        /// Initializes top panel
        /// </summary>
        private void InitializeTopPanel()
        {
            this.panelItemsControl.BackColor = FormMain.AccentColor;
            this.DisplaySelectedItem();
        }

        /// <summary>
        /// Sets correct color for selected item in top panel
        /// </summary>
        private void DisplaySelectedItem()
        {
            foreach (Control control in this.panelItemsControl.Controls)
            {
                control.ForeColor = FormMain.TextColor;
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
            Dialogs.FormAddIS dialog = new Dialogs.FormAddIS();
            dialog.ShowDialog();
        }

        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            this.panelItemsControl.BackColor = Color.White;
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            this.panelItemsControl.BackColor = FormMain.AccentColor;
        }
    }
}