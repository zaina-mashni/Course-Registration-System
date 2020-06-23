namespace Course_Registration_System
{
    partial class Main
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
            this.Course_Table = new System.Windows.Forms.DataGridView();
            this.Selected_Course = new System.Windows.Forms.TextBox();
            this.Add_Course = new System.Windows.Forms.Button();
            this.Register_Table = new System.Windows.Forms.DataGridView();
            this.TotalHours = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.CreateFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Drop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Logout = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Credit = new System.Windows.Forms.TextBox();
            this.CourseView = new System.Windows.Forms.ListView();
            this.Course_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Course_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credit_Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Dept = new System.Windows.Forms.TextBox();
            this.Major = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Info_Lable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Course_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Register_Table)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Course_Table
            // 
            this.Course_Table.AllowUserToAddRows = false;
            this.Course_Table.AllowUserToDeleteRows = false;
            this.Course_Table.AllowUserToOrderColumns = true;
            this.Course_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Course_Table.Location = new System.Drawing.Point(20, 30);
            this.Course_Table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Course_Table.MultiSelect = false;
            this.Course_Table.Name = "Course_Table";
            this.Course_Table.ReadOnly = true;
            this.Course_Table.RowTemplate.Height = 24;
            this.Course_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Course_Table.Size = new System.Drawing.Size(449, 163);
            this.Course_Table.TabIndex = 2;
            this.Course_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Course_Table_CellContentClick);
            // 
            // Selected_Course
            // 
            this.Selected_Course.Location = new System.Drawing.Point(195, 244);
            this.Selected_Course.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Selected_Course.Name = "Selected_Course";
            this.Selected_Course.Size = new System.Drawing.Size(236, 22);
            this.Selected_Course.TabIndex = 3;
            this.Selected_Course.TextChanged += new System.EventHandler(this.Selected_Course_TextChanged);
            // 
            // Add_Course
            // 
            this.Add_Course.BackColor = System.Drawing.Color.Cornsilk;
            this.Add_Course.Location = new System.Drawing.Point(450, 240);
            this.Add_Course.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add_Course.Name = "Add_Course";
            this.Add_Course.Size = new System.Drawing.Size(82, 31);
            this.Add_Course.TabIndex = 4;
            this.Add_Course.Text = "Register";
            this.Add_Course.UseVisualStyleBackColor = false;
            this.Add_Course.Click += new System.EventHandler(this.Add_Course_Click);
            // 
            // Register_Table
            // 
            this.Register_Table.AllowUserToAddRows = false;
            this.Register_Table.AllowUserToOrderColumns = true;
            this.Register_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Register_Table.Location = new System.Drawing.Point(20, 309);
            this.Register_Table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Register_Table.MultiSelect = false;
            this.Register_Table.Name = "Register_Table";
            this.Register_Table.ReadOnly = true;
            this.Register_Table.RowTemplate.Height = 24;
            this.Register_Table.Size = new System.Drawing.Size(644, 180);
            this.Register_Table.TabIndex = 5;
            this.Register_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Register_Table_CellContentClick);
            // 
            // TotalHours
            // 
            this.TotalHours.BackColor = System.Drawing.Color.White;
            this.TotalHours.Location = new System.Drawing.Point(778, 105);
            this.TotalHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalHours.Name = "TotalHours";
            this.TotalHours.ReadOnly = true;
            this.TotalHours.Size = new System.Drawing.Size(62, 22);
            this.TotalHours.TabIndex = 6;
            this.TotalHours.TextChanged += new System.EventHandler(this.TotalHours_TextChanged);
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.White;
            this.TotalPrice.Location = new System.Drawing.Point(754, 148);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(86, 22);
            this.TotalPrice.TabIndex = 7;
            this.TotalPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CreateFile
            // 
            this.CreateFile.BackColor = System.Drawing.Color.Cornsilk;
            this.CreateFile.Location = new System.Drawing.Point(750, 196);
            this.CreateFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(90, 32);
            this.CreateFile.TabIndex = 8;
            this.CreateFile.Text = "Confirm";
            this.CreateFile.UseVisualStyleBackColor = false;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Available Courses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registered Courses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selected Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Credit Hours Registered:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Price in JD:";
            // 
            // Drop
            // 
            this.Drop.BackColor = System.Drawing.Color.Cornsilk;
            this.Drop.Location = new System.Drawing.Point(538, 240);
            this.Drop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Drop.Name = "Drop";
            this.Drop.Size = new System.Drawing.Size(75, 31);
            this.Drop.TabIndex = 14;
            this.Drop.Text = "Drop";
            this.Drop.UseVisualStyleBackColor = false;
            this.Drop.Click += new System.EventHandler(this.Drop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 526);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Controls.Add(this.Logout);
            this.tabPage1.Controls.Add(this.Course_Table);
            this.tabPage1.Controls.Add(this.Drop);
            this.tabPage1.Controls.Add(this.TotalHours);
            this.tabPage1.Controls.Add(this.Add_Course);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.CreateFile);
            this.tabPage1.Controls.Add(this.Selected_Course);
            this.tabPage1.Controls.Add(this.TotalPrice);
            this.tabPage1.Controls.Add(this.Register_Table);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(871, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register Courses";
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Cornsilk;
            this.Logout.Location = new System.Drawing.Point(750, 30);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(90, 41);
            this.Logout.TabIndex = 15;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.Cost);
            this.tabPage2.Controls.Add(this.Credit);
            this.tabPage2.Controls.Add(this.CourseView);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.Dept);
            this.tabPage2.Controls.Add(this.Major);
            this.tabPage2.Controls.Add(this.Gender);
            this.tabPage2.Controls.Add(this.Email);
            this.tabPage2.Controls.Add(this.UserName);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Info_Lable);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(871, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registration Information";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(573, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update Information";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(475, 270);
            this.Cost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Size = new System.Drawing.Size(100, 24);
            this.Cost.TabIndex = 16;
            // 
            // Credit
            // 
            this.Credit.Location = new System.Drawing.Point(216, 270);
            this.Credit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Size = new System.Drawing.Size(100, 24);
            this.Credit.TabIndex = 15;
            // 
            // CourseView
            // 
            this.CourseView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Course_ID,
            this.Course_Name,
            this.Credit_Hours,
            this.Time,
            this.Department_Name,
            this.Price});
            this.CourseView.FullRowSelect = true;
            this.CourseView.GridLines = true;
            this.CourseView.HideSelection = false;
            this.CourseView.Location = new System.Drawing.Point(83, 305);
            this.CourseView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseView.Name = "CourseView";
            this.CourseView.Size = new System.Drawing.Size(699, 186);
            this.CourseView.TabIndex = 14;
            this.CourseView.UseCompatibleStateImageBehavior = false;
            this.CourseView.View = System.Windows.Forms.View.Details;
            // 
            // Course_ID
            // 
            this.Course_ID.Text = "Course ID";
            this.Course_ID.Width = 90;
            // 
            // Course_Name
            // 
            this.Course_Name.Text = "Course Name";
            this.Course_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Course_Name.Width = 150;
            // 
            // Credit_Hours
            // 
            this.Credit_Hours.Text = "Credit";
            this.Credit_Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Credit_Hours.Width = 70;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time.Width = 150;
            // 
            // Department_Name
            // 
            this.Department_Name.Text = "Department Name";
            this.Department_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Department_Name.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Credit Hours:";
            // 
            // Dept
            // 
            this.Dept.Location = new System.Drawing.Point(573, 166);
            this.Dept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dept.Name = "Dept";
            this.Dept.ReadOnly = true;
            this.Dept.Size = new System.Drawing.Size(183, 24);
            this.Dept.TabIndex = 11;
            // 
            // Major
            // 
            this.Major.Location = new System.Drawing.Point(564, 117);
            this.Major.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(183, 24);
            this.Major.TabIndex = 10;
            this.Major.TextChanged += new System.EventHandler(this.Major_TextChanged);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(167, 220);
            this.Gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Size = new System.Drawing.Size(176, 24);
            this.Gender.TabIndex = 9;
            this.Gender.TextChanged += new System.EventHandler(this.Gender_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(167, 170);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(178, 24);
            this.Email.TabIndex = 8;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(167, 122);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(178, 24);
            this.UserName.TabIndex = 7;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Major:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name:";
            // 
            // Info_Lable
            // 
            this.Info_Lable.AutoSize = true;
            this.Info_Lable.ForeColor = System.Drawing.Color.Tomato;
            this.Info_Lable.Location = new System.Drawing.Point(153, 60);
            this.Info_Lable.Name = "Info_Lable";
            this.Info_Lable.Size = new System.Drawing.Size(534, 18);
            this.Info_Lable.TabIndex = 1;
            this.Info_Lable.Text = "Fill in the details in \'Register Courses\' tab then click \'Confirm\' to view.";
            this.Info_Lable.Click += new System.EventHandler(this.Info_Lable_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(354, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(879, 526);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Course_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Register_Table)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Course_Table;
        private System.Windows.Forms.TextBox Selected_Course;
        private System.Windows.Forms.Button Add_Course;
        private System.Windows.Forms.DataGridView Register_Table;
        private System.Windows.Forms.TextBox TotalHours;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Drop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label Info_Lable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox Credit;
        private System.Windows.Forms.ListView CourseView;
        private System.Windows.Forms.ColumnHeader Course_ID;
        private System.Windows.Forms.ColumnHeader Course_Name;
        private System.Windows.Forms.ColumnHeader Credit_Hours;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Department_Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Dept;
        private System.Windows.Forms.TextBox Major;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}