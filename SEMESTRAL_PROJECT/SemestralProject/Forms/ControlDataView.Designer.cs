namespace SemestralProject.Forms
{
    partial class ControlDataView
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
            this.flowLayoutPanelImageName = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.flowLayoutPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelDates = new System.Windows.Forms.TableLayoutPanel();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelUpdated = new System.Windows.Forms.Label();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.textBoxUpdated = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelContent.SuspendLayout();
            this.flowLayoutPanelImageName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.flowLayoutPanelDetails.SuspendLayout();
            this.tableLayoutPanelDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.ColumnCount = 1;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Controls.Add(this.flowLayoutPanelImageName, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.flowLayoutPanelDetails, 0, 1);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 2;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(411, 571);
            this.tableLayoutPanelContent.TabIndex = 0;
            // 
            // flowLayoutPanelImageName
            // 
            this.flowLayoutPanelImageName.Controls.Add(this.pictureBoxImage);
            this.flowLayoutPanelImageName.Controls.Add(this.labelName);
            this.flowLayoutPanelImageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelImageName.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelImageName.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelImageName.Name = "flowLayoutPanelImageName";
            this.flowLayoutPanelImageName.Size = new System.Drawing.Size(405, 279);
            this.flowLayoutPanelImageName.TabIndex = 0;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(402, 231);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(3, 237);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(402, 38);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "label1";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelDetails
            // 
            this.flowLayoutPanelDetails.Controls.Add(this.labelDescription);
            this.flowLayoutPanelDetails.Controls.Add(this.textBoxDescription);
            this.flowLayoutPanelDetails.Controls.Add(this.tableLayoutPanelDates);
            this.flowLayoutPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDetails.Location = new System.Drawing.Point(3, 288);
            this.flowLayoutPanelDetails.Name = "flowLayoutPanelDetails";
            this.flowLayoutPanelDetails.Size = new System.Drawing.Size(405, 280);
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
            this.textBoxDescription.Location = new System.Drawing.Point(3, 23);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(402, 165);
            this.textBoxDescription.TabIndex = 1;
            // 
            // tableLayoutPanelDates
            // 
            this.tableLayoutPanelDates.ColumnCount = 2;
            this.tableLayoutPanelDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.53234F));
            this.tableLayoutPanelDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.46766F));
            this.tableLayoutPanelDates.Controls.Add(this.labelCreated, 0, 0);
            this.tableLayoutPanelDates.Controls.Add(this.labelUpdated, 0, 1);
            this.tableLayoutPanelDates.Controls.Add(this.textBoxCreated, 1, 0);
            this.tableLayoutPanelDates.Controls.Add(this.textBoxUpdated, 1, 1);
            this.tableLayoutPanelDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDates.Location = new System.Drawing.Point(3, 194);
            this.tableLayoutPanelDates.Name = "tableLayoutPanelDates";
            this.tableLayoutPanelDates.RowCount = 2;
            this.tableLayoutPanelDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDates.Size = new System.Drawing.Size(402, 73);
            this.tableLayoutPanelDates.TabIndex = 2;
            // 
            // labelCreated
            // 
            this.labelCreated.AutoSize = true;
            this.labelCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCreated.Location = new System.Drawing.Point(3, 0);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(169, 36);
            this.labelCreated.TabIndex = 0;
            this.labelCreated.Text = "Vytvořeno";
            this.labelCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUpdated
            // 
            this.labelUpdated.AutoSize = true;
            this.labelUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUpdated.Location = new System.Drawing.Point(3, 36);
            this.labelUpdated.Name = "labelUpdated";
            this.labelUpdated.Size = new System.Drawing.Size(169, 37);
            this.labelUpdated.TabIndex = 1;
            this.labelUpdated.Text = "Naposledy změneno";
            this.labelUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCreated.Location = new System.Drawing.Point(178, 3);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.ReadOnly = true;
            this.textBoxCreated.Size = new System.Drawing.Size(221, 27);
            this.textBoxCreated.TabIndex = 2;
            // 
            // textBoxUpdated
            // 
            this.textBoxUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUpdated.Location = new System.Drawing.Point(178, 39);
            this.textBoxUpdated.Name = "textBoxUpdated";
            this.textBoxUpdated.ReadOnly = true;
            this.textBoxUpdated.Size = new System.Drawing.Size(221, 27);
            this.textBoxUpdated.TabIndex = 3;
            // 
            // ControlDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelContent);
            this.Name = "ControlDataView";
            this.Size = new System.Drawing.Size(411, 571);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.flowLayoutPanelImageName.ResumeLayout(false);
            this.flowLayoutPanelImageName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.flowLayoutPanelDetails.ResumeLayout(false);
            this.flowLayoutPanelDetails.PerformLayout();
            this.tableLayoutPanelDates.ResumeLayout(false);
            this.tableLayoutPanelDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelContent;
        private FlowLayoutPanel flowLayoutPanelImageName;
        private PictureBox pictureBoxImage;
        private Label labelName;
        private FlowLayoutPanel flowLayoutPanelDetails;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private TableLayoutPanel tableLayoutPanelDates;
        private Label labelCreated;
        private Label labelUpdated;
        private TextBox textBoxCreated;
        private TextBox textBoxUpdated;
    }
}
