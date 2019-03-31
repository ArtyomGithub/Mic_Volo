using System;
using System.Collections;
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
    class LINQBasedFieldsAreClunky
    {
        private static string[] currentVideoGames =
        {
            "Marrowind","Uncharted 2","Fallout 3","Daxter",
            "System Shock 2"
        };
        private IEnumerable<string> subset = from g in currentVideoGames
                                             where g.Contains(" ")
                                             select g;
        public void PrintGames()
        {
            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void ReflectOverQueryResults(object resultSet)
        {
            Console.WriteLine("********Info about your query******");
            Console.WriteLine("resultSet is of type: {0}",resultSet.GetType().Name);
            Console.WriteLine("result location: {0}",resultSet.GetType().Assembly.GetName().Name);
        }
        static void QueryOverStrings()
        {
            string[] currentVideoGames = { "Marrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            //IEnumerable<string> subset = from games in currentVideoGames
            //                             where games.Contains(" ")
            //                             orderby games
            //                             select games;
            string[] subset = new string[5];
            int k = 0;
            for (int i = 0; i < currentVideoGames.Length; i++)
            {
                if (currentVideoGames[i].Contains(" "))
                {
                    subset[k] = currentVideoGames[i];
                    k++;
                }
            }
            Array.Sort(subset);
            foreach (string s in subset)
            {
                if(s!=null)
                Console.WriteLine("Item: {0}",s);

            }
        }
        static void QueryOverInt()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 4, 8 };
            var subset = from i in numbers
                         where i < 10
                         select i;
            foreach (var i in subset)
            {
                Console.WriteLine("{0}<10",i);
            }
            Console.WriteLine();
            numbers[0] = 4;
            foreach (var j in subset)
            {
                Console.WriteLine("{0}<10",j);
            }
            ReflectOverQueryResults(subset);
        }
        static void ImmediateExeccution()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            int[] subsetAsIntArray = (from i in numbers
                                      where i < 10
                                      select i).ToArray<int>();
            List<int> subsetAsListOfInts = (from i in numbers
                                            where i < 10
                                            select i).ToList<int>();
        }
        static string[] GetStringSubset()
        {
            string[] colors = {"Light Red","Green","Yellow",
            "Dark Red","Red","Purple"};
            IEnumerable<string> theRedColors = from c in colors
                                               where c.Contains("Red")
                                               select c;
            return theRedColors.ToArray();
        }
        static void GetFastCars(List<MCar> myCars)
        {
            var fastCars = from i in myCars
                           where i.Speed > 55
                           select i;
            foreach (var c in fastCars)
            {
                Console.WriteLine("{0} is going too fast!",c.PetName);
            }
        }
        static void GetFastBmwCars(List<MCar> mCars)
        {
            var bmw = from auto in mCars
                      where auto.Make.Contains("BMW") && auto.Speed>90
                      select auto;
            foreach (var a in bmw)
            {
                Console.WriteLine("{0} is going too fast !",a.PetName);
            }
        }
        static void LINQOverArrayList()
        {
            Console.WriteLine("******LINQ to ArrayList******");
            ArrayList myCars = new ArrayList()
            {
                new MCar{PetName="Henry",Color="Silver",Speed=100,Make="BMW"},
                new MCar{PetName="Danisy",Color="Tan",Speed=90,Make="BMW"},
                new MCar{PetName="Mary",Color="Black",Speed=55,Make="VW"},
                new MCar{PetName="Clunker",Color="Rust",Speed=5,Make="Yugo"},
                new MCar{PetName="Melvin",Color="White",Speed=43,Make="Ford"},
            };
            var myCarsEnum = myCars.OfType<MCar>();
            var fastCars = from c in myCarsEnum
                           where c.Speed > 55
                           select c;
            foreach (var c in fastCars)
            {
                Console.WriteLine("{0} is going too fast!",c.PetName);
            }
        }
        static void OfTypeAsFilter()
        {
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10, 40, 8, false, new MCar(), "string data" });
            var myInts = myStuff.OfType<int>();
            foreach (int i in myInts)
            {
                Console.WriteLine("Int value: {0}",i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("******LINQ Transformations**********\n");
            List<MCar> myCars = new List<MCar>()
            {
                new MCar{PetName="Henry",Color="Silver",Speed=100,Make="BMW"},
                new MCar{PetName="Daisy",Color="Tan",Speed=90,Make="BMW"},
                new MCar{PetName="Mary",Color="Black",Speed=55,Make="VM"},
                new MCar{PetName="Clunker",Color="Rust",Speed=5,Make="Yugo"},
                new MCar{PetName="Melvin",Color="White",Speed=43,Make="Ford"},
            };
            //LINQOverArrayList();
            OfTypeAsFilter();
            //IEnumerable<string> subset = GetStringSubset();
            //foreach (string item in GetStringSubset())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
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

            

        }
    }
}
