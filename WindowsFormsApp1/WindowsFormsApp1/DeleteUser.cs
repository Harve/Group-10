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
    public partial class DeleteUser : Form
    {
        User userToDelete;
        Form previousForm;
        public DeleteUser(User currentUser, Form previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
            foreach (User editUser in SQLDatabase.SelectFromDatabase.ImportUsers())
            {
                SelectUser.Items.Add(editUser.id);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            userToDelete = SQLDatabase.SelectFromDatabase.allUsers.Find(x => x.id.Contains(SelectUser.Text));
            fname.Text = userToDelete.firstname;
            sname.Text = userToDelete.surname;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            SQLDatabase.DeleteFromDatabase.DeleteUser(userToDelete.id);
            SQLDatabase.DeleteFromDatabase.DeleteRole(userToDelete.id);

            MessageBox.Show("User succesfuly deleted");

            SelectUser.Items.Clear();

            foreach (User editUser in SQLDatabase.SelectFromDatabase.ImportUsers())
            {
                SelectUser.Items.Add(editUser.id);
            }
        }

    }
    
}
