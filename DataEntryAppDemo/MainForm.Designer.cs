namespace DataEntryAppDemo
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            userNameLabel = new Label();
            passwordLabel = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, projectToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(52, 20);
            fileToolStripMenuItem.Text = "Home";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(56, 20);
            projectToolStripMenuItem.Text = "Project";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(64, 20);
            accountToolStripMenuItem.Text = "Account";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(211, 148);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(60, 15);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(211, 187);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(282, 145);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(290, 23);
            userNameTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(282, 184);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(290, 23);
            passwordTextBox.TabIndex = 7;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(478, 233);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 25);
            loginButton.TabIndex = 8;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
    }
}