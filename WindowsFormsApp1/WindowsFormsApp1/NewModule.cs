using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backbone;

namespace UserInterface
{
    public partial class NewModule : Form
    {
        public User CurrentUser;
        public List<string> Team;
        

        public NewModule(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            foreach(User staff in SQLDatabase.SelectFromDatabase.allUsers)
            {
                TeamListBox.Items.Add(staff.id + " " + staff.firstname + " " + staff.surname);
            }
            foreach(Programme program in SQLDatabase.SelectFromDatabase.allProgrammes)
            {
                ProgrammeBox.Items.Add(program.programmeID + " " + program.title);
            }
           
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            string[] programid = ProgrammeBox.Text.Split(' ');
            SQLDatabase.InsertIntoDatabase.InsertIntoModule(ModuleID.Text, Title.Text, programid[0]);
            Module module = new Module(ModuleID.Text, Title.Text, programid[0]);

            

            List<string> TeamMembers = new List<string>();
            string Leader = "";
            foreach( string teammember in TeamListBox.SelectedItems)
            {
                string[] member = teammember.Split(' ');
                int isLeader = 0;
                if(TeamLeader.Text == teammember)
                {
                    isLeader = 1;
                    Leader = member[0];
                }
                TeamMembers.Add(member[0]);
                SQLDatabase.InsertIntoDatabase.InsertIntoModuleTeam(member[0],ModuleID.Text,isLeader);
                SQLDatabase.InsertIntoDatabase.InsertIntoNotification("NEW MODULE: " + Title.Text, CurrentUser.id, member[0]);
                notification notification = new notification("", "NEW MODULE: " + Title.Text, CurrentUser.id, member[0], DateTime.Now);
                SQLDatabase.SelectFromDatabase.allNotifications.Add(notification);
            }
            module.moduleTeamID = TeamMembers;
            module.moduleLeaderID = Leader;
            SQLDatabase.SelectFromDatabase.allModules.Add(module);
            MessageBox.Show("Module Added Successfully");

        }
        */
        private void TeamListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            if(e.NewValue == CheckState.Checked)
            {
                Team = new List<string>();
                foreach (string selectedstaff in TeamListBox.SelectedItems)
                {
                    Team.Add(selectedstaff);
                }
                
                foreach (string Staff in Team)
                {
                    TeamLeader.Items.Add(Staff);
                }
            }
            else
            {
                TeamLeader.Items.Clear();
                TeamListBox.Refresh();
              
                for (int id = 0; id < TeamListBox.Items.Count -1; id++)
                {
                    if (TeamListBox.GetItemChecked(id))
                    {
                        TeamLeader.Items.Add(TeamListBox.Items[id]);
                    }
                }
            }
                
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateMenu createMenu = new CreateMenu(CurrentUser);
            this.Hide();
            createMenu.Show();
        }

        private void NewModule_Load(object sender, EventArgs e)
        {

        }
    }
}
