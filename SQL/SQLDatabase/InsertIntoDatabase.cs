using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace SQLDatabase
{
    public static class InsertIntoDatabase
    {

        public static void InsertIntoUser(string id,string password,string firstname,string surname, string role)
        {
            password = Encryption.Encrypt(password);
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into user (userid,password,firstname,surname,role) values (@id,@password,@fname,@sname,@role)";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@password", password);
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
                command.Parameters.AddWithValue("@aid", assessmentid);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@mid", moduleid);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void InsertIntoModuleTeam(string userid, string moduleid, int leader)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();
            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into moduleteam (userid,moduleid,isLeader) values (@uid,@mid,@leader)";
                command.Parameters.AddWithValue("@uid", userid);
                command.Parameters.AddWithValue("@mid", moduleid);
                command.Parameters.AddWithValue("@leader", leader);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void InsertIntoDeadline(string information, string moduleid, DateTime date)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();
            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into deadline (moduleid,information,deadlinedate) values (@mid,@info,@date)";
                
                command.Parameters.AddWithValue("@info", information);
                command.Parameters.AddWithValue("@mid", moduleid);
                command.Parameters.AddWithValue("@date", date);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void InsertIntoNotification(string message, string sender, string reciever)
        {
            string encryptedMessage = Encryption.Encrypt(message);
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();
            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText = " insert into notification(notificationid,message,sentTime,senderid,recieverid) values(null,@msg,@time,@send,@recv)";

                command.Parameters.AddWithValue("@msg", encryptedMessage);
                command.Parameters.AddWithValue("@time", DateTime.Now);
                command.Parameters.AddWithValue("@send", sender);
                command.Parameters.AddWithValue("@recv", reciever);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }
    }
}
