using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace SQLDatabase
{
    public static class UpdateDatabase
    {
        public static void UpdateUser(string id, string firstname, string surname, string role)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "update user set firstname = :firstname, surname = :surname, role = :role where userid=:id";
                command.Parameters.Add("firstname", DbType.String).Value = firstname;
                command.Parameters.Add("surname", DbType.String).Value = surname;
                command.Parameters.Add("role", DbType.String).Value = role;
                command.Parameters.Add("id", DbType.String).Value = id;
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void UpdateProgramme(string programmeid, string title, string userid)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "update programme set title = :title, userid = :userid where programmeid=:programmeid";
                command.Parameters.Add("title", DbType.String).Value = title;
                command.Parameters.Add("userid", DbType.String).Value = userid;
                command.Parameters.Add("programmeid", DbType.String).Value = programmeid;
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void UpdateModule(string moduleid, string title, string programmeid)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "update module set title = :title, programmeid = :programmeid where moduleid=:moduleid";
                command.Parameters.Add("title", DbType.String).Value = title;
                command.Parameters.Add("moduleid", DbType.String).Value = moduleid;
                command.Parameters.Add("programmeid", DbType.String).Value = programmeid;
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void UpdateAssessment(string assessmentid, string title, string moduleid)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();
            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "update assessment set title = :title, moduleid = :moduleid where assessmentid=:assessmentid";
                command.Parameters.Add("title", DbType.String).Value = title;
                command.Parameters.Add("assessmentid", DbType.String).Value = assessmentid;
                command.Parameters.Add("moduleid", DbType.String).Value = moduleid;
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }
    }
}
