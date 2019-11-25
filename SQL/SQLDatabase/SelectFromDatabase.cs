using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLDatabase
{
    class SelectFromDatabase
    {
        public static void LoadDatabase()
        {
            ImportUsers();
            ImportProgrammes();
            ImportModules();
            ImportAssessments();
            ImportModuleTeams();
            ImportDeadlines();
        }
        public static void ImportUsers()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from user";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            while (rdr.Read())
            {
                string userid =  rdr.GetString(0);
                string firstname = rdr.GetString(1);
                string surname = rdr.GetString(2);
                string role = rdr.GetString(3);
                Console.WriteLine($@"{userid,-3} {firstname,-8} {surname,-8}  {role,8}");
            }
            m_dbConnection.Close();
        }

        public static void ImportProgrammes()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from programme";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8} ");

            while (rdr.Read())
            {
                string programmeid = rdr.GetString(0);
                string title = rdr.GetString(1);
                string leaderid = rdr.GetString(2);
               
                Console.WriteLine($@"{programmeid,-3} {title,-8} {leaderid,-8}");
            }
            m_dbConnection.Close();
        }

        public static void ImportModules()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from module";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            while (rdr.Read())
            {
                string moduleid = rdr.GetString(0);
                string title = rdr.GetString(1);
                string programmeid = rdr.GetString(2);

                Console.WriteLine($@"{moduleid,-3} {title,-8} {programmeid,-8}");
            }
            m_dbConnection.Close();
        }

        public static void ImportAssessments()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from assessment";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            while (rdr.Read())
            {
                string assessmentid = rdr.GetString(0);
                string title = rdr.GetString(1);
                string moduleid = rdr.GetString(2);

                Console.WriteLine($@"{assessmentid,-3} {title,-8} {moduleid,-8}");
            }
            m_dbConnection.Close();
        }
        public static void ImportModuleTeams()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from moduleteam";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            while (rdr.Read())
            {
                string moduleid = rdr.GetString(0);
                string userid = rdr.GetString(1);
                bool isLeader = Convert.ToBoolean(rdr.GetInt32(2));

                string boolString = isLeader.ToString();

                Console.WriteLine($@"{moduleid,-3} {userid,-8} {boolString,-8}");
            }
            m_dbConnection.Close();
        }

        public static void ImportDeadlines()
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from deadline";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            while (rdr.Read())
            {
                string moduleid = rdr.GetString(0);
                string info = rdr.GetString(1);
                DateTime deadlinedate = rdr.GetDateTime(2);

                string dateString = deadlinedate.ToString();

                Console.WriteLine($@"{moduleid,-3} {info,-8} {dateString,-8}");
            }
            m_dbConnection.Close();
        }
    }
}
