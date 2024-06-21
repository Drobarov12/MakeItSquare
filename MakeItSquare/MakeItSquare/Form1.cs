
namespace MakeItSquare
{
    public partial class Form1 : Form
    {
        private Game _game;
        private const int BOARD_SIZE = 4;

        public Form1()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            Player[] players = new Player[]
            {
                new Player { Name = "Player 1", Color = Color.Red },
                new Player { Name = "Player 2", Color = Color.Blue }
            };

            _game = new Game(BOARD_SIZE, players);

            myPanel.ClientSize = _game.GameSize();
            Invalidate();
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
            if (valid) myPanel.Invalidate();
        }
    }
}
