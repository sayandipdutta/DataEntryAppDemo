using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataEntryAppDemo
{
    public partial class fieldNameEntryForm : Form
    {
        public string? fieldName;

        public fieldNameEntryForm()
        {
            InitializeComponent();
        }

        public void SetInitialFieldName(string initialFieldName = "")
        {
            fieldNameTextBox.Text = initialFieldName;
        }

        private void fieldNameDoneButton_Click(object sender, EventArgs e)
        {
            var _fieldName = fieldNameTextBox.Text?.Trim();
            if (string.IsNullOrEmpty(_fieldName)) {
                MessageBox.Show("Please enter a valid field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fieldName = _fieldName;
            this.DestroyHandle();
        }

        private void fieldNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Handled && e.KeyCode != Keys.Enter) return;
            var _fieldName = fieldNameTextBox.Text?.Trim();
            if (string.IsNullOrEmpty(_fieldName))
            {
                MessageBox.Show("Please enter a valid field name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fieldName = _fieldName;
            fieldNameTextBox.Text = "";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
