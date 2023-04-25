namespace SemestralProject.Forms
{
    partial class ControlProgress
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
            this.labelState = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonShowDetails = new System.Windows.Forms.Button();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelContent
            // 
            this.flowLayoutPanelContent.Controls.Add(this.labelState);
            this.flowLayoutPanelContent.Controls.Add(this.progressBar);
            this.flowLayoutPanelContent.Controls.Add(this.buttonShowDetails);
            this.flowLayoutPanelContent.Controls.Add(this.textBoxDetails);
            this.flowLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelContent.Name = "flowLayoutPanelContent";
            this.flowLayoutPanelContent.Size = new System.Drawing.Size(960, 115);
            this.flowLayoutPanelContent.TabIndex = 0;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(3, 0);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(13, 20);
            this.labelState.TabIndex = 0;
            this.labelState.Text = " ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 23);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(954, 34);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // buttonShowDetails
            // 
            this.buttonShowDetails.Location = new System.Drawing.Point(3, 63);
            this.buttonShowDetails.Name = "buttonShowDetails";
            this.buttonShowDetails.Size = new System.Drawing.Size(173, 47);
            this.buttonShowDetails.TabIndex = 2;
            this.buttonShowDetails.Text = "Zobrazit podrobnosti";
            this.buttonShowDetails.UseVisualStyleBackColor = true;
            this.buttonShowDetails.Click += new System.EventHandler(this.buttonShowDetails_Click);
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Location = new System.Drawing.Point(963, 3);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDetails.Size = new System.Drawing.Size(954, 256);
            this.textBoxDetails.TabIndex = 3;
            this.textBoxDetails.Visible = false;
            // 
            // ControlExportImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelContent);
            this.Name = "ControlExportImport";
            this.Size = new System.Drawing.Size(960, 115);
            this.flowLayoutPanelContent.ResumeLayout(false);
            this.flowLayoutPanelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelContent;
        private Label labelState;
        private ProgressBar progressBar;
        private Button buttonShowDetails;
        private TextBox textBoxDetails;
    }
}
