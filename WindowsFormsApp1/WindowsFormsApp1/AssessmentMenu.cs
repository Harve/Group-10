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
    public partial class AssessmentMenu : Form
    {
        User CurrentUser;
        public AssessmentMenu(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(CurrentUser);
            this.Hide();
            homeForm.Show();
        }
    }
}
