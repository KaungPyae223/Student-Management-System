using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.Studentdata;
using Student.DBA;
using Student.Schdule;
using Student.Log_In;
using Student.Register;
namespace Student
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainPannel.Controls.Count > 0)
            {
                this.mainPannel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPannel.Controls.Add(f);
            this.mainPannel.Tag = f;
            f.Show();
        }
        private void mnuStudent_Click(object sender, EventArgs e)
        {
            loadform(new frm_StudentList());
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRoom_Click(object sender, EventArgs e)
        {
            loadform(new frmRoomList());
        }

        private void mnuAddSection_Click(object sender, EventArgs e)
        {
            loadform(new frmSectionList());
        }

        private void mnuAddTime_Click(object sender, EventArgs e)
        {
            loadform(new frmTimeList());
        }

        private void mnuCourse_Click(object sender, EventArgs e)
        {
            loadform(new frmCourse_List());
        }

        private void mnuSchdule_Click(object sender, EventArgs e)
        {
            loadform(new frmSchdule_list());
        }

        

        private void tsbUser_Click(object sender, EventArgs e)
        {
            loadform(new User_form());
        }

        private void mnuRegister_Click(object sender, EventArgs e)
        {
            loadform(new frmRegisterList());
        }

        private void mnuStudent_Click_1(object sender, EventArgs e)
        {
            loadform(new frm_StudentList());
        }

        private void tsmSchdule_Click(object sender, EventArgs e)
        {
            loadform(new frmSchdule_list());
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbLogin_Click(object sender, EventArgs e)
        {
            if (tsbLogin.Text == "Log Out")
            {
                if (MessageBox.Show("Are you want to logout", "comfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tsbLogin.Text = "Login";
                    loadform(new plane());
                    ShowMenu("");
                }
                return;
            }
            clsMainDb objclsMain = new clsMainDb();
            frm_Login frm = new frm_Login();
            DataTable DT = new DataTable();
            String UserName = "";
            String Password = "";
            int UserID = 0;
        Start:
            frm.txtUserName.Text = UserName;
            frm.txtPass.Text = Password;
           
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int OK = 0;
                if (frm.txtUserName.Text.Trim().ToString() == string.Empty)
                {
                    MessageBox.Show("Please type a User name");
                    frm.txtUserName.Focus();
                    goto Start;
                }
                UserName = frm.txtUserName.Text;
                if (frm.txtPass.Text.Trim().ToString() == string.Empty)
                {
                    MessageBox.Show("Please type a Password");
                    frm.txtPass.Focus();
                    goto Start;
                }
                Password = frm.txtPass.Text;
                if (frm.txtUserID.Text.Trim().ToString() == string.Empty)
                {
                    MessageBox.Show("Please type a User ID");
                    frm.txtUserID.Focus();
                    goto Start;
                }
                if ( int.TryParse(frm.txtUserID.Text.ToString(),out OK)==false)
                {
                    MessageBox.Show("ID should be number");
                    frm.txtUserID.Focus();
                    goto Start;
                } 
                 UserID = Convert.ToInt32(frm.txtUserID.Text.Trim().ToString());
                String SP;
                SP = string.Format("Select_User N'{0}',N'{1}',N'{2}',N'{3}'", UserName, Password, UserID, "2");
                DT = objclsMain.SelectData(SP);
                if (DT.Rows.Count <= 0)
                {
                    MessageBox.Show("User Name, ID or Password is wrong");
                    goto Start;
                }
                if (DT.Rows[0]["Password"].ToString() != UserName)
                {
                    MessageBox.Show("User Name, ID or Password is wrong");
                    goto Start;
                }
                else
                {
                    Program.ID = UserID;
                    string UserLevel = DT.Rows[0]["UserLevel"].ToString();
                    tsbLogin.Text = "Log Out";
                    ShowMenu(UserLevel);
                    
                }

            }
            
            
            
        }

        

        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowMenu("");
        }
        public void ShowMenu(String userlevel)
        {
            String[] arr = userlevel.Split(' ');
            for (int i = 1; i < menuStrip1.Items.Count; i++)
            {
                ToolStripMenuItem mnumain = (ToolStripMenuItem)menuStrip1.Items[i];
                mnumain.Enabled = false;
                foreach (String mnu in arr)
                {
                    if (mnumain.Text.ToString() == mnu.ToString())
                    {
                        mnumain.Enabled = true;
                        break;
                    }
                }
            }
        
        }

        private void mnuRegisteration_Click(object sender, EventArgs e)
        {

        }
    

        
    }
}
