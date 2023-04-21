namespace SemestralProject.Forms.Vehicles
{
    partial class ControlVehicle
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
            this.buttonPicture = new System.Windows.Forms.Button();
            this.labelSpace2 = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.labelSpace3 = new System.Windows.Forms.Label();
            this.labelInformationSystem = new System.Windows.Forms.Label();
            this.comboBoxInformationSystem = new System.Windows.Forms.ComboBox();
            this.labelSpace5 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Button();
            this.labelSpace4 = new System.Windows.Forms.Label();
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
            this.flowLayoutPanelContent.Controls.Add(this.buttonPicture);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace2);
            this.flowLayoutPanelContent.Controls.Add(this.labelManufacturer);
            this.flowLayoutPanelContent.Controls.Add(this.comboBoxManufacturer);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace3);
            this.flowLayoutPanelContent.Controls.Add(this.labelInformationSystem);
            this.flowLayoutPanelContent.Controls.Add(this.comboBoxInformationSystem);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace5);
            this.flowLayoutPanelContent.Controls.Add(this.labelPath);
            this.flowLayoutPanelContent.Controls.Add(this.buttonPath);
            this.flowLayoutPanelContent.Controls.Add(this.labelSpace4);
            this.flowLayoutPanelContent.Controls.Add(this.labelDescription);
            this.flowLayoutPanelContent.Controls.Add(this.textBoxDescription);
            this.flowLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(395, 661);
            this.flowLayoutPanelContent.TabIndex = 3;
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
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Location = new System.Drawing.Point(3, 73);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(64, 20);
            this.labelPicture.TabIndex = 3;
            this.labelPicture.Text = "Obrázek";
            // 
            // buttonPicture
            // 
            this.buttonPicture.BackgroundImage = global::SemestralProject.Resources.picture_default;
            this.buttonPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPicture.FlatAppearance.BorderSize = 0;
            this.buttonPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPicture.Location = new System.Drawing.Point(3, 96);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new System.Drawing.Size(388, 139);
            this.buttonPicture.TabIndex = 4;
            this.buttonPicture.UseVisualStyleBackColor = true;
            this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
            // 
            // labelSpace2
            // 
            this.labelSpace2.AutoSize = true;
            this.labelSpace2.Location = new System.Drawing.Point(3, 238);
            this.labelSpace2.Name = "labelSpace2";
            this.labelSpace2.Size = new System.Drawing.Size(0, 20);
            this.labelSpace2.TabIndex = 5;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(3, 258);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(63, 20);
            this.labelManufacturer.TabIndex = 9;
            this.labelManufacturer.Text = "Výrobce";
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(3, 281);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(388, 28);
            this.comboBoxManufacturer.TabIndex = 10;
            this.comboBoxManufacturer.SelectedValueChanged += new System.EventHandler(this.comboBoxManufacturer_SelectedValueChanged);
            // 
            // labelSpace3
            // 
            this.labelSpace3.AutoSize = true;
            this.labelSpace3.Location = new System.Drawing.Point(3, 312);
            this.labelSpace3.Name = "labelSpace3";
            this.labelSpace3.Size = new System.Drawing.Size(13, 20);
            this.labelSpace3.TabIndex = 8;
            this.labelSpace3.Text = " ";
            // 
            // labelInformationSystem
            // 
            this.labelInformationSystem.AutoSize = true;
            this.labelInformationSystem.Location = new System.Drawing.Point(3, 332);
            this.labelInformationSystem.Name = "labelInformationSystem";
            this.labelInformationSystem.Size = new System.Drawing.Size(129, 20);
            this.labelInformationSystem.TabIndex = 15;
            this.labelInformationSystem.Text = "Informační systém";
            // 
            // comboBoxInformationSystem
            // 
            this.comboBoxInformationSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInformationSystem.FormattingEnabled = true;
            this.comboBoxInformationSystem.Location = new System.Drawing.Point(3, 355);
            this.comboBoxInformationSystem.Name = "comboBoxInformationSystem";
            this.comboBoxInformationSystem.Size = new System.Drawing.Size(388, 28);
            this.comboBoxInformationSystem.TabIndex = 16;
            this.comboBoxInformationSystem.SelectedValueChanged += new System.EventHandler(this.comboBoxInformationSystem_SelectedValueChanged);
            // 
            // labelSpace5
            // 
            this.labelSpace5.AutoSize = true;
            this.labelSpace5.Location = new System.Drawing.Point(3, 386);
            this.labelSpace5.Name = "labelSpace5";
            this.labelSpace5.Size = new System.Drawing.Size(13, 20);
            this.labelSpace5.TabIndex = 14;
            this.labelSpace5.Text = " ";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(3, 406);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(67, 20);
            this.labelPath.TabIndex = 12;
            this.labelPath.Text = "Umístění";
            // 
            // buttonPath
            // 
            this.buttonPath.Image = global::SemestralProject.Resources.folder_open;
            this.buttonPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPath.Location = new System.Drawing.Point(3, 429);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(388, 34);
            this.buttonPath.TabIndex = 13;
            this.buttonPath.Text = "button1";
            this.buttonPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // labelSpace4
            // 
            this.labelSpace4.AutoSize = true;
            this.labelSpace4.Location = new System.Drawing.Point(3, 466);
            this.labelSpace4.Name = "labelSpace4";
            this.labelSpace4.Size = new System.Drawing.Size(13, 20);
            this.labelSpace4.TabIndex = 11;
            this.labelSpace4.Text = " ";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 486);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(44, 20);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Popis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(3, 509);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(388, 144);
            this.textBoxDescription.TabIndex = 7;
            // 
            // ControlVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Name = "ControlVehicle";
            this.Size = new System.Drawing.Size(395, 661);
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
        private Button buttonPicture;
        private Label labelSpace2;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelSpace3;
        private Label labelManufacturer;
        private ComboBox comboBoxManufacturer;
        private Label labelPath;
        private Label labelSpace4;
        private Button buttonPath;
        private Label labelInformationSystem;
        private Label labelSpace5;
        private ComboBox comboBoxInformationSystem;
    }
}
