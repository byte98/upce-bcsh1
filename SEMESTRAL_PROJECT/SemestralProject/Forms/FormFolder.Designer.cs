namespace SemestralProject.Forms
{
    partial class FormFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeViewContent = new System.Windows.Forms.TreeView();
            this.contextMenuStripNodeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHelp = new System.Windows.Forms.Label();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStripNodeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelButtons.Controls.Add(this.buttonOK);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 379);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(798, 71);
            this.flowLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(627, 13);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(148, 43);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(473, 13);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(148, 43);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Storno";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(798, 48);
            this.panelHeader.TabIndex = 1;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(46, 8);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(171, 32);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Vyberte složku";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SemestralProject.Resources.browse32;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // treeViewContent
            // 
            this.treeViewContent.Location = new System.Drawing.Point(12, 54);
            this.treeViewContent.Name = "treeViewContent";
            this.treeViewContent.Size = new System.Drawing.Size(774, 299);
            this.treeViewContent.TabIndex = 2;
            this.treeViewContent.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewContent_AfterLabelEdit);
            this.treeViewContent.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewContent_AfterSelect);
            this.treeViewContent.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewContent_NodeMouseClick);
            // 
            // contextMenuStripNodeMenu
            // 
            this.contextMenuStripNodeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNodeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRefresh,
            this.toolStripMenuItemCreate,
            this.toolStripMenuItemExplorer,
            this.toolStripMenuItemExpand,
            this.toolStripMenuItemCollapse});
            this.contextMenuStripNodeMenu.Name = "contextMenuStripNodeMenu";
            this.contextMenuStripNodeMenu.Size = new System.Drawing.Size(284, 134);
            // 
            // toolStripMenuItemRefresh
            // 
            this.toolStripMenuItemRefresh.Image = global::SemestralProject.Resources.refresh;
            this.toolStripMenuItemRefresh.Name = "toolStripMenuItemRefresh";
            this.toolStripMenuItemRefresh.Size = new System.Drawing.Size(283, 26);
            this.toolStripMenuItemRefresh.Text = "Obnovit";
            this.toolStripMenuItemRefresh.Click += new System.EventHandler(this.toolStripMenuItemRefresh_Click);
            // 
            // toolStripMenuItemCreate
            // 
            this.toolStripMenuItemCreate.Image = global::SemestralProject.Resources.mkdir;
            this.toolStripMenuItemCreate.Name = "toolStripMenuItemCreate";
            this.toolStripMenuItemCreate.Size = new System.Drawing.Size(283, 26);
            this.toolStripMenuItemCreate.Text = "Nová složka";
            this.toolStripMenuItemCreate.Click += new System.EventHandler(this.toolStripMenuItemCreate_Click);
            // 
            // toolStripMenuItemExplorer
            // 
            this.toolStripMenuItemExplorer.Image = global::SemestralProject.Resources.explorer;
            this.toolStripMenuItemExplorer.Name = "toolStripMenuItemExplorer";
            this.toolStripMenuItemExplorer.Size = new System.Drawing.Size(283, 26);
            this.toolStripMenuItemExplorer.Text = "Otevřít v Průzkumníku souborů";
            this.toolStripMenuItemExplorer.Click += new System.EventHandler(this.toolStripMenuItemExplorer_Click);
            // 
            // toolStripMenuItemExpand
            // 
            this.toolStripMenuItemExpand.Image = global::SemestralProject.Resources.expand;
            this.toolStripMenuItemExpand.Name = "toolStripMenuItemExpand";
            this.toolStripMenuItemExpand.Size = new System.Drawing.Size(283, 26);
            this.toolStripMenuItemExpand.Text = "Rozbalit vše";
            this.toolStripMenuItemExpand.Click += new System.EventHandler(this.toolStripMenuItemExpand_Click);
            // 
            // toolStripMenuItemCollapse
            // 
            this.toolStripMenuItemCollapse.Image = global::SemestralProject.Resources.collapse;
            this.toolStripMenuItemCollapse.Name = "toolStripMenuItemCollapse";
            this.toolStripMenuItemCollapse.Size = new System.Drawing.Size(283, 26);
            this.toolStripMenuItemCollapse.Text = "Sbalit vše";
            this.toolStripMenuItemCollapse.Click += new System.EventHandler(this.toolStripMenuItemCollapse_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.Location = new System.Drawing.Point(12, 356);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(417, 20);
            this.labelHelp.TabIndex = 3;
            this.labelHelp.Text = "Pro zobrazení dostupných akcí klikněte pravým tlačítkem myši";
            // 
            // FormFolder
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.treeViewContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.flowLayoutPanelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Výběr složky";
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStripNodeMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelButtons;
        private Button buttonCancel;
        private Button buttonOK;
        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Label labelHeader;
        private TreeView treeViewContent;
        private ContextMenuStrip contextMenuStripNodeMenu;
        private ToolStripMenuItem toolStripMenuItemRefresh;
        private ToolStripMenuItem toolStripMenuItemCreate;
        private ToolStripMenuItem toolStripMenuItemExplorer;
        private ToolStripMenuItem toolStripMenuItemExpand;
        private ToolStripMenuItem toolStripMenuItemCollapse;
        private Label labelHelp;
    }
}