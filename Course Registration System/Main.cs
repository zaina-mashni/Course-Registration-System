using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;



namespace Course_Registration_System
{
    public partial class Main : Form
    {
        private bool isConfirmed;
        DataTable courseTable;
        DataTable registeredTable;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            updateCourseTable();
            updateRgisterTable();
            updatePriceAndHours();
            isConfirmed = false; //is file generated
            Info_Lable.Text = "Fill in the details in 'Register Courses' tab then click 'Confirm' to view.";
        }
        private void updatePriceAndHours()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed to connect to database.", "Error");
                    return;
                }
                int registeredHour = 0;
                int price = 0;
                string sql = "SELECT * FROM registeredCourses WHERE u_email= '" + User.Email + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        sql = "SELECT sum(price*credit) AS 'price',sum(credit) AS 'hours' FROM registeredCourses r,courses c,departments d WHERE r.c_id=c.id AND c.d_id=d.id AND u_email= '" + User.Email + "'";
                        command = new SQLiteCommand(sql, m_dbConnection);
                        try
                        {
                            reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                if (reader["price"] == null || reader["hours"] == null)
                                {
                                    price = 0;
                                    registeredHour = 0;
                                }
                                price = reader.GetInt32(reader.GetOrdinal("price"));
                                registeredHour = reader.GetInt32(reader.GetOrdinal("hours"));
                            }
                            TotalPrice.Text = price.ToString();
                            TotalHours.Text = registeredHour.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Database error occured.\n{ex}");
                        }

                    }
                    else
                    {
                        TotalPrice.Text = price.ToString();
                        TotalHours.Text = registeredHour.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error occured.\n{ex}");
                }
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Course_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow course = Course_Table.Rows[e.RowIndex];
                Selected_Course.Text = course.Cells["Course Name"].Value.ToString();
            }
        }

        private void Selected_Course_TextChanged(object sender, EventArgs e)
        {

        }
        //check is any 2 lectures overlap
        private bool checkAdd(int idx)
        {
            DataGridViewRow course = Course_Table.Rows[idx];
            string[] courseTime = course.Cells["Lecture Time"].Value.ToString().Split(' ');
            string day = courseTime[0];
            string[] time = courseTime[1].Split('-');
            int start = int.Parse(time[0].Remove(time[0].IndexOf(':'), 1));
            int finish = int.Parse(time[1].Remove(time[1].IndexOf(':'), 1));
            foreach (DataGridViewRow registeredCourse in Register_Table.Rows)
            {
                if (registeredCourse.Cells["Lecture Time"].Value.ToString().IndexOf(day) == 0)
                {
                    string[] rCourseTime = registeredCourse.Cells["Lecture Time"].Value.ToString().Split(' ');
                    string[] rTime = rCourseTime[1].Split('-');
                    int rStart = int.Parse(rTime[0].Remove(rTime[0].IndexOf(':'), 1));
                    int rFinish = int.Parse(rTime[1].Remove(rTime[1].IndexOf(':'), 1));
                    if (Math.Max(start, rStart) < Math.Min(finish, rFinish))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void Add_Course_Click(object sender, EventArgs e)
        {
            if (Course_Table.CurrentCell == null)
                return;
            DataGridViewRow course = Course_Table.Rows[Course_Table.CurrentCell.RowIndex];
            int id = int.Parse(course.Cells["Course ID"].Value.ToString());
            if (!checkAdd(Course_Table.CurrentCell.RowIndex))
            {
                MessageBox.Show("Lecture overlaps with another registered lecture.", "Error");
                return;
            }
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed to connect to database.", "Error");
                    return;
                }
                string sql = "INSERT INTO registeredCourses VALUES('" + id + "', '" + User.Email + "')";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error occured.\n{ex}");
                }
            }
            updatePriceAndHours();
            updateCourseTable();
            updateRgisterTable();
            if (Course_Table.CurrentCell == null)
                return;
            course = Course_Table.Rows[Course_Table.CurrentCell.RowIndex];
            Selected_Course.Text = course.Cells["Course Name"].Value.ToString();
        }

        public void updateRgisterTable()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed to connect to database.", "Error");
                    return;
                }
                string sql = "SELECT c.name AS 'Course Name',c.id AS 'Course ID',c.credit AS 'Credit Hours',c.time AS 'Lecture Time',d.name AS 'Department Name',d.price AS 'Price per Credit Hour' FROM registeredCourses r,courses c,departments d WHERE r.c_id=c.id AND c.d_id=d.id AND r.u_email= '" + User.Email + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    registeredTable = new DataTable();
                    registeredTable.Load(reader);
                    Register_Table.DataSource = registeredTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error occured.\n{ex}");
                }
            }
            

        }

        public void updateCourseTable()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed to connect to database.", "Error");
                    return;
                }
                string sql = "SELECT name AS 'Course Name',id AS 'Course ID',credit AS 'Credit Hours',time AS 'Lecture Time' FROM courses WHERE d_id IN (" + User.Department + ",4) AND id NOT IN (SELECT c_id FROM registeredCourses WHERE u_email= '" + User.Email + "')";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    courseTable = new DataTable();
                    courseTable.Load(reader);
                    Course_Table.DataSource = courseTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error occured.\n{ex}");
                }
            }
            
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            var signIn = new SignIn();
            this.Visible = false;
            signIn.ShowDialog();
            this.Close();
        }

        private void Drop_Click(object sender, EventArgs e)
        {
            if (Register_Table.CurrentCell == null)
                return;
            DataGridViewRow course = Register_Table.Rows[Register_Table.CurrentCell.RowIndex];
            int id = int.Parse(course.Cells["Course ID"].Value.ToString());
            //drop selected row from registered table
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed to connect to database.", "Error");
                    return;
                }
                string sql = "DELETE FROM registeredCourses WHERE c_id = " + id;
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error occured.\n{ex}");
                }
                
            }
            updatePriceAndHours();
            updateCourseTable();
            updateRgisterTable();
            if (Register_Table.CurrentCell == null)
                return;
            course = Register_Table.Rows[Register_Table.CurrentCell.RowIndex];
            Selected_Course.Text = course.Cells["Course Name"].Value.ToString();
        }

        private void Register_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow course = Register_Table.Rows[e.RowIndex];
                Selected_Course.Text = course.Cells["Course Name"].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalHours_TextChanged(object sender, EventArgs e)
        {

        }

        private bool createFile()
        {
            try
            {
                using (var writer = new StreamWriter("RegistrationInfo.txt"))
                {

                    string department = "";
                    string major = "";
                    //get user information
                    using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
                    {
                        try
                        {
                            m_dbConnection.Open();
                        }
                        catch (SQLiteException)
                        {
                            MessageBox.Show("Failed to connect to database.", "Error");
                            return false;
                        }
                        string sql = "SELECT d.name AS 'dept',m.name AS 'major' FROM departments d,majors m WHERE d.id=m.d_id AND d.id= " + User.Department + " AND m.id= " + User.Major;
                        SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                        try
                        {
                            SQLiteDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                department = reader["dept"].ToString();
                                major = reader["major"].ToString();
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Database error occured.\n{ex}");
                        }
                        
                    }
                    //write user information to file
                    writer.WriteLine(User.Name + "," + User.Email + "," + User.Gender + "," + department + "," + major);
                    updatePriceAndHours();
                    writer.WriteLine(TotalPrice.Text + "," + TotalHours.Text);
                    foreach (DataGridViewRow registeredCourse in Register_Table.Rows)
                    {
                        string cName = registeredCourse.Cells["Course Name"].Value.ToString();
                        string cId = registeredCourse.Cells["Course ID"].Value.ToString();
                        string hours = registeredCourse.Cells["Credit Hours"].Value.ToString();
                        string time = registeredCourse.Cells["Lecture Time"].Value.ToString();
                        string dName = registeredCourse.Cells["Department Name"].Value.ToString();
                        string price = registeredCourse.Cells["Price per Credit Hour"].Value.ToString();
                        writer.WriteLine(cId + "," + cName + "," + hours + "," + time + "," + dName + "," + price);
                    }
                }
                isConfirmed = true;
                Info_Lable.Text = "";
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while writing to file.\n{ex}", "Error");
                return false;
            }
            
        }

        private void CreateFile_Click(object sender, EventArgs e)
        {
            if(createFile())
                MessageBox.Show("Registraion information file has been generated.\nOpen 'Registraion Information' tab and click 'View' to view it.", "Information");
        }

        private void Info_Lable_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConfirmed) {
                MessageBox.Show("You can't view before registering!", "Error");
                return;
            }
            try
            {
                //read file and assign values to textboxes
                using(var reader = new StreamReader("RegistrationInfo.txt"))
                {
                    string[] line = reader.ReadLine().Split(',');
                    UserName.Text = line[0];
                    Email.Text = line[1];
                    Gender.Text = line[2];
                    Dept.Text = line[3];
                    Major.Text = line[4];
                    line = reader.ReadLine().Split(',');
                    Cost.Text = line[0] + " JD";
                    Credit.Text = line[1];
                    CourseView.Items.Clear();
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine().Split(',');
                        var item = new ListViewItem(line);
                        CourseView.Items.Add(item);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured while reading from file.\n{ex}", "Error");
            }
            
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void Major_TextChanged(object sender, EventArgs e)
        {
            
        }
        //update name and major 
        private void button2_Click(object sender, EventArgs e)
        {
            if (User.Name != UserName.Text)
            {
                //update name if name is changed
                using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
                {
                    try
                    {
                        m_dbConnection.Open();
                    }
                    catch (SQLiteException)
                    {
                        MessageBox.Show("Failed to connect to database.", "Error");
                        return;
                    }
                    string sql = "UPDATE users SET name= '" + UserName.Text + "' WHERE email= '" + User.Email + "'";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database error occured.\n{ex}");
                    }
                    User.Name = UserName.Text;
                    MessageBox.Show($"Name has been changed to {UserName.Text}.", "Information");
                }
            }
            int id = 0;
            //get major id from major name
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("Failed to connect to database.", "Error");
                    return;
                }
                string sql = "SELECT id FROM majors WHERE d_id = '"+User.Department+"' AND name = '" + Major.Text + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error occured.\n{ex}");
                }
                
            }

            if (id != 0 && id != User.Major)
            {
                //update major if major is changed
                using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
                {
                    try
                    {
                        m_dbConnection.Open();
                    }
                    catch (SQLiteException)
                    {
                        MessageBox.Show("Failed to connect to database.", "Error");
                        return;
                    }
                    string sql = "UPDATE users SET m_id= '" + id + "' WHERE email= '" + User.Email + "'";
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database error occured.\n{ex}");
                    }
                    
                    User.Major = id;
                    MessageBox.Show($"Major has been changed to {Major.Text}.", "Information");
                }
            }
            //update file
            createFile();
            if (id == 0)
            {
                MessageBox.Show("Major doesn't exist or is not in your department.");
                return;
            }
        }
    }
}
