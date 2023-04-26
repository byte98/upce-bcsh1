using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class representing 'About' dialog
    /// </summary>
    internal class FormAbout: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlAbout content;

        /// <summary>
        /// Creates new 'About' dialog
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public FormAbout(Context context)
            :base("O programu", "O programu", SemestralProject.Resources.about32, context)
        {
            this.content = new ControlAbout(context);
            this.AddControl(this.content);
            this.HideCancelButton();
            this.HideCloseButton();
        }
    }
}
