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
    class clsCourse
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public string Duriation { get; set; }
        public string Detail { get; set; }
        public string shortform { get; set; }
        public int action { get; set; }
        public int Fee { get; set; }

        public void saveData()
        {
            clsMainDb objClsMain = new clsMainDb();
            try
            {
                objClsMain.databasecon();
                SqlCommand sql = new SqlCommand("Insert_Course", objClsMain.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@ID", ID);
                sql.Parameters.AddWithValue("@Action", action);
                sql.Parameters.AddWithValue("@Detail", Detail);
                sql.Parameters.AddWithValue("@Fee", Fee);
                sql.Parameters.AddWithValue("@Name", CourseName);
                sql.Parameters.AddWithValue("@ShortForm", shortform);
                sql.Parameters.AddWithValue("@duriation", Duriation);
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
