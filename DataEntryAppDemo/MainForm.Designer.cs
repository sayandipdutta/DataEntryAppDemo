namespace DataEntryAppDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nameSubmitButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(54, 40);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 21);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(54, 83);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(84, 21);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(167, 37);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(260, 29);
            firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(167, 80);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(260, 29);
            lastNameTextBox.TabIndex = 3;
            // 
            // nameSubmitButton
            // 
            nameSubmitButton.Location = new Point(54, 133);
            nameSubmitButton.Name = "nameSubmitButton";
            nameSubmitButton.Size = new Size(86, 31);
            nameSubmitButton.TabIndex = 4;
            nameSubmitButton.Text = "Submit";
            nameSubmitButton.UseVisualStyleBackColor = true;
            nameSubmitButton.Click += nameSubmitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(nameSubmitButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button nameSubmitButton;
    }
}
