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
    public partial class PanelMemberOther_HomeForm : Form
    {
        User currentUser;
        Form previousForm;
        public PanelMemberOther_HomeForm(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Back button
        {
            this.Hide();
            previousForm.Show();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {

        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications(currentUser, this);
            this.Hide();
            notifications.Show();
        }
    }
}
