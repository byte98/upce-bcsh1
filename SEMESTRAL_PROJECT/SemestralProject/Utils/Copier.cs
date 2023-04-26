using SemestralProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Utils
{
    /// <summary>
    /// Class which copies data files to right directories
    /// </summary>
    internal class Copier : AbstractProgress
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        private readonly Context context;

        /// <summary>
        /// Structure holding information about one single copy action
        /// </summary>
        private struct CopyItem
        {
            /// <summary>
            /// File which will be copied
            /// </summary>
            public DataFile File { get; init; }

            /// <summary>
            /// Vehicle to which file will be copied
            /// </summary>
            public Vehicle Vehicle { get; init; }

            /// <summary>
            /// Flag, whether file should be replaced
            /// </summary>
            public bool Replace { get; init; }

            /// <summary>
            /// Number of operation
            /// </summary>
            public int Number { get; init; }

            /// <summary>
            /// Total number of operations
            /// </summary>
            public int Total { get; init; }

            /// <summary>
            /// Percentage of progress in whole process of copiing at the start of operation
            /// </summary>
            public ushort StartPercentage { get; init; }

            /// <summary>
            /// Percentage of progress in whole process of copiing at the end of operation
            /// </summary>
            public ushort FinalPercentage { get; init; }

            /// <summary>
            /// Creates new one single copy action
            /// </summary>
            /// <param name="file">File which will be copied</param>
            /// <param name="vehicle">Vehicle to which file will be copied</param>
            /// <param name="replace">Flag, whether file should be replaced (<c>TRUE</c>) or not (<c>FALSE</c>)</param>
            /// <param name="number">Number of operation</param>
            /// <param name="total">Total number of operations</param>
            /// <param name="startPercentage">Percentage of progress in whole process of copiing at the start of operation</param>
            /// <param name="finalPercentage">Percentage of progress in whole process of copiing at the end of operation</param>
            public CopyItem(DataFile file, Vehicle vehicle, bool replace, int number, int total, ushort startPercentage, ushort finalPercentage)
            {
                this.File = file;
                this.Vehicle = vehicle;
                this.Replace = replace;
                this.Number = number;
                this.Total = total;
                this.StartPercentage = startPercentage;
                this.FinalPercentage = finalPercentage;
            }
        }

        /// <summary>
        /// Creates new object which copies data files to right directories
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public Copier(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets data files by information system in which format are data stored
        /// </summary>
        /// <param name="informationSystem">Information system in which format data are stored</param>
        /// <returns>List of all files which stores data in format defined by information system</returns>
        private List<DataFile> GetDataFiles(InformationSystem informationSystem)
        {
            List<DataFile> reti = new List<DataFile>();
            foreach(DataFile dataFile in this.context.DataStorage.DataFiles)
            {
                if (dataFile.InformationSystem.Id == informationSystem.Id)
                {
                    reti.Add(dataFile);
                }
            }
            return reti;
        }
        
        /// <summary>
        /// Computes number of all needed copy operations
        /// </summary>
        /// <returns>Number of all needed copy operations</returns>
        private int ComputeCopyOperations()
        {
            int reti = 0;
            foreach(Vehicle vehicle in this.context.DataStorage.Vehicles)
            {
                reti += this.GetDataFiles(vehicle.InformationSystem).Count;
            }
            return reti;
        }

        /// <summary>
        /// Executes one copy operation
        /// </summary>
        /// <param name="item">Structure holding information about copy operation</param>
        private void ExecuteCopy(Copier.CopyItem item)
        {
            this.OnProgress(new ProgressEventArgs(item.StartPercentage, "Kopíruji soubory (" + item.Number + " / " + item.Total + ")..."));
            string? source = this.context.FileStorage.GetDataFilePath(item.File.Name);
            if (source != null)
            {
                FileInfo fi = new FileInfo(item.File.OriginalPath);
                string destination = this.context.Configuration.VehiclesRoot + Path.DirectorySeparatorChar + item.Vehicle.Path + Path.DirectorySeparatorChar + fi.Name;
                if (File.Exists(destination) && item.Replace == true)
                {
                    File.Delete(destination);
                    this.OnProgressLog(new ProgressLogEventArgs("Smazán soubor " + destination));
                }
                File.Copy(source, destination);
                this.OnProgressLog(new ProgressLogEventArgs("Zkopírován soubor " + fi.Name + " do vozidla " + item.Vehicle.Name));
            }
            else
            {
                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze najít cestu k souboru " + item.File.Name));
            }
            this.OnProgress(new ProgressEventArgs(item.FinalPercentage, "Kopíruji soubory (" + item.Number + " / " + item.Total + ")..."));
        }

        /// <summary>
        /// Generates sequence of commands needed to successfull copy of files
        /// </summary>
        /// <param name="replace">Flag, whether files should be replaced or not</param>
        /// <returns>List with all actions needed to successfull copy of files</returns>
        public List<Action> GetCopySequence(bool replace)
        {
            List<Action> reti = new List<Action>();
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(0, "Připravuji kopírování souborů...")); }));
            ushort portion = 90;
            int steps = this.ComputeCopyOperations();
            ushort progress = 5;
            int counter = 0;
            foreach(Vehicle vehicle in this.context.DataStorage.Vehicles)
            {
                foreach(DataFile dataFile in this.GetDataFiles(vehicle.InformationSystem))
                {
                    ushort final = (ushort)(5 + (ushort)Math.Round((double)counter * ((double)portion / (double)steps)));
                    counter++;
                    Copier.CopyItem item = new CopyItem(
                        dataFile,
                        vehicle,
                        replace,
                        counter,
                        steps,
                        progress,
                        final
                    );
                    reti.Add(new Action(() => { this.ExecuteCopy(item); }));
                    progress = final;
                }
            }
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(100, "Hotovo")); this.OnProcessDone(); }));
            return reti;
        }


    }
}
