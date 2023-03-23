using SemestralProject.Persistence;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Forms
{
    internal partial class ControlAddIS : UserControl
    {
        /// <summary>
        /// Icon of new information system
        /// </summary>
        public Icon ISIcon { get; private set; }

        /// <summary>
        /// Name of information system
        /// </summary>
        public string ISName
        {
            get
            {
                return this.textBoxName.Text;
            }
            set
            {
                this.textBoxName.Text = value;
            }
        }

        /// <summary>
        /// Description of information system
        /// </summary>
        public string ISDescription
        {
            get
            {
                return this.textBoxDescription.Text;
            }
            set
            {
                this.textBoxDescription.Text = value;
            }
        }
        public ControlAddIS()
        {
            InitializeComponent();
            this.ISIcon = FileStorage.Instance.GetIcon(FileStorage.DefaultIconType.IS);
            this.buttonIcon.Image = this.ISIcon.GetImage();
        }

        private void buttonIcon_Click(object sender, EventArgs e)
        {
            Forms.FormIconChooser dialog = new Forms.FormIconChooser();
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                if (dialog.IsPath)
                {
                    FormWait wait = new FormWait(() =>
                    {
                        string name = FileStorage.Instance.GenerateUniqueIcon();
                        this.ISIcon = FileStorage.Instance.AddIcon(name, dialog.SelectedIcon);
                    });
                    wait.ShowDialog();
                }
                else
                {
                    this.ISIcon = FileStorage.Instance.GetIcon(dialog.SelectedIcon, FileStorage.DefaultIconType.IS);
                }
                this.buttonIcon.Image = this.ISIcon.GetImage();
            }
        }
    }
}
