
namespace MakeItSquare
{
    public partial class Form1 : Form
    {
        private Game _game;

        public Form1(List<Player> players, int bordSize)
        {
            InitializeComponent();
            Init(players, bordSize);
            this.DoubleBuffered = true;
        }

        private void Init(List<Player> players, int bordSize)
        {
            _game = new Game(bordSize, players);
            CreateListOfPlayers(players);
            playerLabel.Text = _game.GetCurrentPlayer().Name;

            myPanel.ClientSize = _game.GameSize();
            Invalidate();
        }

        private void CreateListOfPlayers(List<Player> players)
        {
            playersList.Items.Clear();
            players.ForEach(x => playersList.Items.Add(x.Name));
            SetBackgroundColorOnItems(players);
        }

        private void SetBackgroundColorOnItems(List<Player> players)
        {
            foreach (ListViewItem player in playersList.Items)
            {
                var p = players.First(x => x.Name == player.Text);
                if (p is not null)
                    player.BackColor = p.Color;

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           /* Graphics g = e.Graphics;
            _game.Draw(g);*/
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           /* Point clickedPoint = new Point(e.X, e.Y);
            bool valid = _game.Clicked(clickedPoint);
            if (valid) Invalidate();*/
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
                myPanel.Invalidate();
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
