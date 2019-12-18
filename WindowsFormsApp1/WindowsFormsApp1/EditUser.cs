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
        Form previousForm;
        public EditUser(User user, Form previousForm)
        {
            this.previousForm = previousForm;
            CurrentUser = user;
            InitializeComponent();
            foreach (User editUser in SQLDatabase.SelectFromDatabase.ImportUsers())
            {
                SelectUser.Items.Add(editUser.id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void SelectUser_TextUpdate(object sender, EventArgs e)
        {
            userToEdit = SQLDatabase.SelectFromDatabase.allUsers.Find(x => x.id.Contains(SelectUser.Text));
            fname.Text = userToEdit.firstname;
            sname.Text = userToEdit.surname;
            foreach (int i in role.CheckedIndices)
            {
                role.SetItemCheckState(i, CheckState.Unchecked);
            }

            List<Role> roles = SQLDatabase.SelectFromDatabase.ImportRoles();

            for(int i = 0; i< roles.Count; i++)
            {
                if (roles[i].userID == SelectUser.Text)
                {
                    int temp = role.FindStringExact(roles[i].role);

                    role.SetItemChecked(temp, true);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "User details updated";
            SQLDatabase.UpdateDatabase.UpdateUser(SelectUser.Text, fname.Text, sname.Text);
            SQLDatabase.DeleteFromDatabase.DeleteRole(userToEdit.id);
            var temp = role.CheckedIndices;
            for (int i = 0; i < temp.Count; i++)
            {
                role.SelectedIndex = temp[i];
                var temp2 = role.Text;

                SQLDatabase.InsertIntoDatabase.InsertIntoRole(userToEdit.id, temp2);
            }

            if (password.Text != "")
            {
                SQLDatabase.UpdateDatabase.UpdatePassword(SelectUser.Text, password.Text);
                message = "User details and Password updated";
            }
            userToEdit.firstname = fname.Text;
            userToEdit.surname = sname.Text;
            SQLDatabase.SelectFromDatabase.allUsers.Find(x => x.id.Contains(userToEdit.id)).Equals(userToEdit);
            
            MessageBox.Show(message);
        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
