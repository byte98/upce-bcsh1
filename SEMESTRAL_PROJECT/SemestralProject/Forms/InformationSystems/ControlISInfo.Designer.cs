namespace SemestralProject.Forms.InformationSystems
{
    partial class ControlISInfo
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
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelIconName = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.flowLayoutPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelCreated = new System.Windows.Forms.TableLayoutPanel();
            this.labelCreated = new System.Windows.Forms.Label();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelUpdated = new System.Windows.Forms.TableLayoutPanel();
            this.labelUpdated = new System.Windows.Forms.Label();
            this.textBoxUpdated = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelContent.SuspendLayout();
            this.tableLayoutPanelIconName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.flowLayoutPanelDetails.SuspendLayout();
            this.tableLayoutPanelCreated.SuspendLayout();
            this.tableLayoutPanelUpdated.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.ColumnCount = 1;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Controls.Add(this.tableLayoutPanelIconName, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.flowLayoutPanelDetails, 0, 1);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 2;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(480, 596);
            this.tableLayoutPanelContent.TabIndex = 0;
            // 
            // tableLayoutPanelIconName
            // 
            this.tableLayoutPanelIconName.ColumnCount = 1;
            this.tableLayoutPanelIconName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIconName.Controls.Add(this.pictureBoxIcon, 0, 0);
            this.tableLayoutPanelIconName.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelIconName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelIconName.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanelIconName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelIconName.Name = "tableLayoutPanelIconName";
            this.tableLayoutPanelIconName.RowCount = 2;
            this.tableLayoutPanelIconName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.04608F));
            this.tableLayoutPanelIconName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.95392F));
            this.tableLayoutPanelIconName.Size = new System.Drawing.Size(474, 188);
            this.tableLayoutPanelIconName.TabIndex = 0;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(468, 123);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(3, 131);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(468, 57);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelDetails
            // 
            this.flowLayoutPanelDetails.Controls.Add(this.labelDescription);
            this.flowLayoutPanelDetails.Controls.Add(this.textBoxDescription);
            this.flowLayoutPanelDetails.Controls.Add(this.tableLayoutPanelCreated);
            this.flowLayoutPanelDetails.Controls.Add(this.tableLayoutPanelUpdated);
            this.flowLayoutPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDetails.Location = new System.Drawing.Point(3, 200);
            this.flowLayoutPanelDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelDetails.Name = "flowLayoutPanelDetails";
            this.flowLayoutPanelDetails.Size = new System.Drawing.Size(474, 392);
            this.flowLayoutPanelDetails.TabIndex = 1;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(44, 20);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Popis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(3, 24);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(460, 257);
            this.textBoxDescription.TabIndex = 1;
            // 
            // tableLayoutPanelCreated
            // 
            this.tableLayoutPanelCreated.ColumnCount = 2;
            this.tableLayoutPanelCreated.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelCreated.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCreated.Controls.Add(this.labelCreated, 0, 0);
            this.tableLayoutPanelCreated.Controls.Add(this.textBoxCreated, 1, 0);
            this.tableLayoutPanelCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCreated.Location = new System.Drawing.Point(3, 289);
            this.tableLayoutPanelCreated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelCreated.Name = "tableLayoutPanelCreated";
            this.tableLayoutPanelCreated.RowCount = 1;
            this.tableLayoutPanelCreated.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCreated.Size = new System.Drawing.Size(460, 35);
            this.tableLayoutPanelCreated.TabIndex = 2;
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCreated.Location = new System.Drawing.Point(3, 0);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(154, 35);
            this.labelCreated.TabIndex = 0;
            this.labelCreated.Text = "Vytvořeno";
            this.labelCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCreated.Location = new System.Drawing.Point(163, 4);
            this.textBoxCreated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.ReadOnly = true;
            this.textBoxCreated.Size = new System.Drawing.Size(294, 27);
            this.textBoxCreated.TabIndex = 1;
            // 
            // tableLayoutPanelUpdated
            // 
            this.tableLayoutPanelUpdated.ColumnCount = 2;
            this.tableLayoutPanelUpdated.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelUpdated.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelUpdated.Controls.Add(this.labelUpdated, 0, 0);
            this.tableLayoutPanelUpdated.Controls.Add(this.textBoxUpdated, 1, 0);
            this.tableLayoutPanelUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUpdated.Location = new System.Drawing.Point(3, 332);
            this.tableLayoutPanelUpdated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelUpdated.Name = "tableLayoutPanelUpdated";
            this.tableLayoutPanelUpdated.RowCount = 1;
            this.tableLayoutPanelUpdated.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUpdated.Size = new System.Drawing.Size(460, 35);
            this.tableLayoutPanelUpdated.TabIndex = 3;
            // 
            // labelUpdated
            // 
            this.labelUpdated.AutoSize = true;
            this.labelUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUpdated.Location = new System.Drawing.Point(3, 0);
            this.labelUpdated.Name = "labelUpdated";
            this.labelUpdated.Size = new System.Drawing.Size(154, 35);
            this.labelUpdated.TabIndex = 0;
            this.labelUpdated.Text = "Naposledy upraveno";
            this.labelUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUpdated
            // 
            this.textBoxUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUpdated.Location = new System.Drawing.Point(163, 4);
            this.textBoxUpdated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUpdated.Name = "textBoxUpdated";
            this.textBoxUpdated.ReadOnly = true;
            this.textBoxUpdated.Size = new System.Drawing.Size(294, 27);
            this.textBoxUpdated.TabIndex = 1;
            // 
            // ControlISInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelContent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlISInfo";
            this.Size = new System.Drawing.Size(480, 596);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.tableLayoutPanelIconName.ResumeLayout(false);
            this.tableLayoutPanelIconName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.flowLayoutPanelDetails.ResumeLayout(false);
            this.flowLayoutPanelDetails.PerformLayout();
            this.tableLayoutPanelCreated.ResumeLayout(false);
            this.tableLayoutPanelCreated.PerformLayout();
            this.tableLayoutPanelUpdated.ResumeLayout(false);
            this.tableLayoutPanelUpdated.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelContent;
        private TableLayoutPanel tableLayoutPanelIconName;
        private PictureBox pictureBoxIcon;
        private Label labelName;
        private FlowLayoutPanel flowLayoutPanelDetails;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private TableLayoutPanel tableLayoutPanelCreated;
        private Label labelCreated;
        private TableLayoutPanel tableLayoutPanelUpdated;
        private Label labelUpdated;
        private TextBox textBoxCreated;
        private TextBox textBoxUpdated;
    }
}
