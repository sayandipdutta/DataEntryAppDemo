using DataEntryLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void fieldNameAddButton_Click(object sender, EventArgs e)
        {
            using fieldNameEntryForm entryForm = new fieldNameEntryForm();
            switch (entryForm.ShowDialog())
            {
                case DialogResult.Cancel:
                case DialogResult.Abort:
                    return;
            }

            string? fieldName = entryForm.fieldName;

            if (string.IsNullOrEmpty(fieldName))
                MessageBox.Show("Field name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (fieldNameListView
                    .Items
                    .Cast<ListViewItem>()
                    .Any(item => item.Text == entryForm.fieldName))
                MessageBox.Show("Field name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                fieldNameListView.Items.Add(fieldName);
        }

        private void fieldNameListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = fieldNameListView.SelectedItems.Count > 0;
            fieldNameDeleteButton.Enabled = itemSelected;
            fieldNameEditButton.Enabled = itemSelected;
        }

        private void deleteFieldName()
        {
            if (fieldNameListView.SelectedIndices.Count == 0) return;
            var response = MessageBox.Show("Are you sure you want to delete the selected field name?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
                fieldNameListView.Items.RemoveAt(fieldNameListView.SelectedIndices[0]);
        }

        private void fieldNameDeleteButton_Click(object sender, EventArgs e)
        {
            deleteFieldName();
        }

        private void editFieldName()
        {
            var selectedItemIndex = fieldNameListView.SelectedIndices[0];
            if (selectedItemIndex < 0) return;
            var selectedItem = fieldNameListView.Items[selectedItemIndex];
            using fieldNameEntryForm entryForm = new fieldNameEntryForm();
            entryForm.SetInitialFieldName(selectedItem.Text);
            switch (entryForm.ShowDialog())
            {
                case DialogResult.Cancel:
                case DialogResult.Abort:
                    return;
            }
            string? fieldName = entryForm.fieldName;
            if (string.IsNullOrEmpty(fieldName))
                MessageBox.Show("Field name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (fieldNameListView
                    .Items
                    .Cast<ListViewItem>()
                    .Any(item => item.Text == entryForm.fieldName && item != selectedItem))
                MessageBox.Show("Field name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                selectedItem.Text = fieldName;
        }

        private void fieldNameListView_DoubleClick(object sender, EventArgs e)
        {
            editFieldName();
        }

        private void fieldNameEditButton_Click(object sender, EventArgs e)
        {
            editFieldName();
        }

        private void fieldNameListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Handled || fieldNameListView.SelectedIndices.Count == 0) return;
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    deleteFieldName();
                    break;
                case Keys.Enter:
                case Keys.F2:
                    editFieldName();
                    break;
            }
        }

        private void projectCreationDoneButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(projectNameTextBox.Text))
                MessageBox.Show("Project name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (fieldNameListView.Items.Count == 0)
                MessageBox.Show("At least one field name must be added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ProjectConfig projectDetails = new(
                    projectNameTextBox.Text,
                    [.. fieldNameListView.Items
                        .Cast<ListViewItem>()
                        .Select(item => item.Text)]
                );

                string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string projectsPath = Path.Combine(localAppDataPath, "project.txt");
                DataEntryController.SaveProject(projectDetails, projectsPath, username);
                DialogResult = DialogResult.OK;
            }

        }
    }
}
