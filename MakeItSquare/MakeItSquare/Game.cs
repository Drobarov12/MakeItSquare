using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MakeItSquare
{
    public class Game
    {
        public int BoardSize { get; private set; }
        public Line[,] HorizontalLines { get; private set; }
        public Line[,] VerticalLines { get; private set; }
        public Square[,] Squares { get; private set; }
        public List<Player> Players { get; private set; }
        public bool IsFinished { get; set; }
        private List<Point> dots;
        private int currentPlayerIndex;
        private const int DOT_SPACING = 50;
        private const int DOT_SIZE = 7;


        public Game(int boardSize,List<Player> players)
        {
            BoardSize = boardSize;
            Players = players;
            currentPlayerIndex = 0;
            dots = new List<Point>();
            IsFinished = false;
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            HorizontalLines = new Line[BoardSize + 1, BoardSize+1];
            VerticalLines = new Line[BoardSize + 1, BoardSize + 1];
            Squares = new Square[BoardSize, BoardSize];

            // Initialize lines and squares
            for (int i = 0; i <= BoardSize; i++)
            {
                for (int j = 0; j <= BoardSize; j++)

                {
                    dots.Add(new Point(i * DOT_SPACING, j * DOT_SPACING));
                }
            }

            for (int i = 0; i <= BoardSize; i++)
            {
                for (int j = 0; j <= BoardSize; j++)
                {
                    if(i <= BoardSize)
                        HorizontalLines[i, j] = new Line { Start = new Point(i, j), End = new Point(i+1,j), IsDrawn = false, DotSpacing = DOT_SPACING };
                    if (j <= BoardSize)
                        VerticalLines[i, j] = new Line { Start = new Point(i, j), End = new Point(i, j+1), IsDrawn = false, DotSpacing = DOT_SPACING };
                    if (i < BoardSize && j < BoardSize)
                        Squares[i, j] = new Square { TopLeft = new Point(i * DOT_SPACING, j * DOT_SPACING), Owner = null, Size = DOT_SPACING };
                }
            }

            DrawOutsideLines();
        }

        private void DrawOutsideLines()
        {
            for (int i = 0; i <= BoardSize; i++)
            {
                for (int j = 0; j <= BoardSize; j++)
                {
                    if(i == 0 || i == BoardSize)
                    {
                        VerticalLines[i, j].IsDrawn = true;
                    }
                    if(j == 0 || j == BoardSize)
                    {
                        HorizontalLines[i, j].IsDrawn = true;
                    }
                }
            }

        }

        public Size GameSize()
        {
            return new Size((BoardSize * DOT_SPACING) +3, (BoardSize * DOT_SPACING)+3);
        }

        public bool AddLine(Point start, Point end)
        {
            bool isHorizontal = start.Y == end.Y;
            bool isVertical = start.X == end.X;

            if (!isHorizontal && !isVertical)
            {
                return false; // Diagonal lines are not allowed
            }

            if ((isHorizontal && start.X > end.X) || (isVertical && start.Y > end.Y))
            {
                var temp = start;
                start = end;
                end = temp;
            }

            int x = start.X / DOT_SPACING;
            int y = start.Y / DOT_SPACING;

            Line line = isHorizontal ? HorizontalLines[x, y] : VerticalLines[x, y];

            if (line.IsDrawn)
            {
                return false; // Line already drawn
            }

            line.IsDrawn = true;
            bool squareCompleted = false;

            
            if (isHorizontal)
            {
                // Check the square above and below the line
                if (y > 0 && HorizontalLines[x, y - 1].IsDrawn &&
                    VerticalLines[x, y - 1].IsDrawn && VerticalLines[x + 1, y - 1].IsDrawn)
                {
                    Squares[x, y - 1].Owner = GetCurrentPlayer();
                    GetCurrentPlayer().Score++;
                    squareCompleted = true;
                    CheckIfFinished();
                }
                if (y < BoardSize && HorizontalLines[x, y + 1].IsDrawn &&
                    VerticalLines[x, y].IsDrawn && VerticalLines[x + 1, y].IsDrawn)
                {
                    Squares[x, y].Owner = GetCurrentPlayer();
                    GetCurrentPlayer().Score++;
                    squareCompleted = true;
                    CheckIfFinished();
                }
            }
            else if (isVertical)
            {
                // Check the square to the left and right of the line
                if (x > 0 && VerticalLines[x - 1, y].IsDrawn &&
                    HorizontalLines[x - 1, y].IsDrawn && HorizontalLines[x - 1, y + 1].IsDrawn)
                {
                    Squares[x - 1, y].Owner = GetCurrentPlayer();
                    GetCurrentPlayer().Score++;
                    squareCompleted = true;
                    CheckIfFinished();
                }
                if (x < BoardSize && VerticalLines[x + 1, y].IsDrawn &&
                    HorizontalLines[x, y].IsDrawn && HorizontalLines[x, y + 1].IsDrawn)
                {
                    Squares[x, y].Owner = GetCurrentPlayer();
                    GetCurrentPlayer().Score++;
                    squareCompleted = true;
                    CheckIfFinished();
                }
            }

            if (!squareCompleted)
            {
                SwitchPlayer();
            }

            return true;

        }

        private void CheckIfFinished()
        {
            var hasEmpty = false;
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    if (Squares[i,j].Owner == null)
                        hasEmpty = true;
                }
            }
            IsFinished = !hasEmpty;
        }

        public Player GetCurrentPlayer()
        {
            return Players[currentPlayerIndex];
        }

        private void SwitchPlayer()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % Players.Count;
        }

        public bool Clicked(Point clickedPoint)
        {

            Point? startPoint = null;
            Point? endPoint = null;

            foreach (var dot in dots)
            {
                if (startPoint == null || Distance(clickedPoint, dot) < Distance(clickedPoint, startPoint.Value))
                {
                    endPoint = startPoint;
                    startPoint = dot;
                }
                else if (endPoint == null || Distance(clickedPoint, dot) < Distance(clickedPoint, endPoint.Value))
                {
                    endPoint = dot;
                }
            }

            if (startPoint.HasValue && endPoint.HasValue)
            {
                if ((startPoint.Value.X == endPoint.Value.X && Math.Abs(startPoint.Value.Y - endPoint.Value.Y) == DOT_SPACING) ||
                    (startPoint.Value.Y == endPoint.Value.Y && Math.Abs(startPoint.Value.X - endPoint.Value.X) == DOT_SPACING))
                {
                    bool lineAdded = AddLine(startPoint.Value, endPoint.Value);
                    if (lineAdded)
                    {
                        return true;
                    }
                }
            }
            return  false;
        }

        private double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public void Draw(Graphics g)
        {
            foreach(var dot in dots)
            {
                g.FillEllipse(Brushes.Black, dot.X - DOT_SIZE / 2, dot.Y - DOT_SIZE / 2, DOT_SIZE, DOT_SIZE);
            }

            for (int i = 0; i <= BoardSize; i++)
            {
                for (int j = 0; j <= BoardSize; j++)
                {
                    if (HorizontalLines[i, j].IsDrawn)
                    {
                        HorizontalLines[i, j].Draw(g);
                    }

                    if (i <= BoardSize && VerticalLines[i, j].IsDrawn)
                    {
                        VerticalLines[i, j].Draw(g);
                    }

                    if(i < BoardSize && j < BoardSize && Squares[i,j].Owner != null)
                    {
                        Squares[i, j].Draw(g, Squares[i, j].Owner.Color);
                    }
                }
            }

            g.Dispose();
        }

        public List<Player> PlayerWon()
        {
            Dictionary<Player, int> playerSquareCounts = new Dictionary<Player, int>();

            Players.ForEach(x=> playerSquareCounts[x] = 0);
            
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    Player owner = Squares[i, j].Owner;
                    if (owner != null)
                    {
                        playerSquareCounts[owner]++;
                    }
                }
            }

            int maxSquares = playerSquareCounts.Values.Max();

            // Find all players with the maximum count of squares
            List<Player> winners = playerSquareCounts.Where(kvp => kvp.Value == maxSquares)
                                                     .Select(kvp => kvp.Key)
                                                     .ToList();

            return winners;
        }
    }
}
