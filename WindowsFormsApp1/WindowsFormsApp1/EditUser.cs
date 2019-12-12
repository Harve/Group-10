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
    public partial class EditUser : Form
    {
        User CurrentUser;
        User userToEdit;
        public EditUser(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            foreach (User editUser in SQLDatabase.SelectFromDatabase.allUsers)
            {
                SelectUser.Items.Add(editUser.id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu(CurrentUser);
            this.Hide();
            userMenu.Show();
        }

        private void SelectUser_TextUpdate(object sender, EventArgs e)
        {
            userToEdit = SQLDatabase.SelectFromDatabase.allUsers.Find(x => x.id.Contains(SelectUser.Text));
            fname.Text = userToEdit.firstname;
            sname.Text = userToEdit.surname;
            role.SelectedItem = userToEdit.role;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "User details updated";
            SQLDatabase.UpdateDatabase.UpdateUser(SelectUser.Text, fname.Text, sname.Text, role.Text);
            if(password.Text != "")
            {
                SQLDatabase.UpdateDatabase.UpdatePassword(SelectUser.Text, password.Text);
                message = "User details and Password updated";
            }
            userToEdit.firstname = fname.Text;
            userToEdit.surname = sname.Text;
            userToEdit.role = role.Text;
            SQLDatabase.SelectFromDatabase.allUsers.Find(x => x.id.Contains(userToEdit.id)).Equals(userToEdit);
            
            MessageBox.Show(message);
        }
    }
}
