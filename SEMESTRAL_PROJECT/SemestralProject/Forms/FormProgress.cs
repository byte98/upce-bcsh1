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
    /// Class which represents form which informs about progress of process
    /// </summary>
    internal class FormProgress : FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        public ControlProgress Content { get; init; }

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
        /// Creates new form which informs about export process
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <returns>Form which has ability to inform about export process</returns>
        public static FormProgress CreateExportForm(Context context)
        {
            return new FormProgress(context, SemestralProject.Resources.export32, "Export dat", "Exportování dat");
        }

        /// <summary>
        /// Creates new form which informs about import process
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <returns>Form which has ability to inform about import process</returns>
        public static FormProgress CreateImportForm(Context context)
        {
            return new FormProgress(context, SemestralProject.Resources.import32, "Import dat", "Importování dat");
        }

        /// <summary>
        /// Creates new form which informs about process of copiing files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <returns>Form which has ability to inform about process of copiing files</returns>
        public static FormProgress CreateCopyForm(Context context)
        {
            return new FormProgress(context, SemestralProject.Resources.copy32, "Kopírovat soubory", "Kopírování souborů");
        }

        /// <summary>
        /// Creates new form which informs about process of copiing and replacing files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <returns>Form which has ability to inform about process of copiing and replacing files</returns>
        public static FormProgress CreateCopyReplaceForm(Context context)
        {
            return new FormProgress(context, SemestralProject.Resources.copyr32, "Kopírovat a nahradit soubory", "Kopírování a nahrazování souborů");
        }

        /// <summary>
        /// Creates new form which informs about process of deleting all data and files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <returns>Form which has ability to inform about process of deleting all data and files</returns>
        public static FormProgress CreateDeleteForm(Context context)
        {
            return new FormProgress(context, SemestralProject.Resources.delete32, "Smazat všechny soubory a data", "Mazání všech souboru a dat");
        }

        /// <summary>
        /// Creates new dialog for informing about import/export process
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="icon">Icon displayed in header</param>
        /// <param name="title">Title of dialog</param>
        /// <param name="header">Text displayed in </param>
        private FormProgress(Context context, Bitmap icon, string title, string header)
            : base(title, header, icon, context)
        {
            this.HideCancelButton();
            this.DisableButtons();
            this.HideCloseButton();
            this.Content = new ControlProgress(this.Context);
            this.AddControl(this.Content);
            this.OnOKClicked(delegate (object? sender, EventArgs e)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this)
                    {
                        form.Enabled = true;
                    }
                }
                this.Close();
            });
            this.Load += FormProgress_Load;
        }

        private void FormProgress_Load(object? sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Enabled = false;
                }
            }
        }
    }
}
