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
using SemestralProject.Persistence;
using SemestralProject.Utils;
using SemestralProject.Visual;
using Icon = SemestralProject.Visual.Icon;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Class which represents control which enables to choose icon
    /// </summary>
    internal partial class ControlIconsChooser : UserControl, IControl
    {
        /// <summary>
        /// Number of columns in control
        /// </summary>
        private const int Columns = 6;

        /// <summary>
        /// Size of icons in icon chooser
        /// </summary>
        private const int IconSize = 64;

        /// <summary>
        /// List of all available icons
        /// </summary>
        private readonly List<(Icon icon, bool isPath, string nameOrPath)> icons;

        /// <summary>
        /// Name or path to selected icon
        /// </summary>
        public string SelectedIcon { get; private set; }

        /// <summary>
        /// Flag, whether <see cref="SelectedIcon"/> is path (<c>true</c>) or name (<c>false</c>)
        /// </summary>
        public bool SelectedIsPath { get; private set; } = false;

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context { get; init; }

        /// <summary>
        /// Creates new control for choosing icon
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        public ControlIconsChooser(Context context)
        {
            this.Context = context;
            InitializeComponent();
            this.icons = new List<(Icon icon, bool, string)>();
            this.InitializeIcons();
            this.flowLayoutPanelContent.Controls.Add(this.controlBrowseButtonBrowseIcons);
            this.SelectedIcon = this.icons[0].nameOrPath;
            this.SelectedIsPath = this.icons[0].isPath;
            this.controlBrowseButtonBrowseIcons.FileFilter = "Obrázek|*.BMP;*.GIF;*.JPG;*.JPEG;*.PNG";
            this.controlBrowseButtonBrowseIcons.FileSelectedEvent += ControlBrowseButton_FileSelectedEvent;
            this.ShowIcons();
            Control ctrl = this.tableLayoutPanelIconView.Controls[0];
            if (ctrl is Button)
            {
                Button btn = (Button)ctrl;
                btn.FlatAppearance.BorderColor = this.Context.Configuration.AccentColor;
                btn.Text = "";
            }
        }

        /// <summary>
        /// Initializes icons stored already in system
        /// </summary>
        private void InitializeIcons()
        {
            foreach (Icon icon in this.Context.FileStorage.GetAllIcons())
            {
                this.icons.Add((icon, false, icon.Name));
            }
        }

        private void ControlBrowseButton_FileSelectedEvent(object sender, ControlBrowseButton.FileSelectedArgs args)
        {
            if (File.Exists(args.SelectedFile))
            {
                Icon icon = new Icon(Path.GetFileNameWithoutExtension(args.SelectedFile), args.SelectedFile);
                this.icons.Insert(0, (icon, true, args.SelectedFile));
                this.ShowIcons();
            }
            Button btn = (Button)this.tableLayoutPanelIconView.Controls[0];
            btn.PerformClick();
        }

        /// <summary>
        /// Shows icons in selection
        /// </summary>
        private void ShowIcons()
        {
            this.tableLayoutPanelIconView.Controls.Clear();
            int rows = (int)Math.Ceiling((double)icons.Count / (double)ControlIconsChooser.Columns);
            this.tableLayoutPanelIconView.RowCount = rows;
            this.tableLayoutPanelIconView.ColumnCount = ControlIconsChooser.Columns;
            float pct = (float)Math.Round(((double)1 / (double)this.tableLayoutPanelIconView.ColumnCount) * (double)100);
            this.tableLayoutPanelIconView.ColumnStyles.Clear();
            for (int i = 0; i < this.tableLayoutPanelIconView.ColumnCount; i++)
            {
                this.tableLayoutPanelIconView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, pct));
            }
            this.tableLayoutPanelIconView.RowStyles.Clear();
            for (int i = 0; i < this.tableLayoutPanelIconView.RowCount; i++)
            {
                this.tableLayoutPanelIconView.RowStyles.Add(new RowStyle(SizeType.Absolute, ControlIconsChooser.IconSize));
            }

            foreach ((Icon icon, bool isPath, string nameOrPath) icon in icons)
            {
                Button button = new Button();
                button.FlatAppearance.BorderSize = 8;
                button.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Window);
                button.FlatStyle = FlatStyle.Flat;
                button.Width = ControlIconsChooser.IconSize;
                button.Height = ControlIconsChooser.IconSize;
                button.MaximumSize = new Size(int.MaxValue, ControlIconsChooser.IconSize);
                button.Dock = DockStyle.Fill;
                button.BackgroundImage = icon.icon.GetImage();
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Tag = icon;
                button.Font = new Font(new FontFamily("Segoe UI Symbol"), 16f, FontStyle.Bold, GraphicsUnit.Pixel);
                button.ForeColor = this.Context.Configuration.AccentColor;
                button.Click += this.IconButtonClicked;
                button.TextAlign = ContentAlignment.BottomRight;
                this.tableLayoutPanelIconView.Controls.Add(button);
            }
        }

        /// <summary>
        /// Handles click on any button with picture
        /// </summary>
        private void IconButtonClicked(object? sender, EventArgs args)
        {
            foreach (Control control in this.tableLayoutPanelIconView.Controls)
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
                        (Icon icon, bool isPath, string nameOrPath) tag = ((Icon icon, bool isPath, string nameOrPath))btn.Tag;
                        this.SelectedIsPath = tag.isPath;
                        this.SelectedIcon = tag.nameOrPath;
                    }

                }
            }
        }
    }
}
