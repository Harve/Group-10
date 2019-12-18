using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLDatabase;
using Backbone;

namespace UserInterface
{
    public partial class AddUser : Form
    {
        public User CurrentUser;
        private Form previousForm;
        public AddUser(User user,Form previousForm)
        {
            this.previousForm = previousForm;
            CurrentUser = user;
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (id.Text != "" || password.Text != "" || firstname.Text != "" || surname.Text != "" || role.CheckedIndices.Count !=0)
            {

                Regex idRegex = new Regex(@"[0-9]{8}");
                Regex passwordRegex = new Regex(@"[0-9a-zA-Z]");
                Regex nameRegex = new Regex(@"[a-zA-Z]");

                if (!(idRegex.IsMatch(id.Text)))
                {
                    MessageBox.Show("Error Id contains non number characters");
                    return;
                }
                if (!(nameRegex.IsMatch(firstname.Text)) || !(nameRegex.IsMatch(surname.Text)))
                {
                    MessageBox.Show("Error Name contains non letter characters");
                    return;
                }
                if (!(passwordRegex.IsMatch(password.Text)))
                {
                    MessageBox.Show("Password contains non letter or number character");
                    return;
                }
                SQLDatabase.InsertIntoDatabase.InsertIntoUser(id.Text, password.Text, firstname.Text, surname.Text);
                User NewUser = new User(id.Text, firstname.Text, surname.Text);
                SQLDatabase.SelectFromDatabase.allUsers.Add(NewUser);

                var temp = role.CheckedIndices;
                for (int i = 0; i<temp.Count;i++)
                {
                    role.SelectedIndex = temp[i];
                    var temp2 = role.Text;

                    SQLDatabase.InsertIntoDatabase.InsertIntoRole(id.Text, temp2);
                }
                id.Clear(); firstname.Clear(); surname.Clear(); password.Clear(); role.ClearSelected();

                MessageBox.Show("User Added Sucessfully");

                foreach (int i in role.CheckedIndices)
                {
                    role.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            else
            {
                MessageBox.Show("ID/Password/Firstname/Surname/Role is empty");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
  
