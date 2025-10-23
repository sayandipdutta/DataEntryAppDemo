using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace DataEntryAppDemo
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        private void addFieldButton_Click(object sender, EventArgs e)
        {
            var fieldName = fieldNameComboBox.Text?.Trim();
            if (string.IsNullOrWhiteSpace(fieldName))
                MessageBox.Show("Please enter a valid field name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (fieldNamesListBox.Items.Contains(fieldName))
                MessageBox.Show("Field name already exists.", "Duplicate Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                fieldNamesListBox.Items.Add(fieldName);

            fieldNameComboBox.Text = "";
        }

        private void templateEntryDoneButton_Click(object sender, EventArgs e)
        {
            if (fieldNamesListBox.Items.Count == 0)
                MessageBox.Show("Please add at least one field to the template.", "No Fields Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (instructionRichTextBox.Text.Trim().Length == 0)
                MessageBox.Show("Please provide instructions for the template.", "No Instructions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                this.DialogResult = DialogResult.OK;
        }

    }
}
