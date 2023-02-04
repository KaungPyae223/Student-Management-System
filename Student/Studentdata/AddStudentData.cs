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

namespace Student.Studentdata
{
    public partial class frmAddStudentData : Form
    {
        clsStudent objClsStudent = new clsStudent();
        public frmAddStudentData()
        {
            InitializeComponent();
        }
        public String SPString ="";
        public int StudetnID = 0;
        public Boolean idEDIT = false;
        clsMainDb obj_ClsMainDb = new clsMainDb();
        DataTable DT;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text.Trim().ToString() == String.Empty)
            {
                MessageBox.Show("Please type a name", "Error");
                txtName.Focus();
            }
            else if (txtPhone.Text.Trim().ToString() == String.Empty)
            {
                MessageBox.Show("Please type a Phone number", "Error");
                txtPhone.Focus();
            }
            
            else if (txtNRC.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type a NRC", "Error");
                txtNRC.Focus();
            }
            else if (txtGmail.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please type an Email", "Error");
                txtGmail.Focus();
            }
            else if (txtAddress.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("please type anaddress", "Error");
                txtAddress.Focus();
            }
            else
            {
                SPString = String.Format("Select_Student N'{0}', N'{1}', N'{2}',N'{3}'", txtName.Text.Trim().ToString(), txtGmail.Text.Trim().ToString(), "0", "0");
                DT = obj_ClsMainDb.SelectData(SPString);
                if (DT.Rows.Count > 0 && idEDIT==false)
                {
                    MessageBox.Show("This Student is alread exit", "Error");
                }
                else
                {
                    objClsStudent.StudetnID = StudetnID;
                    objClsStudent.Name = txtName.Text;
                    objClsStudent.Address = txtAddress.Text;
                    objClsStudent.Phone = txtPhone.Text;
                    objClsStudent.Gmail = txtGmail.Text;
                    objClsStudent.Address = txtAddress.Text;
                    objClsStudent.NRC = txtNRC.Text;

                    if (idEDIT)
                    {
                        objClsStudent.Action = 1;
                        objClsStudent.saveData();
                        MessageBox.Show("Successfully Updated", "Successfully", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        objClsStudent.Action = 0;
                        objClsStudent.saveData();
                        MessageBox.Show("Successfully Added", "Successfully", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
