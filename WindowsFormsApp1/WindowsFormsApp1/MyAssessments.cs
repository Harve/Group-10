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
        public List<Module> UsersModule;
        public List<Assessment> UsersAssessment = new List<Assessment>();
        public MyAssessments(User user)
        {
            CurrentUser = user;
            InitializeComponent();
            UsersModule = SQLDatabase.SelectFromDatabase.allModules.FindAll(x => x.moduleTeamID.Contains(CurrentUser.id));
            foreach (Module module in UsersModule)
            {

                foreach (Assessment AssessToAdd in SQLDatabase.SelectFromDatabase.allAssessments)
                {
                    if (AssessToAdd.moduleID == module.moduleID)
                    {
                        UsersAssessment.Add(AssessToAdd);
                    }
                }

            }    

            if (UsersAssessment.Count == 0)
            {
              

            }
            
            foreach(Assessment assmentrow in UsersAssessment)
            {
                Deadline dead = SQLDatabase.SelectFromDatabase.allDeadlines.Find(x => x.assessmentid == assmentrow.assessmentID);
                if(dead == null)
                {
                    AssessmentViewer.Rows.Add(assmentrow.assessmentID, assmentrow.title, assmentrow.moduleID);
                }
                else
                {
                    AssessmentViewer.Rows.Add(assmentrow.assessmentID, assmentrow.title, assmentrow.moduleID, dead.deadlineDate, dead.title);
                }
               
            }
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

        private void MyAssessments_Load(object sender, EventArgs e)
        {

        }
    }
}
