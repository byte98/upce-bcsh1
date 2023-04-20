using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Forms.DataFiles;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Controllers
{
    /// <summary>
    /// Class which handles all actions over files
    /// </summary>
    internal class FilesController : AbstractController<DataFile>
    {
        /// <summary>
        /// Creates new controller of data files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public FilesController(Context context) : base(context){}

        public override void Create()
        {
            FormDataFileAdd dialog = new FormDataFileAdd(this.context);
            if (dialog.ShowDialog() == DialogResult.OK && dialog.DataFileMap != null && dialog.DataFileSystem != null && dialog.DataFilePath != string.Empty && File.Exists(dialog.DataFilePath))
            {
                FormWait wait = new FormWait(() =>
                {
                    string fileName = this.context.FileStorage.AddDataFile(dialog.DataFilePath);
                    this.context.DataStorage.DataFiles.Add(new DataFile(
                        this.GenerateId(),
                        fileName,
                        dialog.DataFileDescription,
                        dialog.DataFilePath,
                        dialog.DataFileSystem,
                        dialog.DataFileMap
                    ));
                    this.context.DataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        /// <summary>
        /// Generates new identifier for data file
        /// </summary>
        /// <returns>Pseudo-random unique identifer for data file</returns>
        private string GenerateId()
        {
            string reti = string.Empty;
            do
            {
                reti = this.GenerateIdentifier("FILE_");
            }
            while (this.GetById(reti) != null);
            return reti;
        }

        /// <summary>
        /// Gets data file by its identifier
        /// </summary>
        /// <param name="id">Searched identifier of data file</param>
        /// <returns>Data file with searched identifier or <c>NULL</c>, if there is no such data file</returns>
        private DataFile? GetById(string id)
        {
            DataFile? reti = null;
            foreach(DataFile file in this.context.DataStorage.DataFiles)
            {
                if (file.Id == id)
                {
                    reti = file;
                    break;
                }
            }
            return reti;
        }

        public override void Delete()
        {
            if (MessageBox.Show(
                        "Opravdu chcete smazat všechny soubory?" + Environment.NewLine +
                        "Počet souborů, které budou smazány: " + this.context.DataStorage.DataFiles.Count + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Smazat soubory",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
            {
                FormWait wait = new FormWait(() =>
                {
                    this.context.DataStorage.DataFiles.Clear();
                    this.context.DataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        public override void Edit(string id)
        {
            DataFile? file = this.GetById(id);
            if (file != null)
            {
                FormDataFileEdit dialog = new FormDataFileEdit(file, this.context);
                if (dialog.ShowDialog() == DialogResult.OK && dialog.DataFileSystem != null && dialog.DataFileMap != null && dialog.DataFilePath != string.Empty && File.Exists(dialog.DataFilePath))
                {
                    FormWait wait = new FormWait(() =>
                    {
                        string fileName = this.context.FileStorage.AddDataFile(dialog.DataFilePath);
                        file.Edit(fileName, dialog.DataFileDescription, dialog.DataFilePath, dialog.DataFileSystem, dialog.DataFileMap);
                        this.context.DataStorage.Save();
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        public override void Info(string id)
        {
            DataFile? file = this.GetById(id);
            if (file != null)
            {
                FormDataFileInfo dialog = new FormDataFileInfo(file, this.context);
                dialog.ShowDialog();
            }
        }

        public override void Remove(string id)
        {
            DataFile? file = this.GetById(id);
            if (file != null)
            {
                FileInfo fi = new FileInfo(file.OriginalPath);
                if (MessageBox.Show(
                        "Opravdu chcete odstranit soubor " + fi.Name + "?" + Environment.NewLine +
                        "Tato akce je nevratná.",
                        "Ostranit soubor",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        if (this.context.DataStorage.DataFiles.Contains(file))
                        {
                            this.context.DataStorage.DataFiles.Remove(file);
                        }
                        this.context.DataStorage.Save();
                        file = null;
                    }, this.context);
                    wait.ShowDialog();
                }
            }
        }

        public override List<DataFile> Search(string phrase)
        {
            List<DataFile> reti = new List<DataFile>();
            FormWait wait = new FormWait(() =>
            {
                foreach (DataFile file in this.context.DataStorage.DataFiles)
                {
                    if (file.Matches(phrase))
                    {
                        reti.Add(file);
                    }
                }
            }, this.context);
            wait.ShowDialog();
            return reti;
        }
    }
}
