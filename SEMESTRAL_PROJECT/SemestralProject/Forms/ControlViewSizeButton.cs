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
    internal partial class ControlViewSizeButton : UserControl
    {
        /// <summary>
        /// View of data which will be controlled by this control
        /// </summary>
        public IView? DataView {private get; set; }

        public ControlViewSizeButton()
        {
            InitializeComponent();
        }

        private void ControlViewSizeButton_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            this.contextMenuStripSizes.Show(this, 0, 0);
        }

        private void contextMenuStripSizes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            View size = View.Details;
            if (e.ClickedItem == this.toolStripMenuItemLIcons)
            {
                size = View.LargeIcon;
            }
            else if (e.ClickedItem == this.toolStripMenuItemSIcons)
            {
                size = View.SmallIcon;
            }
            else if (e.ClickedItem == this.toolStripMenuItemList)
            {
                size = View.List;
            }
            else if (e.ClickedItem == this.toolStripMenuItemDetails)
            {
                size = View.Details;
            }
            else if (e.ClickedItem == this.toolStripMenuItemTiles)
            {
                size = View.Tile;
            }
            this.DataView?.SetItemsSize(size);
            this.SetViewSize(size);
        }

        /// <summary>
        /// Sets displayed size of items
        /// </summary>
        /// <param name="size">Displayed size of items</param>
        private void SetViewSize(View size)
        {
            switch(size)
            {
                case View.LargeIcon: this.buttonMain.Image = SemestralProject.Resources.icons_l; this.buttonMain.Text = "Velké ikony ▼"; break;
                case View.SmallIcon: this.buttonMain.Image = SemestralProject.Resources.icons_s; this.buttonMain.Text = "Malé ikony ▼"; break;
                case View.Details: this.buttonMain.Image = SemestralProject.Resources.icons_details; this.buttonMain.Text = "Podrobnosti ▼"; break;
                case View.List: this.buttonMain.Image = SemestralProject.Resources.icons_list; this.buttonMain.Text = "Seznam ▼"; break;
                case View.Tile: this.buttonMain.Image = SemestralProject.Resources.icons_tiles; this.buttonMain.Text = "Dlaždice ▼"; break;

            }
        }
    }
}
