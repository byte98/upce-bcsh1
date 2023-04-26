using SemestralProject.Persistence;
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
    internal abstract partial class FormDialog : Form, IForm
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
        /// Wrapper of all system resources
        /// </summary>
        public Context Context { get; init; } = Context.CreateEmptyContext(); // Here empty context is assigned because of otherwise Visual Studio gets warning 'Possible null reference'

        /// <summary>
        /// Creates new dialog
        /// </summary>
        /// <param name="title">Title of dialog</param>
        /// <param name="header">Header of dialog</param>
        /// <param name="icon">Icon of dialog</param>
        /// <param name="context">Wrapper of all program resources</param>
        public FormDialog(string title, string header, Bitmap icon, Context context)
        {
            this.Context = context;
            InitializeComponent();
            if (this.Context != null)
            {
                this.panelHeader.BackColor = this.Context.Configuration.AccentColor;
                this.panelHeader.ForeColor = this.Context.Configuration.TextColor;
            }
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

        /// <summary>
        /// Disables dialog buttons
        /// </summary>
        protected void DisableButtons()
        {
            this.buttonOK.Enabled = false;
            this.buttonCancel.Enabled = false;
        }

        /// <summary>
        /// Enables dialog buttons
        /// </summary>
        protected void EnableButtons()
        {
            this.buttonOK.Enabled = true;
            this.buttonCancel.Enabled = true;
        }

        private void FormAddIS_Deactivate(object sender, EventArgs e)
        {
            this.panelHeader.BackColor = Color.White;
        }

        private void FormAddIS_Activated(object sender, EventArgs e)
        {
            if (this.Context != null)
            {
                this.panelHeader.BackColor = this.Context.Configuration.AccentColor;
            }
        }

        /// <summary>
        /// Adds handler on event 'click on OK button'
        /// </summary>
        /// <param name="eventHandler">Event handler which will be invoked</param>
        protected void OnOKClicked(EventHandler eventHandler)
        {
            this.buttonOK.Click += eventHandler;
        }

        /// <summary>
        /// Hides close button
        /// </summary>
        protected void HideCloseButton()
        {
            this.ControlBox = false;
        }

    }
}
