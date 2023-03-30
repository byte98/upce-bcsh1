using SemestralProject.Data;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class which represents control used to create and edit data with icons
    /// </summary>
    internal partial class ControlDataIcon : UserControl, IControl
    {
        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Icon of data
        /// </summary>
        public Icon? DataIcon { get; private set; }

        /// <summary>
        /// Name of data
        /// </summary>
        public string? DataName
        {
            get
            {
                return this.textBoxName.Text;
            }

            init
            {
                this.textBoxName.Text = value;
            }

        }

        /// <summary>
        /// Description of data
        /// </summary>
        public string? DataDescripiton
        {
            get
            {
                return this.textBoxDescription.Text;
            }

            init
            {
                this.textBoxDescription.Text = value;
            }
        }

        /// <summary>
        /// Creates new control for creating data with icons
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlDataIcon(Context context)
        {
            InitializeComponent();
            this.Context = context;
        }

        /// <summary>
        /// Creates new control for editing data with icons
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="data">Data which will be edited</param>
        public ControlDataIcon(Context context, AbstractIconData data): this(context)
        {
            this.DataName = data.Name;
            this.DataDescripiton = data.Description;
            this.DataIcon = data.Icon;
            this.buttonIcon.Image = this.DataIcon?.GetImage();
        }

        private void buttonIcon_Click(object sender, EventArgs e)
        {
            FormIconChooser dialog = new FormIconChooser(this.Context);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.IsPath)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        this.DataIcon = this.Context.FileStorage.AddIcon(dialog.SelectedIcon);
                    }, this.Context);
                }
                else
                {
                    this.DataIcon = this.Context.FileStorage.GetIcon(dialog.SelectedIcon, Persistence.FileStorage.DefaultIconType.IS);
                }
                this.buttonIcon.Image = this.DataIcon?.GetImage();
            }
        }
    }
}
