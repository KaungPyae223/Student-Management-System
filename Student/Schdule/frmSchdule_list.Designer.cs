namespace Student.DBA
{
    partial class frmSchdule_list
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchdule_list));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.Search = new System.Windows.Forms.ToolStripSplitButton();
            this.mnuDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRoomName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourseName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstSearchWith = new System.Windows.Forms.ToolStripTextBox();
            this.dgvSchdule = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchdule)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete,
            this.Search,
            this.tstSearchWith});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.AutoSize = false;
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(60, 30);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.AutoSize = false;
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(123, 30);
            this.tsbEdit.Text = "Edit Startdate";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 30);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // Search
            // 
            this.Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Search.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDate,
            this.mnuRoomName,
            this.mnuCourseName,
            this.mnuUserName});
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search.Name = "Search";
            this.Search.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Search.Size = new System.Drawing.Size(69, 30);
            this.Search.Text = "Search";
            // 
            // mnuDate
            // 
            this.mnuDate.Name = "mnuDate";
            this.mnuDate.Size = new System.Drawing.Size(167, 24);
            this.mnuDate.Text = "Date";
            this.mnuDate.Click += new System.EventHandler(this.mnuDate_Click);
            // 
            // mnuRoomName
            // 
            this.mnuRoomName.Name = "mnuRoomName";
            this.mnuRoomName.Size = new System.Drawing.Size(167, 24);
            this.mnuRoomName.Text = "Room Name";
            this.mnuRoomName.Click += new System.EventHandler(this.mnuRoomName_Click);
            // 
            // mnuCourseName
            // 
            this.mnuCourseName.Name = "mnuCourseName";
            this.mnuCourseName.Size = new System.Drawing.Size(167, 24);
            this.mnuCourseName.Text = "Course Name";
            this.mnuCourseName.Click += new System.EventHandler(this.mnuCourseName_Click);
            // 
            // mnuUserName
            // 
            this.mnuUserName.Name = "mnuUserName";
            this.mnuUserName.Size = new System.Drawing.Size(167, 24);
            this.mnuUserName.Text = "User Name";
            this.mnuUserName.Click += new System.EventHandler(this.mnuUserName_Click);
            // 
            // tstSearchWith
            // 
            this.tstSearchWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tstSearchWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tstSearchWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstSearchWith.Name = "tstSearchWith";
            this.tstSearchWith.Size = new System.Drawing.Size(222, 33);
            this.tstSearchWith.TextChanged += new System.EventHandler(this.tstSearchWith_TextChanged);
            // 
            // dgvSchdule
            // 
            this.dgvSchdule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchdule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchdule.Location = new System.Drawing.Point(0, 33);
            this.dgvSchdule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSchdule.Name = "dgvSchdule";
            this.dgvSchdule.RowTemplate.Height = 28;
            this.dgvSchdule.Size = new System.Drawing.Size(817, 382);
            this.dgvSchdule.TabIndex = 2;
            // 
            // frmSchdule_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 415);
            this.Controls.Add(this.dgvSchdule);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSchdule_list";
            this.Text = "frmSchdule_list";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSchdule_list_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchdule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripTextBox tstSearchWith;
        private System.Windows.Forms.ToolStripSplitButton Search;
        private System.Windows.Forms.ToolStripMenuItem mnuDate;
        private System.Windows.Forms.ToolStripMenuItem mnuRoomName;
        private System.Windows.Forms.ToolStripMenuItem mnuUserName;
        private System.Windows.Forms.ToolStripMenuItem mnuCourseName;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        public System.Windows.Forms.DataGridView dgvSchdule;
    }
}