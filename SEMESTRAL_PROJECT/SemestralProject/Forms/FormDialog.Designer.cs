namespace SemestralProject.Forms
{
    abstract partial class FormDialog: Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxHeaderIcon = new System.Windows.Forms.PictureBox();
            this.panelDialogButtons = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.flowLayoutPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderIcon)).BeginInit();
            this.panelDialogButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.pictureBoxHeaderIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(496, 49);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(43, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(0, 32);
            this.labelHeader.TabIndex = 2;
            // 
            // pictureBoxHeaderIcon
            // 
            this.pictureBoxHeaderIcon.Location = new System.Drawing.Point(0, 8);
            this.pictureBoxHeaderIcon.Name = "pictureBoxHeaderIcon";
            this.pictureBoxHeaderIcon.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxHeaderIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHeaderIcon.TabIndex = 1;
            this.pictureBoxHeaderIcon.TabStop = false;
            // 
            // panelDialogButtons
            // 
            this.panelDialogButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDialogButtons.Controls.Add(this.buttonCancel);
            this.panelDialogButtons.Controls.Add(this.buttonOK);
            this.panelDialogButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDialogButtons.Location = new System.Drawing.Point(0, 601);
            this.panelDialogButtons.Margin = new System.Windows.Forms.Padding(3, 21, 3, 3);
            this.panelDialogButtons.Name = "panelDialogButtons";
            this.panelDialogButtons.Size = new System.Drawing.Size(496, 80);
            this.panelDialogButtons.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(175, 28);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(149, 40);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Storno";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(330, 28);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(152, 40);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.AutoSize = true;
            this.flowLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanelContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(496, 552);
            this.flowLayoutPanelContent.TabIndex = 2;
            // 
            // FormDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(496, 681);
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Controls.Add(this.panelDialogButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Přidat nový informační systém";
            this.Activated += new System.EventHandler(this.FormAddIS_Activated);
            this.Deactivate += new System.EventHandler(this.FormAddIS_Deactivate);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeaderIcon)).EndInit();
            this.panelDialogButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBoxHeaderIcon;
        private Label labelHeader;
        private Panel panelDialogButtons;
        private Button buttonCancel;
        private Button buttonOK;
        private FlowLayoutPanel flowLayoutPanelContent;
    }
}