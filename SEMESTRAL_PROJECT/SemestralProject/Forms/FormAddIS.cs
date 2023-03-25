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
        /// Creates new add information system dialog
        /// </summary>
        public FormAddIS(): base("Přidat informační systém", "Nový informační systém", SemestralProject.Resources.is_add)
        {
            this.content = new ControlAddIS();
            this.AddControl(this.content);
            this.Icon = SemestralProject.Resources.addis;
        }
    }
}
