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
using Student.ReportData;
namespace Student.Studentdata
{
    public partial class frm_StudentList : Form
    {
        clsMainDb clsMainDB = new clsMainDb();
        String SPString;
        DataTable DT;
        clsStudent clsStudent = new clsStudent();
        clsMainDb OBJclsMain = new clsMainDb();
        public frm_StudentList()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmAddStudentData fd = new frmAddStudentData();
            fd.ShowDialog();
            showData();
        }

        private void frm_StudentList_Load(object sender, EventArgs e)
        {
            showData();
        }
        public void showData()
        {
            SPString = String.Format("Select_Student N'{0}', N'{1}', N'{2}',N'{3}'", "0", "0", "0", "1");

            dgvStudent.DataSource=clsMainDB.SelectData(SPString);


            dgvStudent.Columns[0].Width = (dgvStudent.Width / 100) * 5;
            dgvStudent.Columns[1].Visible = false;
            dgvStudent.Columns[2].Width = (dgvStudent.Width / 100) * 17; 
            dgvStudent.Columns[3].Width = (dgvStudent.Width / 100) * 17;
            dgvStudent.Columns[4].Width = (dgvStudent.Width / 100) * 25;
            dgvStudent.Columns[5].Width = (dgvStudent.Width / 100) * 25;
            dgvStudent.Columns[6].Width = (dgvStudent.Width / 100) * 15;

            OBJclsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "Name");
            tslLabel.Text = "Name";
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            showEntry();
            showData();
        }
        public void showEntry()
        {
            if (dgvStudent.CurrentRow.Cells[0].Value.ToString() == string.Empty) 
            {
                MessageBox.Show("There is No Data");
            }
            else
            {
                frmAddStudentData frm = new frmAddStudentData();
                frm.StudetnID=Convert.ToInt32(dgvStudent.CurrentRow.Cells["StudentID"].Value.ToString());
                frm.txtAddress.Text=dgvStudent.CurrentRow.Cells["Address"].Value.ToString();
                frm.txtGmail.Text=dgvStudent.CurrentRow.Cells["Gmail"].Value.ToString();
                frm.txtName.Text = dgvStudent.CurrentRow.Cells["Name"].Value.ToString();
                frm.txtNRC.Text = dgvStudent.CurrentRow.Cells["NRC"].Value.ToString();
                frm.txtPhone.Text = dgvStudent.CurrentRow.Cells["Phone"].Value.ToString();
                frm.btnAdd.Text = "Edit";
                frm.idEDIT = true;
                frm.ShowDialog();
                showData();
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            String StudentID = dgvStudent.CurrentRow.Cells["StudentID"].Value.ToString();
            if (StudentID == string.Empty)
                MessageBox.Show("Please select a item to delete");
            else
            {
                if (MessageBox.Show("Do you really want to delete?", "comfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsStudent.StudetnID = Convert.ToInt32(StudentID);
                    clsStudent.Action = 2;
                    clsStudent.saveData();
                    MessageBox.Show("Successfully deleted");
                    showData();
                
                }
            }
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmName_Click(object sender, EventArgs e)
        {
            tslLabel.Text = "Name";
            SPString = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "1");
            OBJclsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "Name");
        }

        private void tsmPhone_Click(object sender, EventArgs e)
        {
            tslLabel.Text = "Phone";
            SPString = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "1");
            OBJclsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "Phone");
        }

        private void tsmAddress_Click(object sender, EventArgs e)
        {
            tslLabel.Text = "Address";
            SPString = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "1");
            OBJclsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "Address");
        }

        private void tsmGmail_Click(object sender, EventArgs e)
        {
            tslLabel.Text = "Email";
            SPString = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "1");
            OBJclsMain.toolStripTextBoxdata(ref tstSearchWith, SPString, "Gmail");
        }

        private void tstSearchWith_TextChanged(object sender, EventArgs e)
        {
            if (tslLabel.Text == "Name")
            {
                SPString = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.Trim().ToString(), "0", "0", "2");

            }
            else if (tslLabel.Text == "Address")
            {
                SPString = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.Trim().ToString(), "0", "0", "3");

            }
            else if (tslLabel.Text == "Email")
            {
                SPString = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.Trim().ToString(), "0", "0", "4");

            }
            else if (tslLabel.Text == "Phone")
            {
                SPString = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", tstSearchWith.Text.Trim().ToString(), "0", "0", "5");

            }
            dgvStudent.DataSource = OBJclsMain.SelectData(SPString);

        }

        private void tslLabel_ButtonClick(object sender, EventArgs e)
        {

        }


        

       
    }
}
