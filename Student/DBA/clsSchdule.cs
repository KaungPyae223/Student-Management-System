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
    class clsSchdule
    {
        clsMainDb objclsMainDb = new clsMainDb();
        public string SchduleID { get; set; }
        public int CoursseID { get; set; }
        public int roomID { get; set; }
        public int SectionID { get; set; }
        public int TimeID { get; set; }
        
        public string start { get; set; }
        public int action { get; set; }


        public void SaveData()
        {
            try
            {
                objclsMainDb.databasecon();
                SqlCommand sql = new SqlCommand("Insert_Schdule", objclsMainDb.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@suID", SchduleID);
                sql.Parameters.AddWithValue("@couID", CoursseID);
                sql.Parameters.AddWithValue("@roomID", roomID);
                sql.Parameters.AddWithValue("@SectionID", SectionID);
                sql.Parameters.AddWithValue("@timeID", TimeID);
                sql.Parameters.AddWithValue("@start", start);
                sql.Parameters.AddWithValue("@userID", Program.ID);
                sql.Parameters.AddWithValue("@action", action);
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
