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

namespace SemestralProject.Forms.Maps
{
    internal partial class ControlInfoMap : UserControl
    {
        /// <summary>
        /// Name of map
        /// </summary>
        public string? MapName
        {
            set
            {
                this.labelName.Text = value;
            }
        }

        /// <summary>
        /// Description of map
        /// </summary>
        public string? MapDescription
        {
            set
            {
                this.textBoxDescription.Text = value; 
            }
        }

        /// <summary>
        /// Picture of map
        /// </summary>
        public Picture? MapPicture
        {
            set
            {
                this.pictureBoxPicture.Image = value?.GetImage();
            }
        }

        /// <summary>
        /// Date and time of creation of map
        /// </summary>
        public DateTime? MapCreated
        {
            set
            {
                this.textBoxCreated.Text = value.ToString();
            }
        }

        /// <summary>
        /// Date and time of last modification of map
        /// </summary>
        public DateTime? MapUpdated
        {
            set
            {
                this.textBoxUpdated.Text = value.ToString();
            }
        }

        public ControlInfoMap()
        {
            InitializeComponent();
        }
    }
}
