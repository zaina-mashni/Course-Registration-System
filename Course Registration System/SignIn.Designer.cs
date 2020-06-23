namespace Course_Registration_System
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.Login_Email = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.TabPage();
            this.Register_Major = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Register_Department = new System.Windows.Forms.ComboBox();
            this.Register_Button = new System.Windows.Forms.Button();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Register_CPassword = new System.Windows.Forms.TextBox();
            this.Register_Password = new System.Windows.Forms.TextBox();
            this.Register_Email = new System.Windows.Forms.TextBox();
            this.Register_Name = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.Register);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 583);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Linen;
            this.Login.Controls.Add(this.pictureBox1);
            this.Login.Controls.Add(this.Login_Button);
            this.Login.Controls.Add(this.label2);
            this.Login.Controls.Add(this.label1);
            this.Login.Controls.Add(this.Login_Password);
            this.Login.Controls.Add(this.Login_Email);
            this.Login.Location = new System.Drawing.Point(4, 29);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(976, 550);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Button.BackColor = System.Drawing.Color.White;
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Location = new System.Drawing.Point(400, 440);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(134, 61);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // Login_Password
            // 
            this.Login_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Password.Location = new System.Drawing.Point(346, 375);
            this.Login_Password.MaxLength = 20;
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.Size = new System.Drawing.Size(249, 27);
            this.Login_Password.TabIndex = 1;
            this.Login_Password.UseSystemPasswordChar = true;
            this.Login_Password.TextChanged += new System.EventHandler(this.Login_Password_TextChanged);
            // 
            // Login_Email
            // 
            this.Login_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Email.Location = new System.Drawing.Point(346, 266);
            this.Login_Email.MaxLength = 30;
            this.Login_Email.Name = "Login_Email";
            this.Login_Email.Size = new System.Drawing.Size(249, 27);
            this.Login_Email.TabIndex = 0;
            this.Login_Email.TextChanged += new System.EventHandler(this.Login_Email_TextChanged);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Linen;
            this.Register.Controls.Add(this.Register_Major);
            this.Register.Controls.Add(this.label9);
            this.Register.Controls.Add(this.label8);
            this.Register.Controls.Add(this.Register_Department);
            this.Register.Controls.Add(this.Register_Button);
            this.Register.Controls.Add(this.Female);
            this.Register.Controls.Add(this.Male);
            this.Register.Controls.Add(this.label7);
            this.Register.Controls.Add(this.label6);
            this.Register.Controls.Add(this.label5);
            this.Register.Controls.Add(this.label4);
            this.Register.Controls.Add(this.label3);
            this.Register.Controls.Add(this.Register_CPassword);
            this.Register.Controls.Add(this.Register_Password);
            this.Register.Controls.Add(this.Register_Email);
            this.Register.Controls.Add(this.Register_Name);
            this.Register.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(4, 29);
            this.Register.Name = "Register";
            this.Register.Padding = new System.Windows.Forms.Padding(3);
            this.Register.Size = new System.Drawing.Size(976, 550);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            // 
            // Register_Major
            // 
            this.Register_Major.FormattingEnabled = true;
            this.Register_Major.Location = new System.Drawing.Point(493, 340);
            this.Register_Major.Name = "Register_Major";
            this.Register_Major.Size = new System.Drawing.Size(187, 27);
            this.Register_Major.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Major";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Department";
            // 
            // Register_Department
            // 
            this.Register_Department.FormattingEnabled = true;
            this.Register_Department.Items.AddRange(new object[] {
            "Information Technology",
            "Business",
            "Engineering"});
            this.Register_Department.Location = new System.Drawing.Point(493, 251);
            this.Register_Department.Name = "Register_Department";
            this.Register_Department.Size = new System.Drawing.Size(187, 27);
            this.Register_Department.TabIndex = 12;
            this.Register_Department.SelectedIndexChanged += new System.EventHandler(this.Register_Department_SelectedIndexChanged);
            // 
            // Register_Button
            // 
            this.Register_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Register_Button.BackColor = System.Drawing.Color.White;
            this.Register_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Register_Button.Location = new System.Drawing.Point(505, 452);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(144, 43);
            this.Register_Button.TabIndex = 11;
            this.Register_Button.Text = "Create Account";
            this.Register_Button.UseVisualStyleBackColor = false;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // Female
            // 
            this.Female.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(583, 143);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(84, 23);
            this.Female.TabIndex = 10;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(583, 109);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(67, 23);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // Register_CPassword
            // 
            this.Register_CPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register_CPassword.Location = new System.Drawing.Point(86, 380);
            this.Register_CPassword.MaxLength = 20;
            this.Register_CPassword.Name = "Register_CPassword";
            this.Register_CPassword.Size = new System.Drawing.Size(220, 27);
            this.Register_CPassword.TabIndex = 3;
            this.Register_CPassword.UseSystemPasswordChar = true;
            // 
            // Register_Password
            // 
            this.Register_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register_Password.Location = new System.Drawing.Point(86, 298);
            this.Register_Password.MaxLength = 20;
            this.Register_Password.Name = "Register_Password";
            this.Register_Password.Size = new System.Drawing.Size(220, 27);
            this.Register_Password.TabIndex = 2;
            this.Register_Password.UseSystemPasswordChar = true;
            // 
            // Register_Email
            // 
            this.Register_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register_Email.Location = new System.Drawing.Point(86, 207);
            this.Register_Email.MaxLength = 30;
            this.Register_Email.Name = "Register_Email";
            this.Register_Email.Size = new System.Drawing.Size(220, 27);
            this.Register_Email.TabIndex = 1;
            // 
            // Register_Name
            // 
            this.Register_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register_Name.Location = new System.Drawing.Point(86, 127);
            this.Register_Name.MaxLength = 20;
            this.Register_Name.Name = "Register_Name";
            this.Register_Name.Size = new System.Drawing.Size(220, 27);
            this.Register_Name.TabIndex = 0;
            this.Register_Name.TextChanged += new System.EventHandler(this.Register_Name_TextChanged);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 586);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Register.ResumeLayout(false);
            this.Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage Register;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_Password;
        private System.Windows.Forms.TextBox Login_Email;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Register_CPassword;
        private System.Windows.Forms.TextBox Register_Password;
        private System.Windows.Forms.TextBox Register_Email;
        private System.Windows.Forms.TextBox Register_Name;
        private System.Windows.Forms.ComboBox Register_Major;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Register_Department;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

