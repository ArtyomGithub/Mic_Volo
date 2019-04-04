using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.BooksExample
{
    public enum PointColor { LightBlue,BloodRed,Gold};
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Color = PointColor.Gold;
        }
        public Point(PointColor pointColor) {
            Color = pointColor;
        }
        public Point() : this(PointColor.BloodRed) { }
        public void DisplayStats()
        {
            Console.WriteLine("[{0},{1}]",X,Y);
            Console.WriteLine("Point is {0}",Color);
        }
    }
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();
        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }
        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2}"+
                "BottomRight: {3}, {4}, {5}]",topLeft.X,topLeft.Y,topLeft.Color,
                bottomRight.X,bottomRight.Y,bottomRight.Color);
        }
    }
    class MyMathClass
    {
        public static readonly double PI;
        static MyMathClass()
        {
            PI = 3.14;
            Console.WriteLine("barev static ctor");
        }
        public MyMathClass()
        {
            Console.WriteLine("default ctor barev");   
        }
    }
}
