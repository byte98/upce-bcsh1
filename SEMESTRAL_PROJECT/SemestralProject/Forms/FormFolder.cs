using SemestralProject.Utils;
using SemestralProject.Visual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SemestralProject.Forms
{
    /// <summary>
    /// Form for choosing directory
    /// </summary>
    internal partial class FormFolder : Form, IForm
    {
        /// <summary>
        /// Index in image list for default node 
        /// </summary>
        private const int NodeDefault = 0;

        /// <summary>
        /// Index in image list for selected node
        /// </summary>
        private const int NodeSelected = 1;

        /// <summary>
        /// List with images for nodes
        /// </summary>
        private readonly ImageList nodeImages;

        /// <summary>
        /// Wrapper of all program resources
        /// </summary>
        public Context Context{ get; init; }

        /// <summary>
        /// Root directory
        /// </summary>
        private readonly string rootDirectory;

        /// <summary>
        /// Path selected by dialog
        /// </summary>
        public string? SelectedPath { get; private set; }

        /// <summary>
        /// Actually edited node
        /// </summary>
        private TreeNode? edited;

        /// <summary>
        /// Creates new dialog for choosing directory
        /// </summary>
        /// <param name="context">Wrapper of all program resources</param>
        /// <param name="rootDir">Root directory</param>
        public FormFolder(Context context, string rootDir)
        {
            InitializeComponent();
            this.nodeImages = new ImageList();
            this.rootDirectory = rootDir;
            this.Context = context;
            this.panelHeader.BackColor = this.Context.Configuration.AccentColor;
            this.panelHeader.ForeColor = this.Context.Configuration.TextColor;
            this.InitializeTreeview();
            this.Icon = SemestralProject.Resources.icon_folder1;
        }

        /// <summary>
        /// Initializes tree view
        /// </summary>
        private void InitializeTreeview()
        {
            this.nodeImages.Images.Add(SemestralProject.Resources.folder);
            this.nodeImages.Images.Add(SemestralProject.Resources.folder_open);
            this.nodeImages.ImageSize = new Size(24, 24);
            this.treeViewContent.ImageList = this.nodeImages;
            if (Directory.Exists(this.rootDirectory) == false)
            {
                Directory.CreateDirectory(this.rootDirectory);
            }
            this.treeViewContent.Nodes.Clear();
            this.treeViewContent.Nodes.Add(this.TraverseDirectory(this.rootDirectory));
        }

        /// <summary>
        /// Traverses directory and saves content into tree node
        /// </summary>
        /// <param name="directory">Directory which will be traversed</param>
        /// <returns>Structure of directory as tree node</returns>
        private TreeNode? TraverseDirectory(string directory)
        {
            TreeNode? reti = null;
            if (Directory.Exists(directory))
            {
                string name = directory.Split(Path.DirectorySeparatorChar)[directory.Split(Path.DirectorySeparatorChar).Length - 1];
                if (directory == this.rootDirectory)
                {
                    name = Path.GetFullPath(this.rootDirectory);
                }
                reti = new TreeNode(name);
                foreach (string dir in Directory.EnumerateDirectories(directory))
                {
                    TreeNode? subdir = this.TraverseDirectory(dir);
                    if (subdir != null)
                    {
                        reti.Nodes.Add(subdir);
                    }
                }
                reti.ImageIndex = FormFolder.NodeDefault;
                reti.SelectedImageIndex = FormFolder.NodeSelected;
            }
            return reti;
        }

        private void treeViewContent_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = this.treeViewContent.SelectedNode;
            this.SelectedPath = selected.FullPath;
            if (this.SelectedPath.StartsWith(this.rootDirectory))
            {
                int idx = this.SelectedPath.IndexOf(this.rootDirectory);
                if (idx >= 0)
                {
                    this.SelectedPath = this.SelectedPath.Remove(idx, this.rootDirectory.Length);
                }
            }
        }

        private void treeViewContent_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStripNodeMenu.Show(new Point(
                    this.Location.X + e.X,
                    this.Location.Y + e.Y
                ));
            }
        }

        private void toolStripMenuItemExplorer_Click(object sender, EventArgs e)
        {
            TreeNode selected = this.treeViewContent.SelectedNode;
            string selectedPath = selected.FullPath;
            Process.Start("explorer.exe", Path.GetFullPath(selectedPath));
        }

        private void toolStripMenuItemCreate_Click(object sender, EventArgs e)
        {
            TreeNode selected = this.treeViewContent.SelectedNode;
            if (selected != null)
            {
                TreeNode newNode = new TreeNode(this.CreateNewNodeName(selected));
                newNode.ImageIndex = FormFolder.NodeDefault;
                newNode.SelectedImageIndex = FormFolder.NodeSelected;
                this.edited = newNode;
                selected.Nodes.Add(newNode);
                this.treeViewContent.LabelEdit = true;
                selected.ExpandAll();
                newNode.BeginEdit();
                selected.ExpandAll();
            }
        }

        /// <summary>
        /// Generates name for new node
        /// </summary>
        /// <param name="node">Parential node to which new node will be added</param>
        /// <returns>Name for new node</returns>
        private string CreateNewNodeName(TreeNode node)
        {
            int counter = 1;
            bool contains = true;
            if (node != null)
            {
                do
                {
                    contains = false;
                    string name = "Nová složka (" + counter + ")";
                    counter++;
                    foreach (TreeNode childNode in node.Nodes)
                    {
                        if (childNode.Text == name)
                        {
                            contains = true;
                            break;
                        }
                    }
                }
                while (contains);
            }
            return "Nová složka (" + counter + ")";
        }

        private void treeViewContent_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            this.treeViewContent.LabelEdit = false;
            if (this.edited != null)
            {
                this.BeginInvoke(new Action(() => this.treeViewContent_LabelEditFinished(this.edited)));
            }
        }

        private void treeViewContent_LabelEditFinished(TreeNode node)
        {
            string path = Path.GetFullPath(node.FullPath);
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
        }

        private void toolStripMenuItemRefresh_Click(object sender, EventArgs e)
        {
            TreeNode selected = this.treeViewContent.SelectedNode;
            if (selected != null)
            {
                TreeNode? newNode = this.TraverseDirectory(selected.FullPath);
                int idx = this.treeViewContent.Nodes.IndexOf(selected);
                if (idx >= 0 && idx < this.treeViewContent.Nodes.Count)
                {
                    this.treeViewContent.Nodes.RemoveAt(idx);
                    this.treeViewContent.Nodes.Insert(idx, newNode);
                }
            }
        }

        private void toolStripMenuItemExpand_Click(object sender, EventArgs e)
        {
            this.treeViewContent.SelectedNode?.ExpandAll();
        }

        private void toolStripMenuItemCollapse_Click(object sender, EventArgs e)
        {
            this.treeViewContent.SelectedNode?.Collapse();
        }
    }
}
