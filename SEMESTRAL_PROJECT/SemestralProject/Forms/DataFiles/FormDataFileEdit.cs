using SemestralProject.Data;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.DataFiles
{
    /// <summary>
    /// Class representing dialog for editing data file
    /// </summary>
    internal class FormDataFileEdit: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlDataFile content;

        /// <summary>
        /// Path to data file
        /// </summary>
        public string DataFilePath => this.content.FilePath;

        /// <summary>
        /// Description of data file
        /// </summary>
        public string DataFileDescription => this.content.FileDescription;

        /// <summary>
        /// Information system in which format data file holds data
        /// </summary>
        public InformationSystem? DataFileSystem => this.content.FileSystem;

        /// <summary>
        /// Map which data file holds
        /// </summary>
        public Map? DataFileMap => this.content.FileMap;

        /// <summary>
        /// Creates new dialog for editing data file
        /// </summary>
        /// <param name="dataFile">Data file which will be edited</param>
        /// <param name="context">Wrapper of all program resources</param>
        public FormDataFileEdit(DataFile dataFile, Context context)
            : base("Upravit soubor", "Editace souboru", SemestralProject.Resources.file_edit, context)
        {
            this.content = new ControlDataFile(context, dataFile);
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.icon_file1;
        }
    }
}
