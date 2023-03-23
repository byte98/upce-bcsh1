﻿using System;
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
    internal partial class FormWait : Form
    {
        /// <summary>
        /// Action which will be done during form displayed
        /// </summary>
        private readonly Action action;
        
        /// <summary>
        /// Creates new waiting form
        /// </summary>
        /// <param name="action">Action which needs to be done during form displayed</param>
        public FormWait(Action action)
        {
            InitializeComponent();
            this.action = action;
        }

        private async void FormWait_Load(object sender, EventArgs e)
        {
            await Task.Run(() => { this.action.Invoke(); });
            this.Close();
        }
    }
}