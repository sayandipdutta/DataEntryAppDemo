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
            openTemplateForm = new Button();
            templateInfoTreeView = new TreeView();
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
            // openTemplateForm
            // 
            openTemplateForm.Location = new Point(72, 109);
            openTemplateForm.Name = "openTemplateForm";
            openTemplateForm.Size = new Size(111, 23);
            openTemplateForm.TabIndex = 2;
            openTemplateForm.Text = "Add Template";
            openTemplateForm.UseVisualStyleBackColor = true;
            openTemplateForm.Click += openTemplateForm_Click;
            // 
            // templateInfoTreeView
            // 
            templateInfoTreeView.Location = new Point(78, 176);
            templateInfoTreeView.Name = "templateInfoTreeView";
            templateInfoTreeView.Size = new Size(121, 97);
            templateInfoTreeView.TabIndex = 3;
            // 
            // CreateProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(templateInfoTreeView);
            Controls.Add(openTemplateForm);
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
        private Button openTemplateForm;
        private TreeView templateInfoTreeView;
    }
}