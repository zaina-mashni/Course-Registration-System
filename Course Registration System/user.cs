using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace Course_Registration_System
{
    static class User
    {
        public static string Name { set; get; }
        public static string Email { set; get; }
        public static string Password { set; get; }
        public static string Gender { set; get; }
        public static string CPassword { set; get; }
        public static int Department { set; get; }
        public static int Major { set; get; }

        public static bool login()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    return false;
                }
                string sql = "SELECT * FROM users WHERE email = '" + Email + "' AND password = '" + Password + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Name = reader["name"].ToString();
                        Email = reader["email"].ToString();
                        Password = reader["password"].ToString();
                        Gender = reader["gender"].ToString();
                        Department = reader.GetInt32(reader.GetOrdinal("d_id"));
                        Major = reader.GetInt32(reader.GetOrdinal("m_id"));
                        return true;
                    }
                    reader.Close();
                    reader.Dispose();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
           
        }

        public static bool checkEmail()
        {
            if (Email.IndexOf('@') != -1 && Email.IndexOf('.', Email.IndexOf('@')) != -1)
            {
                return true;
            }
            return false;
        }

        public static bool checkPassword()
        {
            if (CPassword != Password)
            {
                return false;
            }
            return true;
        }
        public static bool checkExists()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    return false;
                }
                string sql = "SELECT * FROM users WHERE email='" + Email + "'";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }
                    reader.Close();
                    reader.Dispose();
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
            return false;

        }
        public static bool createAccount()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=database.sqlite;Version=3;"))
            {
                try
                {
                    m_dbConnection.Open();
                }
                catch (SQLiteException)
                {
                    return false;
                }
                string sql = "INSERT INTO users VALUES('" + Name + "', '" + Email + "', '" + Password + "', '" + Gender + "','" + Department + "', '" + Major + "')";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
        }

    }
}
