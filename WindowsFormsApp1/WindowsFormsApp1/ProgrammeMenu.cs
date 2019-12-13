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
    public partial class ProgrammeMenu : Form
    {
        User CurrentUser;
        public ProgrammeMenu(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(CurrentUser);
            this.Hide();
            homeForm.Show();
        }
    }
}
