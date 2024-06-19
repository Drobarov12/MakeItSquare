using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeItSquare
{
    public class Square
    {
        public Point TopLeft { get; set; }
        public Player Owner { get; set; }

        public void Draw(Graphics g, Color color, int size)
        {
            Brush b = new SolidBrush(color);
            g.FillRectangle(b, TopLeft.X *size , TopLeft.Y*size, size, size);
        }
    }
}
