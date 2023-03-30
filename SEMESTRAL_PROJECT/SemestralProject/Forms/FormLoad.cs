﻿using SemestralProject.Persistence;
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
    internal partial class FormLoad : Form, IForm
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
        /// Struct which holds item in loading sequence
        /// </summary>
        private struct LoadSequenceItem
        {
            /// <summary>
            /// Weight of item in sequence (incrementation value of progress)
            /// </summary>
            public ushort Weight { get; set; }

            /// <summary>
            /// Name of item
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Action which will be performed during loading
            /// </summary>
            public Action Action { get; set; }

            /// <summary>
            /// Creates new item from loading sequence
            /// </summary>
            /// <param name="weight">Weight of item in sequence</param>
            /// <param name="name">Name of item</param>
            /// <param name="action">Action which will be performed during loading</param>
            public LoadSequenceItem(ushort weight, string name, Action action)
            {
                this.Weight = weight;
                this.Name = name;
                this.Action = action;
            }
        }

        /// <summary>
        /// Minimal time in sleep when loading sequence is running
        /// </summary>
        private const int SleepMin = 200;

        /// <summary>
        /// Maximal time in sleep when loading sequence is running
        /// </summary>
        private const int SleepMax = 1000;

        public Context Context { get; init; }

        /// <summary>
        /// Loading sequence of program
        /// </summary>
        private readonly List<LoadSequenceItem> loadingSequence;

        /// <summary>
        /// Creates new loading form
        /// </summary>
        /// <param name="parent">Form controlling behaviour of whole application</param>
        public FormLoad(FormMain parent, Context context)
        {
            this.Context = context;
            this.loadingSequence = new List<LoadSequenceItem>();
            this.BuildSequence();
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

        /// <summary>
        /// Builds steps necessary to complete loading of program
        /// </summary>
        private void BuildSequence()
        {
            this.loadingSequence.Clear();
            this.loadingSequence.Add(new LoadSequenceItem(10, "Načítám...", () => { }));
            this.loadingSequence.Add(new LoadSequenceItem(15, "Načítám soubory...", () =>
            {
                this.Context.FileStorage.Load();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(15, "Načítám ikony...", () =>
            {
                this.Context.FileStorage.LoadIcons();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(15, "Načítám obrázky...", () =>
            {
                this.Context.FileStorage.LoadPictures();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(15, "Načítám data...", () =>
            {
                this.Context.DataStorage.Load();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(15, "Načítám informační systémy...", () =>
            {
                this.Context.DataStorage.LoadInformationSystems();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(15, "Načítám oblasti...", () =>
            {
                this.Context.DataStorage.LoadMaps();
            }));
        }

        /// <summary>
        /// Gets random number for thread sleep
        /// </summary>
        /// <returns>Pseudo-random integer in specified interval</returns>
        private int RandomSleepTime()
        {
            Random random = new Random();
            return random.Next(FormLoad.SleepMin, FormLoad.SleepMax + 1);
        }

        private async void FormLoad_Load(object sender, EventArgs e)
        {
            this.progressBarLoad.Value = 0;
            foreach(LoadSequenceItem item in this.loadingSequence)
            {
                this.labelState.Text = item.Name;
                await (Task.Run(() =>
                {
                    item.Action.Invoke();
                    Thread.Sleep(this.RandomSleepTime());
                }));
                this.progressBarLoad.Value += (int)item.Weight;
            }
            this.progressBarLoad.Value = 100;
            this.labelState.Text = "Hotovo";
            await Task.Run(() => { Thread.Sleep(this.RandomSleepTime()); });
            this.parent.Show();
            this.Close();
        }
    }
}
