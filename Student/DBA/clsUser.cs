using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Student.DBA
{
    class clsUser
    {
        public string name { get; set; }
        public string Password { get; set; }
        public string Level { get; set; }
        public int Action { get; set; }        
        public int ID { get; set; }
        public void saveData()
        {
            clsMainDb objClsMain = new clsMainDb();
            try
            {
                objClsMain.databasecon();
                SqlCommand sql = new SqlCommand("Insert_User", objClsMain.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@name", name);
                sql.Parameters.AddWithValue("@password", Password);
                sql.Parameters.AddWithValue("@Level", Level);
                sql.Parameters.AddWithValue("@id", ID);
                sql.Parameters.AddWithValue("@action", Action);
                sql.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                objClsMain.con.Close();
            }
        }
    }
}
