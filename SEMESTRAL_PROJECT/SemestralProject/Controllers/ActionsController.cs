using SemestralProject.Forms;
using SemestralProject.Persistence;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Controllers
{
    /// <summary>
    /// Controller of actions page
    /// </summary>
    internal class ActionsController
    {
        /// <summary>
        /// Object which has ability to export state of program into file
        /// </summary>
        private readonly Exporter exporter;

        /// <summary>
        /// Object which has ability to import state of program from file
        /// </summary>
        private readonly Importer importer;

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        private readonly Context context;

        /// <summary>
        /// Form which informs about progress of process
        /// </summary>
        private FormProgress? formProgress;

        /// <summary>
        /// Minimal thread sleep (in miliseconds) during export/import
        /// </summary>
        private const int EISleepMin = 100;

        /// <summary>
        /// Maximal thread sleep (in miliseconds) during export/import
        /// </summary>
        private const int EISleepMax = 1000;

        /// <summary>
        /// Reference to main form used to refresh all views
        /// </summary>
        private readonly FormMain mainForm;

        /// <summary>
        /// Minimal thread sleep (in miliseconds) during file copiing
        /// </summary>
        private const int CopySleepMin = 10;

        /// <summary>
        /// Maximal thread sleep (in miliseconds) during file copiing
        /// </summary>
        private const int CopySleepMax = 100;

        /// <summary>
        /// Object which can copy files into right directories
        /// </summary>
        private readonly Copier copier;

        /// <summary>
        /// Creates new controller of actions page
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="formMain">Reference to main form for refreshing views</param>
        public ActionsController(Context context, FormMain formMain)
        {
            this.context = context;
            this.mainForm = formMain;
            this.exporter = new Exporter(this.context);
            this.importer = new Importer(this.context);
            this.copier = new Copier(this.context);
            this.exporter.Progress += ProgressEventHandler;
            this.exporter.ProgressLog += ProgressLogEventhandler;
            this.exporter.ProcessDone += ProgressDoneEventHandler;
            this.importer.Progress += ProgressEventHandler;
            this.importer.ProgressLog += ProgressLogEventhandler;
            this.importer.ProcessDone += ProgressDoneEventHandler;
            this.importer.ProcessDone += ImportDoneHandler;
            this.copier.Progress += ProgressEventHandler;
            this.copier.ProgressLog += ProgressLogEventhandler;
            this.copier.ProcessDone += ProgressDoneEventHandler;
        }

        /// <summary>
        /// Exports state of program into file
        /// </summary>
        /// <param name="path">Path to file to which state of program will be saved</param>
        public void Export(string path)
        {
            this.exporter.OutputPath = path;
            this.formProgress = FormProgress.CreateExportForm(this.context);
            this.formProgress.Show();
            Random random = new Random();
            Task.Run(new Action(() =>
            {
                foreach(Action action in this.exporter.GetExportSequence())
                {
                    action();
                    Thread.Sleep(random.Next(ActionsController.EISleepMin, ActionsController.EISleepMax));
                }
            }));
            this.formProgress.BringToFront();
            this.formProgress.TopMost = true;
        }

        /// <summary>
        /// Imports state of program from file
        /// </summary>
        /// <param name="path">Path to file from which state of program will be imported from</param>
        public void Import(string path)
        {
            this.importer.InputPath = path;
            this.formProgress = FormProgress.CreateImportForm(this.context);
            this.formProgress.Show();
            Random random = new Random();
            Task.Run(new Action(() =>
            {
                foreach(Action action in this.importer.GetImportSequence())
                {
                    action();
                    Thread.Sleep(random.Next(ActionsController.EISleepMin, ActionsController.EISleepMax));
                }
            }));
            this.formProgress.BringToFront();
            this.formProgress.TopMost = true;
        }

        /// <summary>
        /// Performs copiing of data files into directories of vehicles
        /// </summary>
        /// <param name="replace">Flag, whether files should be replaced or not</param>
        public void Copy(bool replace = false)
        {
            if (replace == true)
            {
                this.formProgress = FormProgress.CreateCopyReplaceForm(this.context);
            }
            else
            {
                this.formProgress = FormProgress.CreateCopyForm(this.context);
            }
            this.formProgress.Show();
            Random random = new Random();
            Task.Run(new Action(() =>
            {
                foreach(Action action in this.copier.GetCopySequence(replace))
                {
                    action();
                    Thread.Sleep(random.Next(ActionsController.CopySleepMin, ActionsController.CopySleepMax));
                }
            }));
            this.formProgress.BringToFront();
            this.formProgress.TopMost = true;
        }

        /// <summary>
        /// Handles import done event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        private void ImportDoneHandler(object sender)
        {
            this.mainForm.Invoke(new MethodInvoker(delegate ()
            {
                this.mainForm.RefreshViews();
            }));
        }


        /// <summary>
        /// Handles progress event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event</param>
        private void ProgressEventHandler(object sender, AbstracProgress.ProgressEventArgs e)
        {
            if (this.formProgress!= null)
            {
                this.formProgress.Invoke(new MethodInvoker(delegate ()
                {
                    if (e.Percentage < 0 || e.Percentage > 100)
                    {
                        this.formProgress.Content.ContentProgress.Style = ProgressBarStyle.Marquee;
                    }
                    else
                    {
                        this.formProgress.Content.ContentProgress.Style = ProgressBarStyle.Continuous;
                        this.formProgress.Content.ContentProgress.Value = e.Percentage;
                    }
                    this.formProgress.Content.ContentState.Text = e.State;
                }));
            }
        }

        /// <summary>
        /// Handles progress log event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event</param>
        private void ProgressLogEventhandler(object sender, AbstracProgress.ProgressLogEventArgs e)
        {
            if (this.formProgress != null)
            {
                this.formProgress.Invoke(new MethodInvoker(delegate ()
                {
                    this.formProgress.Content.ContentLog.AppendText(e.DateTime.ToString() + " | " + e.Message + Environment.NewLine);
                }));
            }
        }

        /// <summary>
        /// Handles process done event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        private void ProgressDoneEventHandler(object sender)
        {
            if (this.formProgress != null)
            {
                this.formProgress.Invoke(new MethodInvoker(delegate ()
                {
                    this.formProgress.ButtonsEnabled = true;
                }));
            }
        }
    }
}
