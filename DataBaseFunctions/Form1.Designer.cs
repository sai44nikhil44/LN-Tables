namespace DataBaseFunctions
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.InsertBox = new System.Windows.Forms.TextBox();
            this.UpdateUser2Box = new System.Windows.Forms.TextBox();
            this.UpdateUser1Box = new System.Windows.Forms.TextBox();
            this.DeleteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(282, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(441, 12);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(781, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InsertBox
            // 
            this.InsertBox.Location = new System.Drawing.Point(318, 12);
            this.InsertBox.Name = "InsertBox";
            this.InsertBox.Size = new System.Drawing.Size(100, 22);
            this.InsertBox.TabIndex = 5;
            // 
            // UpdateUser2Box
            // 
            this.UpdateUser2Box.Location = new System.Drawing.Point(860, 13);
            this.UpdateUser2Box.Name = "UpdateUser2Box";
            this.UpdateUser2Box.Size = new System.Drawing.Size(100, 22);
            this.UpdateUser2Box.TabIndex = 6;
            // 
            // UpdateUser1Box
            // 
            this.UpdateUser1Box.Location = new System.Drawing.Point(650, 13);
            this.UpdateUser1Box.Name = "UpdateUser1Box";
            this.UpdateUser1Box.Size = new System.Drawing.Size(125, 22);
            this.UpdateUser1Box.TabIndex = 7;
            // 
            // DeleteBox
            // 
            this.DeleteBox.Location = new System.Drawing.Point(318, 53);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(100, 22);
            this.DeleteBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(443, 291);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(162, 48);
            this.openFile.TabIndex = 10;
            this.openFile.Text = "Open  file";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 545);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBox);
            this.Controls.Add(this.UpdateUser1Box);
            this.Controls.Add(this.UpdateUser2Box);
            this.Controls.Add(this.InsertBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox InsertBox;
        private System.Windows.Forms.TextBox UpdateUser2Box;
        private System.Windows.Forms.TextBox UpdateUser1Box;
        private System.Windows.Forms.TextBox DeleteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFile;
    }
}

