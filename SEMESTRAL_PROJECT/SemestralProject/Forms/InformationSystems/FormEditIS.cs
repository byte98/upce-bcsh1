using SemestralProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icon = SemestralProject.Visual.Icon;  

namespace SemestralProject.Forms.InformationSystems
{
    /// <summary>
    /// Class representing edit information system dialog
    /// </summary>
    internal class FormEditIS: FormDialog
    {
        /// <summary>
        /// Reference to content of dialog
        /// </summary>
        private ControlEditIS content;

        /// <summary>
        /// Name of information system
        /// </summary>
        public string ISName
        {
            get
            {
                return this.content.ISName;
            }
        }

        /// <summary>
        /// Description of information system
        /// </summary>
        public string ISDescription
        {
            get
            {
                return this.content.ISDescription;
            }
        }

        /// <summary>
        /// Icon of information system
        /// </summary>
        public Icon ISIcon
        {
            get
            {
                return this.content.ISIcon;
            }
        }

        /// <summary>
        /// Information system which is being edited
        /// </summary>
        public InformationSystem InformationSystem { get; init; }

        /// <summary>
        /// Creates new edit information system dialog
        /// </summary>
        /// <param name="system">System which will be edited</param>
        public FormEditIS(InformationSystem system): base("Upravit informační systém", "Úprava informačního systému", SemestralProject.Resources.is_edit)
        {
            this.InformationSystem = system;
            this.content = new ControlEditIS();
            this.AddControl(this.content);
            this.content.ISName = this.InformationSystem.Name;
            this.content.ISIcon = this.InformationSystem.Icon;
            this.content.ISDescription = this.InformationSystem.Description;
            this.Icon = SemestralProject.Resources.addis;
        }
    }
}
