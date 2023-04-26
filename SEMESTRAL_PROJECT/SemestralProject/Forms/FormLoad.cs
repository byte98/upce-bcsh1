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
        private const int SleepMin = 0;

        /// <summary>
        /// Maximal time in sleep when loading sequence is running
        /// </summary>
        private const int SleepMax = 1000;

        /// <summary>
        /// Wrapper of all system resources
        /// </summary>
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
            this.Icon = SemestralProject.Resources.icon_hourglass1;
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
            this.loadingSequence.Add(new LoadSequenceItem(5, "Načítám...", () => { }));
            loadingSequence.Add(new LoadSequenceItem(5, "Načítám konfiguraci...", () =>
            {
                this.Context.Configuration.Load();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(5, "Načítám soubory...", () =>
            {
                this.Context.FileStorage.Load();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(20 / 3, "Načítám ikony...", () =>
            {
                this.Context.FileStorage.LoadIcons();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(20 / 3, "Načítám obrázky...", () =>
            {
                this.Context.FileStorage.LoadPictures();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(20 / 3, "Načítám obsah datových souborů...", () =>
            {
                this.Context.FileStorage.LoadDataFiles();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(5, "Načítám data...", () =>
            {
                this.Context.DataStorage.Load();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(60 / 5, "Načítám informační systémy...", () =>
            {
                this.Context.DataStorage.LoadInformationSystems();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(60 / 5, "Načítám oblasti...", () =>
            {
                this.Context.DataStorage.LoadMaps();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(60 / 5, "Načítám výrobce...", () =>
            {
                this.Context.DataStorage.LoadManufacturers();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(60 / 5, "Načítám vozidla...", () =>
            {
                this.Context.DataStorage.LoadVehicles();
            }));
            this.loadingSequence.Add(new LoadSequenceItem(60 / 5, "Načítám datové soubory...", () =>
            {
                this.Context.DataStorage.LoadDataFiles();
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
