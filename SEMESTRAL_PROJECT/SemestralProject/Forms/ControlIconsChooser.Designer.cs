namespace SemestralProject.Forms
{
    partial class ControlIconsChooser
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
            this.labelAvailable = new System.Windows.Forms.Label();
            this.listViewIcons = new System.Windows.Forms.ListView();
            this.controlBrowseButtonBrowseIcons = new SemestralProject.Forms.ControlBrowseButton();
            this.flowLayoutPanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.Controls.Add(this.labelAvailable);
            this.flowLayoutPanelContent.Controls.Add(this.listViewIcons);
            this.flowLayoutPanelContent.Controls.Add(this.controlBrowseButtonBrowseIcons);
            this.flowLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(324, 275);
            this.flowLayoutPanelContent.TabIndex = 0;
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAvailable.Location = new System.Drawing.Point(3, 0);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(318, 15);
            this.labelAvailable.TabIndex = 0;
            this.labelAvailable.Text = "Dostupné ikony";
            // 
            // listViewIcons
            // 
            this.listViewIcons.Location = new System.Drawing.Point(3, 18);
            this.listViewIcons.Name = "listViewIcons";
            this.listViewIcons.Size = new System.Drawing.Size(318, 210);
            this.listViewIcons.TabIndex = 1;
            this.listViewIcons.UseCompatibleStateImageBehavior = false;
            this.listViewIcons.View = System.Windows.Forms.View.SmallIcon;
            // 
            // controlBrowseButtonBrowseIcons
            // 
            this.controlBrowseButtonBrowseIcons.FileFilter = "Všechny soubory | *.*";
            this.controlBrowseButtonBrowseIcons.Location = new System.Drawing.Point(3, 234);
            this.controlBrowseButtonBrowseIcons.Name = "controlBrowseButtonBrowseIcons";
            this.controlBrowseButtonBrowseIcons.Size = new System.Drawing.Size(120, 36);
            this.controlBrowseButtonBrowseIcons.TabIndex = 2;
            // 
            // ControlIconsChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Name = "ControlIconsChooser";
            this.Size = new System.Drawing.Size(324, 275);
            this.flowLayoutPanelContent.ResumeLayout(false);
            this.flowLayoutPanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelContent;
        private Label labelAvailable;
        private ListView listViewIcons;
        private ControlBrowseButton controlBrowseButtonBrowseIcons;
    }
}
