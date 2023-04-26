namespace SemestralProject.Forms
{
    partial class ControlAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAbout));
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.labelHeader1 = new System.Windows.Forms.Label();
            this.labelVersionName = new System.Windows.Forms.Label();
            this.labelVersionValue = new System.Windows.Forms.Label();
            this.labelAssembyDateValue = new System.Windows.Forms.Label();
            this.labelAuthorValue1 = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelAssembyDateName = new System.Windows.Forms.Label();
            this.linkLabelAuthorEmail = new System.Windows.Forms.LinkLabel();
            this.tabControlDetails = new System.Windows.Forms.TabControl();
            this.tabPageLicense = new System.Windows.Forms.TabPage();
            this.textBoxLicense = new System.Windows.Forms.TextBox();
            this.tabPageThirdParty = new System.Windows.Forms.TabPage();
            this.textBoxThirdParty = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelContent.SuspendLayout();
            this.tabControlDetails.SuspendLayout();
            this.tabPageLicense.SuspendLayout();
            this.tabPageThirdParty.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.ColumnCount = 2;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContent.Controls.Add(this.labelHeader1, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.labelVersionName, 0, 1);
            this.tableLayoutPanelContent.Controls.Add(this.labelVersionValue, 1, 1);
            this.tableLayoutPanelContent.Controls.Add(this.labelAssembyDateValue, 1, 2);
            this.tableLayoutPanelContent.Controls.Add(this.labelAuthorValue1, 1, 3);
            this.tableLayoutPanelContent.Controls.Add(this.labelAuthorName, 0, 3);
            this.tableLayoutPanelContent.Controls.Add(this.labelAssembyDateName, 0, 2);
            this.tableLayoutPanelContent.Controls.Add(this.linkLabelAuthorEmail, 1, 4);
            this.tableLayoutPanelContent.Controls.Add(this.tabControlDetails, 0, 5);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 6;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(569, 600);
            this.tableLayoutPanelContent.TabIndex = 0;
            // 
            // labelHeader1
            // 
            this.labelHeader1.AutoSize = true;
            this.labelHeader1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelContent.SetColumnSpan(this.labelHeader1, 2);
            this.labelHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeader1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(96)))));
            this.labelHeader1.Location = new System.Drawing.Point(3, 0);
            this.labelHeader1.Margin = new System.Windows.Forms.Padding(0);
            this.labelHeader1.Name = "labelHeader1";
            this.labelHeader1.Size = new System.Drawing.Size(563, 128);
            this.labelHeader1.TabIndex = 0;
            this.labelHeader1.Text = "Správce distribucí\r\ndatových souborů";
            this.labelHeader1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersionName
            // 
            this.labelVersionName.AutoSize = true;
            this.labelVersionName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersionName.Location = new System.Drawing.Point(3, 128);
            this.labelVersionName.Name = "labelVersionName";
            this.labelVersionName.Size = new System.Drawing.Size(278, 24);
            this.labelVersionName.TabIndex = 1;
            this.labelVersionName.Text = "Verze:";
            this.labelVersionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVersionValue
            // 
            this.labelVersionValue.AutoSize = true;
            this.labelVersionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersionValue.Location = new System.Drawing.Point(287, 128);
            this.labelVersionValue.Name = "labelVersionValue";
            this.labelVersionValue.Size = new System.Drawing.Size(279, 24);
            this.labelVersionValue.TabIndex = 2;
            this.labelVersionValue.Text = "1.0.0";
            this.labelVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAssembyDateValue
            // 
            this.labelAssembyDateValue.AutoSize = true;
            this.labelAssembyDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssembyDateValue.Location = new System.Drawing.Point(287, 152);
            this.labelAssembyDateValue.Name = "labelAssembyDateValue";
            this.labelAssembyDateValue.Size = new System.Drawing.Size(279, 24);
            this.labelAssembyDateValue.TabIndex = 3;
            this.labelAssembyDateValue.Text = "26/04/2023";
            this.labelAssembyDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAuthorValue1
            // 
            this.labelAuthorValue1.AutoSize = true;
            this.labelAuthorValue1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAuthorValue1.Location = new System.Drawing.Point(287, 176);
            this.labelAuthorValue1.Name = "labelAuthorValue1";
            this.labelAuthorValue1.Size = new System.Drawing.Size(279, 24);
            this.labelAuthorValue1.TabIndex = 4;
            this.labelAuthorValue1.Text = "Jiří Škoda";
            this.labelAuthorValue1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAuthorName.Location = new System.Drawing.Point(3, 176);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(278, 24);
            this.labelAuthorName.TabIndex = 7;
            this.labelAuthorName.Text = "Autor:";
            this.labelAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAssembyDateName
            // 
            this.labelAssembyDateName.AutoSize = true;
            this.labelAssembyDateName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssembyDateName.Location = new System.Drawing.Point(3, 152);
            this.labelAssembyDateName.Name = "labelAssembyDateName";
            this.labelAssembyDateName.Size = new System.Drawing.Size(278, 24);
            this.labelAssembyDateName.TabIndex = 8;
            this.labelAssembyDateName.Text = "Datum vydání:";
            this.labelAssembyDateName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelAuthorEmail
            // 
            this.linkLabelAuthorEmail.AutoSize = true;
            this.linkLabelAuthorEmail.Location = new System.Drawing.Point(287, 200);
            this.linkLabelAuthorEmail.Name = "linkLabelAuthorEmail";
            this.linkLabelAuthorEmail.Size = new System.Drawing.Size(203, 20);
            this.linkLabelAuthorEmail.TabIndex = 9;
            this.linkLabelAuthorEmail.TabStop = true;
            this.linkLabelAuthorEmail.Text = "<jiri.skoda@student.upce.cz>";
            this.linkLabelAuthorEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuthorEmail_LinkClicked);
            // 
            // tabControlDetails
            // 
            this.tableLayoutPanelContent.SetColumnSpan(this.tabControlDetails, 2);
            this.tabControlDetails.Controls.Add(this.tabPageLicense);
            this.tabControlDetails.Controls.Add(this.tabPageThirdParty);
            this.tabControlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDetails.Location = new System.Drawing.Point(3, 227);
            this.tabControlDetails.Name = "tabControlDetails";
            this.tabControlDetails.SelectedIndex = 0;
            this.tabControlDetails.Size = new System.Drawing.Size(563, 370);
            this.tabControlDetails.TabIndex = 10;
            // 
            // tabPageLicense
            // 
            this.tabPageLicense.AutoScroll = true;
            this.tabPageLicense.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLicense.Controls.Add(this.textBoxLicense);
            this.tabPageLicense.Location = new System.Drawing.Point(4, 29);
            this.tabPageLicense.Name = "tabPageLicense";
            this.tabPageLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicense.Size = new System.Drawing.Size(555, 337);
            this.tabPageLicense.TabIndex = 0;
            this.tabPageLicense.Text = "Licence";
            // 
            // textBoxLicense
            // 
            this.textBoxLicense.Location = new System.Drawing.Point(3, 3);
            this.textBoxLicense.Multiline = true;
            this.textBoxLicense.Name = "textBoxLicense";
            this.textBoxLicense.ReadOnly = true;
            this.textBoxLicense.Size = new System.Drawing.Size(531, 2005);
            this.textBoxLicense.TabIndex = 2;
            this.textBoxLicense.Text = resources.GetString("textBoxLicense.Text");
            // 
            // tabPageThirdParty
            // 
            this.tabPageThirdParty.AutoScroll = true;
            this.tabPageThirdParty.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageThirdParty.Controls.Add(this.textBoxThirdParty);
            this.tabPageThirdParty.Location = new System.Drawing.Point(4, 29);
            this.tabPageThirdParty.Name = "tabPageThirdParty";
            this.tabPageThirdParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThirdParty.Size = new System.Drawing.Size(555, 337);
            this.tabPageThirdParty.TabIndex = 1;
            this.tabPageThirdParty.Text = "Použité zdroje třetích stran";
            // 
            // textBoxThirdParty
            // 
            this.textBoxThirdParty.Location = new System.Drawing.Point(0, 0);
            this.textBoxThirdParty.Multiline = true;
            this.textBoxThirdParty.Name = "textBoxThirdParty";
            this.textBoxThirdParty.ReadOnly = true;
            this.textBoxThirdParty.Size = new System.Drawing.Size(555, 334);
            this.textBoxThirdParty.TabIndex = 0;
            this.textBoxThirdParty.Text = "Icons by Icons8\r\nhttps://icons8.com\r\n\r\n";
            // 
            // ControlAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelContent);
            this.Name = "ControlAbout";
            this.Size = new System.Drawing.Size(569, 600);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.tableLayoutPanelContent.PerformLayout();
            this.tabControlDetails.ResumeLayout(false);
            this.tabPageLicense.ResumeLayout(false);
            this.tabPageLicense.PerformLayout();
            this.tabPageThirdParty.ResumeLayout(false);
            this.tabPageThirdParty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelContent;
        private Label labelHeader1;
        private Label labelVersionName;
        private Label labelVersionValue;
        private Label labelAssembyDateValue;
        private Label labelAuthorValue1;
        private Label labelAuthorName;
        private Label labelAssembyDateName;
        private LinkLabel linkLabelAuthorEmail;
        private TabControl tabControlDetails;
        private TabPage tabPageLicense;
        private TabPage tabPageThirdParty;
        private TextBox textBoxLicense;
        private TextBox textBoxThirdParty;
    }
}
