namespace LNTables
{
    partial class ConfigForm
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
            this.serverlabel = new System.Windows.Forms.Label();
            this.ServertextBox = new System.Windows.Forms.TextBox();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.WindowsradioButton = new System.Windows.Forms.RadioButton();
            this.SQLServerradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SQLCredgroupBox = new System.Windows.Forms.GroupBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.userlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SQLCredgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverlabel
            // 
            this.serverlabel.AutoSize = true;
            this.serverlabel.Location = new System.Drawing.Point(62, 40);
            this.serverlabel.Name = "serverlabel";
            this.serverlabel.Size = new System.Drawing.Size(54, 17);
            this.serverlabel.TabIndex = 0;
            this.serverlabel.Text = "Server:";
            // 
            // ServertextBox
            // 
            this.ServertextBox.Location = new System.Drawing.Point(122, 40);
            this.ServertextBox.Name = "ServertextBox";
            this.ServertextBox.Size = new System.Drawing.Size(224, 22);
            this.ServertextBox.TabIndex = 2;
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(139, 425);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(139, 23);
            this.Connectbutton.TabIndex = 3;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // WindowsradioButton
            // 
            this.WindowsradioButton.AutoSize = true;
            this.WindowsradioButton.Location = new System.Drawing.Point(52, 33);
            this.WindowsradioButton.Name = "WindowsradioButton";
            this.WindowsradioButton.Size = new System.Drawing.Size(179, 21);
            this.WindowsradioButton.TabIndex = 4;
            this.WindowsradioButton.TabStop = true;
            this.WindowsradioButton.Text = "Windows Authentication";
            this.WindowsradioButton.UseVisualStyleBackColor = true;
            this.WindowsradioButton.CheckedChanged += new System.EventHandler(this.WindowsradioButton_CheckedChanged);
            // 
            // SQLServerradioButton
            // 
            this.SQLServerradioButton.AutoSize = true;
            this.SQLServerradioButton.Location = new System.Drawing.Point(52, 72);
            this.SQLServerradioButton.Name = "SQLServerradioButton";
            this.SQLServerradioButton.Size = new System.Drawing.Size(197, 21);
            this.SQLServerradioButton.TabIndex = 5;
            this.SQLServerradioButton.TabStop = true;
            this.SQLServerradioButton.Text = "SQL Server Authentication";
            this.SQLServerradioButton.UseVisualStyleBackColor = true;
            this.SQLServerradioButton.CheckedChanged += new System.EventHandler(this.SQLServerradioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SQLCredgroupBox);
            this.groupBox1.Controls.Add(this.SQLServerradioButton);
            this.groupBox1.Controls.Add(this.WindowsradioButton);
            this.groupBox1.Location = new System.Drawing.Point(38, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication Type";
            // 
            // SQLCredgroupBox
            // 
            this.SQLCredgroupBox.Controls.Add(this.passwordtextBox);
            this.SQLCredgroupBox.Controls.Add(this.usertextBox);
            this.SQLCredgroupBox.Controls.Add(this.passwordlabel);
            this.SQLCredgroupBox.Controls.Add(this.userlabel);
            this.SQLCredgroupBox.Location = new System.Drawing.Point(24, 112);
            this.SQLCredgroupBox.Name = "SQLCredgroupBox";
            this.SQLCredgroupBox.Size = new System.Drawing.Size(313, 151);
            this.SQLCredgroupBox.TabIndex = 6;
            this.SQLCredgroupBox.TabStop = false;
            this.SQLCredgroupBox.Visible = false;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(106, 81);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(194, 22);
            this.passwordtextBox.TabIndex = 3;
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // usertextBox
            // 
            this.usertextBox.Location = new System.Drawing.Point(106, 44);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.Size = new System.Drawing.Size(194, 22);
            this.usertextBox.TabIndex = 2;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(32, 85);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(73, 17);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password:";
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(24, 45);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(81, 17);
            this.userlabel.TabIndex = 0;
            this.userlabel.Text = "User name:";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.ServertextBox);
            this.Controls.Add(this.serverlabel);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SQLCredgroupBox.ResumeLayout(false);
            this.SQLCredgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverlabel;
        private System.Windows.Forms.TextBox ServertextBox;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.RadioButton WindowsradioButton;
        private System.Windows.Forms.RadioButton SQLServerradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox SQLCredgroupBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label userlabel;
    }
}

