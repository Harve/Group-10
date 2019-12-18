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
    public partial class ModuleAdd : Form
    {
        User currentUser;
        Form previousForm;
        public ModuleAdd(User currentUser, Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();

            List<Role> allRoles = SQLDatabase.SelectFromDatabase.ImportRoles();
            for (int i = 0; i < allRoles.Count; i++)
            {
                if (allRoles[i].role == "Module Leader")
                {
                    moduleLeaderDropdown.Items.Add(allRoles[i].userID);
                }
            }
            List<Programme> allProgrammes = SQLDatabase.SelectFromDatabase.ImportProgrammes();
            for(int i = 0; i < allProgrammes.Count; i++)
            {
                programmeIDDropdown.Items.Add(allProgrammes[i].programmeID);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((programmeIDDropdown.Text.Count() > 0) && (moduleNameTextbox.Text.Count() > 0) && (moduleLeaderDropdown.Text.Count() > 0) && (moduleIDTextbox.Text.Count() >= 8))
            {
                SQLDatabase.InsertIntoDatabase.InsertIntoModule(moduleIDTextbox.Text, moduleNameTextbox.Text, programmeIDDropdown.Text, moduleLeaderDropdown.Text);

                MessageBox.Show("Module Sucesfully Added");
                moduleIDTextbox.Clear();
                moduleNameTextbox.Clear();
                moduleLeaderDropdown.Text = "";
                programmeIDDropdown.Text = "";
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
    }
}
