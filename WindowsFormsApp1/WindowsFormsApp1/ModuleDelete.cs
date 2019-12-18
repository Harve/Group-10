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
    public partial class ModuleDelete : Form
    {
        User currentUser;
        Form previousForm;
        List<Module> allModules;
        public ModuleDelete(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();

            allModules = SQLDatabase.SelectFromDatabase.ImportModules();
            for (int i = 0; i < allModules.Count; i++)
            {
                moduleIDDropdown.Items.Add(allModules[i].moduleID);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SQLDatabase.DeleteFromDatabase.DeleteModule(moduleIDDropdown.Text);

            MessageBox.Show("Module Succesfully Deleted");
            moduleIDDropdown.Items.Clear();
            moduleLeaderTextbox.Clear();
            moduleNameTextbox.Clear();
            programmeIDTextbox.Clear();
            allModules = SQLDatabase.SelectFromDatabase.ImportModules();
            for(int i = 0; i < allModules.Count(); i++)
            {
                moduleIDDropdown.Items.Add(allModules[i].moduleID);
            }
        }

        private void moduleIDDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0;i<allModules.Count;i++)
            {
                if (allModules[i].moduleID == moduleIDDropdown.Text)
                {
                    moduleLeaderTextbox.Text = allModules[i].moduleLeaderID;
                    moduleNameTextbox.Text = allModules[i].title;
                    programmeIDTextbox.Text = allModules[i].programmeID;

                    break;
                }
            }
        }
    }
}
