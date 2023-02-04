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
    class clsTime
    {
        int Hour, Minute;
        public int action { get; set; }
        public string Time{ get; set; }
        public int ID { get; set; }
        public void SetData(DateTime Time)
        {
            Hour = Convert.ToInt32(Time.Hour);
            Minute = Convert.ToInt32(Time.Minute);
        }
        public Boolean checktime(clsTime T1, clsTime T2)
        {
            T1.Minute += T1.Hour * 60;
            T2.Minute += T2.Hour * 60;
            if (T1.Minute > T2.Minute || T1.Minute == T2.Minute)
            {
                MessageBox.Show("End time must be greather than start time");
                return false;
            }
            return true;
        }
        public void saveData()
        {
            clsMainDb objClsMain = new clsMainDb();
            try
            {
                objClsMain.databasecon();
                SqlCommand sql = new SqlCommand("Insert_Time", objClsMain.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Time", Time);
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
                objClsMain.con.Close();
            }
        }
    }
}
