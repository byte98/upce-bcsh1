namespace SemestralProject.Forms
{
    internal partial class ControlISView
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
            this.listViewContent = new System.Windows.Forms.ListView();
            this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewContent
            // 
            this.listViewContent.AllowColumnReorder = true;
            this.listViewContent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDescription});
            this.listViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewContent.FullRowSelect = true;
            this.listViewContent.Location = new System.Drawing.Point(0, 0);
            this.listViewContent.MultiSelect = false;
            this.listViewContent.Name = "listViewContent";
            this.listViewContent.Size = new System.Drawing.Size(150, 150);
            this.listViewContent.TabIndex = 0;
            this.listViewContent.UseCompatibleStateImageBehavior = false;
            this.listViewContent.View = System.Windows.Forms.View.Details;
            this.listViewContent.SelectedIndexChanged += new System.EventHandler(this.listViewContent_SelectedIndexChanged);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Název";
            this.columnHeaderName.Width = 31;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Popis";
            this.columnHeaderDescription.Width = 149;
            // 
            // ControlISView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewContent);
            this.Name = "ControlISView";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listViewContent;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderDescription;
    }
}
