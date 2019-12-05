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
    public partial class MyAssessments : Form
    {
        public User CurrentUser;
        public MyAssessments(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        private void CreateNewLable_Click(object sender, EventArgs e)
        {

        }

        private void AssessmentLabel_Click(object sender, EventArgs e)
        {

        }

        private void ModuleLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(CurrentUser);
            this.Hide();
            homeForm.Show();
        }
    }
}
