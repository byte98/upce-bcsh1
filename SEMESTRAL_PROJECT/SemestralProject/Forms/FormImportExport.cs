using SemestralProject.Persistence;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class which represents form which informs about import/export process
    /// </summary>
    internal class FormImportExport : FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        public ControlExportImport Content { get; init; }

        /// <summary>
        /// Attrinbute holding flag, whether buttons are enabled or not
        /// </summary>
        private bool buttonsEnabled = false;

        /// <summary>
        /// Flag, whether buttons are enabled or not
        /// </summary>
        public bool ButtonsEnabled
        {
            get
            {
                return this.buttonsEnabled;
            }
            set
            {
                this.buttonsEnabled = value;
                if (this.buttonsEnabled)
                {
                    this.EnableButtons();
                }
                else
                {
                    this.DisableButtons();
                }
            }
        }

        /// <summary>
        /// Creates new dialog for informing about export process
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public FormImportExport(Context context)
            : base("Export dat", "Exportování dat", SemestralProject.Resources.export32, context)
        {
            this.HideCancelButton();
            this.DisableButtons();
            this.HideCloseButton();
            this.Content = new ControlExportImport(this.Context);
            this.AddControl(this.Content);
            this.OnOKClicked(delegate (object? sender, EventArgs e)
            {
                this.Close();
            });
        }
    }
}
