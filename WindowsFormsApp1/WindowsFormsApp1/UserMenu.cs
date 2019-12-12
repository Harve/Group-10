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
    public partial class UserMenu : Form
    {
        User CurrentUser;
        public UserMenu(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrator administrator = new Administrator(CurrentUser);
            this.Hide();
            administrator.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(CurrentUser);
            this.Hide();
            addUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser(CurrentUser);
            this.Hide();
            editUser.Show();
        }
    }
}
