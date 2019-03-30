using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.SomeEazyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> myListOfRects = new List<Rectangle>
            {
                new Rectangle{TopLeft=new Point{X=10,Y=10},
                BottomRight=new Point{X=200,Y=200}},
                new Rectangle{TopLeft=new Point{X=2,Y=2},
                BottomRight=new Point{X=100,Y=100}},
                new Rectangle{TopLeft=new Point{X=5,Y=5},
                BottomRight=new Point{X=90,Y=75}}
            };
        }
    }
}
