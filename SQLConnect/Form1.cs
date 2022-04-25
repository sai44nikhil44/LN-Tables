using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQLConnect
{
    public partial class Form1 : Form
    {
        string filename = "";
        string NumberFileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            
             if (SearchTextBox.Text != "")
            {
                SQLFunctions.Select(SearchTextBox.Text, this.dataGridView1);
                //SearchTextBox.Clear(); 
            }
           
            else if (OpenFIle.Text != "" && SearchTextBox.Text == "" && NumberSearchtextBox.Text == "" && NumberSeperatorTextBox.Text == "")
            {
                try
                {
                    
                    string seperateChar = SeperatorTextBox.Text;

                    char seperator = Convert.ToChar(seperateChar);
                    SQLFunctions.SelectFromFile(filename, seperator, this.dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Specify the seperator");
                }
            }

            else if (NumberSearchtextBox.Text != "")
            {
                SQLFunctions.SelectNumber(NumberSearchtextBox.Text, this.dataGridView1);
            }
            else if (OpenNumberFile.Text != "" && SearchTextBox.Text == "" && NumberSearchtextBox.Text == "" && SeperatorTextBox.Text == "") 
            {
                try
                {

                    string seperateChar = NumberSeperatorTextBox.Text;

                    char seperator = Convert.ToChar(seperateChar);
                    SQLFunctions.SelectNumberFromFile(NumberFileName, seperator, this.dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Specify the seperator");
                }
            }
            else
            {
                MessageBox.Show("Enter Table Name or Choose a File");
            }

            
        }

        private void OpenFIle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog.FileName;
            }
            string[] file = filename.Split('\\');
            filenameTextBox.Text = file[2];
            SearchTextBox.Clear();
        }

        private void OpenNumberFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                NumberFileName = openFileDialog.FileName;
            }
            string[] file = NumberFileName.Split('\\');
            NumberFileNametextBox.Text = file[2];
            NumberSearchtextBox.Clear();
        }

        private void NumberSearchtextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            NumberSeperatorTextBox.Clear();
            SeperatorTextBox.Clear();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            NumberSearchtextBox.Clear();
            NumberSeperatorTextBox.Clear();
            SeperatorTextBox.Clear();

        }

        private void filenameTextBox_TextChanged(object sender, EventArgs e)
        {
            //NumberFileNametextBox.Clear();
            NumberSeperatorTextBox.Clear();
        }

        private void NumberFileNametextBox_TextChanged(object sender, EventArgs e)
        {
            //filenameTextBox.Clear();
            SeperatorTextBox.Clear();
        }

        private void SeperatorTextBox_TextChanged(object sender, EventArgs e)
        {
            NumberSeperatorTextBox.Clear();
            NumberSearchtextBox.Clear();
            SearchTextBox.Clear();
        }

        private void NumberSeperatorTextBox_TextChanged(object sender, EventArgs e)
        {
            
            SearchTextBox.Clear();
            SeperatorTextBox.Clear();
            NumberSearchtextBox.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Credentials credentials = new Credentials();
            credentials.ShowDialog();
        }
    }
}
