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
    public partial class AdminModuleMenu : Form
    {
        User currentUser;
        Form previousForm;
        public AdminModuleMenu(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ModuleAdd moduleAdd = new ModuleAdd(currentUser, this);
            this.Hide();
            moduleAdd.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ModuleEdit moduleEdit = new ModuleEdit(currentUser, this);
            this.Hide();
            moduleEdit.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ModuleDelete moduleDelete = new ModuleDelete(currentUser, this);
            this.Hide();
            moduleDelete.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//Module Team Manager Button
        {
            ModuleTeamManager moduleTeamManager = new ModuleTeamManager(currentUser, this);
            this.Hide();
            moduleTeamManager.Show();
        }
    }
}
