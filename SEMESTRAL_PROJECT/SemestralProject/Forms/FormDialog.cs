using SemestralProject.Persistence;
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
    internal abstract partial class FormDialog : Form
    {
        /// <summary>
        /// Icon displayed in header area of dialog
        /// </summary>
        protected Bitmap? headerIcon;

        /// <summary>
        /// Icon which is displayed in header area of dialog
        /// </summary>
        public Bitmap? HeaderIcon
        {
            get
            {
                return this.headerIcon;
            }
            set
            {
                this.headerIcon = value;
                this.pictureBoxHeaderIcon.Image = this.headerIcon;
            }
        }

        /// <summary>
        /// Adds control to dialog
        /// </summary>
        /// <param name="control"></param>
        protected void AddControl(Control control)
        {
            this.flowLayoutPanelContent.Controls.Add(control);
        }

        /// <summary>
        /// Text displayed in header area of dialog
        /// </summary>
        protected string headerText = string.Empty;

        /// <summary>
        /// Text which is displayed in header area of dialog
        /// </summary>
        public string HeaderText
        {
            get
            {
                return this.headerText;
            }
            set
            {
                this.headerText = value;
                this.labelHeader.Text = this.headerText;
            }
        }

        /// <summary>
        /// Creates new dialog
        /// </summary>
        /// <param name="title">Title of dialog</param>
        /// <param name="header">Header of dialog</param>
        /// <param name="icon">Icon of dialog</param>
        public FormDialog(string title, string header, Bitmap icon)
        {
            InitializeComponent();
            this.panelHeader.BackColor = Configuration.AccentColor;
            this.panelHeader.ForeColor = Configuration.TextColor;
            this.Text = title;
            this.HeaderText = header; 
            this.HeaderIcon = icon;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Hides cancel button
        /// </summary>
        protected void HideCancelButton()
        {
            this.buttonCancel.Visible = false;
        }

        private void FormAddIS_Deactivate(object sender, EventArgs e)
        {
            this.panelHeader.BackColor = Color.White;
        }

        private void FormAddIS_Activated(object sender, EventArgs e)
        {
            this.panelHeader.BackColor = Configuration.AccentColor;
        }
    }
}
