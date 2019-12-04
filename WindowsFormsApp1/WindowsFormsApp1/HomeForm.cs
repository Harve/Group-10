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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {

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
    }
}
