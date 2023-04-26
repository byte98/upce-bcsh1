using SemestralProject.Data;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.DataFiles
{
    /// <summary>
    /// Class representing dialog which shows information about data file
    /// </summary>
    internal class FormDataFileInfo: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlDataFileDetail content;

        /// <summary>
        /// Creates new dialog which shows information about data file
        /// </summary>
        /// <param name="datafile">Data file which information will be displayed</param>
        /// <param name="context">Wrapper of all system resources</param>
        public FormDataFileInfo(DataFile datafile, Context context)
            : base("Informace o souboru", "Detail souboru", SemestralProject.Resources.file_info,context)
        {
            this.content = new ControlDataFileDetail(datafile, context);
            this.AddControl(this.content);
            this.HideCancelButton();
            this.Icon = SemestralProject.Resources.icon_file1;
        }
    }
}
