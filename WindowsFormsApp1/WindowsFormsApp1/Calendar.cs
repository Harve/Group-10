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
    public partial class Calendar : Form
    {
        public User CurrentUser;

        public List<Assessment> assessments = new List<Assessment>();
        public List<Deadline> deadlines = new List<Deadline>();
        public Calendar(User user)
        {/*
            CurrentUser = user;
            InitializeComponent();
            foreach(Module mod in SQLDatabase.SelectFromDatabase.allModules)
            {
                if (mod.moduleTeamID.Contains(CurrentUser.id))
                {
                    foreach (Assessment assessment in SQLDatabase.SelectFromDatabase.allAssessments)
                    {
                        if(assessment.moduleID == mod.moduleID)
                        {
                            assessments.Add(assessment);
                        }
                      
                    }
                }
            }
            foreach(Assessment assessment in assessments)
            {
                Deadline deadline = SQLDatabase.SelectFromDatabase.allDeadlines.Find(x => x.assessmentid == assessment.assessmentID);
                deadlines.Add(deadline);
            }
            foreach(Deadline deadline in deadlines)
            {   
                if(deadline == null)
                {
                    continue;
                }
                CalendarView.AddBoldedDate(deadline.deadlineDate);
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(CurrentUser);
            this.Hide();
            homeForm.Show();

        }

        private void CalendarView_DateSelected(object sender, DateRangeEventArgs e)
        {
            AssessmentView.Rows.Clear();
            foreach(Deadline deadline in deadlines)
            {
                if (deadline == null)
                {
                    continue;
                }
                if (deadline.deadlineDate == CalendarView.SelectionRange.Start)
                {
                    AssessmentView.Rows.Add(deadline.title, deadline.deadlineDate);
                }
            }
        }
    }
}
