namespace SemestralProject.Forms
{
    partial class ControlDataIcon
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
            this.labelName = new System.Windows.Forms.Label();
            this.flowLayoutPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSpace1 = new System.Windows.Forms.Label();
            this.labelIcon = new System.Windows.Forms.Label();
            this.buttonIcon = new System.Windows.Forms.Button();
            this.labelSpace2 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelContent.SuspendLayout();
            this.SuspendLayout();
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
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.Controls.Add(this.labelName);
            this.flowLayoutPanelContent.Controls.Add(this.textBoxName);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace1);
            this.flowLayoutPanelContent.Controls.Add(this.labelIcon);
            this.flowLayoutPanelContent.Controls.Add(this.buttonIcon);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace2);
            this.flowLayoutPanelContent.Controls.Add(this.labelDescription);
            this.flowLayoutPanelContent.Controls.Add(this.textBoxDescription);
            this.flowLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(394, 443);
            this.flowLayoutPanelContent.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(3, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(388, 27);
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
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.Location = new System.Drawing.Point(3, 73);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(45, 20);
            this.labelIcon.TabIndex = 3;
            this.labelIcon.Text = "Ikona";
            // 
            // buttonIcon
            // 
            this.buttonIcon.FlatAppearance.BorderSize = 0;
            this.buttonIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIcon.Location = new System.Drawing.Point(3, 96);
            this.buttonIcon.Name = "buttonIcon";
            this.buttonIcon.Size = new System.Drawing.Size(388, 139);
            this.buttonIcon.TabIndex = 4;
            this.buttonIcon.UseVisualStyleBackColor = true;
            this.buttonIcon.Click += new System.EventHandler(this.buttonIcon_Click);
            // 
            // labelSpace2
            // 
            this.labelSpace2.AutoSize = true;
            this.labelSpace2.Location = new System.Drawing.Point(3, 238);
            this.labelSpace2.Name = "labelSpace2";
            this.labelSpace2.Size = new System.Drawing.Size(0, 20);
            this.labelSpace2.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 258);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(44, 20);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Popis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(3, 281);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(388, 159);
            this.textBoxDescription.TabIndex = 7;
            // 
            // ControlDataIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Name = "ControlDataIcon";
            this.Size = new System.Drawing.Size(394, 443);
            this.flowLayoutPanelContent.ResumeLayout(false);
            this.flowLayoutPanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelName;
        private FlowLayoutPanel flowLayoutPanelContent;
        private TextBox textBoxName;
        private Label labelSpace1;
        private Label labelIcon;
        private Button buttonIcon;
        private Label labelSpace2;
        private Label labelDescription;
        private TextBox textBoxDescription;
    }
}
