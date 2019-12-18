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
    public partial class Administrator : Form
    {
        public User CurrentUser;
        private Form previousForm;
        public Administrator(User user,Form previousFrom)
        {
            this.previousForm = previousFrom;
            CurrentUser = user;
            InitializeComponent();
        }

        private void ModulesPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UserMenu addUser = new UserMenu(CurrentUser,this);
            this.Hide();
            addUser.Show();
        }
        
        private void ReviewAssessmentsButton_Click(object sender, EventArgs e)
        {

        }
        
        private void ModulesButton_Click(object sender, EventArgs e)
        {
            AdminModuleMenu adminModuleMenu = new AdminModuleMenu(CurrentUser, this);
            this.Hide();
            adminModuleMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)//Programme Button
        {
            AdminProgrammeMenu adminProgrammeMenu = new AdminProgrammeMenu(CurrentUser, this);
            this.Hide();
            adminProgrammeMenu.Show();

        }

        private void BackButtonPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
