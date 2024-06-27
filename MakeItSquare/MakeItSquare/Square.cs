using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeItSquare
{
    [Serializable]
    public class Square
    {
        public Point TopLeft { get; set; }
        public Player Owner { get; set; }
        public int Size { get; set; }

        public void Draw(Graphics g, Color color)
        {
            Brush b = new SolidBrush(color);
            g.FillRectangle(b, TopLeft.X + 1 , TopLeft.Y + 1, Size, Size);
        }
    }
}
