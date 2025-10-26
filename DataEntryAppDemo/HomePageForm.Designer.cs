namespace DataEntryAppDemo
{
    partial class HomePageForm
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
            splitContainer1 = new SplitContainer();
            loadProjectButton = new Button();
            createProjectButton = new Button();
            recentProjectsGroupBox = new GroupBox();
            listView1 = new ListView();
            projectNameColumn = new ColumnHeader();
            projectCreatedAtColumn = new ColumnHeader();
            projectCreatedByColumn = new ColumnHeader();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            recentProjectsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, projectToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(loadProjectButton);
            splitContainer1.Panel1.Controls.Add(createProjectButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(recentProjectsGroupBox);
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 86;
            splitContainer1.TabIndex = 5;
            // 
            // loadProjectButton
            // 
            loadProjectButton.Location = new Point(402, 30);
            loadProjectButton.Name = "loadProjectButton";
            loadProjectButton.Size = new Size(110, 23);
            loadProjectButton.TabIndex = 8;
            loadProjectButton.Text = "Load Project";
            loadProjectButton.UseVisualStyleBackColor = true;
            // 
            // createProjectButton
            // 
            createProjectButton.Location = new Point(287, 30);
            createProjectButton.Name = "createProjectButton";
            createProjectButton.Size = new Size(100, 23);
            createProjectButton.TabIndex = 7;
            createProjectButton.Text = "Create Project";
            createProjectButton.UseVisualStyleBackColor = true;
            createProjectButton.Click += createProjectButton_Click;
            // 
            // recentProjectsGroupBox
            // 
            recentProjectsGroupBox.Controls.Add(listView1);
            recentProjectsGroupBox.Dock = DockStyle.Fill;
            recentProjectsGroupBox.Location = new Point(0, 0);
            recentProjectsGroupBox.Name = "recentProjectsGroupBox";
            recentProjectsGroupBox.Size = new Size(800, 336);
            recentProjectsGroupBox.TabIndex = 0;
            recentProjectsGroupBox.TabStop = false;
            recentProjectsGroupBox.Text = "Recent Projects";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { projectNameColumn, projectCreatedAtColumn, projectCreatedByColumn });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(3, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(794, 314);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // projectNameColumn
            // 
            projectNameColumn.Text = "Name";
            projectNameColumn.Width = 150;
            // 
            // projectCreatedAtColumn
            // 
            projectCreatedAtColumn.Text = "Created At";
            projectCreatedAtColumn.Width = 150;
            // 
            // projectCreatedByColumn
            // 
            projectCreatedByColumn.Text = "Created By";
            projectCreatedByColumn.Width = 150;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Name = "HomePageForm";
            Text = "HomePageForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            recentProjectsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private SplitContainer splitContainer1;
        private Button loadProjectButton;
        private Button createProjectButton;
        private GroupBox recentProjectsGroupBox;
        private ListView listView1;
        private ColumnHeader projectNameColumn;
        private ColumnHeader projectCreatedAtColumn;
        private ColumnHeader projectCreatedByColumn;
    }
}