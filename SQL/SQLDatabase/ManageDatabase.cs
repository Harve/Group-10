using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SQLDatabase
{
    public class ManageDatabase
    {
        public static void CreateDatabase()
        {
            if (File.Exists("Database.sqlite"))
            {
                File.Delete("Datebase.sqlite");
            }

            SQLiteConnection.CreateFile("Database.sqlite");

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "create table user (userid varchar(8), password varchar (30),firstname varchar(20), surname varchar(20))";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();



            sql = "create table programme (programmeid varchar(8),title varchar(40),userid varchar(8))";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table role (userID varchar(8),role varchar (30))";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table module (moduleid varchar(8),title varchar(40), programmeid varchar(8), moduleleader varchar(8))";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table assessment (assessmentid varchar(8),userid varchar(8), moduleid varchar(8),laststep varchar(2),nextstep varchar(3) )";

            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table moduleteam( userid varchar(8), moduleid varchar(8), isLeader boolean)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table deadline( moduleid varchar(8), information varchar(80), deadlinedate datetime)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = "create table notification( notificationid INTEGER PRIMARY KEY AUTOINCREMENT, message varchar(640), sentTime datetime, senderid varchar(8), recieverid varchar(8))";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            InsertIntoDatabase.InsertIntoUser("adminuser", "adminpassword", "Admin", "User");
            InsertIntoDatabase.InsertIntoRole("adminuser", "Administrator");
            m_dbConnection.Close();
        }

        public static bool Logon(string userid,string password)
        {
            if(userid == "" || password == "")
            {
                return false;
            }
            string encryptedPassword;
            

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            encryptedPassword = Encryption.Encrypt(password);

            using (var cmd = new SQLiteCommand("select * from user where userid =@userid and password = @password", m_dbConnection))
            {
                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@password", encryptedPassword);
                using (var reader = cmd.ExecuteReader())
                {
                    var count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
            }
        }
    }
}
