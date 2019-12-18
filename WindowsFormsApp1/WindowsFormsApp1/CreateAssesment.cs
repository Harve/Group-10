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
    public partial class CreateAssesment : Form
    {
        User currentUser;
        Form previousForm;
        List<ModuleTeam> allModuleTeams;
        public CreateAssesment(User currentUser, Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
            allModuleTeams = SQLDatabase.SelectFromDatabase.ImportModuleTeams();
            for(int i = 0; i < allModuleTeams.Count; i++)
            {
                if (currentUser.id == allModuleTeams[i].userID)
                {
                    moduleIDDropdown.Items.Add(allModuleTeams[i].moduleID);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void CreateAssesment_Load(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            SQLDatabase.InsertIntoDatabase.InsertIntoAssessment(assesmentIDTextBox.Text, currentUser.id, moduleIDDropdown.Text,"0","1");

            MessageBox.Show("Assesment Sucesfully Created");
            previousForm.Show();
            this.Close();
        }
    }
}
