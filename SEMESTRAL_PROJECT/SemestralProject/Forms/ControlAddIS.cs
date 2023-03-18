using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Forms
{
    public partial class ControlAddIS : UserControl
    {
        /// <summary>
        /// Name of information system
        /// </summary>
        public string ISName
        {
            get
            {
                return this.textBoxName.Text;
            }
            set
            {
                this.textBoxName.Text = value;
            }
        }

        /// <summary>
        /// Description of information system
        /// </summary>
        public string ISDescription
        {
            get
            {
                return this.textBoxDescription.Text;
            }
            set
            {
                this.textBoxDescription.Text = value;
            }
        }
        public ControlAddIS()
        {
            InitializeComponent();
        }

        private void buttonIcon_Click(object sender, EventArgs e)
        {
            Forms.FormIconChooser dialog = new Forms.FormIconChooser();
            dialog.ShowDialog();
        }
    }
}
