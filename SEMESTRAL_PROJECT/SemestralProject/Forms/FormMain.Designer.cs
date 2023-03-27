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
            this.radioButtonMaps = new System.Windows.Forms.RadioButton();
            this.radioButtonIS = new System.Windows.Forms.RadioButton();
            this.tabPageIS = new System.Windows.Forms.TabPage();
            this.panelISContent = new System.Windows.Forms.Panel();
            this.panelISControls = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddIS = new System.Windows.Forms.Button();
            this.buttonInfoIS = new System.Windows.Forms.Button();
            this.buttonEditIS = new System.Windows.Forms.Button();
            this.buttonRemoveIS = new System.Windows.Forms.Button();
            this.buttonDeleteIS = new System.Windows.Forms.Button();
            this.splitterISControls = new System.Windows.Forms.Splitter();
            this.controlViewSizeButtonIS = new SemestralProject.Forms.ControlViewSizeButton();
            this.panelISSearch = new System.Windows.Forms.Panel();
            this.textBoxISSearch = new System.Windows.Forms.TextBox();
            this.buttonISCancelSearch = new System.Windows.Forms.Button();
            this.buttonISSearch = new System.Windows.Forms.Button();
            this.tabControlContent = new System.Windows.Forms.TabControl();
            this.tabPageMaps = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelMapsControls = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMapAdd = new System.Windows.Forms.Button();
            this.panelItemsControl.SuspendLayout();
            this.tabPageIS.SuspendLayout();
            this.panelISControls.SuspendLayout();
            this.panelISSearch.SuspendLayout();
            this.tabControlContent.SuspendLayout();
            this.tabPageMaps.SuspendLayout();
            this.flowLayoutPanelMapsControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemsControl
            // 
            this.panelItemsControl.Controls.Add(this.radioButtonMaps);
            this.panelItemsControl.Controls.Add(this.radioButtonIS);
            this.panelItemsControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemsControl.Location = new System.Drawing.Point(0, 0);
            this.panelItemsControl.Name = "panelItemsControl";
            this.panelItemsControl.Size = new System.Drawing.Size(1348, 29);
            this.panelItemsControl.TabIndex = 1;
            // 
            // radioButtonMaps
            // 
            this.radioButtonMaps.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMaps.AutoSize = true;
            this.radioButtonMaps.FlatAppearance.BorderSize = 0;
            this.radioButtonMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMaps.Location = new System.Drawing.Point(179, -1);
            this.radioButtonMaps.Name = "radioButtonMaps";
            this.radioButtonMaps.Size = new System.Drawing.Size(76, 30);
            this.radioButtonMaps.TabIndex = 3;
            this.radioButtonMaps.TabStop = true;
            this.radioButtonMaps.Text = "OBLASTI";
            this.radioButtonMaps.UseVisualStyleBackColor = true;
            this.radioButtonMaps.CheckedChanged += new System.EventHandler(this.PanelItemsControlItemClicked);
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
            this.radioButtonIS.CheckedChanged += new System.EventHandler(this.PanelItemsControlItemClicked);
            // 
            // tabPageIS
            // 
            this.tabPageIS.Controls.Add(this.panelISContent);
            this.tabPageIS.Controls.Add(this.panelISControls);
            this.tabPageIS.Location = new System.Drawing.Point(4, 29);
            this.tabPageIS.Name = "tabPageIS";
            this.tabPageIS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIS.Size = new System.Drawing.Size(1340, 659);
            this.tabPageIS.TabIndex = 0;
            this.tabPageIS.Text = "INFORMAČNÍ SYSTÉMY";
            this.tabPageIS.UseVisualStyleBackColor = true;
            // 
            // panelISContent
            // 
            this.panelISContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelISContent.Location = new System.Drawing.Point(3, 110);
            this.panelISContent.Name = "panelISContent";
            this.panelISContent.Size = new System.Drawing.Size(1334, 546);
            this.panelISContent.TabIndex = 1;
            // 
            // panelISControls
            // 
            this.panelISControls.Controls.Add(this.buttonAddIS);
            this.panelISControls.Controls.Add(this.buttonInfoIS);
            this.panelISControls.Controls.Add(this.buttonEditIS);
            this.panelISControls.Controls.Add(this.buttonRemoveIS);
            this.panelISControls.Controls.Add(this.buttonDeleteIS);
            this.panelISControls.Controls.Add(this.splitterISControls);
            this.panelISControls.Controls.Add(this.controlViewSizeButtonIS);
            this.panelISControls.Controls.Add(this.panelISSearch);
            this.panelISControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelISControls.Location = new System.Drawing.Point(3, 3);
            this.panelISControls.Name = "panelISControls";
            this.panelISControls.Size = new System.Drawing.Size(1334, 107);
            this.panelISControls.TabIndex = 0;
            // 
            // buttonAddIS
            // 
            this.buttonAddIS.FlatAppearance.BorderSize = 0;
            this.buttonAddIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddIS.Image = global::SemestralProject.Resources.is_add;
            this.buttonAddIS.Location = new System.Drawing.Point(3, 3);
            this.buttonAddIS.Name = "buttonAddIS";
            this.buttonAddIS.Size = new System.Drawing.Size(94, 94);
            this.buttonAddIS.TabIndex = 0;
            this.buttonAddIS.Text = "Přidat nový IS";
            this.buttonAddIS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddIS.UseVisualStyleBackColor = true;
            this.buttonAddIS.Click += new System.EventHandler(this.buttonAddIS_Click);
            // 
            // buttonInfoIS
            // 
            this.buttonInfoIS.Enabled = false;
            this.buttonInfoIS.FlatAppearance.BorderSize = 0;
            this.buttonInfoIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoIS.Image = global::SemestralProject.Resources.is_info;
            this.buttonInfoIS.Location = new System.Drawing.Point(103, 3);
            this.buttonInfoIS.Name = "buttonInfoIS";
            this.buttonInfoIS.Size = new System.Drawing.Size(94, 94);
            this.buttonInfoIS.TabIndex = 1;
            this.buttonInfoIS.Text = "Informace o IS";
            this.buttonInfoIS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInfoIS.UseVisualStyleBackColor = true;
            this.buttonInfoIS.Click += new System.EventHandler(this.buttonInfoIS_Click);
            // 
            // buttonEditIS
            // 
            this.buttonEditIS.Enabled = false;
            this.buttonEditIS.FlatAppearance.BorderSize = 0;
            this.buttonEditIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditIS.Image = global::SemestralProject.Resources.is_edit;
            this.buttonEditIS.Location = new System.Drawing.Point(203, 3);
            this.buttonEditIS.Name = "buttonEditIS";
            this.buttonEditIS.Size = new System.Drawing.Size(94, 94);
            this.buttonEditIS.TabIndex = 5;
            this.buttonEditIS.Text = "Upravit vybraný IS";
            this.buttonEditIS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditIS.UseVisualStyleBackColor = true;
            this.buttonEditIS.Click += new System.EventHandler(this.buttonEditIS_Click);
            // 
            // buttonRemoveIS
            // 
            this.buttonRemoveIS.Enabled = false;
            this.buttonRemoveIS.FlatAppearance.BorderSize = 0;
            this.buttonRemoveIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveIS.Image = global::SemestralProject.Resources.is_remove;
            this.buttonRemoveIS.Location = new System.Drawing.Point(303, 3);
            this.buttonRemoveIS.Name = "buttonRemoveIS";
            this.buttonRemoveIS.Size = new System.Drawing.Size(94, 94);
            this.buttonRemoveIS.TabIndex = 2;
            this.buttonRemoveIS.Text = "Smazat vybraný IS";
            this.buttonRemoveIS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRemoveIS.UseVisualStyleBackColor = true;
            this.buttonRemoveIS.Click += new System.EventHandler(this.buttonRemoveIS_Click);
            // 
            // buttonDeleteIS
            // 
            this.buttonDeleteIS.FlatAppearance.BorderSize = 0;
            this.buttonDeleteIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteIS.Image = global::SemestralProject.Resources.is_delete;
            this.buttonDeleteIS.Location = new System.Drawing.Point(403, 3);
            this.buttonDeleteIS.Name = "buttonDeleteIS";
            this.buttonDeleteIS.Size = new System.Drawing.Size(94, 94);
            this.buttonDeleteIS.TabIndex = 3;
            this.buttonDeleteIS.Text = "Smazat všechny IS";
            this.buttonDeleteIS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteIS.UseVisualStyleBackColor = true;
            this.buttonDeleteIS.Click += new System.EventHandler(this.buttonDeleteIS_Click);
            // 
            // splitterISControls
            // 
            this.splitterISControls.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterISControls.Location = new System.Drawing.Point(503, 3);
            this.splitterISControls.Name = "splitterISControls";
            this.splitterISControls.Size = new System.Drawing.Size(1, 104);
            this.splitterISControls.TabIndex = 4;
            this.splitterISControls.TabStop = false;
            // 
            // controlViewSizeButtonIS
            // 
            this.controlViewSizeButtonIS.Location = new System.Drawing.Point(510, 3);
            this.controlViewSizeButtonIS.Name = "controlViewSizeButtonIS";
            this.controlViewSizeButtonIS.Size = new System.Drawing.Size(188, 94);
            this.controlViewSizeButtonIS.TabIndex = 6;
            // 
            // panelISSearch
            // 
            this.panelISSearch.Controls.Add(this.textBoxISSearch);
            this.panelISSearch.Controls.Add(this.buttonISCancelSearch);
            this.panelISSearch.Controls.Add(this.buttonISSearch);
            this.panelISSearch.Location = new System.Drawing.Point(704, 3);
            this.panelISSearch.Name = "panelISSearch";
            this.panelISSearch.Size = new System.Drawing.Size(253, 104);
            this.panelISSearch.TabIndex = 7;
            // 
            // textBoxISSearch
            // 
            this.textBoxISSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxISSearch.Name = "textBoxISSearch";
            this.textBoxISSearch.PlaceholderText = "Hledat";
            this.textBoxISSearch.Size = new System.Drawing.Size(247, 27);
            this.textBoxISSearch.TabIndex = 0;
            // 
            // buttonISCancelSearch
            // 
            this.buttonISCancelSearch.Enabled = false;
            this.buttonISCancelSearch.FlatAppearance.BorderSize = 0;
            this.buttonISCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonISCancelSearch.Image = global::SemestralProject.Resources.search_cancel;
            this.buttonISCancelSearch.Location = new System.Drawing.Point(129, 36);
            this.buttonISCancelSearch.Name = "buttonISCancelSearch";
            this.buttonISCancelSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonISCancelSearch.TabIndex = 1;
            this.buttonISCancelSearch.Text = "Zrušit hledání";
            this.buttonISCancelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonISCancelSearch.UseVisualStyleBackColor = true;
            this.buttonISCancelSearch.Click += new System.EventHandler(this.buttonISCancelSearch_Click);
            // 
            // buttonISSearch
            // 
            this.buttonISSearch.FlatAppearance.BorderSize = 0;
            this.buttonISSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonISSearch.Image = global::SemestralProject.Resources.search;
            this.buttonISSearch.Location = new System.Drawing.Point(3, 36);
            this.buttonISSearch.Name = "buttonISSearch";
            this.buttonISSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonISSearch.TabIndex = 1;
            this.buttonISSearch.Text = "Hledat";
            this.buttonISSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonISSearch.UseVisualStyleBackColor = true;
            this.buttonISSearch.Click += new System.EventHandler(this.buttonISSearch_Click);
            // 
            // tabControlContent
            // 
            this.tabControlContent.Controls.Add(this.tabPageIS);
            this.tabControlContent.Controls.Add(this.tabPageMaps);
            this.tabControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContent.Location = new System.Drawing.Point(0, 29);
            this.tabControlContent.Name = "tabControlContent";
            this.tabControlContent.SelectedIndex = 0;
            this.tabControlContent.Size = new System.Drawing.Size(1348, 692);
            this.tabControlContent.TabIndex = 2;
            // 
            // tabPageMaps
            // 
            this.tabPageMaps.Controls.Add(this.flowLayoutPanelMapsControls);
            this.tabPageMaps.Location = new System.Drawing.Point(4, 29);
            this.tabPageMaps.Name = "tabPageMaps";
            this.tabPageMaps.Size = new System.Drawing.Size(1340, 659);
            this.tabPageMaps.TabIndex = 1;
            this.tabPageMaps.Text = "OBLASTI";
            this.tabPageMaps.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMapsControls
            // 
            this.flowLayoutPanelMapsControls.Controls.Add(this.buttonMapAdd);
            this.flowLayoutPanelMapsControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelMapsControls.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMapsControls.Name = "flowLayoutPanelMapsControls";
            this.flowLayoutPanelMapsControls.Size = new System.Drawing.Size(1340, 107);
            this.flowLayoutPanelMapsControls.TabIndex = 0;
            // 
            // buttonMapAdd
            // 
            this.buttonMapAdd.FlatAppearance.BorderSize = 0;
            this.buttonMapAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMapAdd.Image = global::SemestralProject.Resources.map_add;
            this.buttonMapAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonMapAdd.Name = "buttonMapAdd";
            this.buttonMapAdd.Size = new System.Drawing.Size(94, 94);
            this.buttonMapAdd.TabIndex = 0;
            this.buttonMapAdd.Text = "Přidat oblast";
            this.buttonMapAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMapAdd.UseVisualStyleBackColor = true;
            this.buttonMapAdd.Click += new System.EventHandler(this.buttonMapAdd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
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
            this.panelISControls.ResumeLayout(false);
            this.panelISSearch.ResumeLayout(false);
            this.panelISSearch.PerformLayout();
            this.tabControlContent.ResumeLayout(false);
            this.tabPageMaps.ResumeLayout(false);
            this.flowLayoutPanelMapsControls.ResumeLayout(false);
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
        private Button buttonInfoIS;
        private Button buttonRemoveIS;
        private Button buttonDeleteIS;
        private Splitter splitterISControls;
        private Button buttonEditIS;
        private ControlViewSizeButton controlViewSizeButtonIS;
        private TextBox textBoxISSearch;
        private Button buttonISSearch;
        private Panel panelISSearch;
        private Button buttonISCancelSearch;
        private RadioButton radioButtonMaps;
        private TabPage tabPageMaps;
        private FlowLayoutPanel flowLayoutPanelMapsControls;
        private Button buttonMapAdd;
    }
}