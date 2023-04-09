using SemestralProject.Data;
using SemestralProject.Forms;
using SemestralProject.Forms.Manufacturers;
using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Controllers
{
    /// <summary>
    /// Class which controls operations over manufacturers
    /// </summary>
    internal class ManufacturersController: AbstractController
    {
        /// <summary>
        /// Creates new controller of operations over manufacturers
        /// </summary>
        /// <param name="context">Wrapper of all system resources</param>
        public ManufacturersController(Context context) : base(context) { }

        /// <summary>
        /// Creates new manufacturer
        /// </summary>
        public void Create()
        {
            FormManufacturerAdd dialog = new FormManufacturerAdd(this.context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FormWait wait = new FormWait(() =>
                {
                    if (dialog.ManufacturerName != null && dialog.ManufacturerDescription != null && dialog.ManufacturerIcon != null)
                    {
                        this.context.DataStorage.Manufacturers.Add(new Data.Manufacturer(
                            this.GenerateId(),
                            dialog.ManufacturerName,
                            dialog.ManufacturerDescription,
                            dialog.ManufacturerIcon
                        ));
                    }
                    this.context.DataStorage.Save();
                }, this.context);
                wait.ShowDialog();
            }
        }

        /// <summary>
        /// Generates new identifier of information system
        /// </summary>
        /// <returns>Pseudo-random unique identifier</returns>
        private string GenerateId()
        {
            string reti = string.Empty;
            do
            {
                reti = this.GenerateIdentifier("MAN_");
            }
            while (this.GetById(reti) != null);
            return reti;
        }

        /// <summary>
        /// Gets manufacturer by its identifier
        /// </summary>
        /// <param name="id">Identifier of manufacturer</param>
        /// <returns>Manufacturer defined by identifer or <c>NULL</c>, if there is no such manufacturer</returns>
        public Manufacturer? GetById(string id)
        {
            Manufacturer? reti = null;
            foreach (Manufacturer manufacturer in this.context.DataStorage.Manufacturers)
            {
                if (manufacturer.Id == id)
                {
                    reti = manufacturer;
                    break;
                }
            }
            return reti;
        }
    }
}
