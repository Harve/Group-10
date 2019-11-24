using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLDatabase
{
    class InsertDatabase
    {

        public static void InsertIntoUser(string id,string firstname,string surname, string role)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into user (userid,firstname,surname,role) values (@id,@fname,@sname,@role)";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@fname", firstname);
                command.Parameters.AddWithValue("@sname", surname);
                command.Parameters.AddWithValue("@role", role);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        
        }

        public static void InsertIntoProgramme(string programmeid, string title, string userid)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into programme (programmeid,title,userid) values (@pid,@title,@uid)";
                command.Parameters.AddWithValue("@pid", programmeid);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@uid", userid);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void InsertIntoModule(string moduleid, string title, string programmeid)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into module (moduleid,title,programmeid) values (@mid,@title,@pid)";
                command.Parameters.AddWithValue("@mid", moduleid);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@pid", programmeid);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void InsertIntoAssessment(string assessmentid, string title, string moduleid)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();
            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into assessment (assessmentid,title,moduleid) values (@aid,@title,@mid)";
                command.Parameters.AddWithValue("@pid", assessmentid);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@uid", moduleid);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }
    }
}
