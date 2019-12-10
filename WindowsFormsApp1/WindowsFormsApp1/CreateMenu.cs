﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLDatabase;
using Backbone;
namespace UserInterface
{
    public partial class CreateMenu : Form
    {
        public User CurrentUser;
        public CreateMenu(User user)
        {
            CurrentUser = user;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(CurrentUser);
            this.Hide();
            homeForm.Show();
        }
    }
}