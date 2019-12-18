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
        public static List<notification> allNotifications = new List<notification>();
        public static void LoadDatabase()
        {
           

            allUsers = ImportUsers();
            allProgrammes = ImportProgrammes();
            allModules = ImportModules();
            allAssessments = ImportAssessments();
            //ImportModuleTeams();
            allDeadlines = ImportDeadlines();
            allNotifications = ImportNotifications();
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
                User user = new User(userid, firstname, surname);
                Users.Add(user);
            }
            m_dbConnection.Close();
            return Users;
        }

        public static List<Role> ImportRoles()
        {
            List<Role> roles = new List<Role>();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from role";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            //Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            while (rdr.Read())
            {
                string userID = rdr.GetString(0);
                string userRole = rdr.GetString(1);

                Role role = new Role(userID, userRole);
                roles.Add(role);
            }
            m_dbConnection.Close();
            return roles;
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
                string moduleleader = rdr.GetString(3);

                Module module = new Module(moduleid, title, programmeid,moduleleader);
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
                string userid = rdr.GetString(1);
                string moduleid = rdr.GetString(2);
                string laststep = rdr.GetString(3);
                string nextstep = rdr.GetString(4);

                Assessment assessment = new Assessment(assessmentid, moduleid,userid,laststep,nextstep);
                assessments.Add(assessment);
            }
            m_dbConnection.Close();
            return assessments;
        }
        
        public static List<ModuleTeam> ImportModuleTeams()
        {
            List<ModuleTeam> moduleTeamList = new List<ModuleTeam>();
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

                moduleTeamList.Add(new ModuleTeam(moduleid, userid));

            }
            m_dbConnection.Close();
            return moduleTeamList;
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
                string assessmentid = rdr.GetString(0);
                string info = rdr.GetString(1);
                DateTime deadlinedate = rdr.GetDateTime(2);

                Deadline deadline = new Deadline(assessmentid, info, deadlinedate);

                deadlines.Add(deadline);

                
            }
            m_dbConnection.Close();
            return deadlines;
        }

        public static List<notification> ImportNotifications()
        {
            List<notification> notifications = new List<notification>();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Database.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "select * from notification";

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            while (rdr.Read())
            {
                string id = (rdr.GetInt32(0).ToString());
                string message = Encryption.Decrypt(rdr.GetString(1));
                DateTime date = rdr.GetDateTime(2);
               
                string sender = rdr.GetString(3);
                string reciever = rdr.GetString(4);

                notification notification = new notification(id,message,sender,reciever,date);

                notifications.Add(notification);


            }
            m_dbConnection.Close();
            return notifications;
        }
    }
}
