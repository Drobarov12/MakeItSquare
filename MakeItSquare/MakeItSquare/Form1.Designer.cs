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
            myPanel = new Panel();
            playersLabel = new Label();
            gameLabel = new Label();
            playersList = new ListView();
            label1 = new Label();
            playerLabel = new Label();
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
            playersLabel.Location = new Point(575, 75);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playerLabel);
            Controls.Add(label1);
            Controls.Add(playersList);
            Controls.Add(gameLabel);
            Controls.Add(playersLabel);
            Controls.Add(myPanel);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
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
    }
}
