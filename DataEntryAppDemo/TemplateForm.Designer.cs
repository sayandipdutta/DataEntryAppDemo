namespace DataEntryAppDemo
{
    partial class TemplateForm
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
            instructionLabel = new Label();
            instructionRichTextBox = new RichTextBox();
            addFieldButton = new Button();
            fieldNameComboBox = new ComboBox();
            templateEntryDoneButton = new Button();
            fieldNamesListBox = new ListBox();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(90, 36);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(64, 15);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Instruction";
            // 
            // instructionRichTextBox
            // 
            instructionRichTextBox.Location = new Point(89, 54);
            instructionRichTextBox.Name = "instructionRichTextBox";
            instructionRichTextBox.Size = new Size(354, 80);
            instructionRichTextBox.TabIndex = 1;
            instructionRichTextBox.Text = "";
            // 
            // addFieldButton
            // 
            addFieldButton.Location = new Point(366, 153);
            addFieldButton.Name = "addFieldButton";
            addFieldButton.Size = new Size(75, 23);
            addFieldButton.TabIndex = 3;
            addFieldButton.Text = "Add Field ";
            addFieldButton.UseVisualStyleBackColor = true;
            addFieldButton.Click += addFieldButton_Click;
            // 
            // fieldNameComboBox
            // 
            fieldNameComboBox.FormattingEnabled = true;
            fieldNameComboBox.Location = new Point(89, 153);
            fieldNameComboBox.Name = "fieldNameComboBox";
            fieldNameComboBox.Size = new Size(258, 23);
            fieldNameComboBox.TabIndex = 5;
            // 
            // templateEntryDoneButton
            // 
            templateEntryDoneButton.Location = new Point(631, 389);
            templateEntryDoneButton.Name = "templateEntryDoneButton";
            templateEntryDoneButton.Size = new Size(75, 23);
            templateEntryDoneButton.TabIndex = 6;
            templateEntryDoneButton.Text = "Done";
            templateEntryDoneButton.UseVisualStyleBackColor = true;
            templateEntryDoneButton.Click += templateEntryDoneButton_Click;
            // 
            // fieldNamesListBox
            // 
            fieldNamesListBox.FormattingEnabled = true;
            fieldNamesListBox.Location = new Point(90, 220);
            fieldNamesListBox.Name = "fieldNamesListBox";
            fieldNamesListBox.Size = new Size(257, 94);
            fieldNamesListBox.TabIndex = 4;
            // 
            // TemplateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(templateEntryDoneButton);
            Controls.Add(fieldNameComboBox);
            Controls.Add(fieldNamesListBox);
            Controls.Add(addFieldButton);
            Controls.Add(instructionRichTextBox);
            Controls.Add(instructionLabel);
            Name = "TemplateForm";
            Text = "Add Template";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionLabel;
        private RichTextBox instructionRichTextBox;
        private Button addFieldButton;
        private ComboBox fieldNameComboBox;
        private Button templateEntryDoneButton;
        private ListBox fieldNamesListBox;
    }
}