﻿using SemestralProject.Visual;

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
            this.SuspendLayout();
            // 
            // panelItemsControl
            // 
            this.panelItemsControl.Controls.Add(this.radioButtonManufacturers);
            this.panelItemsControl.Controls.Add(this.radioButtonMaps);
            this.panelItemsControl.Controls.Add(this.radioButtonIS);
            this.panelItemsControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemsControl.Location = new System.Drawing.Point(0, 0);
            this.panelItemsControl.Name = "panelItemsControl";
            this.panelItemsControl.Size = new System.Drawing.Size(1348, 29);
            this.panelItemsControl.TabIndex = 1;
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
    }
}