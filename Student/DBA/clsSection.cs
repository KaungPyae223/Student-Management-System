using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.DBA;
using System.Data;
using System.Data.SqlClient;
namespace Student.DBA
{
    class clsSection
    {
        clsMainDb obj_clsMainDB = new clsMainDb();
        public string SectionName { get; set; }
        public string day { get; set; }
        public int action { get; set; }
        public int id { get; set; }
        public void saveData()
        {
            obj_clsMainDB.databasecon();
            SqlCommand sql = new SqlCommand("Insert_Section", obj_clsMainDB.con);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@Name", SectionName);
            sql.Parameters.AddWithValue("@day", day);
            sql.Parameters.AddWithValue("@action", action);
            sql.Parameters.AddWithValue("@ID", id);
            sql.ExecuteNonQuery();
            obj_clsMainDB.con.Close();
        }
    }
}
