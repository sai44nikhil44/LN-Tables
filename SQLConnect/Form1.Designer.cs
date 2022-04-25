namespace SQLConnect
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
            this.Connect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.OpenFIle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SeperatorLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.SeperatorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumberSearchtextBox = new System.Windows.Forms.TextBox();
            this.NumberSeperatorTextBox = new System.Windows.Forms.TextBox();
            this.OpenNumberFile = new System.Windows.Forms.Button();
            this.NumberFileNametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(636, 752);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(137, 34);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Search";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 644);
            this.dataGridView1.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(201, 39);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(223, 22);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // OpenFIle
            // 
            this.OpenFIle.Location = new System.Drawing.Point(200, 104);
            this.OpenFIle.Name = "OpenFIle";
            this.OpenFIle.Size = new System.Drawing.Size(189, 39);
            this.OpenFIle.TabIndex = 3;
            this.OpenFIle.Text = "Choose a File";
            this.OpenFIle.UseVisualStyleBackColor = true;
            this.OpenFIle.Click += new System.EventHandler(this.OpenFIle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note: file format (only .txt)";
            // 
            // SeperatorLabel
            // 
            this.SeperatorLabel.AutoSize = true;
            this.SeperatorLabel.Location = new System.Drawing.Point(114, 202);
            this.SeperatorLabel.Name = "SeperatorLabel";
            this.SeperatorLabel.Size = new System.Drawing.Size(75, 17);
            this.SeperatorLabel.TabIndex = 7;
            this.SeperatorLabel.Text = "Seperator:";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(114, 164);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(75, 17);
            this.fileLabel.TabIndex = 8;
            this.fileLabel.Text = "File Name:";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(200, 161);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.ReadOnly = true;
            this.filenameTextBox.Size = new System.Drawing.Size(189, 22);
            this.filenameTextBox.TabIndex = 9;
            this.filenameTextBox.TextChanged += new System.EventHandler(this.filenameTextBox_TextChanged);
            // 
            // SeperatorTextBox
            // 
            this.SeperatorTextBox.Location = new System.Drawing.Point(201, 199);
            this.SeperatorTextBox.MaxLength = 1;
            this.SeperatorTextBox.Name = "SeperatorTextBox";
            this.SeperatorTextBox.Size = new System.Drawing.Size(100, 22);
            this.SeperatorTextBox.TabIndex = 10;
            this.SeperatorTextBox.TextChanged += new System.EventHandler(this.SeperatorTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchTextBox);
            this.groupBox1.Controls.Add(this.SeperatorTextBox);
            this.groupBox1.Controls.Add(this.OpenFIle);
            this.groupBox1.Controls.Add(this.filenameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fileLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SeperatorLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(468, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 293);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Table Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumberSearchtextBox);
            this.groupBox2.Controls.Add(this.NumberSeperatorTextBox);
            this.groupBox2.Controls.Add(this.OpenNumberFile);
            this.groupBox2.Controls.Add(this.NumberFileNametextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(468, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 293);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find Table Name";
            // 
            // NumberSearchtextBox
            // 
            this.NumberSearchtextBox.Location = new System.Drawing.Point(200, 36);
            this.NumberSearchtextBox.Name = "NumberSearchtextBox";
            this.NumberSearchtextBox.Size = new System.Drawing.Size(223, 22);
            this.NumberSearchtextBox.TabIndex = 2;
            this.NumberSearchtextBox.TextChanged += new System.EventHandler(this.NumberSearchtextBox_TextChanged);
            // 
            // NumberSeperatorTextBox
            // 
            this.NumberSeperatorTextBox.Location = new System.Drawing.Point(200, 201);
            this.NumberSeperatorTextBox.MaxLength = 1;
            this.NumberSeperatorTextBox.Name = "NumberSeperatorTextBox";
            this.NumberSeperatorTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumberSeperatorTextBox.TabIndex = 10;
            this.NumberSeperatorTextBox.TextChanged += new System.EventHandler(this.NumberSeperatorTextBox_TextChanged);
            // 
            // OpenNumberFile
            // 
            this.OpenNumberFile.Location = new System.Drawing.Point(201, 102);
            this.OpenNumberFile.Name = "OpenNumberFile";
            this.OpenNumberFile.Size = new System.Drawing.Size(189, 39);
            this.OpenNumberFile.TabIndex = 3;
            this.OpenNumberFile.Text = "Choose a File";
            this.OpenNumberFile.UseVisualStyleBackColor = true;
            this.OpenNumberFile.Click += new System.EventHandler(this.OpenNumberFile_Click);
            // 
            // NumberFileNametextBox
            // 
            this.NumberFileNametextBox.Location = new System.Drawing.Point(201, 163);
            this.NumberFileNametextBox.Name = "NumberFileNametextBox";
            this.NumberFileNametextBox.ReadOnly = true;
            this.NumberFileNametextBox.Size = new System.Drawing.Size(189, 22);
            this.NumberFileNametextBox.TabIndex = 9;
            this.NumberFileNametextBox.TextChanged += new System.EventHandler(this.NumberFileNametextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "OR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "File Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Table Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Seperator:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Note: file format (only .txt)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Source Control";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(60, 776);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 111);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "For Admin ";
            // 
            // Form1
            // 
            this.AcceptButton = this.Connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LN Tables ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button OpenFIle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SeperatorLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.TextBox SeperatorTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NumberSearchtextBox;
        private System.Windows.Forms.TextBox NumberSeperatorTextBox;
        private System.Windows.Forms.Button OpenNumberFile;
        private System.Windows.Forms.TextBox NumberFileNametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

