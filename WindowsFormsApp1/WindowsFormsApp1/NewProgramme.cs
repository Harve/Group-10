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
    public partial class NewProgramme : Form
    {
        User CurrentUser;
        public NewProgramme(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            foreach(User member in SQLDatabase.SelectFromDatabase.allUsers)
            {
                director.Items.Add(member.id + " " + member.firstname + " " + member.surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateMenu createMenu = new CreateMenu(CurrentUser);
            this.Hide();
            createMenu.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string[] directorid = director.Text.Split(' ');
            SQLDatabase.InsertIntoDatabase.InsertIntoProgramme(id.Text, title.Text, directorid[0]);
            Programme programme = new Programme(id.Text, directorid[0], title.Text);
            SQLDatabase.SelectFromDatabase.allProgrammes.Add(programme);

            SQLDatabase.InsertIntoDatabase.InsertIntoNotification("NEW PROGRAMME: " + title.Text, CurrentUser.id, directorid[0]);
            notification notification = new notification("", "NEW PROGRAMME: " + title.Text, CurrentUser.id, directorid[0], DateTime.Now);
            SQLDatabase.SelectFromDatabase.allNotifications.Add(notification);
            MessageBox.Show("Programme Added");

        
        }
    }
}
