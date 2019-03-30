using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.SomeEazyWork
{
    class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Rectangle()
        {
            
        }
        public Rectangle(int Tlx,int Tly,int Brx,int Bry)
        {
            TopLeft = new Point(Tlx, Tly);
            BottomRight = new Point(Brx, Bry);
        }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
    }
}
