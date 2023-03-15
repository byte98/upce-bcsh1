using System.Windows.Forms;
using Windows.UI;
using Windows.UI.ViewManagement;
using Color = System.Drawing.Color;

namespace SemestralProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            this.InitializeComponent();
            var uiSettings = new UISettings();
            var accent = uiSettings.GetColorValue(UIColorType.Accent);
            this.BackColor = Color.FromArgb(accent.A, accent.R, accent.G, accent.B);
        }
    }
}