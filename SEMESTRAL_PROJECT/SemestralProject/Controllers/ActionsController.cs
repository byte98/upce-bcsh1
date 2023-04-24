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
        /// Wrapper of all program resources
        /// </summary>
        private readonly Context context;

        /// <summary>
        /// Form which informs about import/export process
        /// </summary>
        private FormImportExport? formImportExport;

        /// <summary>
        /// Minimal thread sleep (in miliseconds) during export/import
        /// </summary>
        private const int EISleepMin = 0;

        /// <summary>
        /// Maximal thread sleep (in miliseconds) during export/import
        /// </summary>
        private const int EISleepMax = 1000;

        /// <summary>
        /// Pipeline of commands needed to execute to sucessfull export of data
        /// </summary>
        private readonly List<Action> exportPipeline;

        /// <summary>
        /// Creates new controller of actions page
        /// </summary>
        /// <param name="context"></param>
        public ActionsController(Context context)
        {
            this.context = context;
            this.exporter = new Exporter(this.context);
            this.exportPipeline = new List<Action>();
            this.BuildExportPipeline();
            this.exporter.ExportImport += Exporter_ExportImport;
            this.exporter.ExportImportLog += Exporter_ExportImportLog;
            this.exporter.ExportImportDone += Exporter_ExportImportDone;
        }

        /// <summary>
        /// Builds pipeline of commands needed to be executed to successfull export of data
        /// </summary>
        private void BuildExportPipeline()
        {
            this.exportPipeline.Add(new Action(() => { this.exporter.Export(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.ExportInformationSystems(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.ExportMaps(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.ExportManufacturers(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.ExportVehicles(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.ExportDataFiles(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.ExportIcons(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.ExportPictures(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.ExportDataFilesContent(); }));
            this.exportPipeline.Add(new Action(() => { this.exporter.FinishExport(); }));
        }

        /// <summary>
        /// Exports state of program into file
        /// </summary>
        /// <param name="path">Path to file to which state of program will be saved</param>
        public void Export(string path)
        {
            this.exporter.OutputPath = path;
            this.formImportExport = new FormImportExport(this.context);
            this.formImportExport.Show();
            Random random = new Random();
            Task.Run(new Action(() =>
            {
                foreach(Action action in this.exportPipeline)
                {
                    action();
                    Thread.Sleep(random.Next(ActionsController.EISleepMin, ActionsController.EISleepMax));
                }
            }));
            this.formImportExport.BringToFront();
            this.formImportExport.TopMost = true;
        }

        private void Exporter_ExportImport(object sender, AbstractExporterImporter.ExportImportEventArgs e)
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

        private void Exporter_ExportImportLog(object sender, AbstractExporterImporter.ExportImportLogEventArgs e)
        {
            if (this.formImportExport != null)
            {
                this.formImportExport.Invoke(new MethodInvoker(delegate ()
                {
                    this.formImportExport.Content.ContentLog.AppendText(e.DateTime.ToString() + " | " + e.Message + Environment.NewLine);
                }));
            }
        }

        private void Exporter_ExportImportDone(object sender)
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
