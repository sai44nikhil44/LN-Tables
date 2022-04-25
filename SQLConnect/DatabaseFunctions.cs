using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SQLConnect
{
    static class DatabaseFunctions
    {
        static private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        
        // To display DataSet in Dataview Grid
        static public void Refresh(DataGridView _dataGridView)
        {
            try
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM LN_Table_TableNumbers", connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                connection.Close();
            }
        }

        static public void Insert(string _module,string _tbname,string _tbnumber)
        {
            try
            {

                connection.Open();
                SqlCommand _commandInsert = new SqlCommand("INSERT INTO LN_Table_TableNumbers VALUES (@module,@tbname,@tbnumber)", connection);
                _commandInsert.Parameters.Add("@module", _module);
                _commandInsert.Parameters.Add("@tbname", _tbname);
                _commandInsert.Parameters.Add("@tbnumber", _tbnumber);
                _commandInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void Delete(string _module, string _tbname, string _tbnumber)
        {
            try
            {
                connection.Open();
                if(_module != "" && _tbname == "" && _tbnumber == "")
                {
                    SqlCommand _Delete = new SqlCommand("DELETE FROM LN_Table_TableNumbers where Module = @module", connection);
                    _Delete.Parameters.Add("@module", _module);
                    _Delete.ExecuteNonQuery();
                }

                else if (_module == "" && _tbname != "" && _tbnumber == "")
                {
                    SqlCommand _Delete = new SqlCommand("DELETE FROM LN_Table_TableNumbers where TableName = @tbname", connection);
                    _Delete.Parameters.Add("@tbname", _tbname);
                    _Delete.ExecuteNonQuery();
                }
                else if (_module == "" && _tbname == "" && _tbnumber != "")
                {
                    SqlCommand _Delete = new SqlCommand("DELETE FROM LN_Table_TableNumbers where Number = @tbnumber", connection);
                    _Delete.Parameters.Add("@tbnumber", _tbnumber);
                    _Delete.ExecuteNonQuery();
                }
                else if (_module != "" && _tbname != "" && _tbnumber != "")
                {
                    SqlCommand _Delete = new SqlCommand("DELETE FROM LN_Table_TableNumbers where TableName = @tbname and Number = @tbnumber and Module = @module", connection);
                    _Delete.Parameters.Add("@module", _module);
                    _Delete.Parameters.Add("@tbname", _tbname);
                    _Delete.Parameters.Add("@tbnumber", _tbnumber);
                    _Delete.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
