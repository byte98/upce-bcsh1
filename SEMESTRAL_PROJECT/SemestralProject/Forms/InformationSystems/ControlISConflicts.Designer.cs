namespace SemestralProject.Forms.InformationSystems
{
    partial class ControlISConflicts
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
            this.panelVehicles = new System.Windows.Forms.Panel();
            this.listViewVehicles = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderIS = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderVehiclePath = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCreated = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderUpdated = new System.Windows.Forms.ColumnHeader();
            this.labelVehicles = new System.Windows.Forms.Label();
            this.labelHeaderInfo = new System.Windows.Forms.Label();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFileIS = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFileDesc = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPath = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFileCreated = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFileUpdated = new System.Windows.Forms.ColumnHeader();
            this.labelFiles = new System.Windows.Forms.Label();
            this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxImportant = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelFooterText = new System.Windows.Forms.FlowLayoutPanel();
            this.labelFooter1 = new System.Windows.Forms.Label();
            this.labelFooter2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelContent.SuspendLayout();
            this.panelVehicles.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.tableLayoutPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImportant)).BeginInit();
            this.flowLayoutPanelFooterText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.ColumnCount = 1;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Controls.Add(this.panelVehicles, 0, 1);
            this.tableLayoutPanelContent.Controls.Add(this.labelHeaderInfo, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.panelFiles, 0, 2);
            this.tableLayoutPanelContent.Controls.Add(this.tableLayoutPanelFooter, 0, 3);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 4;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(806, 524);
            this.tableLayoutPanelContent.TabIndex = 0;
            // 
            // panelVehicles
            // 
            this.panelVehicles.Controls.Add(this.listViewVehicles);
            this.panelVehicles.Controls.Add(this.labelVehicles);
            this.panelVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVehicles.Location = new System.Drawing.Point(3, 23);
            this.panelVehicles.Name = "panelVehicles";
            this.panelVehicles.Size = new System.Drawing.Size(800, 216);
            this.panelVehicles.TabIndex = 0;
            // 
            // listViewVehicles
            // 
            this.listViewVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderIS,
            this.columnHeaderDescription,
            this.columnHeaderVehiclePath,
            this.columnHeaderCreated,
            this.columnHeaderUpdated});
            this.listViewVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVehicles.FullRowSelect = true;
            this.listViewVehicles.Location = new System.Drawing.Point(0, 20);
            this.listViewVehicles.Name = "listViewVehicles";
            this.listViewVehicles.Size = new System.Drawing.Size(800, 196);
            this.listViewVehicles.TabIndex = 1;
            this.listViewVehicles.UseCompatibleStateImageBehavior = false;
            this.listViewVehicles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Název";
            // 
            // columnHeaderIS
            // 
            this.columnHeaderIS.Text = "Informační sysém";
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Popis";
            // 
            // columnHeaderVehiclePath
            // 
            this.columnHeaderVehiclePath.Text = "Umístění";
            // 
            // columnHeaderCreated
            // 
            this.columnHeaderCreated.Text = "Vytvořeno";
            // 
            // columnHeaderUpdated
            // 
            this.columnHeaderUpdated.Text = "Naposledy upraveno";
            // 
            // labelVehicles
            // 
            this.labelVehicles.AutoSize = true;
            this.labelVehicles.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVehicles.Location = new System.Drawing.Point(0, 0);
            this.labelVehicles.Name = "labelVehicles";
            this.labelVehicles.Size = new System.Drawing.Size(343, 20);
            this.labelVehicles.TabIndex = 0;
            this.labelVehicles.Text = "Vozidla, na kterých je instalován informační systém";
            // 
            // labelHeaderInfo
            // 
            this.labelHeaderInfo.AutoSize = true;
            this.labelHeaderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderInfo.Location = new System.Drawing.Point(3, 0);
            this.labelHeaderInfo.Name = "labelHeaderInfo";
            this.labelHeaderInfo.Size = new System.Drawing.Size(800, 20);
            this.labelHeaderInfo.TabIndex = 1;
            this.labelHeaderInfo.Text = "Při pokusu o smazání informačního systému byly nalezeny konflikty.";
            // 
            // panelFiles
            // 
            this.panelFiles.Controls.Add(this.listViewFiles);
            this.panelFiles.Controls.Add(this.labelFiles);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(3, 245);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(800, 216);
            this.panelFiles.TabIndex = 2;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderFileIS,
            this.columnHeaderFileDesc,
            this.columnHeaderPath,
            this.columnHeaderFileCreated,
            this.columnHeaderFileUpdated});
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.Location = new System.Drawing.Point(0, 20);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(800, 196);
            this.listViewFiles.TabIndex = 1;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "Název";
            // 
            // columnHeaderFileIS
            // 
            this.columnHeaderFileIS.Text = "Informační systém";
            // 
            // columnHeaderFileDesc
            // 
            this.columnHeaderFileDesc.Text = "Popis";
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Umístění";
            // 
            // columnHeaderFileCreated
            // 
            this.columnHeaderFileCreated.Text = "Vytvořeno";
            // 
            // columnHeaderFileUpdated
            // 
            this.columnHeaderFileUpdated.Text = "Naposledy upraveno";
            // 
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFiles.Location = new System.Drawing.Point(0, 0);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(452, 20);
            this.labelFiles.TabIndex = 0;
            this.labelFiles.Text = "Soubory, které mají data uložena ve formátu informačního systému";
            // 
            // tableLayoutPanelFooter
            // 
            this.tableLayoutPanelFooter.ColumnCount = 2;
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.875F));
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.125F));
            this.tableLayoutPanelFooter.Controls.Add(this.pictureBoxImportant, 0, 0);
            this.tableLayoutPanelFooter.Controls.Add(this.flowLayoutPanelFooterText, 1, 0);
            this.tableLayoutPanelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFooter.Location = new System.Drawing.Point(3, 467);
            this.tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            this.tableLayoutPanelFooter.RowCount = 1;
            this.tableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFooter.Size = new System.Drawing.Size(800, 54);
            this.tableLayoutPanelFooter.TabIndex = 3;
            // 
            // pictureBoxImportant
            // 
            this.pictureBoxImportant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImportant.Image = global::SemestralProject.Resources.important;
            this.pictureBoxImportant.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxImportant.Name = "pictureBoxImportant";
            this.pictureBoxImportant.Size = new System.Drawing.Size(33, 48);
            this.pictureBoxImportant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxImportant.TabIndex = 0;
            this.pictureBoxImportant.TabStop = false;
            // 
            // flowLayoutPanelFooterText
            // 
            this.flowLayoutPanelFooterText.Controls.Add(this.labelFooter1);
            this.flowLayoutPanelFooterText.Controls.Add(this.labelFooter2);
            this.flowLayoutPanelFooterText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFooterText.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFooterText.Location = new System.Drawing.Point(42, 3);
            this.flowLayoutPanelFooterText.Name = "flowLayoutPanelFooterText";
            this.flowLayoutPanelFooterText.Size = new System.Drawing.Size(755, 48);
            this.flowLayoutPanelFooterText.TabIndex = 1;
            // 
            // labelFooter1
            // 
            this.labelFooter1.AutoSize = true;
            this.labelFooter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFooter1.Location = new System.Drawing.Point(3, 0);
            this.labelFooter1.Name = "labelFooter1";
            this.labelFooter1.Size = new System.Drawing.Size(638, 20);
            this.labelFooter1.TabIndex = 0;
            this.labelFooter1.Text = "Pokračováním dojde ke smazání všech výše uvedených vozidel a souborů. Tato akce j" +
    "e nevratná.";
            // 
            // labelFooter2
            // 
            this.labelFooter2.AutoSize = true;
            this.labelFooter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFooter2.Location = new System.Drawing.Point(3, 20);
            this.labelFooter2.Name = "labelFooter2";
            this.labelFooter2.Size = new System.Drawing.Size(638, 20);
            this.labelFooter2.TabIndex = 1;
            this.labelFooter2.Text = "Opravdu chcete pokračovat?";
            // 
            // ControlISConflicts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelContent);
            this.Name = "ControlISConflicts";
            this.Size = new System.Drawing.Size(806, 524);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.tableLayoutPanelContent.PerformLayout();
            this.panelVehicles.ResumeLayout(false);
            this.panelVehicles.PerformLayout();
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            this.tableLayoutPanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImportant)).EndInit();
            this.flowLayoutPanelFooterText.ResumeLayout(false);
            this.flowLayoutPanelFooterText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelContent;
        private Panel panelVehicles;
        private Label labelVehicles;
        private ListView listViewVehicles;
        private Label labelHeaderInfo;
        private Panel panelFiles;
        private ListView listViewFiles;
        private Label labelFiles;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderIS;
        private ColumnHeader columnHeaderDescription;
        private ColumnHeader columnHeaderCreated;
        private ColumnHeader columnHeaderUpdated;
        private TableLayoutPanel tableLayoutPanelFooter;
        private PictureBox pictureBoxImportant;
        private FlowLayoutPanel flowLayoutPanelFooterText;
        private Label labelFooter1;
        private Label labelFooter2;
        private ColumnHeader columnHeaderFileName;
        private ColumnHeader columnHeaderFileIS;
        private ColumnHeader columnHeaderFileDesc;
        private ColumnHeader columnHeaderFileCreated;
        private ColumnHeader columnHeaderFileUpdated;
        private ColumnHeader columnHeaderPath;
        private ColumnHeader columnHeaderVehiclePath;
    }
}
