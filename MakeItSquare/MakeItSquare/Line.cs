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
        public int  DotSpacing { get; set; }

        public bool Equals(Line other)
        {
            return (this.Start == other.Start && this.End == other.End) ||
                   (this.Start == other.End && this.End == other.Start);
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            g.DrawLine(p, Start.X * DotSpacing, Start.Y * DotSpacing,
                            End.X * DotSpacing, End.Y * DotSpacing);
        }
    }
}
