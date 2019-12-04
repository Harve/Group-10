using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Backbone;

namespace SQLDatabase
{
    public class SelectFromDatabase
    {
        public static List<User> allUsers = new List<User>();
        public static List<Programme> allProgrammes = new List<Programme>();
        public static List<Module> allModules = new List<Module>();
        public static List<Assessment> allAssessments = new List<Assessment>();
        public static List<Deadline> allDeadlines = new List<Deadline>();
        public static void LoadDatabase()
        {
           

            allUsers = ImportUsers();
            allProgrammes = ImportProgrammes();
            allModules = ImportModules();
            allAssessments = ImportAssessments();
            ImportModuleTeams();
            allDeadlines = ImportDeadlines();
        }
        public static List<User> ImportUsers()
        {
            List<User> Users = new List<User>();         
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from user";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            while (rdr.Read())
            {
                string userid =  rdr.GetString(0);
                string unencrypted = rdr.GetString(1);
                string password = Encryption.Decrypt(rdr.GetString(1));
                string firstname = rdr.GetString(2);
                string surname = rdr.GetString(3);
                string role = rdr.GetString(4);
                User user = new User(userid, firstname, surname, role);
                Users.Add(user);
            }
            m_dbConnection.Close();
            return Users;
        }

        public static List<Programme> ImportProgrammes()
        {
            List<Programme> programmes = new List<Programme>();
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

                Programme programme = new Programme(programmeid, leaderid, title);
                programmes.Add(programme);
            }
            m_dbConnection.Close();
            return programmes;
        }

        public static List<Module> ImportModules()
        {
            List<Module> modules = new List<Module>();
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

                Module module = new Module(moduleid, title, programmeid);
                modules.Add(module);
            }
            m_dbConnection.Close();
            return modules;
        }

        public static List<Assessment> ImportAssessments()
        {
            List<Assessment> assessments = new List<Assessment>();
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

                Assessment assessment = new Assessment(assessmentid, title, moduleid);
                assessments.Add(assessment);
            }
            m_dbConnection.Close();
            return assessments;
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
                string userid = rdr.GetString(0);
                string moduleid = rdr.GetString(1);
                bool isLeader = Convert.ToBoolean(rdr.GetInt32(2));

                string boolString = isLeader.ToString();

                Module _Module = allModules.Find(x => x.moduleID.Contains(moduleid));

                Console.WriteLine(_Module.moduleID);
                
                
                if (isLeader)
                {
                    _Module.moduleLeaderID = userid;
                }
                _Module.moduleTeamID.Add(userid);
                allModules[allModules.FindIndex(x => x.moduleID.Contains(moduleid))] = _Module;
                Console.WriteLine($@"{moduleid,-3} {userid,-8} {boolString,-8}");
            }
            m_dbConnection.Close();
        }

        public static List<Deadline> ImportDeadlines()
        {
            List<Deadline> deadlines = new List<Deadline>();
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

                Deadline deadline = new Deadline(moduleid, info, deadlinedate);

                deadlines.Add(deadline);

                
            }
            m_dbConnection.Close();
            return deadlines;
        }
    }
}
