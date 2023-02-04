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
    public partial class frmRoomData : Form
    {
        public frmRoomData()
        {
            InitializeComponent();
        }
        clsRoom objclsRoom = new clsRoom();
        public Boolean isEdit = false;
        int OK = 0;
        DataTable DT = new DataTable();
        String SP;
        clsMainDb obj_clsMainDB = new clsMainDb();
        public int ID = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text == string.Empty)
            {
                MessageBox.Show("Please type a room name", "Error");
                txtRoomName.Focus();
            }
            else if (txtAvailable.Text == string.Empty)
            {
                MessageBox.Show("Please enter a available number", "Error");
                txtAvailable.Focus();
            }
            else if (int.TryParse(txtAvailable.Text.ToString(), out OK) == false)
            {
                MessageBox.Show("The available should be number", "Error");
                txtAvailable.Focus();
            }
            else
            {
                SP = string.Format("Select_Room N'{0}',N'{1}'", txtRoomName.Text.ToString(), "0");
                DT = obj_clsMainDB.SelectData(SP);
                if (DT.Rows.Count > 0 && isEdit == false)
                {
                    MessageBox.Show("This item is already exit", "Error");
                }
                else
                {
                    objclsRoom.roomname = txtRoomName.Text;
                    objclsRoom.available = Convert.ToInt32(txtAvailable.Text.ToString());
                    objclsRoom.ID = ID;
                    if (isEdit)
                    {
                        objclsRoom.action = 1;
                        objclsRoom.SaveData();
                        MessageBox.Show("Successfully edited", "Successfully");
                        this.Close();
                    }
                    else
                    {
                        objclsRoom.action = 0;
                        objclsRoom.SaveData();
                        MessageBox.Show("Successfully saved", "Successfully");
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
