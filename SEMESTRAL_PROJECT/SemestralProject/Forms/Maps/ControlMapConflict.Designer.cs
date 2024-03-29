﻿namespace SemestralProject.Forms.Maps
{
    partial class ControlMapConflict
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
            this.labelHeaderInfo = new System.Windows.Forms.Label();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFileName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFileMap = new System.Windows.Forms.ColumnHeader();
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
            this.tableLayoutPanelContent.Controls.Add(this.labelHeaderInfo, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.panelFiles, 0, 1);
            this.tableLayoutPanelContent.Controls.Add(this.tableLayoutPanelFooter, 0, 2);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.RowCount = 3;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(806, 524);
            this.tableLayoutPanelContent.TabIndex = 1;
            // 
            // labelHeaderInfo
            // 
            this.labelHeaderInfo.AutoSize = true;
            this.labelHeaderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeaderInfo.Location = new System.Drawing.Point(3, 0);
            this.labelHeaderInfo.Name = "labelHeaderInfo";
            this.labelHeaderInfo.Size = new System.Drawing.Size(800, 20);
            this.labelHeaderInfo.TabIndex = 1;
            this.labelHeaderInfo.Text = "Při pokusu o smazání oblasti byly nalezeny konflikty.";
            // 
            // panelFiles
            // 
            this.panelFiles.Controls.Add(this.listViewFiles);
            this.panelFiles.Controls.Add(this.labelFiles);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(3, 23);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(800, 438);
            this.panelFiles.TabIndex = 2;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFileName,
            this.columnHeaderFileMap,
            this.columnHeaderFileDesc,
            this.columnHeaderPath,
            this.columnHeaderFileCreated,
            this.columnHeaderFileUpdated});
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.Location = new System.Drawing.Point(0, 20);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(800, 418);
            this.listViewFiles.TabIndex = 1;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFileName
            // 
            this.columnHeaderFileName.Text = "Název";
            // 
            // columnHeaderFileMap
            // 
            this.columnHeaderFileMap.Text = "Oblast";
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
            this.labelFiles.Size = new System.Drawing.Size(318, 20);
            this.labelFiles.TabIndex = 0;
            this.labelFiles.Text = "Soubory, ve kterých jsou uložena data k oblasti";
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
            this.labelFooter1.Size = new System.Drawing.Size(574, 20);
            this.labelFooter1.TabIndex = 0;
            this.labelFooter1.Text = "Pokračováním dojde ke smazání všech výše uvedených souborů. Tato akce je nevratná" +
    ".";
            // 
            // labelFooter2
            // 
            this.labelFooter2.AutoSize = true;
            this.labelFooter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFooter2.Location = new System.Drawing.Point(3, 20);
            this.labelFooter2.Name = "labelFooter2";
            this.labelFooter2.Size = new System.Drawing.Size(574, 20);
            this.labelFooter2.TabIndex = 1;
            this.labelFooter2.Text = "Opravdu chcete pokračovat?";
            // 
            // ControlMapConflict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelContent);
            this.Name = "ControlMapConflict";
            this.Size = new System.Drawing.Size(806, 524);
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.tableLayoutPanelContent.PerformLayout();
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
        private Label labelHeaderInfo;
        private Panel panelFiles;
        private ListView listViewFiles;
        private ColumnHeader columnHeaderFileName;
        private ColumnHeader columnHeaderFileMap;
        private ColumnHeader columnHeaderFileDesc;
        private ColumnHeader columnHeaderPath;
        private ColumnHeader columnHeaderFileCreated;
        private ColumnHeader columnHeaderFileUpdated;
        private Label labelFiles;
        private TableLayoutPanel tableLayoutPanelFooter;
        private PictureBox pictureBoxImportant;
        private FlowLayoutPanel flowLayoutPanelFooterText;
        private Label labelFooter1;
        private Label labelFooter2;
    }
}
