using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DataBaseFunctions
{
    static class SQLFunctions
    {
        //AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\extrafiles\c#\DataBaseFunctions");
        static private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:|DataDirectory|\Database.mdf;Integrated Security=True");

        static public void Refresh(DataGridView _dataGridView)
        {
            try
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Table]",connection);
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

        static public void Insert(string _username)
        {
            try
            {

                connection.Open();
                SqlCommand _commandInsert = new SqlCommand("INSERT INTO [Table] VALUES (@username)", connection);
                _commandInsert.Parameters.Add("@username", _username);
                _commandInsert.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void Delete(string _username)
        {
            try
            {
                connection.Open();
                SqlCommand _Delete = new SqlCommand("DELETE FROM [Table] where Username = @username", connection);
                _Delete.Parameters.Add("@username", _username);
                _Delete.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void Update(string _username1,string _username2)
        {
            try
            {
                connection.Open();
                SqlCommand _update = new SqlCommand("UPDATE [Table] SET Username = @username2 where Username = @username1", connection);
                _update.Parameters.Add("@username1",_username1);
                _update.Parameters.Add("@username2", _username2);
                _update.ExecuteNonQuery();
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
