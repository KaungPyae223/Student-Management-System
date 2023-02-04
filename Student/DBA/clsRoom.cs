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
    
    class clsRoom
    {
        clsMainDb objclsMainDb = new clsMainDb();
        public string roomname { get; set; }
        public int available { get; set; }
        public int action { get; set; }
        public int ID { get; set; }
        public void SaveData()
        {
            try
            {
                objclsMainDb.databasecon();
                SqlCommand sql = new SqlCommand("Insert_Room", objclsMainDb.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@roomname", roomname);
                sql.Parameters.AddWithValue("@available", available);
                sql.Parameters.AddWithValue("@action", action);
                sql.Parameters.AddWithValue("@ID", ID);
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
