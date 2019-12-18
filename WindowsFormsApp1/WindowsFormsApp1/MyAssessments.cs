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
        public User currentUser;
        Form previousForm;
        List<Assessment> allAssesments;
        public MyAssessments(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
            allAssesments = SQLDatabase.SelectFromDatabase.ImportAssessments();
            try
            {
                dataGridView1.Rows.Add(allAssesments.Count - 1);
            }
            catch
            {

            }
            
            for (int i = 0; i < allAssesments.Count; i++)
            {
                
                dataGridView1[1, i].Value = allAssesments[i].moduleID;
                dataGridView1[2, i].Value = allAssesments[i].assessmentID;
                dataGridView1[3, i].Value = allAssesments[i].moduleTeamMemberID;
                dataGridView1[4, i].Value = allAssesments[i].getLastStep();
                dataGridView1[5, i].Value = allAssesments[i].getNextStep();
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
            previousForm.Show();
            this.Close();
        }

        private void MyAssessments_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
