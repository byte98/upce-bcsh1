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
    internal partial class ControlBrowseButton : UserControl
    {
        /// <summary>
        /// Class representing arguments of file selection event
        /// </summary>
        internal class FileSelectedArgs: EventArgs
        {
            /// <summary>
            /// Path to selected file
            /// </summary>
            public string SelectedFile { get; set; } = string.Empty;
        }

        /// <summary>
        /// Delegate for file selection event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="args">Arguments of event</param>
        public delegate void FileSelectedHandler(object sender, FileSelectedArgs args);

        /// <summary>
        /// File selection event
        /// </summary>
        public event FileSelectedHandler FileSelectedEvent;

        /// <summary>
        /// Result of dialog
        /// </summary>
        public DialogResult Result { get; private set; }

        /// <summary>
        /// File selected in dialog
        /// </summary>
        public string SelectedFile { get; private set; }

        /// <summary>
        /// Filter of displayed files in dialog
        /// </summary>
        public string FileFilter
        {
            get
            {
                return this.openFileDialogBrowse.Filter;
            }
            set
            {
                this.openFileDialogBrowse.Filter = value;
            }
        }

        /// <summary>
        /// Creates new browse for file button
        /// </summary>
        public ControlBrowseButton()
        {
            InitializeComponent();
            this.openFileDialogBrowse.Filter = "Všechny soubory | *.*";
            this.SelectedFile = string.Empty;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            this.Result = this.openFileDialogBrowse.ShowDialog();
            if (this.Result == DialogResult.OK)
            {
                this.SelectedFile = this.openFileDialogBrowse.FileName;
                this.FileSelectedEvent?.Invoke(this, new FileSelectedArgs { SelectedFile = this.SelectedFile });
            }
        }
    }
}
