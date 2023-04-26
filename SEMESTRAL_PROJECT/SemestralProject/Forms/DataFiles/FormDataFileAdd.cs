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
    /// Class representing dialog for creating new data file
    /// </summary>
    internal class FormDataFileAdd: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlDataFile content;

        /// <summary>
        /// Path to physical file
        /// </summary>
        public string DataFilePath => this.content.FilePath;

        /// <summary>
        /// Description of data file
        /// </summary>
        public string DataFileDescription => this.content.FileDescription;

        /// <summary>
        /// Information system in which format are data formatted
        /// </summary>
        public InformationSystem? DataFileSystem => this.content.FileSystem;

        /// <summary>
        /// Map which data are hold by data file
        /// </summary>
        public Map? DataFileMap => this.content.FileMap;

        /// <summary>
        /// Creates new dialog for creating new data file
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public FormDataFileAdd(Context context)
            : base("Přidat soubor", "Nový soubor", SemestralProject.Resources.file_add, context)
        {
            this.content = new ControlDataFile(this.Context);
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.icon_file1;
        }
    }
}
