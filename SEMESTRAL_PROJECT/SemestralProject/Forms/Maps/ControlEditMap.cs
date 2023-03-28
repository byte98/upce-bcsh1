using SemestralProject.Data;
using SemestralProject.Persistence;
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
    internal partial class ControlEditMap : UserControl
    {
        /// <summary>
        /// Name of map
        /// </summary>
        public string? MapName
        {
            get
            {
                return this.textBoxName.Text;
            }
            private set
            {
                this.textBoxName.Text = value;
            }
        }

        /// <summary>
        /// Description of map
        /// </summary>
        public string? MapDescription
        {
            get
            {
                return this.textBoxDescription.Text;
            }
            private set
            {
                this.textBoxDescription.Text = value;
            }
        }

        /// <summary>
        /// Picture of map
        /// </summary>
        public Picture? MapPicture { get; private set; }


        /// <summary>
        /// Creates new control for editing map
        /// </summary>
        /// <param name="map">Map which is being edited</param>
        public ControlEditMap(Map map)
        {
            InitializeComponent();
            this.MapName = map.Name;
            this.MapPicture = map.Picture;
            this.MapDescription = map.Description;
            this.buttonPicture.Image = this.MapPicture.GetImage();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            FormPictureChooser dialog = new FormPictureChooser();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.SelectedIsPath)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        this.MapPicture = FileStorage.Instance.AddPicture(dialog.SelectedPicture);
                    });
                }
                else
                {
                    this.MapPicture = FileStorage.Instance.GetPictureChecked(dialog.SelectedPicture);
                }
                this.buttonPicture.Image = this.MapPicture?.GetImage();
            }
        }
    }
}
