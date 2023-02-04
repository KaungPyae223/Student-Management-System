using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.DBA;
namespace Student.Schdule
{
    public partial class frmSectionList : Form
    {
        public frmSectionList()
        {
            InitializeComponent();
        }
        clsMainDb objClsMain =new clsMainDb();
        String SP;
        private void frmSectionList_Load(object sender, EventArgs e)
        {
            showData();
        }
        public void showData()
        { 
            SP = string.Format("Select_Section N'{0}',N'{1}',N'{2}'", "1", "0", "0");
            dbvSection.DataSource = objClsMain.SelectData(SP);
            dbvSection.Columns[0].Width = (dbvSection.Width / 100) * 5;
            dbvSection.Columns[1].Visible = false;
            dbvSection.Columns[2].Width = (dbvSection.Width / 100) * 50;
            dbvSection.Columns[3].Width = (dbvSection.Width / 100) * 50;

            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SP, "Date");

        }

        

        private void tsbNew_Click_1(object sender, EventArgs e)
        {
            frmSectionData frm = new frmSectionData();
            frm.ShowDialog();
            showData();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            showEntry();
            showData();
        }
        public void showEntry()
        {
            if (dbvSection.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a section to edit", "Error");
            }
            else
            {
                frmSectionData frm = new frmSectionData();
                frm.txtSectionName.Text = dbvSection.CurrentRow.Cells[2].Value.ToString();
                frm.ID=Convert.ToInt32(dbvSection.CurrentRow.Cells[1].Value.ToString());
                frm.btnSave.Text = "Edit";
                frm.is_Edit = true;
                String chk = dbvSection.CurrentRow.Cells[3].Value.ToString();
                if (chk.Contains("Mon"))
                    frm.chkMonday.Checked = true;
                if (chk.Contains("Sun"))
                    frm.chkSun.Checked = true;
                if (chk.Contains("Tue"))
                    frm.chkThu.Checked = true;
                if (chk.Contains("Web"))
                    frm.chkWeb.Checked = true;
                if (chk.Contains("Thur"))
                    frm.chkThur.Checked = true;
                if (chk.Contains("Fri"))
                    frm.chkFri.Checked = true;
                if (chk.Contains("Sat"))
                    frm.chkSat.Checked = true;

                frm.ShowDialog();
                showData();
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you really want to delete", "comfirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clsSection objClsSection = new clsSection();
                objClsSection.id = Convert.ToInt32(dbvSection.CurrentRow.Cells[1].Value.ToString());
                objClsSection.action = 2;
                objClsSection.saveData();
                MessageBox.Show("Successfully deleted");
                showData();
            }
        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            SP = string.Format("Select_Section N'{0}',N'{1}',N'{2}'", "2", "0", tstSearchWith.Text.Trim().ToString());
            dbvSection.DataSource = objClsMain.SelectData(SP);
        }

        private void dbvSection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
