using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Utils
{
    /// <summary>
    /// Class abstracting commmon attributes for any process which reports progress
    /// </summary>
    internal abstract class AbstracProgress
    {
        /// <summary>
        /// Arguments for progress event
        /// </summary>
        public class ProgressEventArgs : EventArgs
        {
            /// <summary>
            /// Actual progress percentage of progress of process
            /// (if larger than <c>100</c> or less than <c>0</c>, progress is unknown)
            /// </summary>
            public ushort Percentage { get; init; }

            /// <summary>
            /// Actual state of progress of process
            /// </summary>
            public string State { get; init; }

            /// <summary>
            /// Creates new arguments for progress event
            /// </summary>
            /// <param name="percentage">Actual percentage of progress of process</param>
            /// <param name="state">Actual state of progress of process</param>
            public ProgressEventArgs(ushort percentage, string state)
            {
                Percentage = percentage;
                State = state;
            }
        }

        /// <summary>
        /// Delegate for handling progress event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event with actual state</param>
        public delegate void ProgressEventHandler(object sender, ProgressEventArgs e);

        /// <summary>
        /// Event for any progress of process update
        /// </summary>
        public event ProgressEventHandler? Progress;

        /// <summary>
        /// Invokes progress of process update event
        /// </summary>
        /// <param name="args">Arguments of event</param>
        protected virtual void OnProgress(ProgressEventArgs args)
        {
            Progress?.Invoke(this, args);
        }

        /// <summary>
        /// Arguments of progress log event
        /// </summary>
        public class ProgressLogEventArgs : EventArgs
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
            /// Creates new arguments for progress log event
            /// </summary>
            /// <param name="message">Message of log</param>
            public ProgressLogEventArgs(string message)
            {
                Message = message;
                DateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Delegate which handles progress log event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        /// <param name="e">Arguments of event with message of log</param>
        public delegate void ProgressLogEventHandler(object sender, ProgressLogEventArgs e);

        /// <summary>
        /// Event invoked when any new log message has been created during progress of process
        /// </summary>
        public event ProgressLogEventHandler? ProgressLog;

        /// <summary>
        /// Invokes progress log event
        /// </summary>
        /// <param name="args">Arguments of event</param>
        protected virtual void OnProgressLog(ProgressLogEventArgs args)
        {
            ProgressLog?.Invoke(this, args);
        }

        /// <summary>
        /// Delegate handling finishing process event
        /// </summary>
        /// <param name="sender">Sender of event</param>
        public delegate void ProcessDoneEvent(object sender);

        /// <summary>
        /// Event invoked when process is done
        /// </summary>
        public event ProcessDoneEvent? ProcessDone;

        /// <summary>
        /// Invokes process done event
        /// </summary>
        protected virtual void OnProcessDone()
        {
            ProcessDone?.Invoke(this);
        }
    }
}
