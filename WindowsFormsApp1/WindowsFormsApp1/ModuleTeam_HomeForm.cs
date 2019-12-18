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
    public partial class ModuleTeam_HomeForm : Form
    {
        User currentUser;
        Form previousForm;
        public ModuleTeam_HomeForm(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//BackButton
        {
            previousForm.Show();
            this.Close();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            CreateAssesment createAssesment = new CreateAssesment(currentUser, this);
            this.Hide();
            createAssesment.Show();
        }

        private void notificationButton_Click(object sender, EventArgs e)
        {
            Notifications notifications = new Notifications(currentUser, this);
            this.Hide();
            notifications.Show();
        }

        private void assesmentOverviewButton_Click(object sender, EventArgs e)
        {
            MyAssessments myAssessments = new MyAssessments(currentUser,this);
            this.Hide();
            myAssessments.Show();
        }
    }
}
