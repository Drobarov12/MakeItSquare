namespace MakeItSquare
{
    partial class NewGameForm
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
            playerOneLabel = new Label();
            playerTwoLabel = new Label();
            playerOneTB = new TextBox();
            playerTwoTB = new TextBox();
            playerOneColor = new PictureBox();
            PlayerTwoColor = new PictureBox();
            playerOneColorButton = new Button();
            playerTwoColorButton = new Button();
            gameLabel = new Label();
            gameSizeNumber = new NumericUpDown();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)playerOneColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerTwoColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gameSizeNumber).BeginInit();
            SuspendLayout();
            // 
            // playerOneLabel
            // 
            playerOneLabel.AutoSize = true;
            playerOneLabel.Location = new Point(48, 78);
            playerOneLabel.Name = "playerOneLabel";
            playerOneLabel.Size = new Size(84, 15);
            playerOneLabel.TabIndex = 0;
            playerOneLabel.Text = "Player 1 name:";
            // 
            // playerTwoLabel
            // 
            playerTwoLabel.AutoSize = true;
            playerTwoLabel.Location = new Point(48, 121);
            playerTwoLabel.Name = "playerTwoLabel";
            playerTwoLabel.Size = new Size(84, 15);
            playerTwoLabel.TabIndex = 1;
            playerTwoLabel.Text = "Player 2 name:";
            // 
            // playerOneTB
            // 
            playerOneTB.Location = new Point(138, 75);
            playerOneTB.Name = "playerOneTB";
            playerOneTB.Size = new Size(100, 23);
            playerOneTB.TabIndex = 2;
            playerOneTB.Text = "P1";
            // 
            // playerTwoTB
            // 
            playerTwoTB.Location = new Point(138, 118);
            playerTwoTB.Name = "playerTwoTB";
            playerTwoTB.Size = new Size(100, 23);
            playerTwoTB.TabIndex = 3;
            playerTwoTB.Text = "P2";
            // 
            // playerOneColor
            // 
            playerOneColor.BackColor = Color.Blue;
            playerOneColor.Location = new Point(260, 75);
            playerOneColor.Name = "playerOneColor";
            playerOneColor.Size = new Size(23, 23);
            playerOneColor.TabIndex = 4;
            playerOneColor.TabStop = false;
            // 
            // PlayerTwoColor
            // 
            PlayerTwoColor.BackColor = Color.Red;
            PlayerTwoColor.Location = new Point(260, 118);
            PlayerTwoColor.Name = "PlayerTwoColor";
            PlayerTwoColor.Size = new Size(23, 23);
            PlayerTwoColor.TabIndex = 5;
            PlayerTwoColor.TabStop = false;
            // 
            // playerOneColorButton
            // 
            playerOneColorButton.Location = new Point(312, 75);
            playerOneColorButton.Name = "playerOneColorButton";
            playerOneColorButton.Size = new Size(75, 23);
            playerOneColorButton.TabIndex = 6;
            playerOneColorButton.Text = "Color";
            playerOneColorButton.UseVisualStyleBackColor = true;
            playerOneColorButton.Click += playerOneColorButton_Click;
            // 
            // playerTwoColorButton
            // 
            playerTwoColorButton.Location = new Point(312, 118);
            playerTwoColorButton.Name = "playerTwoColorButton";
            playerTwoColorButton.Size = new Size(75, 23);
            playerTwoColorButton.TabIndex = 7;
            playerTwoColorButton.Text = "Color";
            playerTwoColorButton.UseVisualStyleBackColor = true;
            playerTwoColorButton.Click += playerTwoColorButton_Click;
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.Location = new Point(128, 206);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(63, 15);
            gameLabel.TabIndex = 9;
            gameLabel.Text = "Game size:";
            // 
            // gameSizeNumber
            // 
            gameSizeNumber.Location = new Point(210, 204);
            gameSizeNumber.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            gameSizeNumber.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            gameSizeNumber.Name = "gameSizeNumber";
            gameSizeNumber.Size = new Size(120, 23);
            gameSizeNumber.TabIndex = 10;
            gameSizeNumber.ThousandsSeparator = true;
            gameSizeNumber.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // startButton
            // 
            startButton.Location = new Point(191, 315);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 11;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(startButton);
            Controls.Add(gameSizeNumber);
            Controls.Add(gameLabel);
            Controls.Add(playerTwoColorButton);
            Controls.Add(playerOneColorButton);
            Controls.Add(PlayerTwoColor);
            Controls.Add(playerOneColor);
            Controls.Add(playerTwoTB);
            Controls.Add(playerOneTB);
            Controls.Add(playerTwoLabel);
            Controls.Add(playerOneLabel);
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)playerOneColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerTwoColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)gameSizeNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label playerOneLabel;
        private Label playerTwoLabel;
        private TextBox playerOneTB;
        private TextBox playerTwoTB;
        private PictureBox playerOneColor;
        private PictureBox PlayerTwoColor;
        private Button playerOneColorButton;
        private Button playerTwoColorButton;
        private Label gameLabel;
        private NumericUpDown gameSizeNumber;
        private Button startButton;
    }
}