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
namespace Student.Register
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        clsMainDb objclsMain = new clsMainDb();
        String SP;
        public Boolean isEdit = false;
        DataTable DT = new DataTable();
        clsRegister objclsRegister = new clsRegister();
        public int RegistrationID = 0;
        public string Select;
        private void frmRegister_Load(object sender, EventArgs e)
        {
            SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}'", "0", "0", "6");
            cboSchduleID.Items.Clear();
            cboSchduleID.Items.Add("Select Schdule ID");
            DataTable DT = new DataTable();
            DT = objclsMain.SelectData(SP);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                cboSchduleID.Items.Add(DT.Rows[i]["SchduleID"]);
            }

            SP = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", "0", "0", "0", "1");
            objclsMain.TextBoxData(ref txtStudentName, SP, "Name");
            cboSchduleID.SelectedItem = Select;
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            SP = string.Format("Select_Student N'{0}',N'{1}',N'{2}',N'{3}'", txtStudentName.Text.Trim().ToString(), "0", "0", "2");
            objclsMain.TextBoxData(ref txtStudentAddress, SP, "Address");

        }

        private void cboSchduleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSchduleID.SelectedIndex > 0)
            {
                SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}'", cboSchduleID.SelectedItem.ToString(), "0", "6");                
                DT = objclsMain.SelectData(SP);
                
        

                if (DT.Rows.Count > 0)
                {
                    String a = DT.Rows[0]["StartDate"].ToString();
                    lblSchduleDate.Text=a;
                }
            }
            else
            {
                lblSchduleDate.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (cboSchduleID.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Schdule ID");
            }
            else if (txtStudentName.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Please type a student name");
                txtStudentName.Focus();
            }
            else if (txtStudentAddress.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Please type a student Address");
                txtStudentAddress.Focus();
            }
            else
            {
                SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", txtStudentName.Text.Trim().ToString(), txtStudentAddress.Text.Trim().ToString(), "0", "0");
                DT = objclsMain.SelectData(SP);
                if (DT.Rows.Count <= 0)
                {
                    MessageBox.Show("The student is not exit");
                    txtStudentName.Focus();
                }
                else
                {
                    int ID = Convert.ToInt32(DT.Rows[0]["StudentID"].ToString());
                    SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'",cboSchduleID.SelectedItem.ToString(), "0", ID, "1");
                    DT = objclsMain.SelectData(SP);
                    if(DT.Rows.Count > 0 && isEdit == false)
                    {
                        MessageBox.Show("This student is already registered");
                    }
                    else
                    {
                        SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", cboSchduleID.SelectedItem.ToString(), "0", ID, "11");
                        DT = objclsMain.SelectData(SP);
                        int avl = Convert.ToInt32(DT.Rows[0]["available"].ToString());
                        SP = string.Format("Select_Register N'{0}',N'{1}',N'{2}',N'{3}'", cboSchduleID.SelectedItem.ToString(), "0", ID, "12");
                        DT = objclsMain.SelectData(SP);
                        if (DT.Rows.Count >= avl)
                        {
                            MessageBox.Show("The available student is over");
                        }
                        else
                        {
                            objclsRegister.SchduleID = cboSchduleID.SelectedItem.ToString();
                            objclsRegister.StudentID = ID;
                            objclsRegister.note = txtNote.Text;
                            objclsRegister.RID = RegistrationID;
                            objclsRegister.ID = Program.ID;
                            objclsRegister.registrationDate = DateTime.Now.ToShortDateString();
                            if (isEdit)
                            {
                                objclsRegister.action = 2;
                                objclsRegister.SaveData();
                                MessageBox.Show("Successfully edited", "Successfully");
                                this.Close();
                            }
                            else
                            {
                                objclsRegister.action = 0;
                                objclsRegister.SaveData();
                                MessageBox.Show("Successfully saved", "Successfully");
                                this.Close();
                            }
                        }


                    }

                }
                
            }
        }
    }
}
