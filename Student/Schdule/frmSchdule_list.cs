using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.Schdule;
using Student.DBA;

namespace Student.DBA
{
    public partial class frmSchdule_list : Form
    {
        clsMainDb objClsMain = new clsMainDb();
        String SPString;
        DataTable DT;
        public frmSchdule_list()
        {
            InitializeComponent();
        }

        private void frmSchdule_list_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void showdata()
        {
            SPString = string.Format("Select_Schdule N'{0}', N'{1}', N'{2}',N'{3}',N'{4}'", "0", "0", "7","0","0");
            dgvSchdule.DataSource = objClsMain.SelectData(SPString);

            dgvSchdule.Columns[0].Width = (dgvSchdule.Width / 100) * 10;
            dgvSchdule.Columns[1].Width = (dgvSchdule.Width / 100) * 5;
            dgvSchdule.Columns[2].Visible = false;
            dgvSchdule.Columns[3].Visible = false;
            dgvSchdule.Columns[4].Visible = false;
            dgvSchdule.Columns[5].Visible = false;
            dgvSchdule.Columns[6].Width = (dgvSchdule.Width / 100) * 10;
            dgvSchdule.Columns[7].Visible = false;
            dgvSchdule.Columns[8].Width = (dgvSchdule.Width / 100) * 10;
            dgvSchdule.Columns[9].Width = (dgvSchdule.Width / 100) * 15;
            dgvSchdule.Columns[10].Width = (dgvSchdule.Width / 100) * 10;
            dgvSchdule.Columns[11].Width = (dgvSchdule.Width / 100) * 10;
            dgvSchdule.Columns[12].Width = (dgvSchdule.Width / 100) * 15;
            dgvSchdule.Columns[13].Width = (dgvSchdule.Width / 100) * 15;
         

            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "SchduleID");
        }
        private void tsbNew_Click(object sender, EventArgs e)
        {
           
            frmSchdule_Data frm = new frmSchdule_Data();
            frm.ShowDialog();
            showdata();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {   
            if (dgvSchdule.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a row to delete");
            }
            
            else
            {
                SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", dgvSchdule.CurrentRow.Cells[1].Value.ToString(), "0", "13", "0", "0");
                DT = objClsMain.SelectData(SPString);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("Already regirster schdule can't be delete");
                }
                else if(MessageBox.Show("Are you sure to Delete", "comfirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    clsSchdule objclsSchdule = new clsSchdule();
                    objclsSchdule.SchduleID = (dgvSchdule.CurrentRow.Cells[1].Value.ToString());
                    objclsSchdule.action = 2;
                    objclsSchdule.SaveData();
                    MessageBox.Show("Successfully deleted");
                    showdata();
                }
            }
        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text == "Date")
            {
                SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", tstSearchWith.Text.Trim().ToString(), "0", "8","0","0");
            }
            else if (Search.Text == "RoomName")
            {
                SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", tstSearchWith.Text.Trim().ToString(), "0", "9","0","0");
            }
            else if (Search.Text == "CourseName")
            {
                SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", tstSearchWith.Text.Trim().ToString(), "0", "10","0","0");
            }
            else if (Search.Text == "UserName")
            {
                SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", tstSearchWith.Text.Trim().ToString(), "0", "11","0","0");
            }
            dgvSchdule.DataSource = objClsMain.SelectData(SPString);

        }

        private void mnuDate_Click(object sender, EventArgs e)
        {
            Search.Text = "Date";
            SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "0", "7","0","0");
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "Date");
        }

        private void mnuRoomName_Click(object sender, EventArgs e)
        {
            Search.Text = "RoomName";
            SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "0", "7","0","0");
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "RoomName");
        }

        private void mnuCourseName_Click(object sender, EventArgs e)
        {
            Search.Text = "CourseName";
            SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "0", "7","0","0");
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "CourseName");
        }

        private void mnuUserName_Click(object sender, EventArgs e)
        {
            Search.Text = "UserName";
            SPString = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "0", "7","0","0");
            objClsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "UserName");
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvSchdule.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("Please select a StartDate to edit");
            }
            else
            {
                clsSchdule objclsSchdule = new clsSchdule();
                Program.SchduleID = dgvSchdule.CurrentRow.Cells[1].Value.ToString();
                EditStartdate frm1 = new EditStartdate();
                frm1.ShowDialog();
                showdata();
            }

        }



    }
}
