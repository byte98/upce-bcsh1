namespace SemestralProject.Forms
{
    partial class ControlViewSizeButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonMain = new System.Windows.Forms.Button();
            this.contextMenuStripSizes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemLIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripSizes.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMain
            // 
            this.buttonMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMain.FlatAppearance.BorderSize = 0;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Image = global::SemestralProject.Resources.icons_details;
            this.buttonMain.Location = new System.Drawing.Point(0, 0);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(186, 107);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Podrobnosti ▼";
            this.buttonMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // contextMenuStripSizes
            // 
            this.contextMenuStripSizes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSizes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLIcons,
            this.toolStripMenuItemTiles,
            this.toolStripMenuItemSIcons,
            this.toolStripMenuItemList,
            this.toolStripMenuItemDetails});
            this.contextMenuStripSizes.Name = "contextMenuStripSizes";
            this.contextMenuStripSizes.Size = new System.Drawing.Size(215, 162);
            this.contextMenuStripSizes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripSizes_ItemClicked);
            // 
            // toolStripMenuItemLIcons
            // 
            this.toolStripMenuItemLIcons.Image = global::SemestralProject.Resources.icons_l;
            this.toolStripMenuItemLIcons.Name = "toolStripMenuItemLIcons";
            this.toolStripMenuItemLIcons.Size = new System.Drawing.Size(214, 26);
            this.toolStripMenuItemLIcons.Text = "Velké ikony";
            // 
            // toolStripMenuItemSIcons
            // 
            this.toolStripMenuItemSIcons.Image = global::SemestralProject.Resources.icons_m;
            this.toolStripMenuItemSIcons.Name = "toolStripMenuItemSIcons";
            this.toolStripMenuItemSIcons.Size = new System.Drawing.Size(214, 26);
            this.toolStripMenuItemSIcons.Text = "Malé ikony";
            // 
            // toolStripMenuItemList
            // 
            this.toolStripMenuItemList.Image = global::SemestralProject.Resources.icons_list;
            this.toolStripMenuItemList.Name = "toolStripMenuItemList";
            this.toolStripMenuItemList.Size = new System.Drawing.Size(214, 26);
            this.toolStripMenuItemList.Text = "Seznam";
            // 
            // toolStripMenuItemDetails
            // 
            this.toolStripMenuItemDetails.Image = global::SemestralProject.Resources.icons_details;
            this.toolStripMenuItemDetails.Name = "toolStripMenuItemDetails";
            this.toolStripMenuItemDetails.Size = new System.Drawing.Size(214, 26);
            this.toolStripMenuItemDetails.Text = "Podrobnosti";
            // 
            // toolStripMenuItemTiles
            // 
            this.toolStripMenuItemTiles.Image = global::SemestralProject.Resources.icons_tiles;
            this.toolStripMenuItemTiles.Name = "toolStripMenuItemTiles";
            this.toolStripMenuItemTiles.Size = new System.Drawing.Size(214, 26);
            this.toolStripMenuItemTiles.Text = "Dlaždice";
            // 
            // ControlViewSizeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMain);
            this.Name = "ControlViewSizeButton";
            this.Size = new System.Drawing.Size(186, 107);
            this.Load += new System.EventHandler(this.ControlViewSizeButton_Load);
            this.contextMenuStripSizes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonMain;
        private ContextMenuStrip contextMenuStripSizes;
        private ToolStripMenuItem toolStripMenuItemLIcons;
        private ToolStripMenuItem toolStripMenuItemSIcons;
        private ToolStripMenuItem toolStripMenuItemList;
        private ToolStripMenuItem toolStripMenuItemDetails;
        private ToolStripMenuItem toolStripMenuItemTiles;
    }
}
