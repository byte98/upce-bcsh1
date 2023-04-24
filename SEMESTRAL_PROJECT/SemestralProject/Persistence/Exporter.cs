using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Persistence
{
    /// <summary>
    /// Class representing exporter of current state of program into file
    /// </summary>
    internal class Exporter: AbstractExporterImporter
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        private readonly Context context;

        /// <summary>
        /// Actuall progress of export
        /// </summary>
        private ushort progress = 0;

        /// <summary>
        /// Path to file to which data will be exported into
        /// </summary>
        public string OutputPath { private get; set; }


        /// <summary>
        /// Creates new class which performs export of current state of program into file
        /// </summary>
        /// <param name="context">Wrapper of all program resources which will be exported</param>
        public Exporter(Context context)
        {
            this.context = context;
            this.OutputPath = string.Empty;
        }

        /// <summary>
        /// Exports state of program into file
        /// </summary>
        public void Export()
        {
            this.progress = 0;
            this.OnExportImportUpdate(new ExportImportEventArgs(ushort.MaxValue, "Připravuji export dat..."));
            this.MakeExportDirectory();
        }

        /// <summary>
        /// Prepares directory where all exported data will be temporarily saved
        /// </summary>
        private void MakeExportDirectory()
        {
            string path = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT";
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                this.OnExportImportLog(new ExportImportLogEventArgs("Smazán adresář " + path));
            }
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji export dat..."));
            Directory.CreateDirectory(path);
            this.progress++;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji export dat..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Vytvořen adresář " + path));
            Directory.CreateDirectory(path + Path.DirectorySeparatorChar + "DB");
            this.progress++;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji export dat..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Vytvořen adresář " + path + Path.DirectorySeparatorChar + "DB"));
            Directory.CreateDirectory(path + Path.DirectorySeparatorChar + "ICONS");
            this.progress++;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji export dat..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Vytvořen adresář " + path + Path.DirectorySeparatorChar + "ICONS"));
            Directory.CreateDirectory(path + Path.DirectorySeparatorChar + "PICTURES");
            this.progress++;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji export dat..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Vytvořen adresář " + path + Path.DirectorySeparatorChar + "PICTURES"));
            Directory.CreateDirectory(path + Path.DirectorySeparatorChar + "DATAFILES");
            this.progress++;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Připravuji export dat..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Vytvořen adresář " + path + Path.DirectorySeparatorChar + "DATAFILES"));
        }

        /// <summary>
        /// Exports information systems
        /// (this can be called AFTER <see cref="Export(string)" !)/>
        /// </summary>
        public void ExportInformationSystems()
        {
            string input = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.ISFile;
            string output = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + "DB" + Path.DirectorySeparatorChar + DataStorage.ISFile;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Exportuji informační systémy..."));
            File.Copy(input, output, true);
            this.OnExportImportLog(new ExportImportLogEventArgs("Zkopírován soubor " + input + " (" + output + ")"));
            this.progress += (40 / 5);
        }

        /// <summary>
        /// Exports maps
        /// (this can be called AFTER <see cref="Export(string)" !)/>
        /// </summary>
        public void ExportMaps()
        {
            string input = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.MapFile;
            string output = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + "DB" + Path.DirectorySeparatorChar + DataStorage.MapFile;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Exportuji oblasti..."));
            File.Copy(input, output, true);
            this.OnExportImportLog(new ExportImportLogEventArgs("Zkopírován soubor " + input + " (" + output + ")"));
            this.progress += (40 / 5);
        }

        /// <summary>
        /// Exports manufacturers
        /// (this can be called AFTER <see cref="Export(string)" !)/>
        /// </summary>
        public void ExportManufacturers()
        {
            string input = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.ManufacturerFile;
            string output = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + "DB" + Path.DirectorySeparatorChar + DataStorage.ManufacturerFile;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Exportuji výrobce..."));
            File.Copy(input, output, true);
            this.OnExportImportLog(new ExportImportLogEventArgs("Zkopírován soubor " + input + " (" + output + ")"));
            this.progress += (40 / 5);
        }

        /// <summary>
        /// Exports vehicles
        /// (this can be called AFTER <see cref="Export(string)" !)/>
        /// </summary>
        public void ExportVehicles()
        {
            string input = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.VehicleFile;
            string output = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + "DB" + Path.DirectorySeparatorChar + DataStorage.VehicleFile;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Exportuji vozidla..."));
            File.Copy(input, output, true);
            this.OnExportImportLog(new ExportImportLogEventArgs("Zkopírován soubor " + input + " (" + output + ")"));
            this.progress += (40 / 5);
        }

        /// <summary>
        /// Exports data files
        /// (this can be called AFTER <see cref="Export(string)" !)/>
        /// </summary>
        public void ExportDataFiles()
        {
            string input = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_DB" + Path.DirectorySeparatorChar + DataStorage.DataFileFile;
            string output = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + "DB" + Path.DirectorySeparatorChar + DataStorage.DataFileFile;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Exportuji datové soubory..."));
            File.Copy(input, output, true);
            this.OnExportImportLog(new ExportImportLogEventArgs("Zkopírován soubor " + input + " (" + output + ")"));
            this.progress += (40 / 5);
        }

        /// <summary>
        /// Exports icons
        /// (this can be called AFTER <see cref="Export(string)"/>!)
        /// </summary>
        public void ExportIcons()
        {
            double step = 15f / (2f * this.context.FileStorage.GetAllIcons().Count());
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Exportuji ikony..."));
            List<FileWrapper> files = new List<FileWrapper>();
            string iconIn = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[ICONS]";
            string iconOut = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + "ICONS" + Path.DirectorySeparatorChar;
            int counter = 0;
            foreach(Icon icon in this.context.FileStorage.GetAllIcons())
            {
                string? iconFileIn = this.context.FileStorage.GetIconPath(icon);
                if (iconFileIn != null)
                {
                    FileInfo fi = new FileInfo(iconFileIn);
                    string iconFileOut = iconOut + Path.DirectorySeparatorChar + icon.Name;
                    File.Copy(iconFileIn, iconFileOut, true);
                    files.Add(new FileWrapper(icon.Name, iconFileIn, fi.Name));
                    this.OnExportImportLog(new ExportImportLogEventArgs("Zkopírován soubor " + iconFileIn + " (" + iconFileOut + ")"));
                    this.OnExportImportUpdate(new ExportImportEventArgs((ushort)Math.Round((double)this.progress + (counter * step)), "Exportuji ikony..."));
                    counter++;
                }
                else
                {
                    this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Kopírování souboru ikony " + icon.Name + " se nezdařilo!"));
                }
            }
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration(DataStorage.XML._Version, DataStorage.XML._Charset, null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement icons = doc.CreateElement(string.Empty, "ICONS", string.Empty);
            doc.AppendChild(icons);
            foreach (FileWrapper file in files)
            {
                file.ToXml(doc, "ICON", icons);
                this.OnExportImportLog(new ExportImportLogEventArgs("Zapsány údaje k souboru " + file.Path));
                this.OnExportImportUpdate(new ExportImportEventArgs((ushort)Math.Round((double)this.progress + (counter * step)), "Exportuji ikony..."));
                counter++;
            }
            doc.Save(iconOut + "ICONS.XML");
            this.progress = (ushort)Math.Round((double)this.progress + (counter * step));
        }

        /// <summary>
        /// Exports pictures
        /// (this can be called AFTER <see cref="Export(string)"/>!)
        /// </summary>
        public void ExportPictures()
        {
            double step = 15f / (2f * this.context.FileStorage.GetPictures().Count());
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Exportuji obrázky..."));
            List<FileWrapper> files = new List<FileWrapper>();
            string pictureIn = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[PICTURES]";
            string pictureOut = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + "PICTURES" + Path.DirectorySeparatorChar;
            int counter = 0;
            foreach (Picture picture in this.context.FileStorage.GetPictures())
            {
                string? pictureFileIn = this.context.FileStorage.GetPicturePath(picture);
                if (pictureFileIn != null)
                {
                    FileInfo fi = new FileInfo(pictureFileIn);
                    string pictureFileOut = pictureOut + Path.DirectorySeparatorChar + picture.Name;
                    File.Copy(pictureFileIn, pictureFileOut, true);
                    files.Add(new FileWrapper(picture.Name, pictureFileIn, fi.Name));
                    this.OnExportImportLog(new ExportImportLogEventArgs("Zkopírován soubor " + pictureFileIn + " (" + pictureFileOut + ")"));
                    this.OnExportImportUpdate(new ExportImportEventArgs((ushort)Math.Round((double)this.progress + (counter * step)), "Exportuji obrázky..."));
                    counter++;
                }
                else
                {
                    this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Kopírování souboru obrázku " + picture.Name + " se nezdařilo!"));
                }
            }
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration(DataStorage.XML._Version, DataStorage.XML._Charset, null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement pictures = doc.CreateElement(string.Empty, "PICTURES", string.Empty);
            doc.AppendChild(pictures);
            foreach (FileWrapper file in files)
            {
                file.ToXml(doc, "PICTURE", pictures);
                this.OnExportImportLog(new ExportImportLogEventArgs("Zapsány údaje k souboru " + file.Path));
                this.OnExportImportUpdate(new ExportImportEventArgs((ushort)Math.Round((double)this.progress + (counter * step)), "Exportuji obrázky..."));
                counter++;
            }
            doc.Save(pictureOut + "PICTURES.XML");
            this.progress = (ushort)Math.Round((double)this.progress + (counter * step));
        }


        /// <summary>
        /// Exports data files content
        /// (this can be called AFTER <see cref="Export(string)"/>!)
        /// </summary>
        public void ExportDataFilesContent()
        {
            double step = 15f / (2f * this.context.FileStorage.GetDataFiles().Count());
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Exportuji obsah datových souborů..."));
            List<FileWrapper> files = new List<FileWrapper>();
            string dataFileIn = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_FS" + Path.DirectorySeparatorChar + "[DATAFILES]";
            string dataFileOut = this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + "DATAFILES" + Path.DirectorySeparatorChar;
            int counter = 0;
            foreach (string dataFile in this.context.FileStorage.GetDataFiles())
            {
                string? dataFileInFile = this.context.FileStorage.GetDataFilePath(dataFile);
                if (dataFileInFile != null)
                {
                    FileInfo fi = new FileInfo(dataFileInFile);
                    string dataFileOutFile = dataFileOut + Path.DirectorySeparatorChar + dataFile;
                    File.Copy(dataFileInFile, dataFileOutFile, true);
                    files.Add(new FileWrapper(dataFile, dataFileInFile, fi.Name));
                    this.OnExportImportLog(new ExportImportLogEventArgs("Zkopírován soubor " + dataFileInFile + " (" + dataFileOutFile + ")"));
                    this.OnExportImportUpdate(new ExportImportEventArgs((ushort)Math.Round((double)this.progress + (counter * step)), "Exportuji obsah datových souborů..."));
                    counter++;
                }
                else
                {
                    this.OnExportImportLog(new ExportImportLogEventArgs("CHYBA: Kopírování obsahu datového souboru " + dataFile + " se nezdařilo!"));
                }
            }
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration(DataStorage.XML._Version, DataStorage.XML._Charset, null);
            XmlElement? root = doc.DocumentElement;
            doc.InsertBefore(declaration, root);
            XmlElement datafiles = doc.CreateElement(string.Empty, "DATAFILES", string.Empty);
            doc.AppendChild(datafiles);
            foreach (FileWrapper file in files)
            {
                file.ToXml(doc, "DATAFILE", datafiles);
                this.OnExportImportLog(new ExportImportLogEventArgs("Zapsány údaje k souboru " + file.Path));
                this.OnExportImportUpdate(new ExportImportEventArgs((ushort)Math.Round((double)this.progress + (counter * step)), "Exportuji obsah datových souborů..."));
                counter++;
            }
            doc.Save(dataFileOut + "DATAFILES.XML");
            this.progress = (ushort)Math.Round((double)this.progress + (counter * step));
        }

        /// <summary>
        /// Finishes export of data
        /// (this can be as LAST call of any export function)
        /// </summary>
        public void FinishExport()
        {
            this.progress = 90;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Dokončuji export dat..."));
            if (File.Exists(this.OutputPath))
            {
                File.Delete(this.OutputPath);
                this.OnExportImportLog(new ExportImportLogEventArgs("Smazán soubor " + this.OutputPath));
            }
            ZipFile.CreateFromDirectory(this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT", this.OutputPath);
            this.OnExportImportLog(new ExportImportLogEventArgs("Vytvořen soubor " + this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT" + Path.DirectorySeparatorChar + this.OutputPath));
            this.progress = 95;
            Directory.Delete(this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT", true);
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Dokončuji export dat..."));
            this.OnExportImportLog(new ExportImportLogEventArgs("Smazán adresář " + this.context.Configuration.TempDir + Path.DirectorySeparatorChar + "_EXPORT"));
            this.progress = 100;
            this.OnExportImportUpdate(new ExportImportEventArgs(this.progress, "Hotovo"));
            this.OnExportImportLog(new ExportImportLogEventArgs("Hotovo"));
            this.OnExportImportDone();
        }
    }
}
