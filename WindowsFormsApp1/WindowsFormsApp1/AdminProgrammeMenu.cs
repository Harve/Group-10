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
    public partial class AdminProgrammeMenu : Form
    {
        User currentUser;
        Form previousForm;
        public AdminProgrammeMenu(User currentUser,Form previousForm)
        {
            this.currentUser = currentUser;
            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProgrammeAdd programmeAdd = new ProgrammeAdd(currentUser, this);
            this.Hide();
            programmeAdd.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ProgrammeEdit programmeEdit = new ProgrammeEdit(currentUser, this);
            this.Hide();
            programmeEdit.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteProgramme deleteProgramme = new DeleteProgramme(currentUser, this);
            this.Hide();
            deleteProgramme.Show();
        }
    }
}
