using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Utils
{
    /// <summary>
    /// Class which performs deleting all data and files
    /// </summary>
    internal class Deleter: AbstractProgress
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        private readonly Context context;

        /// <summary>
        /// Creates new object which performs deleting all data and files
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public Deleter(Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Gets list of needed actions to sucessfull deleting all data and files
        /// </summary>
        /// <returns>List of all needed actions to successfull deleting all data and files</returns>
        public List<Action> GetDeleteSequence()
        {
            List<Action> reti = new List<Action>();
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(0, "Připravuji smazání všech dat a souborů...")); })); ;
            reti.Add(new Action(() =>
            {
                this.OnProgress(new ProgressEventArgs(0, "Mažu ikony..."));
                double step = 15f / (double)this.context.FileStorage.GetAllIcons().Length;

                // Get names of default icons
                string defaultIcon = this.context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.ANY).Name;
                string isIcon = this.context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.IS).Name;
                string mapIcon = this.context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.MAP).Name;
                string manufacturerIcon = this.context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.MANUFACTURER).Name;
                string fileIcon = this.context.FileStorage.GetIcon(Persistence.FileStorage.DefaultIconType.FILE).Name;

                int counter = 0;
                foreach(Icon icon in this.context.FileStorage.GetAllIcons())
                {
                    counter++;
                    ushort progress = (ushort)(0 + (ushort)Math.Round((double)counter * step));
                    this.OnProgress(new ProgressEventArgs(progress, "Mažu ikony..."));

                    // Check, if icon is default or not
                    if (icon.Name != defaultIcon && icon.Name != isIcon && icon.Name != mapIcon && icon.Name != manufacturerIcon && icon.Name != fileIcon)
                    {
                        string? path = this.context.FileStorage.GetIconPath(icon);
                        if (path != null)
                        {
                            if (File.Exists(path))
                            {
                                this.context.FileStorage.RemoveIcon(icon);
                                this.OnProgressLog(new ProgressLogEventArgs("Smazána ikona " + icon.Name));
                            }
                            else
                            {
                                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze smazat ikonu " + icon.Name + " (soubor nenalezen)!"));
                            }
                        }
                        else
                        {
                            this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze smazat ikonu " + icon.Name + " (neznámá cesta)!"));
                        }
                        
                    }
                    else
                    {
                        this.OnProgressLog(new ProgressLogEventArgs("Ikona " + icon.Name + " je výchozí (nebude smazána)"));
                    }
                }
                this.OnProgress(new ProgressEventArgs(15, "Mažu ikony..."));
            }));
            reti.Add(new Action(() =>
            {
                this.OnProgress(new ProgressEventArgs(15, "Mažu obrázky..."));
                double step = 15f / (double)this.context.FileStorage.GetPictures().Length;

                // Get default picture
                string defaultPict = this.context.FileStorage.GetPictureChecked(null).Name;

                int counter = 0;
                foreach(Picture picture in this.context.FileStorage.GetPictures())
                {
                    counter++;
                    ushort progress = (ushort)(15 + (ushort)Math.Round((double)counter * step));
                    this.OnProgress(new ProgressEventArgs(progress, "Mažu obrázky..."));

                    if (picture.Name != defaultPict)
                    {
                        string? path = this.context.FileStorage.GetPicturePath(picture);
                        if (path != null)
                        {
                            if (File.Exists(path))
                            {
                                this.context.FileStorage.RemovePicture(picture);
                                this.OnProgressLog(new ProgressLogEventArgs("Smazán obrázek " + picture.Name));
                            }
                            else
                            {
                                this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze smazat obrázek " + picture.Name + " (soubor neexistuje)!"));
                            }
                        }
                        else
                        {
                            this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze smazat obrázek " + picture.Name + " (neznámá cesta)!"));
                        }
                    }
                    else
                    {
                        this.OnProgressLog(new ProgressLogEventArgs("Obrázek " + picture.Name + " je výchozí (nebude smazán)"));
                    }
                }
                this.OnProgress(new ProgressEventArgs(30, "Mažu obrázky..."));
            }));
            reti.Add(new Action(() => {
                this.OnProgress(new ProgressEventArgs(30, "Mažu obsah datových souborů..."));
                double step = 15f / (double)this.context.FileStorage.GetDataFiles().Length;
                int counter = 0;
                foreach(string dataFile in this.context.FileStorage.GetDataFiles())
                {
                    counter++;
                    ushort progress = (ushort)(15 + (ushort)Math.Round((double)counter * step));
                    this.OnProgress(new ProgressEventArgs(progress, "Mažu obsah datových souborů..."));
                    string? path = this.context.FileStorage.GetDataFilePath(dataFile);
                    if (path != null)
                    {
                        if (File.Exists(path))
                        {
                            this.context.FileStorage.RemoveDataFile(dataFile);
                            this.OnProgressLog(new ProgressLogEventArgs("Smazán obsah datového souboru " + dataFile));
                        }
                        else
                        {
                            this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze smazat obsah datového souboru " + dataFile + " (soubor neexistuje)!"));
                        }
                    }
                    else
                    {
                        this.OnProgressLog(new ProgressLogEventArgs("CHYBA: Nelze smazat obsah datového souboru " + dataFile + "(neznámá cesta)!"));
                    }
                }
            }));
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(45, "Mažu datové soubory...")); this.context.DataStorage.DataFiles.Clear(); this.OnProgressLog(new ProgressLogEventArgs("Smazány datové soubory")); this.OnProgress(new ProgressEventArgs(51, "Mažu datové soubory...")); }));
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(52, "Mažu vozidla...")); this.context.DataStorage.Vehicles.Clear(); this.OnProgressLog(new ProgressLogEventArgs("Smazány vozidla")); this.OnProgress(new ProgressEventArgs(58, "Mažu vozidla...")); }));
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(59, "Mažu výrobce...")); this.context.DataStorage.Manufacturers.Clear(); this.OnProgressLog(new ProgressLogEventArgs("Smazáni výrobci")); this.OnProgress(new ProgressEventArgs(65, "Mažu výrobce...")); }));
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(66, "Mažu oblasti...")); this.context.DataStorage.Maps.Clear(); this.OnProgressLog(new ProgressLogEventArgs("Smazány oblasti")); this.OnProgress(new ProgressEventArgs(72, "Mažu oblasti...")); }));
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(73, "Mažu informační systémy")); this.context.DataStorage.InformationSystems.Clear(); this.OnProgressLog(new ProgressLogEventArgs("Smazány informační systémy")); this.OnProgress(new ProgressEventArgs(80, "Mažu informační systémy...")); }));
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(80, "Dokončuji mazání všech dat a souborů...")); this.context.DataStorage.Save(); this.OnProgressLog(new ProgressLogEventArgs("Úložiště dat uloženo")); this.OnProgress(new ProgressEventArgs(90, "Dokončuji mazání všech dat a souborů...")); }));
            reti.Add(new Action(() => { this.OnProgress(new ProgressEventArgs(100, "Hotovo")); this.OnProgressLog(new ProgressLogEventArgs("Hotovo")); this.OnProcessDone(); }));
            return reti;
        }
    }
}
