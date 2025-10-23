using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataEntryAppDemo
{
    public partial class CreateProjectForm : Form
    {
        public CreateProjectForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openTemplateForm_Click(object sender, EventArgs e)
        {
            var templateForm = new TemplateForm();
            templateForm.ShowDialog();
        }
    }
}
