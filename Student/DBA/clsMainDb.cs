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
    class clsMainDb
    {
        public SqlConnection con;
        DataSet ds = new DataSet();
        public void databasecon()
        {
            try
            {
                con = new SqlConnection(Student.Properties.Settings.Default.StudentCon);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error Message");
            }
        }
        public DataTable SelectData(string SPString)
        {
            DataTable DT = new DataTable();
            try
            {
                databasecon();
                SqlDataAdapter adpt = new SqlDataAdapter(SPString, con);
                adpt.Fill(DT);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ErrorMessage");
            }
            finally
            {
                con.Close();
            }
            return DT;
        }
        public void toolStripTextBoxdata(ref ToolStripTextBox tstToolStrip, string Sp, string fieldName)
        {
            DataTable DT = new DataTable();
            AutoCompleteStringCollection sourse = new AutoCompleteStringCollection();
            try
            {
                databasecon();
                SqlDataAdapter adpt = new SqlDataAdapter(Sp, con);
                adpt.Fill(DT);
                if (DT.Rows.Count > 0)
                {
                    tstToolStrip.AutoCompleteCustomSource.Clear();
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        sourse.Add(DT.Rows[i][fieldName].ToString());
                    }
                    tstToolStrip.AutoCompleteCustomSource = sourse;
                    tstToolStrip.Text = "";
                    tstToolStrip.Focus();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void TextBoxData(ref TextBox txtTextBox, string SPString, string FieldName)
        {
            DataTable DT = new DataTable();
            AutoCompleteStringCollection Source = new AutoCompleteStringCollection();

            txtTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            try
            {
                databasecon();
                SqlDataAdapter Adpt = new SqlDataAdapter(SPString, con);
                Adpt.Fill(DT);
                if (DT.Rows.Count > 0)
                {
                    txtTextBox.AutoCompleteCustomSource.Clear();
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        Source.Add(DT.Rows[i][FieldName].ToString());
                    }
                }
                txtTextBox.AutoCompleteCustomSource = Source;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        
    }
}
