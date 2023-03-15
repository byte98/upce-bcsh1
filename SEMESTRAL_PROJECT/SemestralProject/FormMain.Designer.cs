namespace SemestralProject
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlContent = new System.Windows.Forms.TabControl();
            this.tabPageIS = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlContent
            // 
            this.tabControlContent.Controls.Add(this.tabPageIS);
            this.tabControlContent.Controls.Add(this.tabPage1);
            this.tabControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContent.Location = new System.Drawing.Point(0, 0);
            this.tabControlContent.Name = "tabControlContent";
            this.tabControlContent.SelectedIndex = 0;
            this.tabControlContent.Size = new System.Drawing.Size(782, 553);
            this.tabControlContent.TabIndex = 0;
            // 
            // tabPageIS
            // 
            this.tabPageIS.Location = new System.Drawing.Point(4, 29);
            this.tabPageIS.Name = "tabPageIS";
            this.tabPageIS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIS.Size = new System.Drawing.Size(774, 520);
            this.tabPageIS.TabIndex = 0;
            this.tabPageIS.Text = "INFORMAČNÍ SYSTÉMY";
            this.tabPageIS.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 520);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControlContent);
            this.Name = "FormMain";
            this.Text = "Správce distribucí datových souborů";
            this.tabControlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlContent;
        private TabPage tabPageIS;
        private TabPage tabPage1;
    }
}