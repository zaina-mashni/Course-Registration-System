using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_System
{
    public partial class SignIn : Form
    {
        University university;
        public SignIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            university = new University();
            string[] depts = university.getDepartments().ToArray();
            Register_Department.Items.Clear();
            Register_Department.Items.AddRange(depts);
        }

        private void Login_Email_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void Register_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string email = Login_Email.Text;
            string password = Login_Password.Text;
            if (email == "" || password == "")
            {
                MessageBox.Show("Enter email and password to login.", "Error");
            }
            else
            {
                User.Email = email;
                User.Password = password;
                if (User.login())
                {
                    MessageBox.Show("Login successful");
                    var mainForm = new Main();
                    this.Visible = false;
                    mainForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Email or password is incorrect!");
                }
            }
        }
        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            string name = Register_Name.Text;
            string email = Register_Email.Text;
            string password = Register_Password.Text;
            string confirmPassword = Register_CPassword.Text;
            if (email == "" || password == "" || name == "" || confirmPassword == "" || (!Male.Checked && !Female.Checked) || Register_Department.SelectedIndex == -1 || Register_Major.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required to register.", "Error");
            }
            else
            {
                string dept = Register_Department.SelectedItem.ToString();
                string major = Register_Major.SelectedItem.ToString();
                string gender = "";
                if (Male.Checked)
                    gender = "male";
                else
                    gender = "female";
                User.Email = email;
                User.Password = password;
                User.Gender = gender;
                User.Name = name;
                User.CPassword = confirmPassword;
                User.Department = university.getDepartmentId(dept);
                User.Major = university.getMajorId(major);
                string output = "";
                //validate input
                if (User.Department == -1 || User.Major == -1)
                {
                    MessageBox.Show("Database error occured.", "Error");
                    return;
                }
                if (!User.checkEmail())
                {
                    output += "Email must be a valid email address.\n";
                }
                if (!User.checkPassword())
                {
                    output += "Password and confirm password must match.\n";
                }
                if (User.checkExists())
                {
                    output += "Email already exists.\n";
                }
                if (output != "")
                {
                    MessageBox.Show(output, "Error");
                }
                else
                {
                    if (User.createAccount())
                        MessageBox.Show("Account created successfully!");
                    else
                        MessageBox.Show("Database error occured.", "Error");
                }

            }

        }

        private void Register_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept = Register_Department.SelectedItem.ToString();
            string[] majors = university.getMajors(dept).ToArray();
            Register_Major.Items.Clear();
            Register_Major.Items.AddRange(majors);
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }
    }
}
