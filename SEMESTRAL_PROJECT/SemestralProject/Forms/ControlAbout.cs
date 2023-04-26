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

namespace SemestralProject.Forms
{
    internal partial class ControlAbout : UserControl, IControl
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Control representing content of 'About' dialog
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlAbout(Context context)
        {
            this.Context = context;
            InitializeComponent();
            
        }

        private void linkLabelAuthorEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start("mailto:jiri.skoda@student.upce.cz"); This not works, not shure why
        }
    }
}
