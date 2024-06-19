using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeItSquare
{
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public bool IsDrawn { get; set; }

        public bool Equals(Line other)
        {
            return (this.Start == other.Start && this.End == other.End) ||
                   (this.Start == other.End && this.End == other.Start);
        }

        public void Draw(Graphics g, int dotSpace)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, Start.X * dotSpace, Start.Y * dotSpace,
                            End.X * dotSpace, End.Y * dotSpace);
        }
    }
}
