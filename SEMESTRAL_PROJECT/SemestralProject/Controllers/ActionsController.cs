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
        /// Form which informs about import/export process
        /// </summary>
        private FormProgress? formImportExport;

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
            this.exporter.Progress += ExportImportHandler;
            this.exporter.ProgressLog += ExportImportLogHandler;
            this.exporter.ProcessDone += ExportImportDoneHandler;
            this.importer.Progress += ExportImportHandler;
            this.importer.ProgressLog += ExportImportLogHandler;
            this.importer.ProcessDone += ExportImportDoneHandler;
            this.importer.ProcessDone += ImportDoneHandler;
        }

        /// <summary>
        /// Exports state of program into file
        /// </summary>
        /// <param name="path">Path to file to which state of program will be saved</param>
        public void Export(string path)
        {
            this.exporter.OutputPath = path;
            this.formImportExport = FormProgress.CreateExportForm(this.context);
            this.formImportExport.Show();
            Random random = new Random();
            Task.Run(new Action(() =>
            {
                foreach(Action action in this.exporter.GetExportSequence())
                {
                    action();
                    Thread.Sleep(random.Next(ActionsController.EISleepMin, ActionsController.EISleepMax));
                }
            }));
            this.formImportExport.BringToFront();
            this.formImportExport.TopMost = true;
        }

        /// <summary>
        /// Imports state of program from file
        /// </summary>
        /// <param name="path">Path to file from which state of program will be imported from</param>
        public void Import(string path)
        {
            this.importer.InputPath = path;
            this.formImportExport = FormProgress.CreateImportForm(this.context);
            this.formImportExport.Show();
            Random random = new Random();
            Task.Run(new Action(() =>
            {
                foreach(Action action in this.importer.GetImportSequence())
                {
                    action();
                    Thread.Sleep(random.Next(ActionsController.EISleepMin, ActionsController.EISleepMax));
                }
            }));
            this.formImportExport.BringToFront();
            this.formImportExport.TopMost = true;
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
        /// Handles export/import event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event</param>
        private void ExportImportHandler(object sender, AbstracProgress.ProgressEventArgs e)
        {
            if (this.formImportExport!= null)
            {
                this.formImportExport.Invoke(new MethodInvoker(delegate ()
                {
                    if (e.Percentage < 0 || e.Percentage > 100)
                    {
                        this.formImportExport.Content.ContentProgress.Style = ProgressBarStyle.Marquee;
                    }
                    else
                    {
                        this.formImportExport.Content.ContentProgress.Style = ProgressBarStyle.Continuous;
                        this.formImportExport.Content.ContentProgress.Value = e.Percentage;
                    }
                    this.formImportExport.Content.ContentState.Text = e.State;
                }));
            }
        }

        /// <summary>
        /// Handles export/import log event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event</param>
        private void ExportImportLogHandler(object sender, AbstracProgress.ProgressLogEventArgs e)
        {
            if (this.formImportExport != null)
            {
                this.formImportExport.Invoke(new MethodInvoker(delegate ()
                {
                    this.formImportExport.Content.ContentLog.AppendText(e.DateTime.ToString() + " | " + e.Message + Environment.NewLine);
                }));
            }
        }

        /// <summary>
        /// Handles export/import done event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        private void ExportImportDoneHandler(object sender)
        {
            if (this.formImportExport != null)
            {
                this.formImportExport.Invoke(new MethodInvoker(delegate ()
                {
                    this.formImportExport.ButtonsEnabled = true;
                }));
            }
        }
    }
}
