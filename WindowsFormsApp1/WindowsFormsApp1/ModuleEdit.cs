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
    public partial class ModuleEdit : Form
    {
        User currentUser;
        Form previousForm;
        List<Programme> allProgrammes;
        List<Module> allModules;
        public ModuleEdit(User currentUser,Form previousForm)
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
            allProgrammes = SQLDatabase.SelectFromDatabase.ImportProgrammes();
            for (int i = 0; i < allProgrammes.Count; i++)
            {
                programmeIDDropdown.Items.Add(allProgrammes[i].programmeID);
            }

            allModules = SQLDatabase.SelectFromDatabase.ImportModules();
            for (int i = 0; i < allModules.Count; i++)
            {
                moduleIdDropdown.Items.Add(allModules[i].moduleID);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if ((programmeIDDropdown.Text.Count() > 0) && (moduleNameTextbox.Text.Count() > 0) && (moduleLeaderDropdown.Text.Count() > 0) && (moduleIdDropdown.Text.Count() >= 8))
            {
                SQLDatabase.UpdateDatabase.UpdateModule(moduleIdDropdown.Text, moduleNameTextbox.Text, programmeIDDropdown.Text, moduleLeaderDropdown.Text);

                MessageBox.Show("Module Infromation Sucessfuly Updated");
                moduleIdDropdown.Text = "";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < allModules.Count(); i++)
            {
                if (allModules[i].moduleID == moduleIdDropdown.Text)
                {
                    moduleNameTextbox.Text = allModules[i].title;
                    moduleLeaderDropdown.Text = allModules[i].moduleLeaderID;
                    programmeIDDropdown.Text = allModules[i].programmeID;

                    break;
                }
            }
        }
    }
}
