using SemestralProject.Persistence;
using SemestralProject.Utils;
using SemestralProject.Visual;
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
    /// <summary>
    /// Class representing control which informs about import/export process
    /// </summary>
    internal partial class ControlExportImport : UserControl, IControl
    {

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context{get; init;}

        /// <summary>
        /// Label holding actual state
        /// </summary>
        public Label ContentState => this.labelState;

        /// <summary>
        /// Progress bar showing actual progress of process
        /// </summary>
        public ProgressBar ContentProgress => this.progressBar;

        /// <summary>
        /// Text box displaying log of progress
        /// </summary>
        public TextBox ContentLog => this.textBoxDetails;

        /// <summary>
        /// Creates new control for informaing about import/export process
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlExportImport(Context context)
        {
            this.Context = context;
            InitializeComponent();
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            if (this.textBoxDetails.Visible)
            {
                this.textBoxDetails.Visible = false;
                this.Size = new Size(960, 115);
                this.buttonShowDetails.Text = "Zobrazit podrobnosti";
            }
            else
            {
                this.textBoxDetails.Visible = true;
                this.Size = new Size(960, 380);
                this.buttonShowDetails.Text = "Skrýt podrobnosti";
            }
        }
    }
}
