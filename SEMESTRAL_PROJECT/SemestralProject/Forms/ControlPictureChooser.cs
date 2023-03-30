using SemestralProject.Persistence;
using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProject.Forms
{
    internal partial class ControlPictureChooser : UserControl, IControl
    {
        /// <summary>
        /// Number of columns in control
        /// </summary>
        private const int Columns = 2;

        /// <summary>
        /// Width of pictures in chooser
        /// </summary>
        private const int PictureWidth = 200;

        /// <summary>
        /// Height of pictures in chooser
        /// </summary>
        private const int PictureHeight = 130;

        /// <summary>
        /// List of all available pictures
        /// </summary>
        private readonly List<(Picture picture, bool isPath, string nameOrPath)> pictures;

        /// <summary>
        /// Name or path to selected picture
        /// </summary>
        public string SelectedPicture { get; private set; }

        /// <summary>
        /// Flag, whether <see cref="SelectedPicture"/> is path (<c>true</c>) or name (<c>false</c>)
        /// </summary>
        public bool SelectedIsPath { get; private set; } = false;

        public Context Context { get; init; }

        public ControlPictureChooser(Context context)
        {
            this.Context = context;
            InitializeComponent();
            this.pictures = new List<(Picture, bool, string)>();
            this.InitializePictures();
            this.SelectedPicture = this.pictures[0].nameOrPath;
            this.SelectedIsPath = this.pictures[0].isPath;
            this.controlBrowseButton.FileFilter = "Obrázek|*.BMP;*.GIF;*.JPG;*.JPEG;*.PNG";
            this.controlBrowseButton.FileSelectedEvent += ControlBrowseButton_FileSelectedEvent;
            this.ShowPictures();
            Control ctrl = this.tableLayoutPanelPictureView.Controls[0];
            if (ctrl is Button)
            {
                Button btn = (Button)ctrl;
                btn.FlatAppearance.BorderColor = this.Context.Configuration.AccentColor;
                btn.Text = "";
            }
        }

        /// <summary>
        /// Initializes pictures stored already in system
        /// </summary>
        private void InitializePictures()
        {
            foreach(Picture picture in this.Context.FileStorage.GetPictures())
            {
                this.pictures.Add((picture, false, picture.Name));
            }
        }

        private void ControlBrowseButton_FileSelectedEvent(object sender, ControlBrowseButton.FileSelectedArgs args)
        {
            if (File.Exists(args.SelectedFile))
            {
                Picture pic = new Picture(args.SelectedFile);
                this.pictures.Add((pic, true, args.SelectedFile));
                this.ShowPictures();
            }
            Button btn = (Button)this.tableLayoutPanelPictureView.Controls[0];
            btn.PerformClick();
        }

        /// <summary>
        /// Shows pictures in selection
        /// </summary>
        private void ShowPictures()
        {
            this.tableLayoutPanelPictureView.Controls.Clear();
            int rows = (int)Math.Ceiling((double)pictures.Count / (double)ControlPictureChooser.Columns);
            this.tableLayoutPanelPictureView.RowCount = rows;
            this.tableLayoutPanelPictureView.ColumnCount = ControlPictureChooser.Columns;
            float pct = (float)Math.Round(((double)1 / (double)this.tableLayoutPanelPictureView.ColumnCount) * (double)100);
            for (int i = 0; i < this.tableLayoutPanelPictureView.ColumnCount; i++)
            {
                this.tableLayoutPanelPictureView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, pct));
            }
            foreach ((Picture picture, bool isPath, string nameOrPath) picture in pictures)
            {
                Button button = new Button();
                button.FlatAppearance.BorderSize = 8;
                button.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Window);
                button.FlatStyle = FlatStyle.Flat;
                button.Width = ControlPictureChooser.PictureWidth;
                button.Height = ControlPictureChooser.PictureHeight;
                button.MaximumSize = new Size(int.MaxValue, ControlPictureChooser.PictureHeight);
                button.Dock = DockStyle.Fill;
                button.BackgroundImage = picture.picture.GetImage();
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Tag = picture;
                button.Font = new Font(new FontFamily("Segoe UI Symbol"), 16f, FontStyle.Bold, GraphicsUnit.Pixel);
                button.ForeColor = this.Context.Configuration.AccentColor;
                button.Click += this.PictureButtonClicked;
                button.TextAlign = ContentAlignment.BottomRight;
                this.tableLayoutPanelPictureView.Controls.Add(button);
            }
        }

        /// <summary>
        /// Handles click on any button with picture
        /// </summary>
        private void PictureButtonClicked(object? sender, EventArgs args)
        {
            foreach(Control control in this.tableLayoutPanelPictureView.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    btn.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Window);
                    btn.Text = string.Empty;
                    if (btn == sender)
                    {
                        btn.FlatAppearance.BorderColor = this.Context.Configuration.AccentColor;
                        btn.Text = "";
                        (Picture picture, bool isPath, string nameOrPath) tag = ((Picture picture, bool isPath, string nameOrPath))btn.Tag;
                        this.SelectedIsPath = tag.isPath;
                        this.SelectedPicture = tag.nameOrPath;
                    }
                    
                }
            }
        }
    }
}
