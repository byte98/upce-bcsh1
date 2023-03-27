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

namespace SemestralProject.Forms.InformationSystems
{
    internal partial class ControlISInfo : UserControl
    {
        /// <summary>
        /// Attribute which represents information system visible in control
        /// </summary>
        private InformationSystem? informationSystem;

        /// <summary>
        /// Information system visible in control
        /// </summary>
        public InformationSystem? InformationSystem
        {
            private get
            {
                return this.informationSystem;
            }
            set
            {
                this.informationSystem = value;
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
            if (this.informationSystem != null)
            {
                this.informationSystem.Icon.Display(this.pictureBoxIcon);
                this.labelName.Text = this.informationSystem.Name;
                this.textBoxDescription.Text = this.informationSystem.Description;
                this.textBoxCreated.Text = this.informationSystem.Created.ToString();
                this.textBoxUpdated.Text = this.informationSystem.Updated.ToString();
            }
        }
    }
}
