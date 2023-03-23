using SemestralProject.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Dialogs
{
    public partial class FormIcons : Form
    {
        public FormIcons()
        {
            InitializeComponent();
            this.panelHeader.BackColor = Configuration.AccentColor;
            this.panelHeader.ForeColor = Configuration.TextColor;
        }

        private void FormIcons_Deactivate(object sender, EventArgs e)
        {
            this.panelHeader.BackColor = Color.White;
        }

        private void FormIcons_Activated(object sender, EventArgs e)
        {
            this.panelHeader.BackColor = Configuration.AccentColor;
        }
    }
}
