using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTables
{
    class SQLConnection
    {
        
        static public void Connect(string connstr,string server)
        {
            
            try
            {
                string script = "";
                SqlConnection cn;
                SqlCommand cm;
                //sqlConnection.Open();
                script = File.ReadAllText("RunScript.sql");
                //deletedb("LN_Tables", connstr);
                string[] ScriptSpilt = script.Split(new string[] { "Go" }, StringSplitOptions.None);

                using (cn = new SqlConnection(connstr))
                {
                    cn.Open();
                    foreach (string str in ScriptSpilt)
                    {
                        using (cm = cn.CreateCommand())
                        {
                            cm.CommandText = str;
                            cm.ExecuteNonQuery();
                            
                        }
                    }
                    cn.Close();
                }
                ExceltoSQL(server);
                
                MessageBox.Show("Connection succeeded");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private static void ExceltoSQL(string server)
        {
            try
            {
                string connstr = @"Data Source= {0};Initial Catalog=LN_Tables;Integrated Security=True";
                connstr = string.Format(connstr, server);
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|LNImportData.xlsx;Extended Properties=Excel 12.0"))
                {
                    con.Open();
                    string Query = string.Format("Select [Module],[Name],[Number] FROM [{0}]", "Sheet1$");
                    OleDbCommand com = new OleDbCommand(Query, con);
                    OleDbDataReader dr = com.ExecuteReader();
                    using (SqlConnection sqlcon = new SqlConnection(connstr))
                    {
                        sqlcon.Open();
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(sqlcon))
                        {
                            bulkCopy.ColumnMappings.Add("Module", "Module");
                            bulkCopy.ColumnMappings.Add("Name", "TableName");
                            bulkCopy.ColumnMappings.Add("Number", "Number");
                            bulkCopy.DestinationTableName = "LN_Table_TableNumbers";
                            bulkCopy.WriteToServer(dr);
                        }
                        sqlcon.Close();
                    }
                    
                    dr.Close();
                    dr.Dispose();
                    con.Close();
                }
                MessageBox.Show("Upload Successfull!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        static private void deletedb(string db,string connstr)
        {
            try
            {
                SqlConnection cn;
                SqlCommand cm;
                cn = new SqlConnection(connstr);
                cm = new SqlCommand(string.Format("drop database {0}",db),cn);
                //cm.Parameters.Add("@db", db);
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
