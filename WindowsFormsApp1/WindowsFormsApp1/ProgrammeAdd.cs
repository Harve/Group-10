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
    public partial class ProgrammeAdd : Form
    {
        User currentUser;
        Form previousForm;
        public ProgrammeAdd(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
            List<Role> allRoles = SQLDatabase.SelectFromDatabase.ImportRoles();
            for (int i = 0; i < allRoles.Count; i++)
            {
                if (allRoles[i].role== "Program Director")
                {
                    programDirectorDropdown.Items.Add(allRoles[i].userID);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((IDinput.Text.Count() >= 8) && (programmeNameInput.Text.Count() > 0) && (programDirectorDropdown.Text.Count() > 0))
            {
                SQLDatabase.InsertIntoDatabase.InsertIntoProgramme(IDinput.Text, programmeNameInput.Text, programDirectorDropdown.Text);

                MessageBox.Show("Programme Sucesfully Added");
                IDinput.Clear();
                programmeNameInput.Clear();
                programDirectorDropdown.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid Inputs");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void IDinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void programmeNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void programDirectorDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
