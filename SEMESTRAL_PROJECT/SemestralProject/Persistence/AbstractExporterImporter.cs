using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class abstracting commmon attributes for both exporter and importer
    /// </summary>
    internal abstract class AbstractExporterImporter
    {
        /// <summary>
        /// Arguments for import/export event
        /// </summary>
        public class ExportImportEventArgs: EventArgs
        {
            /// <summary>
            /// Actual progress percentage of import/export process
            /// (if larger than <c>100</c> or less than <c>0</c>, progress is unknown)
            /// </summary>
            public ushort Percentage { get; init; }

            /// <summary>
            /// Actual state of import/export process
            /// </summary>
            public string State { get; init; }

            /// <summary>
            /// Creates new arguments for import/export event
            /// </summary>
            /// <param name="percentage">Actual percentage of import/export process</param>
            /// <param name="state">Actual state of import/export process</param>
            public ExportImportEventArgs(ushort percentage, string state)
            {
                this.Percentage = percentage;
                this.State = state;
            }
        }

        /// <summary>
        /// Delegate for handling import/export event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event with actual state</param>
        public delegate void ExportImportEventHandler(object sender, ExportImportEventArgs e);

        /// <summary>
        /// Event for any import/export process update
        /// </summary>
        public event ExportImportEventHandler? ExportImport;

        /// <summary>
        /// Invokes import/export process update event
        /// </summary>
        /// <param name="args">Arguments of event</param>
        protected virtual void OnExportImportUpdate(ExportImportEventArgs args)
        {
            this.ExportImport?.Invoke(this, args);
        }

        /// <summary>
        /// Arguments of import/export log event
        /// </summary>
        public class ExportImportLogEventArgs: EventArgs
        {
            /// <summary>
            /// Message of log
            /// </summary>
            public string Message { get; init; }

            /// <summary>
            /// Date and time when log occured
            /// </summary>
            public DateTime DateTime { get; init; }

            /// <summary>
            /// Creates new arguments for import/export log event
            /// </summary>
            /// <param name="message">Message of log</param>
            public ExportImportLogEventArgs(string message)
            {
                this.Message = message;
                this.DateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Delegate which handles import/export log event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event with message of log</param>
        public delegate void ExportImportLogEventHandler(object sender, ExportImportLogEventArgs e);

        /// <summary>
        /// Event invoked when any new log message has been created during import/export process
        /// </summary>
        public event ExportImportLogEventHandler? ExportImportLog;

        /// <summary>
        /// Invokes import/export log event
        /// </summary>
        /// <param name="args">Arguments of event</param>
        protected virtual void OnExportImportLog(ExportImportLogEventArgs args)
        {
            this.ExportImportLog?.Invoke(this, args);
        }

        /// <summary>
        /// Delegate handling finishing import/export event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        public delegate void ExportImportDoneEventHandler(object sender);

        /// <summary>
        /// Event invoked when import/export process is done
        /// </summary>
        public event ExportImportDoneEventHandler? ExportImportDone;

        /// <summary>
        /// Invokes import/export process done event
        /// </summary>
        protected virtual void OnExportImportDone()
        {
            this.ExportImportDone?.Invoke(this);
        }
    }
}
