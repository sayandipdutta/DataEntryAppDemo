using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataEntryAppDemo
{
    public partial class MainForm : Form
    {
        private Boolean debugMode = false;

        public MainForm()
        {
            InitializeComponent();
            this.debugMode = false;
        }
        public MainForm(bool debugMode)
        {
            InitializeComponent();
            this.debugMode = debugMode;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (debugMode || (userNameTextBox.Text == "admin" && passwordTextBox.Text == "password"))
            {
                this.Hide();
                HomePageForm homePageForm = new HomePageForm();
                homePageForm.FormClosed += (s, args) => this.Close();
                homePageForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
