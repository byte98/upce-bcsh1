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
        /// <summary>
        /// Name or path to selected icon
        /// </summary>
        public string SelectedIcon { get; private set; }

        /// <summary>
        /// Flag, whether selected icon is path (TRUE) or name (FALSE)
        /// </summary>
        public bool IsPath { get; private set; }

        /// <summary>
        /// Image list with system icons only
        /// </summary>
        private ImageList systemImageList;

        /// <summary>
        /// Creates new icons chooser
        /// </summary>
        public ControlIconsChooser()
        {
            this.InitializeComponent();
            this.systemImageList = ControlIconsChooser.InitializeSystemImageList();
            this.SelectedIcon = string.Empty;
            this.IsPath = false;
            this.controlBrowseButtonBrowseIcons.FileFilter = "Obrázek|*.BMP;*.GIF;*.JPG;*.JPEG;*.PNG";
            
            this.listViewIcons.Items.Clear();
            this.listViewIcons.LargeImageList = new ImageList();
            this.listViewIcons.LargeImageList.ImageSize = new Size(64, 64);
            foreach(string? key in this.systemImageList.Images.Keys)
            {
                this.listViewIcons.LargeImageList.Images.Add(key, this.systemImageList.Images[key]);
                this.listViewIcons.Items.Add(string.Empty, key);
            }
        }

        /// <summary>
        /// Initializes image list with system icons
        /// </summary>
        private static ImageList InitializeSystemImageList()
        {
            ImageList reti = new ImageList();
            foreach(Icon icon in FileStorage.Instance.GetAllIcons())
            {
                reti.Images.Add(icon.Name, icon.GetImage());
            }
            return reti;
        }

        private void controlBrowseButtonBrowseIcons_FileSelectedEvent(object sender, ControlBrowseButton.FileSelectedArgs args)
        {
            this.listViewIcons.LargeImageList.Images.Add(this.controlBrowseButtonBrowseIcons.SelectedFile,new Bitmap(this.controlBrowseButtonBrowseIcons.SelectedFile));
            this.listViewIcons.Items.Add(string.Empty, this.controlBrowseButtonBrowseIcons.SelectedFile);
        }

        private void listViewIcons_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.listViewIcons.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = this.listViewIcons.SelectedItems[0];
                string iconKey = selectedItem.ImageKey;
                if (this.systemImageList.Images.ContainsKey(iconKey))
                {
                    this.IsPath = false;
                }
                else
                {
                    this.IsPath = true;
                }
                this.SelectedIcon = iconKey;
            }
        }
    }
}
