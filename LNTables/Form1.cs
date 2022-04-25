using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LNTables
{
    public partial class ConfigForm : Form
    {
        string server = "";
        string user = "";
        string pwd = "";
        string connstr = "";
        bool registered = false;
        public ConfigForm()
        {
            InitializeComponent();
            
        }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            server = ServertextBox.Text;
            user = usertextBox.Text;
            pwd = passwordtextBox.Text;
            
            if(WindowsradioButton.Checked == true)
            {
                connstr = @"Data Source= {0};Initial Catalog=master;Integrated Security=True";
                connstr = string.Format(connstr, server);
                
                SQLConnection.Connect(connstr,server);
                registered = true;
                XMLGeneration.GetData();
                MessageBox.Show(XMLGeneration.user);



            }
            else if(SQLServerradioButton.Checked == true)
            {
                //SQLCredgroupBox.Visible = true;
                connstr = @"Data Source={0};Initial Catalog=master;Persist Security Info=True;User ID={1};Password={2}";
                connstr = string.Format(connstr, server, user, pwd);
                SQLConnection.Connect(connstr,server);
                registered = true;

            }
            XMLGeneration.Generate(ServertextBox.Text, usertextBox.Text, passwordtextBox.Text, registered);
            
            
        }

        private void SQLServerradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SQLCredgroupBox.Visible = true;
        }

        private void WindowsradioButton_CheckedChanged(object sender, EventArgs e)
        {
            SQLCredgroupBox.Visible = false;
        }
    }
}
