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
    public partial class HomeForm : Form
    {

        public User CurrentUser;

        public HomeForm(string userid)
        {
           
            CurrentUser = SQLDatabase.SelectFromDatabase.allUsers.Find(x => x.id.Contains(userid));
         
            
            this.BackColor = System.Drawing.Color.AliceBlue;
            InitializeComponent();
            label1.Text = "Welcome " + CurrentUser.firstname + " " + CurrentUser.surname;
            AdminButton.Hide();
            if (true)
            {
                AdminButton.Show();
            }
        }

        public HomeForm(User user)
        {
            CurrentUser = user;
            this.BackColor = System.Drawing.Color.AliceBlue;
            InitializeComponent();
            label1.Text = "Welcome " + CurrentUser.firstname + " " + CurrentUser.surname;
            AdminButton.Hide();
            if (true)
            {
                AdminButton.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateMenu createMenu = new CreateMenu(CurrentUser);
            this.Hide();
            createMenu.Show();
        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications(CurrentUser,this);
            this.Hide();
            notifications.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LogOnForm logOnForm = new LogOnForm();
            this.Hide();
            logOnForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar(CurrentUser);
            this.Hide();
            calendar.Show();
        }
        /*
        private void AdminButton_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator(CurrentUser);
            this.Hide();
            administrator.Show();
        }
        */
        /*
        private void MyAssessmentsButton_Click(object sender, EventArgs e)
        {
            MyAssessments myAssessments = new MyAssessments(CurrentUser);
            this.Hide();
            myAssessments.Show();
        }
        */
    }
}
