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
    class clsStudent
    {
        public int StudetnID { get; set; }
        public string Name { get; set; }
        public String Phone { get; set; }
        public string NRC { get; set; }
        public string Gmail { get; set; }
        public string Address { get; set; }
        public int Action { get; set; }
        String key = "Kmd123!@#";
        clsMainDb obj_clsmainDb = new clsMainDb();

        public void saveData()
        {
            try
            {
                obj_clsmainDb.databasecon();
                SqlCommand sql = new SqlCommand("Insert_Student", obj_clsmainDb.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@StudentID", StudetnID);
                sql.Parameters.AddWithValue("@StudentName", Name);
                sql.Parameters.AddWithValue("@Phone", Phone);
                sql.Parameters.AddWithValue("@NRC", NRC);
                sql.Parameters.AddWithValue("@Gmail", Gmail);
                sql.Parameters.AddWithValue("@Address", Address);
                sql.Parameters.AddWithValue("@Action", Action);
                sql.Parameters.AddWithValue("@key", key);
                sql.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                obj_clsmainDb.con.Close();
            }
        }
    }
}
