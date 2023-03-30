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
    /// Class representing viewer of data
    /// </summary>
    internal partial class ControlDataView : UserControl, IControl
    {
        public Context Context{ get; init; }

        /// <summary>
        /// Creates new viewer of data
        /// </summary>
        /// <param name="name">Name of data</param>
        /// <param name="description">Description of data</param>
        /// <param name="image">Image of data</param>
        /// <param name="created">Date and time of creation of data</param>
        /// <param name="updated">Date and time of last update of data</param>
        /// <param name="context">Wrapper of all programs resources</param>
        public ControlDataView(string name, string description, Bitmap image, DateTime created, DateTime updated, Context context)
        {
            this.Context = context;
            InitializeComponent();
            this.labelName.Text = name;
            this.pictureBoxImage.Image = image;
            this.textBoxDescription.Text = description;
            this.textBoxCreated.Text = created.ToString();
            this.textBoxUpdated.Text = updated.ToString();
        }
    }
}
