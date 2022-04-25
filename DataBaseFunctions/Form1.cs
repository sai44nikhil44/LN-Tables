using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLFunctions.Refresh(this.dataGridView1);


        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if(InsertBox.Text !="")
            {
                SQLFunctions.Insert(InsertBox.Text);
                SQLFunctions.Refresh(this.dataGridView1);
                InsertBox.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DeleteBox.Text !="")
            {
                SQLFunctions.Delete(DeleteBox.Text);
                SQLFunctions.Refresh(this.dataGridView1);
                DeleteBox.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(UpdateUser1Box.Text != "" && UpdateUser2Box.Text != "")
            {
                SQLFunctions.Update(UpdateUser1Box.Text, UpdateUser2Box.Text);
                SQLFunctions.Refresh(this.dataGridView1);
                UpdateUser1Box.Clear();
                UpdateUser2Box.Clear();
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                MessageBox.Show(filename);
            }
        }
    }
}
