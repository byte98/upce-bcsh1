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
    public partial class FormAddIS : Form
    {
        public FormAddIS()
        {
            InitializeComponent();
            this.panelHeader.BackColor = Configuration.AccentColor;
            this.panelHeader.ForeColor = Configuration.TextColor;
        }

        private void FormAddIS_Deactivate(object sender, EventArgs e)
        {
            this.panelHeader.BackColor = Color.White;
        }

        private void FormAddIS_Activated(object sender, EventArgs e)
        {
            this.panelHeader.BackColor = Configuration.AccentColor;
        }
    }
}
