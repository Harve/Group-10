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
        Form previousForm;
        public UserMenu(User user, Form previousForm)
        {
            this.previousForm = previousForm;
            CurrentUser = user;
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(CurrentUser,this);
            this.Hide();
            addUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser(CurrentUser,this);
            this.Hide();
            editUser.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser(CurrentUser,this);
            this.Hide();
            deleteUser.Show();
        }
    }
}
