using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Course_Registration_System
{
    class University
    {
        public List<string> getDepartments()
        {
            List<string> dept = new List<string>();
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    return dept;
                }
                
                string sql = "SELECT name FROM departments WHERE name<>'Common'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dept.Add(reader["name"].ToString());
                    }
                    reader.Close();
                    reader.Dispose();
                    return dept;
                }
                catch (Exception ex)
                {
                    return dept;
                }
                
                
            }
        }
        public List<string> getMajors(string dept)
        {
            int id = 0;
            List<string> majors = new List<string>();
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    return majors;
                }
                string sql = "SELECT id FROM departments WHERE name = '" + dept + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                    reader.Close();
                    reader.Dispose();
                }
                catch (Exception ex)
                {
                    return majors;
                }
               
            }
            
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    return majors;
                }
                string sql = "SELECT name FROM majors WHERE d_id = '" + id + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        majors.Add(reader["name"].ToString());
                    }
                    reader.Close();
                    reader.Dispose();
                    return majors;
                }
                catch (Exception ex)
                {
                    return majors;
                }
                
                
            }
        }

        public int getDepartmentId(string name)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    return -1;
                }
                int id = 0;
                string sql = "SELECT id FROM departments WHERE name = '" + name + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                    reader.Close();
                    reader.Dispose();
                    return id; 
                }
                catch (Exception ex)
                {
                    return -1;
                }

            }
        }
        public int getMajorId(string name)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    return -1;
                }
                int id = 0;
                string sql = "SELECT id FROM majors WHERE name = '" + name + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                    reader.Close();
                    reader.Dispose();
                    return id;
                }
                catch (Exception ex)
                {
                    return -1;
                }

            }
            
        }
    }
}
