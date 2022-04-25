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
    public partial class LNDataBaseFunctions : Form
    {
        public LNDataBaseFunctions()
        {
            InitializeComponent();
        }

        private void LNDataBaseFunctions_Load(object sender, EventArgs e)
        {
            DatabaseFunctions.Refresh(this.dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseFunctions.Insert(ModuletextBox.Text,TableNametextBox.Text,TableNumbertextBox.Text);
            DatabaseFunctions.Refresh(this.dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseFunctions.Delete(ModuletextBox.Text, TableNametextBox.Text, TableNumbertextBox.Text);
            DatabaseFunctions.Refresh(this.dataGridView1);
        }
    }
}
