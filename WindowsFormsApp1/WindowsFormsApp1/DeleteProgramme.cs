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
    public partial class DeleteProgramme : Form
    {
        User currentUser;
        Form previousForm;
        List<Programme> allProgrammes;
        public DeleteProgramme(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
            allProgrammes = SQLDatabase.SelectFromDatabase.ImportProgrammes();
            for (int i = 0; i < allProgrammes.Count; i++)
            {
                ProgrammeIDDropdown.Items.Add(allProgrammes[i].programmeID);
            }
        }

        private void ProgrammeIDDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < allProgrammes.Count; i++)
            {
                if (allProgrammes[i].programmeID == ProgrammeIDDropdown.Text)
                {
                    programmeDirectorTextbox.Text = allProgrammes[i].programmeDirectorID;
                    programmeNameTextBox.Text = allProgrammes[i].title;

                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//Delete Button
        {
            SQLDatabase.DeleteFromDatabase.DeleteProgramme(ProgrammeIDDropdown.Text);
            MessageBox.Show("Programme succesfuly deleted");
            ProgrammeIDDropdown.Items.Clear();
            allProgrammes = SQLDatabase.SelectFromDatabase.ImportProgrammes();
            for (int i = 0; i < allProgrammes.Count; i++)
            {
                ProgrammeIDDropdown.Items.Add(allProgrammes[i].programmeID);
            }
        }

        private void button1_Click(object sender, EventArgs e)//Back Button
        {
            previousForm.Show();
            this.Close();
        }
    }
}
