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
    public partial class RoleSelector : Form
    {
        private User currentUser;

        public RoleSelector(string userID)
        {
            currentUser = SQLDatabase.SelectFromDatabase.allUsers.Find(x => x.id.Contains(userID));
            InitializeComponent();

            List<Role> allRoles = SQLDatabase.SelectFromDatabase.ImportRoles();
            for(int i = 0; i < allRoles.Count; i++)
            {
                if (allRoles[i].userID == currentUser.id)
                {
                    listView1.Items.Add(allRoles[i].role);
                }
            }
            label2.Text = "Welcome " + currentUser.firstname + " " + currentUser.surname;

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 0)
            {

                if (listView1.SelectedItems[0].Text== "Administrator")
                {
                    Administrator administrator = new Administrator(currentUser,this);
                    this.Hide();
                    administrator.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Director of Study")
                {
                    DoS_HomeForm doS_HomeForm = new DoS_HomeForm(currentUser, this);
                    this.Hide();
                    doS_HomeForm.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Faculty Hub")
                {
                    FacHub_HomeForm facHub_HomeForm = new FacHub_HomeForm(currentUser, this);
                    this.Hide();
                    facHub_HomeForm.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Head of Department")
                {
                    HoD_HomeForm hoD_HomeForm = new HoD_HomeForm(currentUser, this);
                    this.Hide();
                    hoD_HomeForm.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Moderator")
                {
                    Moderator_HomeForm moderator_HomeForm = new Moderator_HomeForm(currentUser, this);
                    this.Hide();
                    moderator_HomeForm.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Module Leader")
                {
                    ModuleLeader_HomeForm moduleLeader_HomeForm = new ModuleLeader_HomeForm(currentUser, this);
                    this.Hide();
                    moduleLeader_HomeForm.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Module Team")
                {
                    ModuleTeam_HomeForm moduleTeam_HomeForm = new ModuleTeam_HomeForm(currentUser, this);
                    this.Hide();
                    moduleTeam_HomeForm.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Panel Administrator")
                {
                    PanelAdmin_HomeForm panelAdmin_HomeForm = new PanelAdmin_HomeForm(currentUser, this);
                    this.Hide();
                    panelAdmin_HomeForm.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Panel Member - Other")
                {
                    PanelMemberOther_HomeForm panelMemberOther_HomeForm = new PanelMemberOther_HomeForm(currentUser, this);
                    this.Hide();
                    panelMemberOther_HomeForm.Show();
                }
                else if (listView1.SelectedItems[0].Text == "Program Director")
                {
                    ProgramDirector_HomeForm programDirector_HomeForm = new ProgramDirector_HomeForm(currentUser, this);
                    this.Hide();
                    programDirector_HomeForm.Show();
                }
                else
                {
                    MessageBox.Show("Error: Role choice not recognised");
                }
            }
            else
            {
                MessageBox.Show("Please select a role");
            }
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications(currentUser,this);
            this.Hide();
            notifications.Show();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar(currentUser);
            this.Hide();
            calendar.Show();
        }

        private void logoffButton_Click(object sender, EventArgs e)
        {
            LogOnForm logOnForm = new LogOnForm();
            logOnForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
