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
    public partial class HoD_HomeForm : Form
    {
        User currentUser;
        Form previousForm;
        public HoD_HomeForm(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void assesmentOverviewButton_Click(object sender, EventArgs e)
        {
            MyAssessments myAssessments = new MyAssessments(currentUser, this);
            this.Hide();
            myAssessments.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications(currentUser, this);
            this.Hide();
            notifications.Show();
        }
    }
}
