namespace MakeItSquare
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            myPanel = new Panel();
            playersLabel = new Label();
            gameLabel = new Label();
            playersList = new ListView();
            label1 = new Label();
            playerLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            playersScoreLB = new ListBox();
            playersScore = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // myPanel
            // 
            myPanel.Location = new Point(73, 44);
            myPanel.Name = "myPanel";
            myPanel.Size = new Size(447, 347);
            myPanel.TabIndex = 0;
            myPanel.Paint += myPanel_Paint;
            myPanel.MouseClick += myPanel_MouseClick;
            // 
            // playersLabel
            // 
            playersLabel.AutoSize = true;
            playersLabel.Location = new Point(575, 86);
            playersLabel.Name = "playersLabel";
            playersLabel.Size = new Size(44, 15);
            playersLabel.TabIndex = 0;
            playersLabel.Text = "Players";
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.Location = new Point(79, 23);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(38, 15);
            gameLabel.TabIndex = 1;
            gameLabel.Text = "Game";
            // 
            // playersList
            // 
            playersList.GridLines = true;
            playersList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            playersList.Location = new Point(575, 104);
            playersList.Name = "playersList";
            playersList.Size = new Size(182, 97);
            playersList.TabIndex = 2;
            playersList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 22);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Player: ";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Location = new Point(253, 22);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(20, 15);
            playerLabel.TabIndex = 4;
            playerLabel.Text = "P1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // playersScoreLB
            // 
            playersScoreLB.FormattingEnabled = true;
            playersScoreLB.ItemHeight = 15;
            playersScoreLB.Location = new Point(575, 259);
            playersScoreLB.Name = "playersScoreLB";
            playersScoreLB.Size = new Size(120, 94);
            playersScoreLB.TabIndex = 6;
            // 
            // playersScore
            // 
            playersScore.AutoSize = true;
            playersScore.Location = new Point(575, 241);
            playersScore.Name = "playersScore";
            playersScore.Size = new Size(36, 15);
            playersScore.TabIndex = 7;
            playersScore.Text = "Score";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playersScore);
            Controls.Add(playersScoreLB);
            Controls.Add(playerLabel);
            Controls.Add(label1);
            Controls.Add(playersList);
            Controls.Add(gameLabel);
            Controls.Add(playersLabel);
            Controls.Add(myPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel myPanel;
        private Label playersLabel;
        private Label gameLabel;
        private ListView playersList;
        private Label label1;
        private Label playerLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ListBox playersScoreLB;
        private Label playersScore;
    }
}
