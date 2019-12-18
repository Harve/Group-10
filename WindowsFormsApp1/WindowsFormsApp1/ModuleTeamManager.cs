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
    public partial class ModuleTeamManager : Form
    {
        User currentUser;
        Form previousForm;
        List<ModuleTeam> allModuleTeams;
        List<Module> allModules;
        List<Role> allRoles;
        public ModuleTeamManager(User currentUser, Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();

            allModuleTeams = SQLDatabase.SelectFromDatabase.ImportModuleTeams();
            allModules = SQLDatabase.SelectFromDatabase.ImportModules();
            allRoles = SQLDatabase.SelectFromDatabase.ImportRoles();

            for(int i = 0; i < allModules.Count; i++)
            {
                moduleIDDropdown.Items.Add(allModules[i].moduleID);
            }
            for(int i = 0; i < allRoles.Count; i++)
            {
                if(allRoles[i].role == "Module Team")
                {
                    newModuleTeamChecked.Items.Add(allRoles[i].userID);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //SQLDatabase.DeleteFromDatabase.DeleteModuleTeam(moduleIDDropdown.Text);

            var temp = newModuleTeamChecked.CheckedIndices;
            string temp2 = moduleIDDropdown.Text;
            for (int i = 0; i < temp.Count; i++)
            {
                newModuleTeamChecked.SelectedIndex = temp[i];
                string temp3 = newModuleTeamChecked.Text;
                if(oldModuleTeamList.Items.Contains(temp3))
                {
                    continue;
                }
                SQLDatabase.InsertIntoDatabase.InsertIntoModuleTeam(temp3,temp2);
            }

            MessageBox.Show("Module Team Succesfully Updated");
            moduleIDDropdown.Text = "";
            oldModuleTeamList.Items.Clear();
            allModuleTeams = SQLDatabase.SelectFromDatabase.ImportModuleTeams();

            foreach (int i in newModuleTeamChecked.CheckedIndices)
            {
                newModuleTeamChecked.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void moduleIDDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            oldModuleTeamList.Items.Clear();
            for (int i = 0; i < allModuleTeams.Count; i++)
            {
                if(allModuleTeams[i].moduleID == moduleIDDropdown.Text)
                {
                    oldModuleTeamList.Items.Add(allModuleTeams[i].userID);
                }
            }
        }
    }
}
