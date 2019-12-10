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
using SQLDatabase;

namespace UserInterface
{
    public partial class Notifications : Form
    {
        User CurrentUser;
        public Notifications(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            List<notification> CurentNotification = new List<notification>();
            foreach (notification notification in SQLDatabase.SelectFromDatabase.allNotifications)
            {
                if(notification.reciever == CurrentUser.id)
                {
                    CurentNotification.Add(notification);
                }
            }

            foreach(notification notification in CurentNotification)
            {
                
                NotificationGrid.Rows.Add(notification.sentDate,notification.message,notification.sender);

            }
            
        }

        private void ModuleTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(CurrentUser);
            this.Hide();
            homeForm.Show();
        }
    }
}
