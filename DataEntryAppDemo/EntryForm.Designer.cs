namespace DataEntryAppDemo
{
    partial class EntryForm
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
            filesTabControl = new TabControl();
            tabPage1 = new TabPage();
            fileTree = new TreeView();
            tabPage2 = new TabPage();
            fileList = new ListBox();
            previewPictureBox = new PictureBox();
            metadataGroupBox = new GroupBox();
            instructionListBox = new ListBox();
            relPageNoNumEntry = new NumericUpDown();
            firstNameTextBox = new TextBox();
            imagePathLabel = new Label();
            doctypeComboBox = new ComboBox();
            relPageNoLabel = new Label();
            entryFormButton = new Button();
            doctypeLabel = new Label();
            absPageNoLabel = new Label();
            absPageNoNumEntry = new NumericUpDown();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            accountToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            filesTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).BeginInit();
            metadataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)relPageNoNumEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)absPageNoNumEntry).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Left;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(metadataGroupBox);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1029, 603);
            splitContainer1.SplitterDistance = 733;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(filesTabControl);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(previewPictureBox);
            splitContainer2.Size = new Size(733, 603);
            splitContainer2.SplitterDistance = 244;
            splitContainer2.TabIndex = 0;
            // 
            // filesTabControl
            // 
            filesTabControl.Controls.Add(tabPage1);
            filesTabControl.Controls.Add(tabPage2);
            filesTabControl.Location = new Point(3, 3);
            filesTabControl.Name = "filesTabControl";
            filesTabControl.SelectedIndex = 0;
            filesTabControl.Size = new Size(238, 575);
            filesTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(fileTree);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(230, 541);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // fileTree
            // 
            fileTree.Dock = DockStyle.Left;
            fileTree.Location = new Point(3, 3);
            fileTree.Name = "fileTree";
            fileTree.Size = new Size(224, 535);
            fileTree.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(fileList);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(230, 541);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // fileList
            // 
            fileList.Dock = DockStyle.Left;
            fileList.FormattingEnabled = true;
            fileList.Location = new Point(3, 3);
            fileList.Name = "fileList";
            fileList.Size = new Size(227, 535);
            fileList.TabIndex = 0;
            // 
            // previewPictureBox
            // 
            previewPictureBox.Location = new Point(3, 3);
            previewPictureBox.Name = "previewPictureBox";
            previewPictureBox.Size = new Size(479, 575);
            previewPictureBox.TabIndex = 0;
            previewPictureBox.TabStop = false;
            // 
            // metadataGroupBox
            // 
            metadataGroupBox.Controls.Add(instructionListBox);
            metadataGroupBox.Controls.Add(relPageNoNumEntry);
            metadataGroupBox.Controls.Add(firstNameTextBox);
            metadataGroupBox.Controls.Add(imagePathLabel);
            metadataGroupBox.Controls.Add(doctypeComboBox);
            metadataGroupBox.Controls.Add(relPageNoLabel);
            metadataGroupBox.Controls.Add(entryFormButton);
            metadataGroupBox.Controls.Add(doctypeLabel);
            metadataGroupBox.Controls.Add(absPageNoLabel);
            metadataGroupBox.Controls.Add(absPageNoNumEntry);
            metadataGroupBox.Location = new Point(3, 3);
            metadataGroupBox.Name = "metadataGroupBox";
            metadataGroupBox.Size = new Size(277, 319);
            metadataGroupBox.TabIndex = 20;
            metadataGroupBox.TabStop = false;
            metadataGroupBox.Text = "Metadata";
            // 
            // instructionListBox
            // 
            instructionListBox.FormattingEnabled = true;
            instructionListBox.Location = new Point(6, 236);
            instructionListBox.Name = "instructionListBox";
            instructionListBox.Size = new Size(260, 25);
            instructionListBox.TabIndex = 20;
            // 
            // relPageNoNumEntry
            // 
            relPageNoNumEntry.Location = new Point(220, 186);
            relPageNoNumEntry.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            relPageNoNumEntry.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            relPageNoNumEntry.Name = "relPageNoNumEntry";
            relPageNoNumEntry.Size = new Size(46, 29);
            relPageNoNumEntry.TabIndex = 19;
            relPageNoNumEntry.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(6, 49);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(260, 29);
            firstNameTextBox.TabIndex = 13;
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
            // doctypeComboBox
            // 
            doctypeComboBox.FormattingEnabled = true;
            doctypeComboBox.Location = new Point(6, 119);
            doctypeComboBox.Name = "doctypeComboBox";
            doctypeComboBox.Size = new Size(260, 29);
            doctypeComboBox.TabIndex = 15;
            // 
            // relPageNoLabel
            // 
            relPageNoLabel.AutoSize = true;
            relPageNoLabel.Location = new Point(143, 173);
            relPageNoLabel.MaximumSize = new Size(100, 0);
            relPageNoLabel.Name = "relPageNoLabel";
            relPageNoLabel.Size = new Size(71, 42);
            relPageNoLabel.TabIndex = 18;
            relPageNoLabel.Text = "Relative Page No.";
            // 
            // entryFormButton
            // 
            entryFormButton.Location = new Point(124, 276);
            entryFormButton.Name = "entryFormButton";
            entryFormButton.Size = new Size(144, 31);
            entryFormButton.TabIndex = 14;
            entryFormButton.Text = "Open Entry Form";
            entryFormButton.UseVisualStyleBackColor = true;
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
            // absPageNoNumEntry
            // 
            absPageNoNumEntry.Location = new Point(87, 186);
            absPageNoNumEntry.Name = "absPageNoNumEntry";
            absPageNoNumEntry.Size = new Size(46, 29);
            absPageNoNumEntry.TabIndex = 17;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 608);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1029, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, projectToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1029, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(52, 20);
            fileToolStripMenuItem.Text = "Home";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(56, 20);
            projectToolStripMenuItem.Text = "Project";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(64, 20);
            accountToolStripMenuItem.Text = "Account";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            filesTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)previewPictureBox).EndInit();
            metadataGroupBox.ResumeLayout(false);
            metadataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)relPageNoNumEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)absPageNoNumEntry).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox metadataGroupBox;
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
        private TabControl filesTabControl;
        private TabPage tabPage1;
        private TreeView fileTree;
        private TabPage tabPage2;
        private ListBox fileList;
        private PictureBox previewPictureBox;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem accountToolStripMenuItem;
    }
}
