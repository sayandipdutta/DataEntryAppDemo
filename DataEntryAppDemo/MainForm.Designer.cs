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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            relPageNoNumEntry = new NumericUpDown();
            relPageNoLabel = new Label();
            absPageNoNumEntry = new NumericUpDown();
            absPageNoLabel = new Label();
            doctypeComboBox = new ComboBox();
            entryFormButton = new Button();
            firstNameTextBox = new TextBox();
            doctypeLabel = new Label();
            imagePathLabel = new Label();
            instructionListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)relPageNoNumEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)absPageNoNumEntry).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(1029, 630);
            splitContainer1.SplitterDistance = 733;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Size = new Size(733, 630);
            splitContainer2.SplitterDistance = 244;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(instructionListBox);
            groupBox1.Controls.Add(relPageNoNumEntry);
            groupBox1.Controls.Add(firstNameTextBox);
            groupBox1.Controls.Add(imagePathLabel);
            groupBox1.Controls.Add(doctypeComboBox);
            groupBox1.Controls.Add(relPageNoLabel);
            groupBox1.Controls.Add(entryFormButton);
            groupBox1.Controls.Add(doctypeLabel);
            groupBox1.Controls.Add(absPageNoLabel);
            groupBox1.Controls.Add(absPageNoNumEntry);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 389);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // relPageNoNumEntry
            // 
            relPageNoNumEntry.Location = new Point(167, 228);
            relPageNoNumEntry.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            relPageNoNumEntry.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            relPageNoNumEntry.Name = "relPageNoNumEntry";
            relPageNoNumEntry.Size = new Size(97, 29);
            relPageNoNumEntry.TabIndex = 19;
            relPageNoNumEntry.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // relPageNoLabel
            // 
            relPageNoLabel.AutoSize = true;
            relPageNoLabel.Location = new Point(167, 173);
            relPageNoLabel.MaximumSize = new Size(100, 0);
            relPageNoLabel.Name = "relPageNoLabel";
            relPageNoLabel.Size = new Size(71, 42);
            relPageNoLabel.TabIndex = 18;
            relPageNoLabel.Text = "Relative Page No.";
            // 
            // absPageNoNumEntry
            // 
            absPageNoNumEntry.Location = new Point(6, 228);
            absPageNoNumEntry.Name = "absPageNoNumEntry";
            absPageNoNumEntry.Size = new Size(99, 29);
            absPageNoNumEntry.TabIndex = 17;
            // 
            // absPageNoLabel
            // 
            absPageNoLabel.AutoSize = true;
            absPageNoLabel.Location = new Point(6, 173);
            absPageNoLabel.MaximumSize = new Size(100, 0);
            absPageNoLabel.Name = "absPageNoLabel";
            absPageNoLabel.Size = new Size(75, 42);
            absPageNoLabel.TabIndex = 16;
            absPageNoLabel.Text = "Absolute Page No.";
            // 
            // doctypeComboBox
            // 
            doctypeComboBox.FormattingEnabled = true;
            doctypeComboBox.Location = new Point(6, 119);
            doctypeComboBox.Name = "doctypeComboBox";
            doctypeComboBox.Size = new Size(260, 29);
            doctypeComboBox.TabIndex = 15;
            // 
            // entryFormButton
            // 
            entryFormButton.Location = new Point(124, 346);
            entryFormButton.Name = "entryFormButton";
            entryFormButton.Size = new Size(142, 31);
            entryFormButton.TabIndex = 14;
            entryFormButton.Text = "Open Entry Form";
            entryFormButton.UseVisualStyleBackColor = true;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(6, 49);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(260, 29);
            firstNameTextBox.TabIndex = 13;
            // 
            // doctypeLabel
            // 
            doctypeLabel.AutoSize = true;
            doctypeLabel.Location = new Point(6, 95);
            doctypeLabel.Name = "doctypeLabel";
            doctypeLabel.Size = new Size(67, 21);
            doctypeLabel.TabIndex = 12;
            doctypeLabel.Text = "Doctype";
            // 
            // imagePathLabel
            // 
            imagePathLabel.AutoSize = true;
            imagePathLabel.Enabled = false;
            imagePathLabel.Location = new Point(6, 25);
            imagePathLabel.Name = "imagePathLabel";
            imagePathLabel.Size = new Size(87, 21);
            imagePathLabel.TabIndex = 11;
            imagePathLabel.Text = "Image Path";
            // 
            // instructionListBox
            // 
            instructionListBox.FormattingEnabled = true;
            instructionListBox.Location = new Point(6, 306);
            instructionListBox.Name = "instructionListBox";
            instructionListBox.Size = new Size(258, 25);
            instructionListBox.TabIndex = 20;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)relPageNoNumEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)absPageNoNumEntry).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private NumericUpDown relPageNoNumEntry;
        private TextBox firstNameTextBox;
        private Label imagePathLabel;
        private ComboBox doctypeComboBox;
        private Label relPageNoLabel;
        private Button entryFormButton;
        private Label doctypeLabel;
        private Label absPageNoLabel;
        private NumericUpDown absPageNoNumEntry;
        private ListBox instructionListBox;
    }
}
