using SemestralProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class which represents dialog for choosing pictures
    /// </summary>
    internal class FormPictureChooser: FormDialog
    {
        /// <summary>
        /// Content of dialog
        /// </summary>
        private readonly ControlPictureChooser content;

        /// <summary>
        /// Selected picture
        /// </summary>
        public string SelectedPicture => this.content.SelectedPicture;

        /// <summary>
        /// Flag, whether <see cref="SelectedPicture"/> is path (<c>true</c>) or name (<c>false</c>)
        /// </summary>
        public bool SelectedIsPath => this.content.SelectedIsPath;

        /// <summary>
        /// Creates new dialog for choosing pictures
        /// </summary>
        public FormPictureChooser(Context context): base("Výběr obrázku", "Vyberte obrázek", SemestralProject.Resources.is_default, context)
        {
            this.content = new ControlPictureChooser(this.Context);
            this.AddControl(content);
        }
    }
}
