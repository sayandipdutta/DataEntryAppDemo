using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataEntryAppDemo
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateProjectForm createProjectForm = new CreateProjectForm();
            createProjectForm.FormClosed += (s, args) => this.Close();
            createProjectForm.Show();
        }
    }
}
