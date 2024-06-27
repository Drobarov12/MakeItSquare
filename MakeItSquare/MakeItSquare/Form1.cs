
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace MakeItSquare
{
    public partial class Form1 : Form
    {
        private Game _game;
        private List<Player> _players;
        public string FileName { get; set; }

        public Form1(List<Player> players, int bordSize)
        {
            InitializeComponent();
            Text = "Game";
            _players = players;
            Init(bordSize);
            this.DoubleBuffered = true;
        }

        private void Init(int bordSize)
        {
            _game = new Game(bordSize, _players);

            CreateListOfPlayers();
            playerLabel.Text = _game.GetCurrentPlayer().Name;
            myPanel.ClientSize = _game.GameSize();

            UpdatePlayersScore();

            Invalidate();
        }

        private void CreateListOfPlayers()
        {
            playersList.Items.Clear();
            _players.ForEach(x => playersList.Items.Add(x.Name));
            SetBackgroundColorOnItems();
        }

        private void SetBackgroundColorOnItems()
        {
            foreach (ListViewItem player in playersList.Items)
            {
                var p = _players.First(x => x.Name == player.Text);
                if (p is not null)
                    player.BackColor = p.Color;

            }
        }


        private void myPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _game.Draw(g);
        }

        private void myPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickedPoint = new Point(e.X, e.Y);
            bool valid = _game.Clicked(clickedPoint);
            if (valid)
            {
                playerLabel.Text = _game.GetCurrentPlayer().Name;
                UpdatePlayersScore();
                myPanel.Invalidate();
            }
            if (_game.IsFinished)
            {
                HandelFinishedGame();

            }

        }

        private void HandelFinishedGame()
        {
            var wonPlayer = _game.PlayerWon();
            string message;
            if (wonPlayer.Count == 1)
            {
                message = $"{wonPlayer[0].Name} won the game !!!";
            }
            else
            {
                message = "It's a draw!";
            }

            DialogResult result = MessageBox.Show(message, "Play another game?", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void UpdatePlayersScore()
        {
            playersScoreLB.Enabled = false;
            playersScoreLB.Items.Clear();
            _players.ForEach(p => playersScoreLB.Items.Add(p));
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "MakeItSqeare doc file (*.square)|*.square";
                saveFileDialog.Title = "Save MakeItSqeare doc";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                    IFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                    formatter.Serialize(fileStream, _game);
                }
            }
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MakeItSqeare doc file (*.square)|*.square";
            openFileDialog.Title = "Save MakeItSqeare doc";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                        IFormatter formater = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                        _game = (Game)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}
