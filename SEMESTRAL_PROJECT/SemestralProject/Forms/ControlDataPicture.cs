using SemestralProject.Data;
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
    /// Class which represents control used to create and edit data with pictures
    /// </summary>
    internal partial class ControlDataPicture : UserControl, IControl
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Picture of data
        /// </summary>
        public Picture? DataPicture { get; private set; }

        /// <summary>
        /// Name of data
        /// </summary>
        public string? DataName
        {
            get
            {
                return this.textBoxName.Text;
            }

            init
            {
                this.textBoxName.Text = value;
            }

        }

        /// <summary>
        /// Description of data
        /// </summary>
        public string? DataDescripiton
        {
            get
            {
                return this.textBoxDescription.Text;
            }

            init
            {
                this.textBoxDescription.Text = value;
            }
        }

        /// <summary>
        /// Creates new control for creating data with pictures
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlDataPicture(Context context)
        {
            InitializeComponent();
            this.Context = context;
            this.DataPicture = this.Context.FileStorage.GetPictureChecked(null);
        }

        /// <summary>
        /// Creates new control for editing data with pictures
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="data">Data which will be edited</param>
        public ControlDataPicture(Context context, AbstractPictureData data) : this(context)
        {
            this.DataName = data.Name;
            this.DataDescripiton = data.Description;
            this.DataPicture = data.Picture;
            this.buttonPicture.BackgroundImage = this.DataPicture?.GetImage();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            FormPictureChooser dialog = new FormPictureChooser(this.Context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.SelectedIsPath)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        this.DataPicture = this.Context.FileStorage.AddPicture(dialog.SelectedPicture);
                    }, this.Context);
                    wait.ShowDialog();
                }
                else
                {
                    this.DataPicture = this.Context.FileStorage.GetPictureChecked(dialog.SelectedPicture);
                }
                this.buttonPicture.BackgroundImage = this.DataPicture?.GetImage();
            }
        }
    }
}
