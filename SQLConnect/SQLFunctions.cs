using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQLConnect
{
    static class SQLFunctions
    {
        //static private SqlConnection connection = new SqlConnection("Data Source=INHYNSTALLADA1;Initial Catalog=LN_Tables;Integrated Security=True");
        static private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        static public void Select(string _search,DataGridView _dataGridView)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select TableName,Number from LN_Table_TableNumbers where TableName = @tablename", connection);
                command.Parameters.Add("@tablename", _search);
                SqlDataAdapter _select = new SqlDataAdapter(command);
                
                DataTable dataTable = new DataTable();
                
                _select.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void SelectNumber(string _search, DataGridView _dataGridView)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select TableName,Number from LN_Table_TableNumbers where Number = @Number", connection);
                command.Parameters.Add("@Number", _search);
                SqlDataAdapter _select = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();

                _select.Fill(dataTable);
                _dataGridView.DataSource = dataTable;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }


        static public void SelectFromFile(string _file,char seperator, DataGridView _dataGridView)
        {
            try
            {
                
                string txt = System.IO.File.ReadAllText(_file);
                string[] Tnames = txt.Split(seperator);
                               
                connection.Open();
                DataTable dataTable = new DataTable();
                foreach (string name in Tnames)
                {
                    
                    SqlCommand command = new SqlCommand("select TableName,Number from LN_Table_TableNumbers where TableName = @tablename", connection);
                    command.Parameters.Add("@tablename", name);
                    SqlDataAdapter _select = new SqlDataAdapter(command);
                    
                    _select.Fill(dataTable);
                }
                _dataGridView.DataSource = dataTable;


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void SelectNumberFromFile(string _file, char seperator, DataGridView _dataGridView)
        {
            try
            {

                string txt = System.IO.File.ReadAllText(_file);
                string[] TNumbers = txt.Split(seperator);

                connection.Open();
                DataTable dataTable = new DataTable();
                foreach (string number in TNumbers)
                {

                    SqlCommand command = new SqlCommand("select TableName,Number from LN_Table_TableNumbers where Number = @Number", connection);
                    command.Parameters.Add("@Number", number);
                    SqlDataAdapter _select = new SqlDataAdapter(command);

                    _select.Fill(dataTable);
                }
                _dataGridView.DataSource = dataTable;


            }
            catch (SqlException ex)
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
