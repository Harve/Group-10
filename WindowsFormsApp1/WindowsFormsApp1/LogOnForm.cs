using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class LogOnForm : Form
    {
        public LogOnForm()
        {
            this.BackColor = System.Drawing.Color.AliceBlue;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SQLDatabase.ManageDatabase.Logon(userIdTextBox.Text, passwordTextBox.Text) == true)
            {
                HomeForm homeForm = new HomeForm(userIdTextBox.Text);
                this.Hide();
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("User ID or Password incorrect.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void headerPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void userIdPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
