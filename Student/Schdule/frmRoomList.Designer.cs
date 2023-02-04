namespace Student.Schdule
{
    partial class frmRoomList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstSearchWith = new System.Windows.Forms.ToolStripTextBox();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.dgvSection = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete,
            this.toolStripLabel1,
            this.tstSearchWith,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(726, 33);
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
            this.tsbEdit.Size = new System.Drawing.Size(60, 30);
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
            this.tsbDelete.Size = new System.Drawing.Size(60, 30);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 30);
            this.toolStripLabel1.Text = "RoomName";
            // 
            // tstSearchWith
            // 
            this.tstSearchWith.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tstSearchWith.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tstSearchWith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstSearchWith.Name = "tstSearchWith";
            this.tstSearchWith.Size = new System.Drawing.Size(250, 33);
            this.tstSearchWith.TextChanged += new System.EventHandler(this.tstSearchWith_TextChanged);
            // 
            // tsbPrint
            // 
            this.tsbPrint.AutoSize = false;
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(60, 30);
            this.tsbPrint.Text = "Print";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // dgvSection
            // 
            this.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSection.Location = new System.Drawing.Point(0, 33);
            this.dgvSection.Name = "dgvSection";
            this.dgvSection.RowTemplate.Height = 28;
            this.dgvSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSection.Size = new System.Drawing.Size(726, 458);
            this.dgvSection.TabIndex = 1;
            // 
            // frmRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 491);
            this.Controls.Add(this.dgvSection);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoomList";
            this.Text = "Room List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRoomList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridView dbvRoom;
        private System.Windows.Forms.DataGridView dgvSection;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstSearchWith;
        private System.Windows.Forms.ToolStripButton tsbPrint;
    }
}