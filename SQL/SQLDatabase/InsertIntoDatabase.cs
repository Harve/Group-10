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

        public static void InsertIntoUser(string id,string password,string firstname,string surname)
        {
            password = Encryption.Encrypt(password);
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into user (userid,password,firstname,surname) values (@id,@password,@fname,@sname)";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@fname", firstname);
                command.Parameters.AddWithValue("@sname", surname);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void InsertIntoRole(string id, string userRole)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into role (userID,role) values (@id,@userRole)";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@userRole", userRole);
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

        public static void InsertIntoModule(string moduleid, string title, string programmeid,string moduleleader)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into module (moduleid,title,programmeid,moduleleader) values (@mid,@title,@pid,@mldr)";
                command.Parameters.AddWithValue("@mid", moduleid);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@pid", programmeid);
                command.Parameters.AddWithValue("@mldr", moduleleader);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void InsertIntoAssessment(string assessmentid, string userid, string moduleid, string laststep,string nextstep)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();
            using (SQLiteCommand command = new SQLiteCommand(m_dbConnection))
            {
                command.CommandText =
                    "insert into assessment (assessmentid,userid,moduleid,laststep,nextstep) values (@aid,@userid,@mid,@lstep,@nstep)";
                command.Parameters.AddWithValue("@aid", assessmentid);
                command.Parameters.AddWithValue("@userID", userid);
                command.Parameters.AddWithValue("@mid", moduleid);
                command.Parameters.AddWithValue("@lstep", laststep);
                command.Parameters.AddWithValue("@nstep", nextstep);
                command.ExecuteNonQuery();
            }
            m_dbConnection.Close();
        }

        public static void InsertIntoModuleTeam(string userid, string moduleid)
        {
            bool leader = false;
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
