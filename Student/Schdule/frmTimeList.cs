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
using Student.Schdule;
namespace Student.Schdule
{
    public partial class frmTimeList : Form
    {
        public frmTimeList()
        {
            InitializeComponent();
        }
        clsMainDb objClsMain = new clsMainDb();
        private void TimeList_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmTimeData frm = new frmTimeData();
            frm.ShowDialog();
            showData();
        }
        public void showData()
        {
            String SP = String.Format("Select_Time N'{0}',N'{1}'", "0", "1");
            dgvTime.DataSource = objClsMain.SelectData(SP);
            dgvTime.Columns[0].Width = (dgvTime.Width / 100) * 5;
            dgvTime.Columns[1].Visible = false;
            dgvTime.Columns[2].Width = (dgvTime.Width / 100) * 100;
        
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            frmTimeData frm = new frmTimeData();
            frm.id = Convert.ToInt32(dgvTime.CurrentRow.Cells[1].Value.ToString());
            frm.is_Edit = true;
            frm.btnSave.Text = "Edit";
            frm.ShowDialog();
            showData();            
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvTime.CurrentRow.Cells[0].Value.ToString() == string.Empty)
                MessageBox.Show("please select a time to Delete", "Error");
            else
            {
                if (MessageBox.Show("do you wwant to Delete", "comfirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    clsTime objClsTime = new clsTime();
                    objClsTime.ID = Convert.ToInt32(dgvTime.CurrentRow.Cells[1].Value.ToString());
                    objClsTime.action = 2;
                    objClsTime.saveData();
                    MessageBox.Show("Successfully deleted", "Successfully");
                    showData();
                }
            }
        }
    }
}
