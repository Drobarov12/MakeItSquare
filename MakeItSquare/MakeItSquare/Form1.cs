
namespace MakeItSquare
{
    public partial class Form1 : Form
    {
        private Game _game;
        private List<Player> _players;

        public Form1(List<Player> players, int bordSize)
        {
            InitializeComponent();
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
    }
}
