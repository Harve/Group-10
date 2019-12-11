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
        public AddUser(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (id.Text != "" || password.Text != "" || firstname.Text != "" || surname.Text != "" || role.Text != "")
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
                    MessageBox.Show("Password contains non letter of number character");
                    return;
                }
                SQLDatabase.InsertIntoDatabase.InsertIntoUser(id.Text, password.Text, firstname.Text, surname.Text, role.Text);
                User NewUser = new User(id.Text, firstname.Text, surname.Text, role.Text);
                SQLDatabase.SelectFromDatabase.allUsers.Add(NewUser);
                id.Clear(); firstname.Clear(); surname.Clear(); password.Clear(); role.ResetText();
                MessageBox.Show("User Added Sucessfully");
            }
            else
            {
                MessageBox.Show("ID/Password/Firstname/Surname/Role is empty");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Administrator adminForm = new Administrator(CurrentUser);
            this.Hide();
            adminForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
  
