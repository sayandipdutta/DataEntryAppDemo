namespace DataEntryAppDemo
{
    partial class CreateProjectForm
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
            projectNameLabel = new Label();
            projectNameTextBox = new TextBox();
            fieldNameListView = new ListView();
            fieldNameAddButton = new Button();
            fieldNameDeleteButton = new Button();
            projectCreationDoneButton = new Button();
            fieldNameEditButton = new Button();
            importProjectButton = new Button();
            SuspendLayout();
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new Point(70, 55);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(79, 15);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "Project Name";
            // 
            // projectNameTextBox
            // 
            projectNameTextBox.Location = new Point(167, 50);
            projectNameTextBox.Name = "projectNameTextBox";
            projectNameTextBox.Size = new Size(212, 23);
            projectNameTextBox.TabIndex = 1;
            // 
            // fieldNameListView
            // 
            fieldNameListView.Location = new Point(71, 115);
            fieldNameListView.MultiSelect = false;
            fieldNameListView.Name = "fieldNameListView";
            fieldNameListView.Size = new Size(308, 274);
            fieldNameListView.TabIndex = 2;
            fieldNameListView.UseCompatibleStateImageBehavior = false;
            fieldNameListView.View = View.List;
            fieldNameListView.SelectedIndexChanged += fieldNameListView_SelectedIndexChanged;
            fieldNameListView.DoubleClick += fieldNameListView_DoubleClick;
            fieldNameListView.KeyDown += fieldNameListView_KeyDown;
            // 
            // fieldNameAddButton
            // 
            fieldNameAddButton.Location = new Point(104, 395);
            fieldNameAddButton.Name = "fieldNameAddButton";
            fieldNameAddButton.Size = new Size(75, 23);
            fieldNameAddButton.TabIndex = 3;
            fieldNameAddButton.Text = "&Add";
            fieldNameAddButton.UseVisualStyleBackColor = true;
            fieldNameAddButton.Click += fieldNameAddButton_Click;
            // 
            // fieldNameDeleteButton
            // 
            fieldNameDeleteButton.Enabled = false;
            fieldNameDeleteButton.Location = new Point(185, 395);
            fieldNameDeleteButton.Name = "fieldNameDeleteButton";
            fieldNameDeleteButton.Size = new Size(75, 23);
            fieldNameDeleteButton.TabIndex = 4;
            fieldNameDeleteButton.Text = "&Delete";
            fieldNameDeleteButton.UseVisualStyleBackColor = true;
            fieldNameDeleteButton.Click += fieldNameDeleteButton_Click;
            // 
            // projectCreationDoneButton
            // 
            projectCreationDoneButton.Location = new Point(698, 410);
            projectCreationDoneButton.Name = "projectCreationDoneButton";
            projectCreationDoneButton.Size = new Size(90, 28);
            projectCreationDoneButton.TabIndex = 5;
            projectCreationDoneButton.Text = "Done";
            projectCreationDoneButton.UseVisualStyleBackColor = true;
            projectCreationDoneButton.Click += projectCreationDoneButton_Click;
            // 
            // fieldNameEditButton
            // 
            fieldNameEditButton.Enabled = false;
            fieldNameEditButton.Location = new Point(266, 395);
            fieldNameEditButton.Name = "fieldNameEditButton";
            fieldNameEditButton.Size = new Size(75, 23);
            fieldNameEditButton.TabIndex = 6;
            fieldNameEditButton.Text = "&Edit";
            fieldNameEditButton.UseVisualStyleBackColor = true;
            fieldNameEditButton.Click += fieldNameEditButton_Click;
            // 
            // importProjectButton
            // 
            importProjectButton.Location = new Point(676, 12);
            importProjectButton.Name = "importProjectButton";
            importProjectButton.Size = new Size(112, 29);
            importProjectButton.TabIndex = 7;
            importProjectButton.Text = "Import Project";
            importProjectButton.UseVisualStyleBackColor = true;
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(importProjectButton);
            Controls.Add(fieldNameEditButton);
            Controls.Add(projectCreationDoneButton);
            Controls.Add(fieldNameDeleteButton);
            Controls.Add(fieldNameAddButton);
            Controls.Add(fieldNameListView);
            Controls.Add(projectNameTextBox);
            Controls.Add(projectNameLabel);
            Name = "CreateProjectForm";
            Text = "CreateProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label projectNameLabel;
        private TextBox projectNameTextBox;
        private ListView fieldNameListView;
        private Button fieldNameAddButton;
        private Button fieldNameDeleteButton;
        private Button projectCreationDoneButton;
        private Button fieldNameEditButton;
        private Button importProjectButton;
    }
}