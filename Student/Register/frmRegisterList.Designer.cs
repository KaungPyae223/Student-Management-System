namespace Student.Register
{
    partial class frmRegisterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmSchduleID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStudentName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCourseName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.tstSearchWith = new System.Windows.Forms.ToolStripTextBox();
            this.dgvRegisterList = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbSearch,
            this.tstSearchWith});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(750, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.AutoSize = false;
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(60, 24);
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
            this.tsbEdit.Size = new System.Drawing.Size(60, 24);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 24);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSchduleID,
            this.tsmStudentName,
            this.tsmCourseName,
            this.tsmUserName});
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(69, 24);
            this.tsbSearch.Text = "Search";
            // 
            // tsmSchduleID
            // 
            this.tsmSchduleID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmSchduleID.Name = "tsmSchduleID";
            this.tsmSchduleID.Size = new System.Drawing.Size(173, 24);
            this.tsmSchduleID.Text = "SchduleID";
            this.tsmSchduleID.Click += new System.EventHandler(this.tsmSchduleID_Click);
            // 
            // tsmStudentName
            // 
            this.tsmStudentName.Name = "tsmStudentName";
            this.tsmStudentName.Size = new System.Drawing.Size(173, 24);
            this.tsmStudentName.Text = "Student Name";
            this.tsmStudentName.Click += new System.EventHandler(this.tsmStudentID_Click);
            // 
            // tsmCourseName
            // 
            this.tsmCourseName.Name = "tsmCourseName";
            this.tsmCourseName.Size = new System.Drawing.Size(173, 24);
            this.tsmCourseName.Text = "Course Name";
            this.tsmCourseName.Click += new System.EventHandler(this.tsmCourseName_Click);
            // 
            // tsmUserName
            // 
            this.tsmUserName.Name = "tsmUserName";
            this.tsmUserName.Size = new System.Drawing.Size(173, 24);
            this.tsmUserName.Text = "User Name";
            this.tsmUserName.Click += new System.EventHandler(this.tsmUserName_Click);
            // 
            // tstSearchWith
            // 
            this.tstSearchWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tstSearchWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tstSearchWith.Name = "tstSearchWith";
            this.tstSearchWith.Size = new System.Drawing.Size(200, 27);
            this.tstSearchWith.TextChanged += new System.EventHandler(this.tstSearchWith_TextChanged);
            // 
            // dgvRegisterList
            // 
            this.dgvRegisterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegisterList.Location = new System.Drawing.Point(0, 27);
            this.dgvRegisterList.Name = "dgvRegisterList";
            this.dgvRegisterList.RowTemplate.Height = 24;
            this.dgvRegisterList.Size = new System.Drawing.Size(750, 282);
            this.dgvRegisterList.TabIndex = 1;
            // 
            // frmRegisterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 309);
            this.Controls.Add(this.dgvRegisterList);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegisterList";
            this.Text = "frmRegisterList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegisterList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSplitButton tsbSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmSchduleID;
        private System.Windows.Forms.ToolStripMenuItem tsmStudentName;
        private System.Windows.Forms.ToolStripTextBox tstSearchWith;
        private System.Windows.Forms.DataGridView dgvRegisterList;
        private System.Windows.Forms.ToolStripMenuItem tsmCourseName;
        private System.Windows.Forms.ToolStripMenuItem tsmUserName;
    }
}