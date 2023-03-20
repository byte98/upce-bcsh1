using SemestralProject.Visual;

namespace SemestralProject.Forms
{
    internal partial class FormMain: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelItemsControl = new System.Windows.Forms.Panel();
            this.radioButtonIS = new System.Windows.Forms.RadioButton();
            this.tabPageIS = new System.Windows.Forms.TabPage();
            this.panelISContent = new System.Windows.Forms.Panel();
            this.listViewIS = new System.Windows.Forms.ListView();
            this.panelISControls = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddIS = new System.Windows.Forms.Button();
            this.tabControlContent = new System.Windows.Forms.TabControl();
            this.panelItemsControl.SuspendLayout();
            this.tabPageIS.SuspendLayout();
            this.panelISContent.SuspendLayout();
            this.panelISControls.SuspendLayout();
            this.tabControlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemsControl
            // 
            this.panelItemsControl.Controls.Add(this.radioButtonIS);
            this.panelItemsControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemsControl.Location = new System.Drawing.Point(0, 0);
            this.panelItemsControl.Name = "panelItemsControl";
            this.panelItemsControl.Size = new System.Drawing.Size(782, 29);
            this.panelItemsControl.TabIndex = 1;
            // 
            // radioButtonIS
            // 
            this.radioButtonIS.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonIS.AutoSize = true;
            this.radioButtonIS.Checked = true;
            this.radioButtonIS.FlatAppearance.BorderSize = 0;
            this.radioButtonIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonIS.Location = new System.Drawing.Point(0, 0);
            this.radioButtonIS.Name = "radioButtonIS";
            this.radioButtonIS.Size = new System.Drawing.Size(173, 30);
            this.radioButtonIS.TabIndex = 2;
            this.radioButtonIS.TabStop = true;
            this.radioButtonIS.Text = "INFORMAČNÍ SYSTÉMY";
            this.radioButtonIS.UseVisualStyleBackColor = true;
            // 
            // tabPageIS
            // 
            this.tabPageIS.Controls.Add(this.panelISContent);
            this.tabPageIS.Controls.Add(this.panelISControls);
            this.tabPageIS.Location = new System.Drawing.Point(4, 29);
            this.tabPageIS.Name = "tabPageIS";
            this.tabPageIS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIS.Size = new System.Drawing.Size(774, 491);
            this.tabPageIS.TabIndex = 0;
            this.tabPageIS.Text = "INFORMAČNÍ SYSTÉMY";
            this.tabPageIS.UseVisualStyleBackColor = true;
            // 
            // panelISContent
            // 
            this.panelISContent.Controls.Add(this.listViewIS);
            this.panelISContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelISContent.Location = new System.Drawing.Point(3, 110);
            this.panelISContent.Name = "panelISContent";
            this.panelISContent.Size = new System.Drawing.Size(768, 378);
            this.panelISContent.TabIndex = 1;
            // 
            // listViewIS
            // 
            this.listViewIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewIS.Location = new System.Drawing.Point(0, 0);
            this.listViewIS.Name = "listViewIS";
            this.listViewIS.Size = new System.Drawing.Size(768, 378);
            this.listViewIS.TabIndex = 0;
            this.listViewIS.UseCompatibleStateImageBehavior = false;
            // 
            // panelISControls
            // 
            this.panelISControls.Controls.Add(this.buttonAddIS);
            this.panelISControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelISControls.Location = new System.Drawing.Point(3, 3);
            this.panelISControls.Name = "panelISControls";
            this.panelISControls.Size = new System.Drawing.Size(768, 107);
            this.panelISControls.TabIndex = 0;
            // 
            // buttonAddIS
            // 
            this.buttonAddIS.FlatAppearance.BorderSize = 0;
            this.buttonAddIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddIS.Image = global::SemestralProject.Resources.is_add;
            this.buttonAddIS.Location = new System.Drawing.Point(3, 3);
            this.buttonAddIS.Name = "buttonAddIS";
            this.buttonAddIS.Size = new System.Drawing.Size(94, 107);
            this.buttonAddIS.TabIndex = 0;
            this.buttonAddIS.Text = "Přidat nový IS";
            this.buttonAddIS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddIS.UseVisualStyleBackColor = true;
            this.buttonAddIS.Click += new System.EventHandler(this.buttonAddIS_Click);
            // 
            // tabControlContent
            // 
            this.tabControlContent.Controls.Add(this.tabPageIS);
            this.tabControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContent.Location = new System.Drawing.Point(0, 29);
            this.tabControlContent.Name = "tabControlContent";
            this.tabControlContent.SelectedIndex = 0;
            this.tabControlContent.Size = new System.Drawing.Size(782, 524);
            this.tabControlContent.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControlContent);
            this.Controls.Add(this.panelItemsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Správce distribucí datových souborů";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Deactivate += new System.EventHandler(this.FormMain_Deactivate);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelItemsControl.ResumeLayout(false);
            this.panelItemsControl.PerformLayout();
            this.tabPageIS.ResumeLayout(false);
            this.panelISContent.ResumeLayout(false);
            this.panelISControls.ResumeLayout(false);
            this.tabControlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelItemsControl;
        private RadioButton radioButtonIS;
        private TabPage tabPageIS;
        private TabControl tabControlContent;
        private FlowLayoutPanel panelISControls;
        private Button buttonAddIS;
        private Panel panelISContent;
        private ListView listViewIS;
    }
}