namespace SemestralProject.Forms
{
    partial class ControlIconsChooser
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
            this.tableLayoutPanelIconView = new System.Windows.Forms.TableLayoutPanel();
            this.labelSpace = new System.Windows.Forms.Label();
            this.controlBrowseButtonBrowseIcons = new SemestralProject.Forms.ControlBrowseButton(this.Context);
            this.flowLayoutPanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.Controls.Add(this.labelAvailable);
            this.flowLayoutPanelContent.Controls.Add(this.tableLayoutPanelIconView);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace);
            this.flowLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(510, 473);
            this.flowLayoutPanelContent.TabIndex = 1;
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(3, 0);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(112, 20);
            this.labelAvailable.TabIndex = 0;
            this.labelAvailable.Text = "Dostupné ikony";
            // 
            // tableLayoutPanelIconView
            // 
            this.tableLayoutPanelIconView.AutoScroll = true;
            this.tableLayoutPanelIconView.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanelIconView.ColumnCount = 1;
            this.tableLayoutPanelIconView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIconView.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelIconView.Name = "tableLayoutPanelIconView";
            this.tableLayoutPanelIconView.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelIconView.RowCount = 1;
            this.tableLayoutPanelIconView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIconView.Size = new System.Drawing.Size(492, 341);
            this.tableLayoutPanelIconView.TabIndex = 1;
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
            this.controlBrowseButtonBrowseIcons.FileFilter = "Všechny soubory | *.*";
            this.controlBrowseButtonBrowseIcons.Location = new System.Drawing.Point(3, 391);
            this.controlBrowseButtonBrowseIcons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlBrowseButtonBrowseIcons.Name = "controlBrowseButtonIcons";
            this.controlBrowseButtonBrowseIcons.Size = new System.Drawing.Size(146, 40);
            this.controlBrowseButtonBrowseIcons.TabIndex = 3;
            // 
            // ControlIconsChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlIconsChooser";
            this.Size = new System.Drawing.Size(498, 435);
            this.flowLayoutPanelContent.ResumeLayout(false);
            this.flowLayoutPanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ControlBrowseButton controlBrowseButtonBrowseIcons;
        private FlowLayoutPanel flowLayoutPanelContent;
        private Label labelAvailable;
        private TableLayoutPanel tableLayoutPanelIconView;
        private Label labelSpace;
    }
}
