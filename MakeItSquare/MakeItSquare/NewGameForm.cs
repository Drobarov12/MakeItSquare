using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeItSquare
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        private void playerOneColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                playerOneColor.BackColor = colorDialog.Color;
            }
        }

        private void playerTwoColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PlayerTwoColor.BackColor = colorDialog.Color;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var listOfPlayers = new List<Player>()
            {
                new Player(){ Name = playerOneTB.Text, Color = playerOneColor.BackColor },
                new Player(){ Name = playerTwoTB.Text, Color = PlayerTwoColor.BackColor }
            };

            var gameForm = new Form1(listOfPlayers, (int)gameSizeNumber.Value);
            Hide();
            gameForm.Show();
            gameForm.FormClosed += (s, args) => this.Show();
        }
    }
}
