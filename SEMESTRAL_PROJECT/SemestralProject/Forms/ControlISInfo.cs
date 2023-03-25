using SemestralProject.Data;
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
    internal partial class ControlISInfo : UserControl
    {
        /// <summary>
        /// Information system visible in control
        /// </summary>
        public InformationSystem? InformationSystem
        {
            private get
            {
                return InformationSystem;
            }
            set
            {
                this.InformationSystem = value;
                this.InitializeInformationSystem();
            }
        }

        /// <summary>
        /// Creates new content of information dialog
        /// </summary>
        public ControlISInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes content of dialog for set information system
        /// </summary>
        private void InitializeInformationSystem()
        {
            if (this.InformationSystem != null)
            {
                this.pictureBoxIcon.Image = this.InformationSystem.Icon.GetImage();
                this.labelName.Text = this.InformationSystem.Name;
                this.textBoxDescription.Text = this.InformationSystem.Description;
                this.textBoxCreated.Text = this.InformationSystem.Created.ToString();
                this.textBoxUpdated.Text = this.InformationSystem.Updated.ToString();
            }
        }
    }
}
