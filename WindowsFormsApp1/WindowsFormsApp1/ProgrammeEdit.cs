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
    public partial class ProgrammeEdit : Form
    {
        User currentUser;
        Form previousForm;
        List<Programme> allProgrammes;
        public ProgrammeEdit(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
            List<Role> allRoles = SQLDatabase.SelectFromDatabase.ImportRoles();
            for (int i = 0; i < allRoles.Count; i++)
            {
                if (allRoles[i].role == "Program Director")
                {
                    programmeDirectorDropdown.Items.Add(allRoles[i].userID);
                }
            }
            allProgrammes = SQLDatabase.SelectFromDatabase.ImportProgrammes();
            for(int i = 0; i < allProgrammes.Count; i++)
            {
                programmeIDDropdown.Items.Add(allProgrammes[i].programmeID);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void programmeIDDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < allProgrammes.Count; i++)
            {
                if (allProgrammes[i].programmeID == programmeIDDropdown.Text)
                {
                    programmeDirectorDropdown.Text = allProgrammes[i].programmeDirectorID;
                    programmeNameTextbox.Text = allProgrammes[i].title;

                    break;
                }
            }
        }

        private void programmeDirectorDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if ((programmeNameTextbox.Text.Count() > 0) && (programmeIDDropdown.Text.Count() >= 8)&&(programmeDirectorDropdown.Text.Count()>0))
            {

                SQLDatabase.UpdateDatabase.UpdateProgramme(programmeIDDropdown.SelectedText, programmeNameTextbox.Text, programmeDirectorDropdown.SelectedText);
                programmeDirectorDropdown.Text = "";
                programmeIDDropdown.Text = "";
                programmeNameTextbox.Clear();

                MessageBox.Show("Programme Sucesfully Edited");
                
            }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}
