using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Backbone;

namespace UserInterface
{
    public partial class NewAssessment : Form
    {
        public User CurrentUser;
        public string path;
        public string extension;
        public NewAssessment(User user)
        {
            CurrentUser = user;
            
            InitializeComponent();
            foreach (Module module in SQLDatabase.SelectFromDatabase.allModules)
            {
                ModuleDropDown.Items.Add(module.moduleID + " , " + module.title);
            }

        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DueDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF | *.pdf |DOCX | *.docx"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                path = dialog.FileName; // get name of file
                FileUploadTextBox.Text = path;
                extension = Path.GetExtension(path);
                

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CreateMenu createForm = new CreateMenu(CurrentUser);
            this.Hide();
            createForm.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string id = idTextBox.Text;
            string name = NameTextBox.Text;

            string[] combinedmoduleid = (ModuleDropDown.Text).Split(',');
            string moduleid = combinedmoduleid[0];
            moduleid = moduleid.Trim();

            DateTime date = Convert.ToDateTime((DueDateCalendar.SelectionStart));

            SQLDatabase.InsertIntoDatabase.InsertIntoAssessment(id, name, moduleid);
            Assessment assessment = new Assessment(id, name, moduleid);
            SQLDatabase.SelectFromDatabase.allAssessments.Add(assessment);

            SQLDatabase.InsertIntoDatabase.InsertIntoDeadline(name, id, date);
            Deadline deadline = new Deadline(id, name, date);
            SQLDatabase.SelectFromDatabase.allDeadlines.Add(deadline);

            Module module = SQLDatabase.SelectFromDatabase.allModules.Find(x => x.moduleID == moduleid);
            foreach(string user in module.moduleTeamID)
            {
                SQLDatabase.InsertIntoDatabase.InsertIntoNotification("NEW ASSESSMENT: " + name, CurrentUser.id, user);
                notification notification = new notification("", "NEW ASSESSMENT: " + name, CurrentUser.id, user, DateTime.Now);
                SQLDatabase.SelectFromDatabase.allNotifications.Add(notification);
            }

            string newPath = "Files/"+id+extension;
            try
            {
                File.Copy(path, newPath);
            }
            catch
            {
                MessageBox.Show("No File selected");
            }
            MessageBox.Show("Successfully added Assessment");

        }
    }
}
