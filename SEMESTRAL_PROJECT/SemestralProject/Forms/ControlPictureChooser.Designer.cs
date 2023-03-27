namespace SemestralProject.Forms
{
    partial class ControlPictureChooser
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
            this.flowLayoutPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.tableLayoutPanelPictureView = new System.Windows.Forms.TableLayoutPanel();
            this.labelSpace = new System.Windows.Forms.Label();
            this.controlBrowseButton = new SemestralProject.Forms.ControlBrowseButton();
            this.flowLayoutPanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.Controls.Add(this.labelAvailable);
            this.flowLayoutPanelContent.Controls.Add(this.tableLayoutPanelPictureView);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace);
            this.flowLayoutPanelContent.Controls.Add(this.controlBrowseButton);
            this.flowLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(498, 435);
            this.flowLayoutPanelContent.TabIndex = 0;
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(3, 0);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(129, 20);
            this.labelAvailable.TabIndex = 0;
            this.labelAvailable.Text = "Dostupné obrázky";
            // 
            // tableLayoutPanelPictureView
            // 
            this.tableLayoutPanelPictureView.AutoScroll = true;
            this.tableLayoutPanelPictureView.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanelPictureView.ColumnCount = 1;
            this.tableLayoutPanelPictureView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPictureView.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelPictureView.Name = "tableLayoutPanelPictureView";
            this.tableLayoutPanelPictureView.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelPictureView.RowCount = 1;
            this.tableLayoutPanelPictureView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPictureView.Size = new System.Drawing.Size(492, 341);
            this.tableLayoutPanelPictureView.TabIndex = 1;
            // 
            // labelSpace
            // 
            this.labelSpace.AutoSize = true;
            this.labelSpace.Location = new System.Drawing.Point(3, 367);
            this.labelSpace.Name = "labelSpace";
            this.labelSpace.Size = new System.Drawing.Size(13, 20);
            this.labelSpace.TabIndex = 2;
            this.labelSpace.Text = " ";
            // 
            // controlBrowseButton
            // 
            this.controlBrowseButton.FileFilter = "Všechny soubory | *.*";
            this.controlBrowseButton.Location = new System.Drawing.Point(3, 391);
            this.controlBrowseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlBrowseButton.Name = "controlBrowseButton";
            this.controlBrowseButton.Size = new System.Drawing.Size(146, 40);
            this.controlBrowseButton.TabIndex = 3;
            // 
            // ControlPictureChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Name = "ControlPictureChooser";
            this.Size = new System.Drawing.Size(498, 435);
            this.flowLayoutPanelContent.ResumeLayout(false);
            this.flowLayoutPanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelContent;
        private Label labelAvailable;
        private TableLayoutPanel tableLayoutPanelPictureView;
        private Label labelSpace;
        private ControlBrowseButton controlBrowseButton;
    }
}
