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

namespace SemestralProject.Forms
{
    internal partial class ControlAddMap : UserControl
    {
        /// <summary>
        /// Picture of map
        /// </summary>
        public Picture MapPicture { get; private set; } = FileStorage.Instance.GetPictureChecked(null);

        /// <summary>
        /// Name of map
        /// </summary>
        public string MapName { get; private set; } = string.Empty;

        /// <summary>
        /// Description of map
        /// </summary>
        public string MapDescription { get; private set; } = string.Empty;

        public ControlAddMap()
        {
            InitializeComponent();
            this.buttonPictureSelect.BackgroundImage = this.MapPicture.GetImage();
        }

        private void buttonPictureSelect_Click(object sender, EventArgs e)
        {
            FormPictureChooser pictureChooser = new FormPictureChooser();
            if (pictureChooser.ShowDialog() ==DialogResult.OK)
            {
                if (pictureChooser.SelectedIsPath)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        this.MapPicture = FileStorage.Instance.AddPicture(pictureChooser.SelectedPicture);
                    });
                    wait.ShowDialog();
                }
                else
                {
                    this.MapPicture = FileStorage.Instance.GetPictureChecked(pictureChooser.SelectedPicture);
                }
            }
            this.buttonPictureSelect.BackgroundImage = this.MapPicture.GetImage();
        }
    }
}
