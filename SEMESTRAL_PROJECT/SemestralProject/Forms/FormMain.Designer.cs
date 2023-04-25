using SemestralProject.Visual;

namespace SemestralProject.Forms
{
    internal partial class FormMain: Form, IForm
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
            this.radioButtonActions = new System.Windows.Forms.RadioButton();
            this.radioButtonFiles = new System.Windows.Forms.RadioButton();
            this.radioButtonVehicles = new System.Windows.Forms.RadioButton();
            this.radioButtonManufacturers = new System.Windows.Forms.RadioButton();
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
            this.splitterISControls1 = new System.Windows.Forms.Splitter();
            this.panelISSizeButton = new System.Windows.Forms.Panel();
            this.splitterISControls2 = new System.Windows.Forms.Splitter();
            this.panelISSearch = new System.Windows.Forms.Panel();
            this.textBoxISSearch = new System.Windows.Forms.TextBox();
            this.buttonISCancelSearch = new System.Windows.Forms.Button();
            this.buttonISSearch = new System.Windows.Forms.Button();
            this.splitterISControls3 = new System.Windows.Forms.Splitter();
            this.tabControlContent = new System.Windows.Forms.TabControl();
            this.tabPageMaps = new System.Windows.Forms.TabPage();
            this.panelMapContent = new System.Windows.Forms.Panel();
            this.panelMapsControls = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddMap = new System.Windows.Forms.Button();
            this.buttonInfoMap = new System.Windows.Forms.Button();
            this.buttonEditMap = new System.Windows.Forms.Button();
            this.buttonRemoveMap = new System.Windows.Forms.Button();
            this.buttonDeleteMap = new System.Windows.Forms.Button();
            this.splitterMapControls1 = new System.Windows.Forms.Splitter();
            this.panelMapSizeButton = new System.Windows.Forms.Panel();
            this.splitterMapControls2 = new System.Windows.Forms.Splitter();
            this.panelMapSearch = new System.Windows.Forms.Panel();
            this.textBoxMapSearch = new System.Windows.Forms.TextBox();
            this.buttonMapCancelSearch = new System.Windows.Forms.Button();
            this.buttonMapSearch = new System.Windows.Forms.Button();
            this.splitterMapControls3 = new System.Windows.Forms.Splitter();
            this.tabPageManufacturers = new System.Windows.Forms.TabPage();
            this.panelManufacturerContent = new System.Windows.Forms.Panel();
            this.panelManufacturerControls = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddManufacturer = new System.Windows.Forms.Button();
            this.buttonInfoManufacturer = new System.Windows.Forms.Button();
            this.buttonEditManufacturer = new System.Windows.Forms.Button();
            this.buttonRemoveManufacturer = new System.Windows.Forms.Button();
            this.buttonDeleteManufacturer = new System.Windows.Forms.Button();
            this.splitterManufacturerControls1 = new System.Windows.Forms.Splitter();
            this.panelManufacturerSizeControl = new System.Windows.Forms.Panel();
            this.splitterManufacturerControls2 = new System.Windows.Forms.Splitter();
            this.panelManufacturerSearch = new System.Windows.Forms.Panel();
            this.textBoxManufacturerSearch = new System.Windows.Forms.TextBox();
            this.buttonManufacturerCancelSearch = new System.Windows.Forms.Button();
            this.buttonManufacturerSearch = new System.Windows.Forms.Button();
            this.splitterManufacturerControls3 = new System.Windows.Forms.Splitter();
            this.tabPageVehicles = new System.Windows.Forms.TabPage();
            this.panelVehicleContent = new System.Windows.Forms.Panel();
            this.panelVehicleControls = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.buttonInfoVehicle = new System.Windows.Forms.Button();
            this.buttonEditVehicle = new System.Windows.Forms.Button();
            this.buttonRemoveVehicle = new System.Windows.Forms.Button();
            this.buttonDeleteVehicle = new System.Windows.Forms.Button();
            this.splitterVehicleControls1 = new System.Windows.Forms.Splitter();
            this.panelVehicleSizeButton = new System.Windows.Forms.Panel();
            this.splitterVehicleControls2 = new System.Windows.Forms.Splitter();
            this.panelVehicleSearch = new System.Windows.Forms.Panel();
            this.textBoxVehicleSearch = new System.Windows.Forms.TextBox();
            this.buttonVehicleCancelSearch = new System.Windows.Forms.Button();
            this.buttonVehicleSearch = new System.Windows.Forms.Button();
            this.splitterVehicleControls3 = new System.Windows.Forms.Splitter();
            this.tabPageFiles = new System.Windows.Forms.TabPage();
            this.panelFileContent = new System.Windows.Forms.Panel();
            this.panelFileControls = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.buttonInfoFile = new System.Windows.Forms.Button();
            this.buttonEditFile = new System.Windows.Forms.Button();
            this.buttonRemoveFile = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.splitterFileControls1 = new System.Windows.Forms.Splitter();
            this.panelFileSizeControl = new System.Windows.Forms.Panel();
            this.splitterFileControls2 = new System.Windows.Forms.Splitter();
            this.panelFileSearch = new System.Windows.Forms.Panel();
            this.textBoxFileSearch = new System.Windows.Forms.TextBox();
            this.buttonFileCancelSearch = new System.Windows.Forms.Button();
            this.buttonFileSearch = new System.Windows.Forms.Button();
            this.splitterFileControls3 = new System.Windows.Forms.Splitter();
            this.tabPageActions = new System.Windows.Forms.TabPage();
            this.panelActionsContent = new System.Windows.Forms.TableLayoutPanel();
            this.panelActionsHeader = new System.Windows.Forms.Panel();
            this.labelActionsHeader = new System.Windows.Forms.Label();
            this.pictureBoxActionsHeader = new System.Windows.Forms.PictureBox();
            this.splitterActionsHeader = new System.Windows.Forms.Splitter();
            this.groupBoxActionsDataTransfer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelActionsDataTransfer = new System.Windows.Forms.TableLayoutPanel();
            this.buttonActionsExport = new System.Windows.Forms.Button();
            this.buttonActionsImport = new System.Windows.Forms.Button();
            this.flowLayoutPanelActionsExport = new System.Windows.Forms.FlowLayoutPanel();
            this.labelActionsExport1 = new System.Windows.Forms.Label();
            this.labelActionsExport2 = new System.Windows.Forms.Label();
            this.labelActionsExport3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelActionsImport = new System.Windows.Forms.FlowLayoutPanel();
            this.labelActionsImport1 = new System.Windows.Forms.Label();
            this.labelActionsImport2 = new System.Windows.Forms.Label();
            this.labelActionsImport3 = new System.Windows.Forms.Label();
            this.groupBoxActionCopy = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelActionCopyContent = new System.Windows.Forms.TableLayoutPanel();
            this.buttonActionCopy = new System.Windows.Forms.Button();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogImport = new System.Windows.Forms.OpenFileDialog();
            this.buttonActionCopyReplace = new System.Windows.Forms.Button();
            this.flowLayoutPanelActionCopy = new System.Windows.Forms.FlowLayoutPanel();
            this.labelActionCopy1 = new System.Windows.Forms.Label();
            this.labelActionCopy2 = new System.Windows.Forms.Label();
            this.labelActionCopy3 = new System.Windows.Forms.Label();
            this.flowLayoutPanelActionCopyReplace = new System.Windows.Forms.FlowLayoutPanel();
            this.labelActionCopyReplace1 = new System.Windows.Forms.Label();
            this.labelActionCopyReplace2 = new System.Windows.Forms.Label();
            this.labelActionCopyReplace3 = new System.Windows.Forms.Label();
            this.panelItemsControl.SuspendLayout();
            this.tabPageIS.SuspendLayout();
            this.panelISControls.SuspendLayout();
            this.panelISSearch.SuspendLayout();
            this.tabControlContent.SuspendLayout();
            this.tabPageMaps.SuspendLayout();
            this.panelMapsControls.SuspendLayout();
            this.panelMapSearch.SuspendLayout();
            this.tabPageManufacturers.SuspendLayout();
            this.panelManufacturerControls.SuspendLayout();
            this.panelManufacturerSearch.SuspendLayout();
            this.tabPageVehicles.SuspendLayout();
            this.panelVehicleControls.SuspendLayout();
            this.panelVehicleSearch.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            this.panelFileControls.SuspendLayout();
            this.panelFileSearch.SuspendLayout();
            this.tabPageActions.SuspendLayout();
            this.panelActionsContent.SuspendLayout();
            this.panelActionsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionsHeader)).BeginInit();
            this.groupBoxActionsDataTransfer.SuspendLayout();
            this.tableLayoutPanelActionsDataTransfer.SuspendLayout();
            this.flowLayoutPanelActionsExport.SuspendLayout();
            this.flowLayoutPanelActionsImport.SuspendLayout();
            this.groupBoxActionCopy.SuspendLayout();
            this.tableLayoutPanelActionCopyContent.SuspendLayout();
            this.flowLayoutPanelActionCopy.SuspendLayout();
            this.flowLayoutPanelActionCopyReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemsControl
            // 
            this.panelItemsControl.Controls.Add(this.radioButtonActions);
            this.panelItemsControl.Controls.Add(this.radioButtonFiles);
            this.panelItemsControl.Controls.Add(this.radioButtonVehicles);
            this.panelItemsControl.Controls.Add(this.radioButtonManufacturers);
            this.panelItemsControl.Controls.Add(this.radioButtonMaps);
            this.panelItemsControl.Controls.Add(this.radioButtonIS);
            this.panelItemsControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemsControl.Location = new System.Drawing.Point(0, 0);
            this.panelItemsControl.Name = "panelItemsControl";
            this.panelItemsControl.Size = new System.Drawing.Size(1348, 29);
            this.panelItemsControl.TabIndex = 1;
            // 
            // radioButtonActions
            // 
            this.radioButtonActions.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonActions.AutoSize = true;
            this.radioButtonActions.FlatAppearance.BorderSize = 0;
            this.radioButtonActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonActions.Location = new System.Drawing.Point(522, 0);
            this.radioButtonActions.Name = "radioButtonActions";
            this.radioButtonActions.Size = new System.Drawing.Size(54, 30);
            this.radioButtonActions.TabIndex = 6;
            this.radioButtonActions.TabStop = true;
            this.radioButtonActions.Text = "AKCE";
            this.radioButtonActions.UseVisualStyleBackColor = true;
            this.radioButtonActions.CheckedChanged += new System.EventHandler(this.PanelItemsControlItemClicked);
            // 
            // radioButtonFiles
            // 
            this.radioButtonFiles.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFiles.AutoSize = true;
            this.radioButtonFiles.FlatAppearance.BorderSize = 0;
            this.radioButtonFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonFiles.Location = new System.Drawing.Point(431, -1);
            this.radioButtonFiles.Name = "radioButtonFiles";
            this.radioButtonFiles.Size = new System.Drawing.Size(85, 30);
            this.radioButtonFiles.TabIndex = 5;
            this.radioButtonFiles.TabStop = true;
            this.radioButtonFiles.Text = "SOUBORY";
            this.radioButtonFiles.UseVisualStyleBackColor = true;
            this.radioButtonFiles.CheckedChanged += new System.EventHandler(this.PanelItemsControlItemClicked);
            // 
            // radioButtonVehicles
            // 
            this.radioButtonVehicles.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonVehicles.AutoSize = true;
            this.radioButtonVehicles.FlatAppearance.BorderSize = 0;
            this.radioButtonVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonVehicles.Location = new System.Drawing.Point(345, -1);
            this.radioButtonVehicles.Name = "radioButtonVehicles";
            this.radioButtonVehicles.Size = new System.Drawing.Size(80, 30);
            this.radioButtonVehicles.TabIndex = 4;
            this.radioButtonVehicles.TabStop = true;
            this.radioButtonVehicles.Text = "VOZIDLA";
            this.radioButtonVehicles.UseVisualStyleBackColor = true;
            this.radioButtonVehicles.CheckedChanged += new System.EventHandler(this.PanelItemsControlItemClicked);
            // 
            // radioButtonManufacturers
            // 
            this.radioButtonManufacturers.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonManufacturers.AutoSize = true;
            this.radioButtonManufacturers.FlatAppearance.BorderSize = 0;
            this.radioButtonManufacturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonManufacturers.Location = new System.Drawing.Point(261, 0);
            this.radioButtonManufacturers.Name = "radioButtonManufacturers";
            this.radioButtonManufacturers.Size = new System.Drawing.Size(78, 30);
            this.radioButtonManufacturers.TabIndex = 4;
            this.radioButtonManufacturers.TabStop = true;
            this.radioButtonManufacturers.Text = "VÝROBCI";
            this.radioButtonManufacturers.UseVisualStyleBackColor = true;
            this.radioButtonManufacturers.CheckedChanged += new System.EventHandler(this.PanelItemsControlItemClicked);
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
            this.panelISControls.Controls.Add(this.splitterISControls1);
            this.panelISControls.Controls.Add(this.panelISSizeButton);
            this.panelISControls.Controls.Add(this.splitterISControls2);
            this.panelISControls.Controls.Add(this.panelISSearch);
            this.panelISControls.Controls.Add(this.splitterISControls3);
            this.panelISControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelISControls.Location = new System.Drawing.Point(3, 3);
            this.panelISControls.Name = "panelISControls";
            this.panelISControls.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
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
            // splitterISControls1
            // 
            this.splitterISControls1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterISControls1.Location = new System.Drawing.Point(503, 3);
            this.splitterISControls1.Name = "splitterISControls1";
            this.splitterISControls1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.splitterISControls1.Size = new System.Drawing.Size(1, 104);
            this.splitterISControls1.TabIndex = 4;
            this.splitterISControls1.TabStop = false;
            // 
            // panelISSizeButton
            // 
            this.panelISSizeButton.Location = new System.Drawing.Point(510, 3);
            this.panelISSizeButton.Name = "panelISSizeButton";
            this.panelISSizeButton.Size = new System.Drawing.Size(188, 94);
            this.panelISSizeButton.TabIndex = 10;
            // 
            // splitterISControls2
            // 
            this.splitterISControls2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterISControls2.Location = new System.Drawing.Point(704, 3);
            this.splitterISControls2.Name = "splitterISControls2";
            this.splitterISControls2.Size = new System.Drawing.Size(1, 104);
            this.splitterISControls2.TabIndex = 8;
            this.splitterISControls2.TabStop = false;
            // 
            // panelISSearch
            // 
            this.panelISSearch.Controls.Add(this.textBoxISSearch);
            this.panelISSearch.Controls.Add(this.buttonISCancelSearch);
            this.panelISSearch.Controls.Add(this.buttonISSearch);
            this.panelISSearch.Location = new System.Drawing.Point(711, 3);
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
            // splitterISControls3
            // 
            this.splitterISControls3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterISControls3.Location = new System.Drawing.Point(970, 3);
            this.splitterISControls3.Name = "splitterISControls3";
            this.splitterISControls3.Size = new System.Drawing.Size(1, 104);
            this.splitterISControls3.TabIndex = 9;
            this.splitterISControls3.TabStop = false;
            // 
            // tabControlContent
            // 
            this.tabControlContent.Controls.Add(this.tabPageIS);
            this.tabControlContent.Controls.Add(this.tabPageMaps);
            this.tabControlContent.Controls.Add(this.tabPageManufacturers);
            this.tabControlContent.Controls.Add(this.tabPageVehicles);
            this.tabControlContent.Controls.Add(this.tabPageFiles);
            this.tabControlContent.Controls.Add(this.tabPageActions);
            this.tabControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContent.Location = new System.Drawing.Point(0, 29);
            this.tabControlContent.Name = "tabControlContent";
            this.tabControlContent.SelectedIndex = 0;
            this.tabControlContent.Size = new System.Drawing.Size(1348, 692);
            this.tabControlContent.TabIndex = 2;
            // 
            // tabPageMaps
            // 
            this.tabPageMaps.Controls.Add(this.panelMapContent);
            this.tabPageMaps.Controls.Add(this.panelMapsControls);
            this.tabPageMaps.Location = new System.Drawing.Point(4, 29);
            this.tabPageMaps.Name = "tabPageMaps";
            this.tabPageMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaps.Size = new System.Drawing.Size(1340, 659);
            this.tabPageMaps.TabIndex = 1;
            this.tabPageMaps.Text = "OBLASTI";
            this.tabPageMaps.UseVisualStyleBackColor = true;
            // 
            // panelMapContent
            // 
            this.panelMapContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMapContent.Location = new System.Drawing.Point(3, 110);
            this.panelMapContent.Name = "panelMapContent";
            this.panelMapContent.Size = new System.Drawing.Size(1334, 546);
            this.panelMapContent.TabIndex = 2;
            // 
            // panelMapsControls
            // 
            this.panelMapsControls.Controls.Add(this.buttonAddMap);
            this.panelMapsControls.Controls.Add(this.buttonInfoMap);
            this.panelMapsControls.Controls.Add(this.buttonEditMap);
            this.panelMapsControls.Controls.Add(this.buttonRemoveMap);
            this.panelMapsControls.Controls.Add(this.buttonDeleteMap);
            this.panelMapsControls.Controls.Add(this.splitterMapControls1);
            this.panelMapsControls.Controls.Add(this.panelMapSizeButton);
            this.panelMapsControls.Controls.Add(this.splitterMapControls2);
            this.panelMapsControls.Controls.Add(this.panelMapSearch);
            this.panelMapsControls.Controls.Add(this.splitterMapControls3);
            this.panelMapsControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMapsControls.Location = new System.Drawing.Point(3, 3);
            this.panelMapsControls.Name = "panelMapsControls";
            this.panelMapsControls.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelMapsControls.Size = new System.Drawing.Size(1334, 107);
            this.panelMapsControls.TabIndex = 1;
            // 
            // buttonAddMap
            // 
            this.buttonAddMap.FlatAppearance.BorderSize = 0;
            this.buttonAddMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMap.Image = global::SemestralProject.Resources.map_add;
            this.buttonAddMap.Location = new System.Drawing.Point(3, 3);
            this.buttonAddMap.Name = "buttonAddMap";
            this.buttonAddMap.Size = new System.Drawing.Size(94, 94);
            this.buttonAddMap.TabIndex = 0;
            this.buttonAddMap.Text = "Přidat oblast";
            this.buttonAddMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddMap.UseVisualStyleBackColor = true;
            this.buttonAddMap.Click += new System.EventHandler(this.buttonAddMap_Click);
            // 
            // buttonInfoMap
            // 
            this.buttonInfoMap.Enabled = false;
            this.buttonInfoMap.FlatAppearance.BorderSize = 0;
            this.buttonInfoMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoMap.Image = global::SemestralProject.Resources.map_info;
            this.buttonInfoMap.Location = new System.Drawing.Point(103, 3);
            this.buttonInfoMap.Name = "buttonInfoMap";
            this.buttonInfoMap.Size = new System.Drawing.Size(94, 94);
            this.buttonInfoMap.TabIndex = 1;
            this.buttonInfoMap.Text = "Informace o oblasti";
            this.buttonInfoMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInfoMap.UseVisualStyleBackColor = true;
            this.buttonInfoMap.Click += new System.EventHandler(this.buttonInfoMap_Click);
            // 
            // buttonEditMap
            // 
            this.buttonEditMap.Enabled = false;
            this.buttonEditMap.FlatAppearance.BorderSize = 0;
            this.buttonEditMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditMap.Image = global::SemestralProject.Resources.map_edit;
            this.buttonEditMap.Location = new System.Drawing.Point(203, 3);
            this.buttonEditMap.Name = "buttonEditMap";
            this.buttonEditMap.Size = new System.Drawing.Size(94, 94);
            this.buttonEditMap.TabIndex = 5;
            this.buttonEditMap.Text = "Upravit oblast";
            this.buttonEditMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditMap.UseVisualStyleBackColor = true;
            this.buttonEditMap.Click += new System.EventHandler(this.buttonEditMap_Click);
            // 
            // buttonRemoveMap
            // 
            this.buttonRemoveMap.Enabled = false;
            this.buttonRemoveMap.FlatAppearance.BorderSize = 0;
            this.buttonRemoveMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveMap.Image = global::SemestralProject.Resources.map_remove;
            this.buttonRemoveMap.Location = new System.Drawing.Point(303, 3);
            this.buttonRemoveMap.Name = "buttonRemoveMap";
            this.buttonRemoveMap.Size = new System.Drawing.Size(94, 94);
            this.buttonRemoveMap.TabIndex = 2;
            this.buttonRemoveMap.Text = "Smazat oblast";
            this.buttonRemoveMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRemoveMap.UseVisualStyleBackColor = true;
            this.buttonRemoveMap.Click += new System.EventHandler(this.buttonRemoveMap_Click);
            // 
            // buttonDeleteMap
            // 
            this.buttonDeleteMap.FlatAppearance.BorderSize = 0;
            this.buttonDeleteMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMap.Image = global::SemestralProject.Resources.map_delete;
            this.buttonDeleteMap.Location = new System.Drawing.Point(403, 3);
            this.buttonDeleteMap.Name = "buttonDeleteMap";
            this.buttonDeleteMap.Size = new System.Drawing.Size(94, 94);
            this.buttonDeleteMap.TabIndex = 3;
            this.buttonDeleteMap.Text = "Smazat všechno";
            this.buttonDeleteMap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteMap.UseVisualStyleBackColor = true;
            this.buttonDeleteMap.Click += new System.EventHandler(this.buttonDeleteMap_Click);
            // 
            // splitterMapControls1
            // 
            this.splitterMapControls1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterMapControls1.Location = new System.Drawing.Point(503, 3);
            this.splitterMapControls1.Name = "splitterMapControls1";
            this.splitterMapControls1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.splitterMapControls1.Size = new System.Drawing.Size(1, 104);
            this.splitterMapControls1.TabIndex = 4;
            this.splitterMapControls1.TabStop = false;
            // 
            // panelMapSizeButton
            // 
            this.panelMapSizeButton.Location = new System.Drawing.Point(510, 3);
            this.panelMapSizeButton.Name = "panelMapSizeButton";
            this.panelMapSizeButton.Size = new System.Drawing.Size(188, 94);
            this.panelMapSizeButton.TabIndex = 10;
            // 
            // splitterMapControls2
            // 
            this.splitterMapControls2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterMapControls2.Location = new System.Drawing.Point(704, 3);
            this.splitterMapControls2.Name = "splitterMapControls2";
            this.splitterMapControls2.Size = new System.Drawing.Size(1, 104);
            this.splitterMapControls2.TabIndex = 8;
            this.splitterMapControls2.TabStop = false;
            // 
            // panelMapSearch
            // 
            this.panelMapSearch.Controls.Add(this.textBoxMapSearch);
            this.panelMapSearch.Controls.Add(this.buttonMapCancelSearch);
            this.panelMapSearch.Controls.Add(this.buttonMapSearch);
            this.panelMapSearch.Location = new System.Drawing.Point(711, 3);
            this.panelMapSearch.Name = "panelMapSearch";
            this.panelMapSearch.Size = new System.Drawing.Size(253, 104);
            this.panelMapSearch.TabIndex = 7;
            // 
            // textBoxMapSearch
            // 
            this.textBoxMapSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxMapSearch.Name = "textBoxMapSearch";
            this.textBoxMapSearch.PlaceholderText = "Hledat";
            this.textBoxMapSearch.Size = new System.Drawing.Size(247, 27);
            this.textBoxMapSearch.TabIndex = 0;
            // 
            // buttonMapCancelSearch
            // 
            this.buttonMapCancelSearch.Enabled = false;
            this.buttonMapCancelSearch.FlatAppearance.BorderSize = 0;
            this.buttonMapCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMapCancelSearch.Image = global::SemestralProject.Resources.search_cancel;
            this.buttonMapCancelSearch.Location = new System.Drawing.Point(129, 36);
            this.buttonMapCancelSearch.Name = "buttonMapCancelSearch";
            this.buttonMapCancelSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonMapCancelSearch.TabIndex = 1;
            this.buttonMapCancelSearch.Text = "Zrušit hledání";
            this.buttonMapCancelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMapCancelSearch.UseVisualStyleBackColor = true;
            this.buttonMapCancelSearch.Click += new System.EventHandler(this.buttonMapCancelSearch_Click);
            // 
            // buttonMapSearch
            // 
            this.buttonMapSearch.FlatAppearance.BorderSize = 0;
            this.buttonMapSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMapSearch.Image = global::SemestralProject.Resources.search;
            this.buttonMapSearch.Location = new System.Drawing.Point(3, 36);
            this.buttonMapSearch.Name = "buttonMapSearch";
            this.buttonMapSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonMapSearch.TabIndex = 1;
            this.buttonMapSearch.Text = "Hledat";
            this.buttonMapSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMapSearch.UseVisualStyleBackColor = true;
            this.buttonMapSearch.Click += new System.EventHandler(this.buttonMapSearch_Click);
            // 
            // splitterMapControls3
            // 
            this.splitterMapControls3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterMapControls3.Location = new System.Drawing.Point(970, 3);
            this.splitterMapControls3.Name = "splitterMapControls3";
            this.splitterMapControls3.Size = new System.Drawing.Size(1, 104);
            this.splitterMapControls3.TabIndex = 9;
            this.splitterMapControls3.TabStop = false;
            // 
            // tabPageManufacturers
            // 
            this.tabPageManufacturers.Controls.Add(this.panelManufacturerContent);
            this.tabPageManufacturers.Controls.Add(this.panelManufacturerControls);
            this.tabPageManufacturers.Location = new System.Drawing.Point(4, 29);
            this.tabPageManufacturers.Name = "tabPageManufacturers";
            this.tabPageManufacturers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManufacturers.Size = new System.Drawing.Size(1340, 659);
            this.tabPageManufacturers.TabIndex = 2;
            this.tabPageManufacturers.Text = "VÝROBCI";
            this.tabPageManufacturers.UseVisualStyleBackColor = true;
            // 
            // panelManufacturerContent
            // 
            this.panelManufacturerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManufacturerContent.Location = new System.Drawing.Point(3, 110);
            this.panelManufacturerContent.Name = "panelManufacturerContent";
            this.panelManufacturerContent.Size = new System.Drawing.Size(1334, 546);
            this.panelManufacturerContent.TabIndex = 3;
            // 
            // panelManufacturerControls
            // 
            this.panelManufacturerControls.Controls.Add(this.buttonAddManufacturer);
            this.panelManufacturerControls.Controls.Add(this.buttonInfoManufacturer);
            this.panelManufacturerControls.Controls.Add(this.buttonEditManufacturer);
            this.panelManufacturerControls.Controls.Add(this.buttonRemoveManufacturer);
            this.panelManufacturerControls.Controls.Add(this.buttonDeleteManufacturer);
            this.panelManufacturerControls.Controls.Add(this.splitterManufacturerControls1);
            this.panelManufacturerControls.Controls.Add(this.panelManufacturerSizeControl);
            this.panelManufacturerControls.Controls.Add(this.splitterManufacturerControls2);
            this.panelManufacturerControls.Controls.Add(this.panelManufacturerSearch);
            this.panelManufacturerControls.Controls.Add(this.splitterManufacturerControls3);
            this.panelManufacturerControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManufacturerControls.Location = new System.Drawing.Point(3, 3);
            this.panelManufacturerControls.Name = "panelManufacturerControls";
            this.panelManufacturerControls.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelManufacturerControls.Size = new System.Drawing.Size(1334, 107);
            this.panelManufacturerControls.TabIndex = 2;
            // 
            // buttonAddManufacturer
            // 
            this.buttonAddManufacturer.FlatAppearance.BorderSize = 0;
            this.buttonAddManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddManufacturer.Image = global::SemestralProject.Resources.manufacturers_add;
            this.buttonAddManufacturer.Location = new System.Drawing.Point(3, 3);
            this.buttonAddManufacturer.Name = "buttonAddManufacturer";
            this.buttonAddManufacturer.Size = new System.Drawing.Size(94, 94);
            this.buttonAddManufacturer.TabIndex = 0;
            this.buttonAddManufacturer.Text = "Přidat výrobce";
            this.buttonAddManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddManufacturer.UseVisualStyleBackColor = true;
            this.buttonAddManufacturer.Click += new System.EventHandler(this.buttonAddManufacturer_Click);
            // 
            // buttonInfoManufacturer
            // 
            this.buttonInfoManufacturer.Enabled = false;
            this.buttonInfoManufacturer.FlatAppearance.BorderSize = 0;
            this.buttonInfoManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoManufacturer.Image = global::SemestralProject.Resources.manufacturers_info;
            this.buttonInfoManufacturer.Location = new System.Drawing.Point(103, 3);
            this.buttonInfoManufacturer.Name = "buttonInfoManufacturer";
            this.buttonInfoManufacturer.Size = new System.Drawing.Size(94, 94);
            this.buttonInfoManufacturer.TabIndex = 1;
            this.buttonInfoManufacturer.Text = "Informace o výrobci";
            this.buttonInfoManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInfoManufacturer.UseVisualStyleBackColor = true;
            this.buttonInfoManufacturer.Click += new System.EventHandler(this.buttonInfoManufacturer_Click);
            // 
            // buttonEditManufacturer
            // 
            this.buttonEditManufacturer.Enabled = false;
            this.buttonEditManufacturer.FlatAppearance.BorderSize = 0;
            this.buttonEditManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditManufacturer.Image = global::SemestralProject.Resources.manufacturers_edit;
            this.buttonEditManufacturer.Location = new System.Drawing.Point(203, 3);
            this.buttonEditManufacturer.Name = "buttonEditManufacturer";
            this.buttonEditManufacturer.Size = new System.Drawing.Size(94, 94);
            this.buttonEditManufacturer.TabIndex = 5;
            this.buttonEditManufacturer.Text = "Upravit výrobce";
            this.buttonEditManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditManufacturer.UseVisualStyleBackColor = true;
            this.buttonEditManufacturer.Click += new System.EventHandler(this.buttonEditManufacturer_Click);
            // 
            // buttonRemoveManufacturer
            // 
            this.buttonRemoveManufacturer.Enabled = false;
            this.buttonRemoveManufacturer.FlatAppearance.BorderSize = 0;
            this.buttonRemoveManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveManufacturer.Image = global::SemestralProject.Resources.manufacturers_remove;
            this.buttonRemoveManufacturer.Location = new System.Drawing.Point(303, 3);
            this.buttonRemoveManufacturer.Name = "buttonRemoveManufacturer";
            this.buttonRemoveManufacturer.Size = new System.Drawing.Size(94, 94);
            this.buttonRemoveManufacturer.TabIndex = 2;
            this.buttonRemoveManufacturer.Text = "Smazat výrobce";
            this.buttonRemoveManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRemoveManufacturer.UseVisualStyleBackColor = true;
            this.buttonRemoveManufacturer.Click += new System.EventHandler(this.buttonRemoveManufacturer_Click);
            // 
            // buttonDeleteManufacturer
            // 
            this.buttonDeleteManufacturer.FlatAppearance.BorderSize = 0;
            this.buttonDeleteManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteManufacturer.Image = global::SemestralProject.Resources.manufacturers_delete;
            this.buttonDeleteManufacturer.Location = new System.Drawing.Point(403, 3);
            this.buttonDeleteManufacturer.Name = "buttonDeleteManufacturer";
            this.buttonDeleteManufacturer.Size = new System.Drawing.Size(94, 94);
            this.buttonDeleteManufacturer.TabIndex = 3;
            this.buttonDeleteManufacturer.Text = "Smazat všechno";
            this.buttonDeleteManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteManufacturer.UseVisualStyleBackColor = true;
            this.buttonDeleteManufacturer.Click += new System.EventHandler(this.buttonDeleteManufacturer_Click);
            // 
            // splitterManufacturerControls1
            // 
            this.splitterManufacturerControls1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterManufacturerControls1.Location = new System.Drawing.Point(503, 3);
            this.splitterManufacturerControls1.Name = "splitterManufacturerControls1";
            this.splitterManufacturerControls1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.splitterManufacturerControls1.Size = new System.Drawing.Size(1, 104);
            this.splitterManufacturerControls1.TabIndex = 4;
            this.splitterManufacturerControls1.TabStop = false;
            // 
            // panelManufacturerSizeControl
            // 
            this.panelManufacturerSizeControl.Location = new System.Drawing.Point(510, 3);
            this.panelManufacturerSizeControl.Name = "panelManufacturerSizeControl";
            this.panelManufacturerSizeControl.Size = new System.Drawing.Size(188, 94);
            this.panelManufacturerSizeControl.TabIndex = 10;
            // 
            // splitterManufacturerControls2
            // 
            this.splitterManufacturerControls2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterManufacturerControls2.Location = new System.Drawing.Point(704, 3);
            this.splitterManufacturerControls2.Name = "splitterManufacturerControls2";
            this.splitterManufacturerControls2.Size = new System.Drawing.Size(1, 104);
            this.splitterManufacturerControls2.TabIndex = 8;
            this.splitterManufacturerControls2.TabStop = false;
            // 
            // panelManufacturerSearch
            // 
            this.panelManufacturerSearch.Controls.Add(this.textBoxManufacturerSearch);
            this.panelManufacturerSearch.Controls.Add(this.buttonManufacturerCancelSearch);
            this.panelManufacturerSearch.Controls.Add(this.buttonManufacturerSearch);
            this.panelManufacturerSearch.Location = new System.Drawing.Point(711, 3);
            this.panelManufacturerSearch.Name = "panelManufacturerSearch";
            this.panelManufacturerSearch.Size = new System.Drawing.Size(253, 104);
            this.panelManufacturerSearch.TabIndex = 7;
            // 
            // textBoxManufacturerSearch
            // 
            this.textBoxManufacturerSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxManufacturerSearch.Name = "textBoxManufacturerSearch";
            this.textBoxManufacturerSearch.PlaceholderText = "Hledat";
            this.textBoxManufacturerSearch.Size = new System.Drawing.Size(247, 27);
            this.textBoxManufacturerSearch.TabIndex = 0;
            // 
            // buttonManufacturerCancelSearch
            // 
            this.buttonManufacturerCancelSearch.Enabled = false;
            this.buttonManufacturerCancelSearch.FlatAppearance.BorderSize = 0;
            this.buttonManufacturerCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManufacturerCancelSearch.Image = global::SemestralProject.Resources.search_cancel;
            this.buttonManufacturerCancelSearch.Location = new System.Drawing.Point(129, 36);
            this.buttonManufacturerCancelSearch.Name = "buttonManufacturerCancelSearch";
            this.buttonManufacturerCancelSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonManufacturerCancelSearch.TabIndex = 1;
            this.buttonManufacturerCancelSearch.Text = "Zrušit hledání";
            this.buttonManufacturerCancelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonManufacturerCancelSearch.UseVisualStyleBackColor = true;
            this.buttonManufacturerCancelSearch.Click += new System.EventHandler(this.buttonManufacturerCancelSearch_Click);
            // 
            // buttonManufacturerSearch
            // 
            this.buttonManufacturerSearch.FlatAppearance.BorderSize = 0;
            this.buttonManufacturerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManufacturerSearch.Image = global::SemestralProject.Resources.search;
            this.buttonManufacturerSearch.Location = new System.Drawing.Point(3, 36);
            this.buttonManufacturerSearch.Name = "buttonManufacturerSearch";
            this.buttonManufacturerSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonManufacturerSearch.TabIndex = 1;
            this.buttonManufacturerSearch.Text = "Hledat";
            this.buttonManufacturerSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonManufacturerSearch.UseVisualStyleBackColor = true;
            this.buttonManufacturerSearch.Click += new System.EventHandler(this.buttonManufacturerSearch_Click);
            // 
            // splitterManufacturerControls3
            // 
            this.splitterManufacturerControls3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterManufacturerControls3.Location = new System.Drawing.Point(970, 3);
            this.splitterManufacturerControls3.Name = "splitterManufacturerControls3";
            this.splitterManufacturerControls3.Size = new System.Drawing.Size(1, 104);
            this.splitterManufacturerControls3.TabIndex = 9;
            this.splitterManufacturerControls3.TabStop = false;
            // 
            // tabPageVehicles
            // 
            this.tabPageVehicles.Controls.Add(this.panelVehicleContent);
            this.tabPageVehicles.Controls.Add(this.panelVehicleControls);
            this.tabPageVehicles.Location = new System.Drawing.Point(4, 29);
            this.tabPageVehicles.Name = "tabPageVehicles";
            this.tabPageVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVehicles.Size = new System.Drawing.Size(1340, 659);
            this.tabPageVehicles.TabIndex = 3;
            this.tabPageVehicles.Text = "VOZIDLA";
            this.tabPageVehicles.UseVisualStyleBackColor = true;
            // 
            // panelVehicleContent
            // 
            this.panelVehicleContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVehicleContent.Location = new System.Drawing.Point(3, 110);
            this.panelVehicleContent.Name = "panelVehicleContent";
            this.panelVehicleContent.Size = new System.Drawing.Size(1334, 546);
            this.panelVehicleContent.TabIndex = 4;
            // 
            // panelVehicleControls
            // 
            this.panelVehicleControls.Controls.Add(this.buttonAddVehicle);
            this.panelVehicleControls.Controls.Add(this.buttonInfoVehicle);
            this.panelVehicleControls.Controls.Add(this.buttonEditVehicle);
            this.panelVehicleControls.Controls.Add(this.buttonRemoveVehicle);
            this.panelVehicleControls.Controls.Add(this.buttonDeleteVehicle);
            this.panelVehicleControls.Controls.Add(this.splitterVehicleControls1);
            this.panelVehicleControls.Controls.Add(this.panelVehicleSizeButton);
            this.panelVehicleControls.Controls.Add(this.splitterVehicleControls2);
            this.panelVehicleControls.Controls.Add(this.panelVehicleSearch);
            this.panelVehicleControls.Controls.Add(this.splitterVehicleControls3);
            this.panelVehicleControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVehicleControls.Location = new System.Drawing.Point(3, 3);
            this.panelVehicleControls.Name = "panelVehicleControls";
            this.panelVehicleControls.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelVehicleControls.Size = new System.Drawing.Size(1334, 107);
            this.panelVehicleControls.TabIndex = 1;
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.FlatAppearance.BorderSize = 0;
            this.buttonAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddVehicle.Image = global::SemestralProject.Resources.vehicle_add;
            this.buttonAddVehicle.Location = new System.Drawing.Point(3, 3);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(94, 94);
            this.buttonAddVehicle.TabIndex = 0;
            this.buttonAddVehicle.Text = "Přidat nové vozidlo";
            this.buttonAddVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // buttonInfoVehicle
            // 
            this.buttonInfoVehicle.Enabled = false;
            this.buttonInfoVehicle.FlatAppearance.BorderSize = 0;
            this.buttonInfoVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoVehicle.Image = global::SemestralProject.Resources.vehicle_info;
            this.buttonInfoVehicle.Location = new System.Drawing.Point(103, 3);
            this.buttonInfoVehicle.Name = "buttonInfoVehicle";
            this.buttonInfoVehicle.Size = new System.Drawing.Size(94, 94);
            this.buttonInfoVehicle.TabIndex = 1;
            this.buttonInfoVehicle.Text = "Informace o vozidlu";
            this.buttonInfoVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInfoVehicle.UseVisualStyleBackColor = true;
            this.buttonInfoVehicle.Click += new System.EventHandler(this.buttonInfoVehicle_Click);
            // 
            // buttonEditVehicle
            // 
            this.buttonEditVehicle.Enabled = false;
            this.buttonEditVehicle.FlatAppearance.BorderSize = 0;
            this.buttonEditVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditVehicle.Image = global::SemestralProject.Resources.vehicle_edit;
            this.buttonEditVehicle.Location = new System.Drawing.Point(203, 3);
            this.buttonEditVehicle.Name = "buttonEditVehicle";
            this.buttonEditVehicle.Size = new System.Drawing.Size(94, 94);
            this.buttonEditVehicle.TabIndex = 5;
            this.buttonEditVehicle.Text = "Upravit vozidlo";
            this.buttonEditVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditVehicle.UseVisualStyleBackColor = true;
            this.buttonEditVehicle.Click += new System.EventHandler(this.buttonEditVehicle_Click);
            // 
            // buttonRemoveVehicle
            // 
            this.buttonRemoveVehicle.Enabled = false;
            this.buttonRemoveVehicle.FlatAppearance.BorderSize = 0;
            this.buttonRemoveVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveVehicle.Image = global::SemestralProject.Resources.vehicle_remove;
            this.buttonRemoveVehicle.Location = new System.Drawing.Point(303, 3);
            this.buttonRemoveVehicle.Name = "buttonRemoveVehicle";
            this.buttonRemoveVehicle.Size = new System.Drawing.Size(94, 94);
            this.buttonRemoveVehicle.TabIndex = 2;
            this.buttonRemoveVehicle.Text = "Smazat vozidlo";
            this.buttonRemoveVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRemoveVehicle.UseVisualStyleBackColor = true;
            this.buttonRemoveVehicle.Click += new System.EventHandler(this.buttonRemoveVehicle_Click);
            // 
            // buttonDeleteVehicle
            // 
            this.buttonDeleteVehicle.FlatAppearance.BorderSize = 0;
            this.buttonDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteVehicle.Image = global::SemestralProject.Resources.vehicle_delete;
            this.buttonDeleteVehicle.Location = new System.Drawing.Point(403, 3);
            this.buttonDeleteVehicle.Name = "buttonDeleteVehicle";
            this.buttonDeleteVehicle.Size = new System.Drawing.Size(94, 94);
            this.buttonDeleteVehicle.TabIndex = 3;
            this.buttonDeleteVehicle.Text = "Smazat všechno";
            this.buttonDeleteVehicle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteVehicle.UseVisualStyleBackColor = true;
            this.buttonDeleteVehicle.Click += new System.EventHandler(this.buttonDeleteVehicle_Click);
            // 
            // splitterVehicleControls1
            // 
            this.splitterVehicleControls1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterVehicleControls1.Location = new System.Drawing.Point(503, 3);
            this.splitterVehicleControls1.Name = "splitterVehicleControls1";
            this.splitterVehicleControls1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.splitterVehicleControls1.Size = new System.Drawing.Size(1, 104);
            this.splitterVehicleControls1.TabIndex = 4;
            this.splitterVehicleControls1.TabStop = false;
            // 
            // panelVehicleSizeButton
            // 
            this.panelVehicleSizeButton.Location = new System.Drawing.Point(510, 3);
            this.panelVehicleSizeButton.Name = "panelVehicleSizeButton";
            this.panelVehicleSizeButton.Size = new System.Drawing.Size(188, 94);
            this.panelVehicleSizeButton.TabIndex = 10;
            // 
            // splitterVehicleControls2
            // 
            this.splitterVehicleControls2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterVehicleControls2.Location = new System.Drawing.Point(704, 3);
            this.splitterVehicleControls2.Name = "splitterVehicleControls2";
            this.splitterVehicleControls2.Size = new System.Drawing.Size(1, 104);
            this.splitterVehicleControls2.TabIndex = 8;
            this.splitterVehicleControls2.TabStop = false;
            // 
            // panelVehicleSearch
            // 
            this.panelVehicleSearch.Controls.Add(this.textBoxVehicleSearch);
            this.panelVehicleSearch.Controls.Add(this.buttonVehicleCancelSearch);
            this.panelVehicleSearch.Controls.Add(this.buttonVehicleSearch);
            this.panelVehicleSearch.Location = new System.Drawing.Point(711, 3);
            this.panelVehicleSearch.Name = "panelVehicleSearch";
            this.panelVehicleSearch.Size = new System.Drawing.Size(253, 104);
            this.panelVehicleSearch.TabIndex = 7;
            // 
            // textBoxVehicleSearch
            // 
            this.textBoxVehicleSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxVehicleSearch.Name = "textBoxVehicleSearch";
            this.textBoxVehicleSearch.PlaceholderText = "Hledat";
            this.textBoxVehicleSearch.Size = new System.Drawing.Size(247, 27);
            this.textBoxVehicleSearch.TabIndex = 0;
            // 
            // buttonVehicleCancelSearch
            // 
            this.buttonVehicleCancelSearch.Enabled = false;
            this.buttonVehicleCancelSearch.FlatAppearance.BorderSize = 0;
            this.buttonVehicleCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleCancelSearch.Image = global::SemestralProject.Resources.search_cancel;
            this.buttonVehicleCancelSearch.Location = new System.Drawing.Point(129, 36);
            this.buttonVehicleCancelSearch.Name = "buttonVehicleCancelSearch";
            this.buttonVehicleCancelSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonVehicleCancelSearch.TabIndex = 1;
            this.buttonVehicleCancelSearch.Text = "Zrušit hledání";
            this.buttonVehicleCancelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonVehicleCancelSearch.UseVisualStyleBackColor = true;
            this.buttonVehicleCancelSearch.Click += new System.EventHandler(this.buttonVehicleCancelSearch_Click);
            // 
            // buttonVehicleSearch
            // 
            this.buttonVehicleSearch.FlatAppearance.BorderSize = 0;
            this.buttonVehicleSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVehicleSearch.Image = global::SemestralProject.Resources.search;
            this.buttonVehicleSearch.Location = new System.Drawing.Point(3, 36);
            this.buttonVehicleSearch.Name = "buttonVehicleSearch";
            this.buttonVehicleSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonVehicleSearch.TabIndex = 1;
            this.buttonVehicleSearch.Text = "Hledat";
            this.buttonVehicleSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonVehicleSearch.UseVisualStyleBackColor = true;
            this.buttonVehicleSearch.Click += new System.EventHandler(this.buttonVehicleSearch_Click);
            // 
            // splitterVehicleControls3
            // 
            this.splitterVehicleControls3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterVehicleControls3.Location = new System.Drawing.Point(970, 3);
            this.splitterVehicleControls3.Name = "splitterVehicleControls3";
            this.splitterVehicleControls3.Size = new System.Drawing.Size(1, 104);
            this.splitterVehicleControls3.TabIndex = 9;
            this.splitterVehicleControls3.TabStop = false;
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.panelFileContent);
            this.tabPageFiles.Controls.Add(this.panelFileControls);
            this.tabPageFiles.Location = new System.Drawing.Point(4, 29);
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiles.Size = new System.Drawing.Size(1340, 659);
            this.tabPageFiles.TabIndex = 4;
            this.tabPageFiles.Text = "SOUBORY";
            this.tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // panelFileContent
            // 
            this.panelFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFileContent.Location = new System.Drawing.Point(3, 110);
            this.panelFileContent.Name = "panelFileContent";
            this.panelFileContent.Size = new System.Drawing.Size(1334, 546);
            this.panelFileContent.TabIndex = 5;
            // 
            // panelFileControls
            // 
            this.panelFileControls.Controls.Add(this.buttonAddFile);
            this.panelFileControls.Controls.Add(this.buttonInfoFile);
            this.panelFileControls.Controls.Add(this.buttonEditFile);
            this.panelFileControls.Controls.Add(this.buttonRemoveFile);
            this.panelFileControls.Controls.Add(this.buttonDeleteFile);
            this.panelFileControls.Controls.Add(this.splitterFileControls1);
            this.panelFileControls.Controls.Add(this.panelFileSizeControl);
            this.panelFileControls.Controls.Add(this.splitterFileControls2);
            this.panelFileControls.Controls.Add(this.panelFileSearch);
            this.panelFileControls.Controls.Add(this.splitterFileControls3);
            this.panelFileControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFileControls.Location = new System.Drawing.Point(3, 3);
            this.panelFileControls.Name = "panelFileControls";
            this.panelFileControls.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelFileControls.Size = new System.Drawing.Size(1334, 107);
            this.panelFileControls.TabIndex = 2;
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.FlatAppearance.BorderSize = 0;
            this.buttonAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFile.Image = global::SemestralProject.Resources.file_add;
            this.buttonAddFile.Location = new System.Drawing.Point(3, 3);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(94, 94);
            this.buttonAddFile.TabIndex = 0;
            this.buttonAddFile.Text = "Přidat nový soubor";
            this.buttonAddFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // buttonInfoFile
            // 
            this.buttonInfoFile.Enabled = false;
            this.buttonInfoFile.FlatAppearance.BorderSize = 0;
            this.buttonInfoFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfoFile.Image = global::SemestralProject.Resources.file_info;
            this.buttonInfoFile.Location = new System.Drawing.Point(103, 3);
            this.buttonInfoFile.Name = "buttonInfoFile";
            this.buttonInfoFile.Size = new System.Drawing.Size(94, 94);
            this.buttonInfoFile.TabIndex = 1;
            this.buttonInfoFile.Text = "Informace o souboru";
            this.buttonInfoFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonInfoFile.UseVisualStyleBackColor = true;
            this.buttonInfoFile.Click += new System.EventHandler(this.buttonInfoFile_Click);
            // 
            // buttonEditFile
            // 
            this.buttonEditFile.Enabled = false;
            this.buttonEditFile.FlatAppearance.BorderSize = 0;
            this.buttonEditFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditFile.Image = global::SemestralProject.Resources.file_edit;
            this.buttonEditFile.Location = new System.Drawing.Point(203, 3);
            this.buttonEditFile.Name = "buttonEditFile";
            this.buttonEditFile.Size = new System.Drawing.Size(94, 94);
            this.buttonEditFile.TabIndex = 5;
            this.buttonEditFile.Text = "Upravit soubor";
            this.buttonEditFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEditFile.UseVisualStyleBackColor = true;
            this.buttonEditFile.Click += new System.EventHandler(this.buttonEditFile_Click);
            // 
            // buttonRemoveFile
            // 
            this.buttonRemoveFile.Enabled = false;
            this.buttonRemoveFile.FlatAppearance.BorderSize = 0;
            this.buttonRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveFile.Image = global::SemestralProject.Resources.file_remove;
            this.buttonRemoveFile.Location = new System.Drawing.Point(303, 3);
            this.buttonRemoveFile.Name = "buttonRemoveFile";
            this.buttonRemoveFile.Size = new System.Drawing.Size(94, 94);
            this.buttonRemoveFile.TabIndex = 2;
            this.buttonRemoveFile.Text = "Smazat soubor";
            this.buttonRemoveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRemoveFile.UseVisualStyleBackColor = true;
            this.buttonRemoveFile.Click += new System.EventHandler(this.buttonRemoveFile_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.FlatAppearance.BorderSize = 0;
            this.buttonDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteFile.Image = global::SemestralProject.Resources.file_delete;
            this.buttonDeleteFile.Location = new System.Drawing.Point(403, 3);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(94, 94);
            this.buttonDeleteFile.TabIndex = 3;
            this.buttonDeleteFile.Text = "Smazat všechno";
            this.buttonDeleteFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // splitterFileControls1
            // 
            this.splitterFileControls1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterFileControls1.Location = new System.Drawing.Point(503, 3);
            this.splitterFileControls1.Name = "splitterFileControls1";
            this.splitterFileControls1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.splitterFileControls1.Size = new System.Drawing.Size(1, 104);
            this.splitterFileControls1.TabIndex = 4;
            this.splitterFileControls1.TabStop = false;
            // 
            // panelFileSizeControl
            // 
            this.panelFileSizeControl.Location = new System.Drawing.Point(510, 3);
            this.panelFileSizeControl.Name = "panelFileSizeControl";
            this.panelFileSizeControl.Size = new System.Drawing.Size(188, 94);
            this.panelFileSizeControl.TabIndex = 10;
            // 
            // splitterFileControls2
            // 
            this.splitterFileControls2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterFileControls2.Location = new System.Drawing.Point(704, 3);
            this.splitterFileControls2.Name = "splitterFileControls2";
            this.splitterFileControls2.Size = new System.Drawing.Size(1, 104);
            this.splitterFileControls2.TabIndex = 8;
            this.splitterFileControls2.TabStop = false;
            // 
            // panelFileSearch
            // 
            this.panelFileSearch.Controls.Add(this.textBoxFileSearch);
            this.panelFileSearch.Controls.Add(this.buttonFileCancelSearch);
            this.panelFileSearch.Controls.Add(this.buttonFileSearch);
            this.panelFileSearch.Location = new System.Drawing.Point(711, 3);
            this.panelFileSearch.Name = "panelFileSearch";
            this.panelFileSearch.Size = new System.Drawing.Size(253, 104);
            this.panelFileSearch.TabIndex = 7;
            // 
            // textBoxFileSearch
            // 
            this.textBoxFileSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxFileSearch.Name = "textBoxFileSearch";
            this.textBoxFileSearch.PlaceholderText = "Hledat";
            this.textBoxFileSearch.Size = new System.Drawing.Size(247, 27);
            this.textBoxFileSearch.TabIndex = 0;
            // 
            // buttonFileCancelSearch
            // 
            this.buttonFileCancelSearch.Enabled = false;
            this.buttonFileCancelSearch.FlatAppearance.BorderSize = 0;
            this.buttonFileCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileCancelSearch.Image = global::SemestralProject.Resources.search_cancel;
            this.buttonFileCancelSearch.Location = new System.Drawing.Point(129, 36);
            this.buttonFileCancelSearch.Name = "buttonFileCancelSearch";
            this.buttonFileCancelSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonFileCancelSearch.TabIndex = 1;
            this.buttonFileCancelSearch.Text = "Zrušit hledání";
            this.buttonFileCancelSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFileCancelSearch.UseVisualStyleBackColor = true;
            this.buttonFileCancelSearch.Click += new System.EventHandler(this.buttonFileCancelSearch_Click);
            // 
            // buttonFileSearch
            // 
            this.buttonFileSearch.FlatAppearance.BorderSize = 0;
            this.buttonFileSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileSearch.Image = global::SemestralProject.Resources.search;
            this.buttonFileSearch.Location = new System.Drawing.Point(3, 36);
            this.buttonFileSearch.Name = "buttonFileSearch";
            this.buttonFileSearch.Size = new System.Drawing.Size(120, 58);
            this.buttonFileSearch.TabIndex = 1;
            this.buttonFileSearch.Text = "Hledat";
            this.buttonFileSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFileSearch.UseVisualStyleBackColor = true;
            this.buttonFileSearch.Click += new System.EventHandler(this.buttonFileSearch_Click);
            // 
            // splitterFileControls3
            // 
            this.splitterFileControls3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitterFileControls3.Location = new System.Drawing.Point(970, 3);
            this.splitterFileControls3.Name = "splitterFileControls3";
            this.splitterFileControls3.Size = new System.Drawing.Size(1, 104);
            this.splitterFileControls3.TabIndex = 9;
            this.splitterFileControls3.TabStop = false;
            // 
            // tabPageActions
            // 
            this.tabPageActions.Controls.Add(this.panelActionsContent);
            this.tabPageActions.Location = new System.Drawing.Point(4, 29);
            this.tabPageActions.Name = "tabPageActions";
            this.tabPageActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActions.Size = new System.Drawing.Size(1340, 659);
            this.tabPageActions.TabIndex = 5;
            this.tabPageActions.Text = "AKCE";
            this.tabPageActions.UseVisualStyleBackColor = true;
            // 
            // panelActionsContent
            // 
            this.panelActionsContent.AutoScroll = true;
            this.panelActionsContent.ColumnCount = 1;
            this.panelActionsContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelActionsContent.Controls.Add(this.panelActionsHeader, 0, 0);
            this.panelActionsContent.Controls.Add(this.splitterActionsHeader, 0, 1);
            this.panelActionsContent.Controls.Add(this.groupBoxActionsDataTransfer, 0, 3);
            this.panelActionsContent.Controls.Add(this.groupBoxActionCopy, 0, 2);
            this.panelActionsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActionsContent.Location = new System.Drawing.Point(3, 3);
            this.panelActionsContent.Name = "panelActionsContent";
            this.panelActionsContent.RowCount = 5;
            this.panelActionsContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.panelActionsContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.panelActionsContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.panelActionsContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.panelActionsContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.panelActionsContent.Size = new System.Drawing.Size(1334, 653);
            this.panelActionsContent.TabIndex = 0;
            // 
            // panelActionsHeader
            // 
            this.panelActionsHeader.Controls.Add(this.labelActionsHeader);
            this.panelActionsHeader.Controls.Add(this.pictureBoxActionsHeader);
            this.panelActionsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActionsHeader.Location = new System.Drawing.Point(3, 3);
            this.panelActionsHeader.Name = "panelActionsHeader";
            this.panelActionsHeader.Size = new System.Drawing.Size(1328, 69);
            this.panelActionsHeader.TabIndex = 0;
            // 
            // labelActionsHeader
            // 
            this.labelActionsHeader.AutoSize = true;
            this.labelActionsHeader.Font = new System.Drawing.Font("Segoe UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActionsHeader.Location = new System.Drawing.Point(73, 29);
            this.labelActionsHeader.Name = "labelActionsHeader";
            this.labelActionsHeader.Size = new System.Drawing.Size(74, 38);
            this.labelActionsHeader.TabIndex = 1;
            this.labelActionsHeader.Text = "Akce";
            // 
            // pictureBoxActionsHeader
            // 
            this.pictureBoxActionsHeader.Image = global::SemestralProject.Resources.actions;
            this.pictureBoxActionsHeader.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxActionsHeader.Name = "pictureBoxActionsHeader";
            this.pictureBoxActionsHeader.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxActionsHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxActionsHeader.TabIndex = 0;
            this.pictureBoxActionsHeader.TabStop = false;
            // 
            // splitterActionsHeader
            // 
            this.splitterActionsHeader.BackColor = System.Drawing.Color.Black;
            this.splitterActionsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterActionsHeader.Location = new System.Drawing.Point(3, 78);
            this.splitterActionsHeader.Name = "splitterActionsHeader";
            this.splitterActionsHeader.Size = new System.Drawing.Size(1328, 1);
            this.splitterActionsHeader.TabIndex = 1;
            this.splitterActionsHeader.TabStop = false;
            // 
            // groupBoxActionsDataTransfer
            // 
            this.groupBoxActionsDataTransfer.Controls.Add(this.tableLayoutPanelActionsDataTransfer);
            this.groupBoxActionsDataTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActionsDataTransfer.Location = new System.Drawing.Point(3, 271);
            this.groupBoxActionsDataTransfer.Name = "groupBoxActionsDataTransfer";
            this.groupBoxActionsDataTransfer.Size = new System.Drawing.Size(1328, 176);
            this.groupBoxActionsDataTransfer.TabIndex = 2;
            this.groupBoxActionsDataTransfer.TabStop = false;
            this.groupBoxActionsDataTransfer.Text = "Přesun dat";
            // 
            // tableLayoutPanelActionsDataTransfer
            // 
            this.tableLayoutPanelActionsDataTransfer.ColumnCount = 2;
            this.tableLayoutPanelActionsDataTransfer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.606657F));
            this.tableLayoutPanelActionsDataTransfer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.39334F));
            this.tableLayoutPanelActionsDataTransfer.Controls.Add(this.buttonActionsExport, 0, 0);
            this.tableLayoutPanelActionsDataTransfer.Controls.Add(this.buttonActionsImport, 0, 1);
            this.tableLayoutPanelActionsDataTransfer.Controls.Add(this.flowLayoutPanelActionsExport, 1, 0);
            this.tableLayoutPanelActionsDataTransfer.Controls.Add(this.flowLayoutPanelActionsImport, 1, 1);
            this.tableLayoutPanelActionsDataTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelActionsDataTransfer.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelActionsDataTransfer.Name = "tableLayoutPanelActionsDataTransfer";
            this.tableLayoutPanelActionsDataTransfer.RowCount = 2;
            this.tableLayoutPanelActionsDataTransfer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActionsDataTransfer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActionsDataTransfer.Size = new System.Drawing.Size(1322, 150);
            this.tableLayoutPanelActionsDataTransfer.TabIndex = 0;
            // 
            // buttonActionsExport
            // 
            this.buttonActionsExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonActionsExport.Image = global::SemestralProject.Resources.export;
            this.buttonActionsExport.Location = new System.Drawing.Point(3, 3);
            this.buttonActionsExport.Name = "buttonActionsExport";
            this.buttonActionsExport.Size = new System.Drawing.Size(121, 69);
            this.buttonActionsExport.TabIndex = 0;
            this.buttonActionsExport.UseVisualStyleBackColor = true;
            this.buttonActionsExport.Click += new System.EventHandler(this.buttonActionsExport_Click);
            // 
            // buttonActionsImport
            // 
            this.buttonActionsImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonActionsImport.Image = global::SemestralProject.Resources.import;
            this.buttonActionsImport.Location = new System.Drawing.Point(3, 78);
            this.buttonActionsImport.Name = "buttonActionsImport";
            this.buttonActionsImport.Size = new System.Drawing.Size(121, 69);
            this.buttonActionsImport.TabIndex = 1;
            this.buttonActionsImport.UseVisualStyleBackColor = true;
            this.buttonActionsImport.Click += new System.EventHandler(this.buttonActionsImport_Click);
            // 
            // flowLayoutPanelActionsExport
            // 
            this.flowLayoutPanelActionsExport.Controls.Add(this.labelActionsExport1);
            this.flowLayoutPanelActionsExport.Controls.Add(this.labelActionsExport2);
            this.flowLayoutPanelActionsExport.Controls.Add(this.labelActionsExport3);
            this.flowLayoutPanelActionsExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelActionsExport.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelActionsExport.Location = new System.Drawing.Point(130, 3);
            this.flowLayoutPanelActionsExport.Name = "flowLayoutPanelActionsExport";
            this.flowLayoutPanelActionsExport.Size = new System.Drawing.Size(1189, 69);
            this.flowLayoutPanelActionsExport.TabIndex = 2;
            // 
            // labelActionsExport1
            // 
            this.labelActionsExport1.AutoSize = true;
            this.labelActionsExport1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelActionsExport1.Location = new System.Drawing.Point(3, 0);
            this.labelActionsExport1.Name = "labelActionsExport1";
            this.labelActionsExport1.Size = new System.Drawing.Size(82, 20);
            this.labelActionsExport1.TabIndex = 0;
            this.labelActionsExport1.Text = "Export dat";
            // 
            // labelActionsExport2
            // 
            this.labelActionsExport2.AutoSize = true;
            this.labelActionsExport2.Location = new System.Drawing.Point(3, 20);
            this.labelActionsExport2.Name = "labelActionsExport2";
            this.labelActionsExport2.Size = new System.Drawing.Size(362, 20);
            this.labelActionsExport2.TabIndex = 1;
            this.labelActionsExport2.Text = " • umožní exportovat všechna uložená data v systému";
            // 
            // labelActionsExport3
            // 
            this.labelActionsExport3.AutoSize = true;
            this.labelActionsExport3.Location = new System.Drawing.Point(3, 40);
            this.labelActionsExport3.Name = "labelActionsExport3";
            this.labelActionsExport3.Size = new System.Drawing.Size(397, 20);
            this.labelActionsExport3.TabIndex = 2;
            this.labelActionsExport3.Text = " • používá se hlavně při nutnosti přesunu dat na jiný systém";
            // 
            // flowLayoutPanelActionsImport
            // 
            this.flowLayoutPanelActionsImport.Controls.Add(this.labelActionsImport1);
            this.flowLayoutPanelActionsImport.Controls.Add(this.labelActionsImport2);
            this.flowLayoutPanelActionsImport.Controls.Add(this.labelActionsImport3);
            this.flowLayoutPanelActionsImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelActionsImport.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelActionsImport.Location = new System.Drawing.Point(130, 78);
            this.flowLayoutPanelActionsImport.Name = "flowLayoutPanelActionsImport";
            this.flowLayoutPanelActionsImport.Size = new System.Drawing.Size(1189, 69);
            this.flowLayoutPanelActionsImport.TabIndex = 3;
            // 
            // labelActionsImport1
            // 
            this.labelActionsImport1.AutoSize = true;
            this.labelActionsImport1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelActionsImport1.Location = new System.Drawing.Point(3, 0);
            this.labelActionsImport1.Name = "labelActionsImport1";
            this.labelActionsImport1.Size = new System.Drawing.Size(85, 20);
            this.labelActionsImport1.TabIndex = 0;
            this.labelActionsImport1.Text = "Import dat";
            // 
            // labelActionsImport2
            // 
            this.labelActionsImport2.AutoSize = true;
            this.labelActionsImport2.Location = new System.Drawing.Point(3, 20);
            this.labelActionsImport2.Name = "labelActionsImport2";
            this.labelActionsImport2.Size = new System.Drawing.Size(225, 20);
            this.labelActionsImport2.TabIndex = 1;
            this.labelActionsImport2.Text = " • umožní načíst data ze souboru";
            // 
            // labelActionsImport3
            // 
            this.labelActionsImport3.AutoSize = true;
            this.labelActionsImport3.Location = new System.Drawing.Point(3, 40);
            this.labelActionsImport3.Name = "labelActionsImport3";
            this.labelActionsImport3.Size = new System.Drawing.Size(428, 20);
            this.labelActionsImport3.TabIndex = 2;
            this.labelActionsImport3.Text = " • tato akce nebude mít vliv na data aktuálně uložená v systému";
            // 
            // groupBoxActionCopy
            // 
            this.groupBoxActionCopy.Controls.Add(this.tableLayoutPanelActionCopyContent);
            this.groupBoxActionCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActionCopy.Location = new System.Drawing.Point(3, 87);
            this.groupBoxActionCopy.Name = "groupBoxActionCopy";
            this.groupBoxActionCopy.Size = new System.Drawing.Size(1328, 178);
            this.groupBoxActionCopy.TabIndex = 3;
            this.groupBoxActionCopy.TabStop = false;
            this.groupBoxActionCopy.Text = "Kopírování souborů";
            // 
            // tableLayoutPanelActionCopyContent
            // 
            this.tableLayoutPanelActionCopyContent.ColumnCount = 2;
            this.tableLayoutPanelActionCopyContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.61F));
            this.tableLayoutPanelActionCopyContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.39F));
            this.tableLayoutPanelActionCopyContent.Controls.Add(this.flowLayoutPanelActionCopyReplace, 1, 1);
            this.tableLayoutPanelActionCopyContent.Controls.Add(this.flowLayoutPanelActionCopy, 1, 0);
            this.tableLayoutPanelActionCopyContent.Controls.Add(this.buttonActionCopy, 0, 0);
            this.tableLayoutPanelActionCopyContent.Controls.Add(this.buttonActionCopyReplace, 0, 1);
            this.tableLayoutPanelActionCopyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelActionCopyContent.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelActionCopyContent.Name = "tableLayoutPanelActionCopyContent";
            this.tableLayoutPanelActionCopyContent.RowCount = 2;
            this.tableLayoutPanelActionCopyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActionCopyContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelActionCopyContent.Size = new System.Drawing.Size(1322, 152);
            this.tableLayoutPanelActionCopyContent.TabIndex = 0;
            // 
            // buttonActionCopy
            // 
            this.buttonActionCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonActionCopy.Image = global::SemestralProject.Resources.copy;
            this.buttonActionCopy.Location = new System.Drawing.Point(3, 3);
            this.buttonActionCopy.Name = "buttonActionCopy";
            this.buttonActionCopy.Size = new System.Drawing.Size(121, 70);
            this.buttonActionCopy.TabIndex = 0;
            this.buttonActionCopy.UseVisualStyleBackColor = true;
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.FileName = "EXPORT.EXDAT";
            this.saveFileDialogExport.Filter = "Exportovaný soubor dat|*.EXDAT";
            // 
            // openFileDialogImport
            // 
            this.openFileDialogImport.FileName = "EXPORT.EXDAT";
            this.openFileDialogImport.Filter = "Exportovaný soubor dat|*.EXDAT";
            // 
            // buttonActionCopyReplace
            // 
            this.buttonActionCopyReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonActionCopyReplace.Image = global::SemestralProject.Resources.copyr;
            this.buttonActionCopyReplace.Location = new System.Drawing.Point(3, 79);
            this.buttonActionCopyReplace.Name = "buttonActionCopyReplace";
            this.buttonActionCopyReplace.Size = new System.Drawing.Size(121, 70);
            this.buttonActionCopyReplace.TabIndex = 1;
            this.buttonActionCopyReplace.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelActionCopy
            // 
            this.flowLayoutPanelActionCopy.Controls.Add(this.labelActionCopy1);
            this.flowLayoutPanelActionCopy.Controls.Add(this.labelActionCopy2);
            this.flowLayoutPanelActionCopy.Controls.Add(this.labelActionCopy3);
            this.flowLayoutPanelActionCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelActionCopy.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelActionCopy.Location = new System.Drawing.Point(130, 3);
            this.flowLayoutPanelActionCopy.Name = "flowLayoutPanelActionCopy";
            this.flowLayoutPanelActionCopy.Size = new System.Drawing.Size(1189, 70);
            this.flowLayoutPanelActionCopy.TabIndex = 3;
            // 
            // labelActionCopy1
            // 
            this.labelActionCopy1.AutoSize = true;
            this.labelActionCopy1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelActionCopy1.Location = new System.Drawing.Point(3, 0);
            this.labelActionCopy1.Name = "labelActionCopy1";
            this.labelActionCopy1.Size = new System.Drawing.Size(140, 20);
            this.labelActionCopy1.TabIndex = 0;
            this.labelActionCopy1.Text = "Kopírovat soubory";
            // 
            // labelActionCopy2
            // 
            this.labelActionCopy2.AutoSize = true;
            this.labelActionCopy2.Location = new System.Drawing.Point(3, 20);
            this.labelActionCopy2.Name = "labelActionCopy2";
            this.labelActionCopy2.Size = new System.Drawing.Size(449, 20);
            this.labelActionCopy2.TabIndex = 1;
            this.labelActionCopy2.Text = " • provede kopírování všech datových souborů do adresářů vozidel";
            // 
            // labelActionCopy3
            // 
            this.labelActionCopy3.AutoSize = true;
            this.labelActionCopy3.Location = new System.Drawing.Point(3, 40);
            this.labelActionCopy3.Name = "labelActionCopy3";
            this.labelActionCopy3.Size = new System.Drawing.Size(469, 20);
            this.labelActionCopy3.TabIndex = 2;
            this.labelActionCopy3.Text = " • pokud v adresáři vozidla již datovy soubor existuje, bude přeskočen";
            // 
            // flowLayoutPanelActionCopyReplace
            // 
            this.flowLayoutPanelActionCopyReplace.Controls.Add(this.labelActionCopyReplace1);
            this.flowLayoutPanelActionCopyReplace.Controls.Add(this.labelActionCopyReplace2);
            this.flowLayoutPanelActionCopyReplace.Controls.Add(this.labelActionCopyReplace3);
            this.flowLayoutPanelActionCopyReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelActionCopyReplace.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelActionCopyReplace.Location = new System.Drawing.Point(130, 79);
            this.flowLayoutPanelActionCopyReplace.Name = "flowLayoutPanelActionCopyReplace";
            this.flowLayoutPanelActionCopyReplace.Size = new System.Drawing.Size(1189, 70);
            this.flowLayoutPanelActionCopyReplace.TabIndex = 4;
            // 
            // labelActionCopyReplace1
            // 
            this.labelActionCopyReplace1.AutoSize = true;
            this.labelActionCopyReplace1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelActionCopyReplace1.Location = new System.Drawing.Point(3, 0);
            this.labelActionCopyReplace1.Name = "labelActionCopyReplace1";
            this.labelActionCopyReplace1.Size = new System.Drawing.Size(215, 20);
            this.labelActionCopyReplace1.TabIndex = 0;
            this.labelActionCopyReplace1.Text = "Kopírovat a nahradit soubory";
            // 
            // labelActionCopyReplace2
            // 
            this.labelActionCopyReplace2.AutoSize = true;
            this.labelActionCopyReplace2.Location = new System.Drawing.Point(3, 20);
            this.labelActionCopyReplace2.Name = "labelActionCopyReplace2";
            this.labelActionCopyReplace2.Size = new System.Drawing.Size(449, 20);
            this.labelActionCopyReplace2.TabIndex = 1;
            this.labelActionCopyReplace2.Text = " • provede kopírování všech datových souborů do adresářů vozidel";
            // 
            // labelActionCopyReplace3
            // 
            this.labelActionCopyReplace3.AutoSize = true;
            this.labelActionCopyReplace3.Location = new System.Drawing.Point(3, 40);
            this.labelActionCopyReplace3.Name = "labelActionCopyReplace3";
            this.labelActionCopyReplace3.Size = new System.Drawing.Size(462, 20);
            this.labelActionCopyReplace3.TabIndex = 2;
            this.labelActionCopyReplace3.Text = " • pokud v adresáři vozidla již datový soubor existuje, bude nahrazen";
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
            this.panelMapsControls.ResumeLayout(false);
            this.panelMapSearch.ResumeLayout(false);
            this.panelMapSearch.PerformLayout();
            this.tabPageManufacturers.ResumeLayout(false);
            this.panelManufacturerControls.ResumeLayout(false);
            this.panelManufacturerSearch.ResumeLayout(false);
            this.panelManufacturerSearch.PerformLayout();
            this.tabPageVehicles.ResumeLayout(false);
            this.panelVehicleControls.ResumeLayout(false);
            this.panelVehicleSearch.ResumeLayout(false);
            this.panelVehicleSearch.PerformLayout();
            this.tabPageFiles.ResumeLayout(false);
            this.panelFileControls.ResumeLayout(false);
            this.panelFileSearch.ResumeLayout(false);
            this.panelFileSearch.PerformLayout();
            this.tabPageActions.ResumeLayout(false);
            this.panelActionsContent.ResumeLayout(false);
            this.panelActionsHeader.ResumeLayout(false);
            this.panelActionsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionsHeader)).EndInit();
            this.groupBoxActionsDataTransfer.ResumeLayout(false);
            this.tableLayoutPanelActionsDataTransfer.ResumeLayout(false);
            this.flowLayoutPanelActionsExport.ResumeLayout(false);
            this.flowLayoutPanelActionsExport.PerformLayout();
            this.flowLayoutPanelActionsImport.ResumeLayout(false);
            this.flowLayoutPanelActionsImport.PerformLayout();
            this.groupBoxActionCopy.ResumeLayout(false);
            this.tableLayoutPanelActionCopyContent.ResumeLayout(false);
            this.flowLayoutPanelActionCopy.ResumeLayout(false);
            this.flowLayoutPanelActionCopy.PerformLayout();
            this.flowLayoutPanelActionCopyReplace.ResumeLayout(false);
            this.flowLayoutPanelActionCopyReplace.PerformLayout();
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
        private Splitter splitterISControls1;
        private Button buttonEditIS;
        private TextBox textBoxISSearch;
        private Button buttonISSearch;
        private Panel panelISSearch;
        private Button buttonISCancelSearch;
        private RadioButton radioButtonMaps;
        private TabPage tabPageMaps;
        private Splitter splitterISControls2;
        private Splitter splitterISControls3;
        private RadioButton radioButtonManufacturers;
        private Panel panelISSizeButton;
        private FlowLayoutPanel panelMapsControls;
        private Button buttonAddMap;
        private Button buttonInfoMap;
        private Button buttonEditMap;
        private Button buttonRemoveMap;
        private Button buttonDeleteMap;
        private Splitter splitterMapControls1;
        private Panel panelMapSizeButton;
        private Splitter splitterMapControls2;
        private Panel panelMapSearch;
        private TextBox textBoxMapSearch;
        private Button buttonMapCancelSearch;
        private Button buttonMapSearch;
        private Splitter splitterMapControls3;
        private Panel panelMapContent;
        private TabPage tabPageManufacturers;
        private Panel panelManufacturerContent;
        private FlowLayoutPanel panelManufacturerControls;
        private Button buttonAddManufacturer;
        private Button buttonInfoManufacturer;
        private Button buttonEditManufacturer;
        private Button buttonRemoveManufacturer;
        private Button buttonDeleteManufacturer;
        private Splitter splitterManufacturerControls1;
        private Panel panelManufacturerSizeControl;
        private Splitter splitterManufacturerControls2;
        private Panel panelManufacturerSearch;
        private TextBox textBoxManufacturerSearch;
        private Button buttonManufacturerCancelSearch;
        private Button buttonManufacturerSearch;
        private Splitter splitterManufacturerControls3;
        private RadioButton radioButtonVehicles;
        private TabPage tabPageVehicles;
        private FlowLayoutPanel panelVehicleControls;
        private Button buttonAddVehicle;
        private Button buttonInfoVehicle;
        private Button buttonEditVehicle;
        private Button buttonRemoveVehicle;
        private Button buttonDeleteVehicle;
        private Splitter splitterVehicleControls1;
        private Panel panelVehicleSizeButton;
        private Splitter splitterVehicleControls2;
        private Panel panelVehicleSearch;
        private TextBox textBoxVehicleSearch;
        private Button buttonVehicleCancelSearch;
        private Button buttonVehicleSearch;
        private Splitter splitterVehicleControls3;
        private Panel panelVehicleContent;
        private RadioButton radioButtonFiles;
        private TabPage tabPageFiles;
        private FlowLayoutPanel panelFileControls;
        private Button buttonAddFile;
        private Button buttonInfoFile;
        private Button buttonEditFile;
        private Button buttonRemoveFile;
        private Button buttonDeleteFile;
        private Splitter splitterFileControls1;
        private Panel panelFileSizeControl;
        private Splitter splitterFileControls2;
        private Panel panelFileSearch;
        private TextBox textBoxFileSearch;
        private Button buttonFileCancelSearch;
        private Button buttonFileSearch;
        private Splitter splitterFileControls3;
        private Panel panelFileContent;
        private TabPage tabPageActions;
        private RadioButton radioButtonActions;
        private TableLayoutPanel panelActionsContent;
        private Panel panelActionsHeader;
        private PictureBox pictureBoxActionsHeader;
        private Label labelActionsHeader;
        private Splitter splitterActionsHeader;
        private GroupBox groupBoxActionsDataTransfer;
        private TableLayoutPanel tableLayoutPanelActionsDataTransfer;
        private Button buttonActionsExport;
        private Button buttonActionsImport;
        private FlowLayoutPanel flowLayoutPanelActionsExport;
        private Label labelActionsExport1;
        private Label labelActionsExport2;
        private Label labelActionsExport3;
        private FlowLayoutPanel flowLayoutPanelActionsImport;
        private Label labelActionsImport1;
        private Label labelActionsImport2;
        private Label labelActionsImport3;
        private SaveFileDialog saveFileDialogExport;
        private OpenFileDialog openFileDialogImport;
        private GroupBox groupBoxActionCopy;
        private TableLayoutPanel tableLayoutPanelActionCopyContent;
        private Button buttonActionCopy;
        private Button buttonActionCopyReplace;
        private FlowLayoutPanel flowLayoutPanelActionCopyReplace;
        private Label labelActionCopyReplace1;
        private Label labelActionCopyReplace2;
        private Label labelActionCopyReplace3;
        private FlowLayoutPanel flowLayoutPanelActionCopy;
        private Label labelActionCopy1;
        private Label labelActionCopy2;
        private Label labelActionCopy3;
    }
}