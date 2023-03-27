namespace SemestralProject.Forms
{
    partial class ControlAddMap
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSpace1 = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.buttonPictureSelect = new System.Windows.Forms.Button();
            this.labelSpace2 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.Controls.Add(this.labelName);
            this.flowLayoutPanelContent.Controls.Add(this.textBoxName);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace1);
            this.flowLayoutPanelContent.Controls.Add(this.labelPicture);
            this.flowLayoutPanelContent.Controls.Add(this.buttonPictureSelect);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace2);
            this.flowLayoutPanelContent.Controls.Add(this.labelDescription);
            this.flowLayoutPanelContent.Controls.Add(this.textBoxDescription);
            this.flowLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(377, 465);
            this.flowLayoutPanelContent.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Název";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(3, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(371, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // labelSpace1
            // 
            this.labelSpace1.AutoSize = true;
            this.labelSpace1.Location = new System.Drawing.Point(3, 53);
            this.labelSpace1.Name = "labelSpace1";
            this.labelSpace1.Size = new System.Drawing.Size(13, 20);
            this.labelSpace1.TabIndex = 2;
            this.labelSpace1.Text = " ";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Location = new System.Drawing.Point(3, 73);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(64, 20);
            this.labelPicture.TabIndex = 3;
            this.labelPicture.Text = "Obrázek";
            // 
            // buttonPictureSelect
            // 
            this.buttonPictureSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPictureSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPictureSelect.Location = new System.Drawing.Point(3, 96);
            this.buttonPictureSelect.Name = "buttonPictureSelect";
            this.buttonPictureSelect.Size = new System.Drawing.Size(371, 156);
            this.buttonPictureSelect.TabIndex = 4;
            this.buttonPictureSelect.UseVisualStyleBackColor = true;
            this.buttonPictureSelect.Click += new System.EventHandler(this.buttonPictureSelect_Click);
            // 
            // labelSpace2
            // 
            this.labelSpace2.AutoSize = true;
            this.labelSpace2.Location = new System.Drawing.Point(3, 255);
            this.labelSpace2.Name = "labelSpace2";
            this.labelSpace2.Size = new System.Drawing.Size(13, 20);
            this.labelSpace2.TabIndex = 5;
            this.labelSpace2.Text = " ";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 275);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(44, 20);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Popis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(3, 298);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(371, 164);
            this.textBoxDescription.TabIndex = 7;
            // 
            // ControlAddMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlAddMap";
            this.Size = new System.Drawing.Size(377, 465);
            this.flowLayoutPanelContent.ResumeLayout(false);
            this.flowLayoutPanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelContent;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelSpace1;
        private Label labelPicture;
        private Button buttonPictureSelect;
        private Label labelSpace2;
        private Label labelDescription;
        private TextBox textBoxDescription;
    }
}
