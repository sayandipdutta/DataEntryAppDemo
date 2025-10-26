namespace DataEntryAppDemo
{
    partial class fieldNameEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fieldNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // fieldNameTextBox
            // 
            fieldNameTextBox.Location = new Point(25, 24);
            fieldNameTextBox.Name = "fieldNameTextBox";
            fieldNameTextBox.Size = new Size(316, 23);
            fieldNameTextBox.TabIndex = 1;
            fieldNameTextBox.KeyDown += fieldNameTextBox_KeyDown;
            // 
            // fieldNameEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 65);
            Controls.Add(fieldNameTextBox);
            Name = "fieldNameEntryForm";
            Text = "Enter Field Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox fieldNameTextBox;
    }
}