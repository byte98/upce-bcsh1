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
    internal partial class FormLoad : Form
    {
        /// <summary>
        /// Year of program release
        /// </summary>
        private const int Released = 2023;

        /// <summary>
        /// Parential form controlling behaviour of whole application
        /// </summary>
        private readonly FormMain parent;

        /// <summary>
        /// Creates new loading form
        /// </summary>
        /// <param name="parent">Form controlling behaviour of whole application</param>
        public FormLoad(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.labelCopyright.Text = "(c) Jiří Škoda " + FormLoad.Released;
            if (DateTime.Now.Year != FormLoad.Released)
            {
                this.labelCopyright.Text += " - " + DateTime.Now.Year;
            }
            this.labelCopyright.BackColor = Color.FromArgb(255, 66, 0, 96);
            this.BackColor = this.labelCopyright.BackColor;
            this.labelCopyright.BringToFront();
        }

        private async void FormLoad_Load(object sender, EventArgs e)
        {
            this.progressBarLoad.Value = 10;
            FileStorage fs = FileStorage.Instance;
            await Task.Run(() =>
            {
                fs.Load();
                Thread.Sleep(1000);
            });
            this.progressBarLoad.Value = 100;
            await Task.Run(() => {
                Thread.Sleep(1000);
            });
            this.parent.Show();
            this.Close();
        }
    }
}
