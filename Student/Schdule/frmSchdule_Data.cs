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
    public partial class frmSchdule_Data : Form
    {
        public frmSchdule_Data()
        {
            InitializeComponent();
        }
        clsMainDb objClsMain = new clsMainDb();
        public string ID;
        string SP;
        DataTable DT;
        
        public String course = "Select a course";
        public String room = "Select a Room";
        public String Date = "Select a Date";
        public String Time = "Select a Time";
        public String Ongoing = "True";
        int couID,romid,secid,timID,avl;
        private void frmSchdule_Data_Load(object sender, EventArgs e)
        {
            SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "5/27/2003", "0","0","0");
            AddCombo(ref cboCourse, "CourseName", "Select a course", course);

            SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "5/27/2003", "1","0","0");
            AddCombo(ref cboRoomName, "RoomName", "Select a Room", room);

            SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "5/27/2003", "2","0","0");
            AddCombo(ref cboDate, "Date", "Select a Date", Date);

            SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "5/27/2003", "3","0","0");
            AddCombo(ref cboTime, "Time", "Select a Time", Time);

           
        }
        

        private void cboRoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoomName.SelectedItem == "Add Data")
            {
                frmRoomData frm = new frmRoomData();
                frm.ShowDialog();
                SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "5/27/2003", "1","0","0");
                AddCombo(ref cboRoomName, "RoomName", "Select a Room",room);  
            }
            else if (cboRoomName.SelectedIndex > 0)
            {
                SP = string.Format("Select_Room N'{0}',N'{1}'", cboRoomName.SelectedItem.ToString(), "0");
                DT = objClsMain.SelectData(SP);
                romid = Convert.ToInt32(DT.Rows[0]["RoomNo"].ToString());
                lblAvailable.Text = DT.Rows[0]["available"].ToString();
            }
            else
            {
                lblAvailable.Text = "";

            }
        }
        public void AddCombo(ref ComboBox cbo, String Display, String Start, String Select)
        {
            cbo.Items.Clear();
            cbo.Items.Add( Start);
            DataTable DT = new DataTable();
            DT = objClsMain.SelectData(SP);
            for (int i = 0; i < DT.Rows.Count; i++)
            { 
                cbo.Items.Add(DT.Rows[i][Display]);
            }
            cbo.Items.Add("Add Data");
            cbo.SelectedItem = Select;
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourse.SelectedItem == "Add Data")
            {
                frmCourseData frm = new frmCourseData();
                frm.ShowDialog();
                SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "5/27/2003", "0","0","0");
                AddCombo(ref cboCourse, "CourseName", "Select a course",course);
            }
            else if (cboCourse.SelectedIndex > 0)
            {
                SP = string.Format("Select_Course N'{0}',N'{1}',N'{2}'", cboCourse.SelectedItem.ToString(), "0", "1");
                DT = objClsMain.SelectData(SP);
                couID = Convert.ToInt32(DT.Rows[0]["CourseID"].ToString());
                ID = DT.Rows[0]["shortform"].ToString();
                SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", ID, "5/27/2003", "4","0","0");
                DT = objClsMain.SelectData(SP);

                if (DT.Rows.Count > 0)
                {
                    String a = DT.Rows[0]["SchduleID"].ToString();
                    string[] z = a.Split('-');
                    string p = z[1].Trim();
                    int i = Convert.ToInt32(p);
                    i = i + 1;
                    
                    ID = ID + " - " + i;
                    lblID.Text = ID;
                }
                else
                {
                    lblID.Text = ID + " - " + 0;
                }
            }
            else
            {
                lblID.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", dateTimePicker1.Value.ToShortDateString(), "5","0","0");
            DT = objClsMain.SelectData(SP);
            int no = Convert.ToInt32(DT.Rows[0]["NO"].ToString());
            if (no <= 0)
            {
                MessageBox.Show("Date must be greather than today");
                dateTimePicker1.Focus();
            }
            else if (lblID.Text == string.Empty)
            {
                MessageBox.Show("Please select a course");
                cboCourse.Focus();
                
            }
            else if (lblAvailable.Text == string.Empty)
            {
                MessageBox.Show("Please select a roomname");
                cboRoomName.Focus();

            }
            else if (cboDate.SelectedItem == "Select a date")
            {
                MessageBox.Show("Please select a date");
                cboDate.Focus();
            }
            else if (cboTime.SelectedItem == "Select a Time")
            {
                MessageBox.Show("Please select a time");
                cboTime.Focus();
            }

            else
            {
                SP = string.Format("Select_Time N'{0}',N'{1}'", cboTime.SelectedItem.ToString(), "0");
                DT = objClsMain.SelectData(SP);
                timID = Convert.ToInt32(DT.Rows[0]["TimeID"].ToString());
                
                SP = string.Format("Select_Section N'{0}',N'{1}',N'{2}'", "0","0", cboDate.SelectedItem.ToString().Trim());
                DT = objClsMain.SelectData(SP);
                secid = Convert.ToInt32(DT.Rows[0]["SectionID"].ToString());

                SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", dateTimePicker1.Value.ToShortDateString(), "12", secid, timID);
                DT = objClsMain.SelectData(SP);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("This Schdule is already exist");

                }
                else
                {
                    clsSchdule objclsSchdule = new clsSchdule();

                    objclsSchdule.SchduleID = lblID.Text.ToString();
                    objclsSchdule.SectionID = secid;
                    objclsSchdule.CoursseID = couID;
                    objclsSchdule.roomID = romid;
                    objclsSchdule.TimeID = timID;
                    objclsSchdule.start = dateTimePicker1.Value.ToShortDateString();

                    objclsSchdule.action = 0;
                    objclsSchdule.SaveData();
                    MessageBox.Show("Suvccessfully saved");
                }
                
                
            }

        }

        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDate.SelectedItem == "Add Data")
            {
                frmSectionData frm = new frmSectionData();
                frm.ShowDialog();
                SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "5/27/2003", "2","0","0");
                AddCombo(ref cboDate, "Date", "Select a Date", Date);  
                
            }
        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTime.SelectedItem == "Add Data")
            {
                frmTimeData frm = new frmTimeData();
                frm.ShowDialog();
                SP = string.Format("Select_Schdule N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'", "0", "5/27/2003", "3","0","0");
                AddCombo(ref cboTime, "Time", "Select a Time",Time);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
