using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Forms.DataFiles
{
    /// <summary>
    /// Class representing control which displays detail of data file
    /// </summary>
    internal partial class ControlDataFileDetail : UserControl, IControl
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context{get; init;}

        /// <summary>
        /// Creates new dialog with detail of data file
        /// </summary>
        /// <param name="dataFile">Data file which details will be displayed</param>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlDataFileDetail(DataFile dataFile, Context context)
        {
            InitializeComponent();
            this.Context = context;
            FileInfo fi = new FileInfo(dataFile.OriginalPath);
            this.labelName.Text = fi.Name;
            this.textBoxPath.Text = fi.FullName;
            this.pictureBoxInformationSystem.Image = dataFile.InformationSystem.Icon.GetImage();
            this.textBoxInformationSystem.Text = dataFile.InformationSystem.Name;
            this.pictureBoxMap.Image = dataFile.Map.Picture.GetImage();
            this.textBoxMap.Text = dataFile.Map.Name;
            this.textBoxDescription.Text = dataFile.Description;
            this.textBoxCreated.Text = dataFile.Created.ToString();
            this.textBoxUpdated.Text = dataFile.Updated.ToString();
        }

        private void buttonExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.GetDirectoryName(this.textBoxPath.Text) ?? string.Empty);
        }
    }
}
