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
        public Administrator(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        private void ModulesPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(CurrentUser);
            this.Hide();
            homeForm.Show();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UserMenu addUser = new UserMenu(CurrentUser);
            this.Hide();
            addUser.Show();
        }

        private void ReviewAssessmentsButton_Click(object sender, EventArgs e)
        {
            AssessmentMenu assessmentMenu = new AssessmentMenu(CurrentUser);
            this.Hide();
            assessmentMenu.Show();
        }

        private void ModulesButton_Click(object sender, EventArgs e)
        {
            ModuleMenu moduleMenu = new ModuleMenu(CurrentUser);
            this.Hide();
            moduleMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgrammeMenu programmeMenu = new ProgrammeMenu(CurrentUser);
            this.Hide();
            programmeMenu.Show();
        }
    }
}
