using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student.DBA
{
    class clsRegister
    {
        clsMainDb objclsMainDb = new clsMainDb();
        public string SchduleID { get; set; }
        public int StudentID { get; set; }
        public int action { get; set; }
        public string note { get; set; }
        public int ID { get; set; }
        public int RID { get; set; }
        public string registrationDate { get; set; }
        

        public void SaveData()
        {
            try
            {
                objclsMainDb.databasecon();
                SqlCommand sql = new SqlCommand("Insert_Register", objclsMainDb.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@para1", SchduleID);
                sql.Parameters.AddWithValue("@StudentID", StudentID);
                sql.Parameters.AddWithValue("@note", note);
                sql.Parameters.AddWithValue("@user", ID);
                sql.Parameters.AddWithValue("@registrationdate", registrationDate);
                sql.Parameters.AddWithValue("@action", action);
                sql.Parameters.AddWithValue("@ID", RID);

                sql.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                objclsMainDb.con.Close();
            }

        }
    }

}
