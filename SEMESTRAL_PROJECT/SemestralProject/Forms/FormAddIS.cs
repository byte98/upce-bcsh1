using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Icon = SemestralProject.Visual.Icon;  

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class representing add information system dialog
    /// </summary>
    internal class FormAddIS: FormDialog
    {
        /// <summary>
        /// Reference to content of dialog
        /// </summary>
        private ControlAddIS content;

        /// <summary>
        /// Name of information system
        /// </summary>
        public string ISName
        {
            get
            {
                return this.content.ISName;
            }
            set
            {
                this.content.ISName = value;
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
            set
            {
                this.content.ISDescription = value;
            }
        }

        /// <summary>
        /// Icon of information system
        /// </summary>
        public Icon ISIcon { get; private set; }

        /// <summary>
        /// Creates new add information system dialog
        /// </summary>
        public FormAddIS(): base("Přidat informační systém", "Nový informační systém", SemestralProject.Resources.is_add)
        {
            this.content = new ControlAddIS();
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.addis;
            this.ISIcon = this.content.ISIcon;
        }
    }
}
