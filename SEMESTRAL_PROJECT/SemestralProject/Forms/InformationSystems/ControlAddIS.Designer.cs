namespace SemestralProject.Forms.InformationSystems
{
    partial class ControlAddIS
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
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
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.AutoSize = true;
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
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(330, 349);
            this.flowLayoutPanelContent.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(324, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Název";
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(3, 18);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(324, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // labelSpace1
            // 
            this.labelSpace1.AutoSize = true;
            this.labelSpace1.Location = new System.Drawing.Point(3, 44);
            this.labelSpace1.Name = "labelSpace1";
            this.labelSpace1.Size = new System.Drawing.Size(0, 15);
            this.labelSpace1.TabIndex = 2;
            // 
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.Location = new System.Drawing.Point(3, 59);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(36, 15);
            this.labelIcon.TabIndex = 3;
            this.labelIcon.Text = "Ikona";
            // 
            // buttonIcon
            // 
            this.buttonIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIcon.Image = global::SemestralProject.Resources.is_default;
            this.buttonIcon.Location = new System.Drawing.Point(3, 77);
            this.buttonIcon.Name = "buttonIcon";
            this.buttonIcon.Size = new System.Drawing.Size(324, 87);
            this.buttonIcon.TabIndex = 4;
            this.buttonIcon.UseVisualStyleBackColor = true;
            this.buttonIcon.Click += new System.EventHandler(this.buttonIcon_Click);
            // 
            // labelSpace2
            // 
            this.labelSpace2.AutoSize = true;
            this.labelSpace2.Location = new System.Drawing.Point(3, 167);
            this.labelSpace2.Name = "labelSpace2";
            this.labelSpace2.Size = new System.Drawing.Size(0, 15);
            this.labelSpace2.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 182);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(36, 15);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Popis";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxDescription.Location = new System.Drawing.Point(3, 200);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(324, 146);
            this.textBoxDescription.TabIndex = 7;
            // 
            // ControlAddIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Name = "ControlAddIS";
            this.Size = new System.Drawing.Size(330, 349);
            this.flowLayoutPanelContent.ResumeLayout(false);
            this.flowLayoutPanelContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelContent;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelSpace1;
        private Label labelIcon;
        private Button buttonIcon;
        private Label labelSpace2;
        private Label labelDescription;
        private TextBox textBoxDescription;
    }
}
