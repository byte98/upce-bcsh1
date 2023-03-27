using SemestralProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms.InformationSystems
{
    /// <summary>
    /// Class representing dialog with information about information system
    /// </summary>
    internal class FormISInfo: FormDialog
    {
        /// <summary>
        /// Information system which details will be displayed
        /// </summary>
        private readonly InformationSystem system;

        /// <summary>
        /// Control which represents content of dialog
        /// </summary>
        private readonly ControlISInfo content;

        /// <summary>
        /// Creates new dialog with information about system
        /// </summary>
        /// <param name="system">Information system which details will be displayed</param>
        public FormISInfo(InformationSystem system) : base("Informace o systému", "Informace o systému", SemestralProject.Resources.is_info)
        {
            this.system = system;
            this.content = new ControlISInfo();
            this.AddControl(this.content);
            this.content.InformationSystem = this.system;
            this.HideCancelButton();
        }
    }
}
