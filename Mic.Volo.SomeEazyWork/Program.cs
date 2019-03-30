using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.SomeEazyWork
{
    static class ObjectExtensions
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: \n\t->{1}\n",obj.GetType().Name);
            Assembly.GetAssembly(obj.GetType());
        }
    }
    class Program
    {
        static void QueryOverStrings()
        {
            string[] currentVideoGames = { "Marrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            IEnumerable<string> subset = from games in currentVideoGames
                                         where games.Contains(" ")
                                         orderby games
                                         select games;
            foreach (string s in subset)
            {
                Console.WriteLine("Item: {0}",s);
            }
        }
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
            //List<int> list = new List<int>();
            //list.AddRange(new int[] { 10,20,15,13,1,9,11,45});
            //List<int> evenNumbers = list.FindAll(i => i % 2 == 0);
            //Console.WriteLine("Here are your even numbers:");
            //foreach (int evenumber in evenNumbers)
            //{
            //    Console.Write("{0} \t",evenumber);
            //}
            //Console.WriteLine();

            //int myInt = 12345678;
            //myInt.DisplayDefiningAssembly();

            //System.Data.DataSet d = new System.Data.DataSet();
            //d.DisplayDefiningAssembly();
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new { Color = "Red", MAke = "Saab", CurrentSpeed = 55 },
                Price=34.000
            };

            Console.WriteLine("*****Fun with LINQ to Objects******\n");
            QueryOverStrings();
            

        }
    }
}
