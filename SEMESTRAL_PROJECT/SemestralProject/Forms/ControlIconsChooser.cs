using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SemestralProject.Persistence;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Forms
{
    public partial class ControlIconsChooser : UserControl
    {
        public ControlIconsChooser()
        {
            InitializeComponent();
            this.controlBrowseButtonBrowseIcons.FileFilter = "Obrázek | *.BMP;*.GIF,*.JPG;*.JPEG;*.PNG";
            this.listViewIcons.Items.Clear();
            this.listViewIcons.SmallImageList = new ImageList();
            foreach(Icon icon in FileStorage.Instance.GetAllIcons())
            {
                this.listViewIcons.SmallImageList.Images.Add(icon.Name, icon.GetImage());
                this.listViewIcons.Items.Add(string.Empty, icon.Name);
            }

        }
    }
}
