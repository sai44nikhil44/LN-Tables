using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConnect
{
    public partial class Credentials : Form
    {
        public Credentials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UsertextBox.Text == "admin" && PasswordtextBox.Text == "admin")
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Hide();
                LNDataBaseFunctions lNDataBaseFunctions = new LNDataBaseFunctions();
                lNDataBaseFunctions.ShowDialog();
            }
        }
    }
}
