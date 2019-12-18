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
    public partial class DoS_HomeForm : Form
    {
        User currentUser;
        Form previousForm;

        public DoS_HomeForm(User currentUser, Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications(currentUser, this);
            this.Hide();
            notifications.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void setDeadlinesButton_Click(object sender, EventArgs e)
        {

        }

        private void assignModeratorsButton_Click(object sender, EventArgs e)
        {

        }

        private void panelButton_Click(object sender, EventArgs e)
        {

        }

        private void assesmentOverviewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
