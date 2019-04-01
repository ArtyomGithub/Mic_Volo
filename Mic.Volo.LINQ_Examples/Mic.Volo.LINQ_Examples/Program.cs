using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.LINQ_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myCars = new List<string>
            {
                "Yugo","Aztec","BMW"
            };
            List<string> yourCars = new List<string>
            {
                "BMW","Saab","Aztec"
            };
            var carDiff = (from c in myCars select c).
                Except(from c2 in yourCars select c2);
            Console.WriteLine("Here is what you don`t have,but I do: ");
            foreach (string s in carDiff)
            {
                Console.WriteLine(s);
            }
            var carIntersect = (from c in myCars select c).
                Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carIntersect)
            {
                Console.WriteLine(s); 
            }
            var carUnion = (from c in myCars select c).
                Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything: ");
            foreach (string item in carUnion)
            {
                Console.WriteLine(item);
            }
            var carConcat = (from c in myCars select c).
                Concat(from c2 in yourCars select c2);
            Console.WriteLine("Everythin maybe double count gives: ");
            foreach (string car in carUnion.Distinct())
            {
                Console.WriteLine(car);
            }
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };
            Console.WriteLine("Max temp: {0}",
                (from t in winterTemps select t).Max());
            Console.WriteLine("Min temp is : {0}",
                (from t in winterTemps select t).Min());
            Console.WriteLine("Average temp : {0}",
                (from t in winterTemps select t).Average());
            Console.WriteLine("Sum of all temps : {0}",
                (from t in winterTemps select t).Sum());
            QueryStringWithEnumerableAndLambdas();
            QueryStringWithAnonymousMethods();
        }
        static void QueryStringWithAnonymousMethods()
        {
            Console.WriteLine("*****Using Anonymous Methods******");
            string[] currentVideoGames = {"Marrowind","Uncharted 2",
            "Fallout 3","Daxter","System Shock 2"};
            Func<string, bool> searchFilter = delegate (string game)
               {
                   return game.Contains(" ");
               };
            Func<string, string> itemToProcess = delegate (string s) { return s; };
            var subset = currentVideoGames.Where(searchFilter).
                OrderBy(itemToProcess).Select(itemToProcess);
            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}",game);
            }
            Console.WriteLine();
        }
        static void QueryStringWithEnumerableAndLambdas()
        {
            Console.WriteLine("******Using Enumerable/Labmda Expressions*******");
            string[] currentVideoGames = {"Marowind","Uncharted 2",
            "Fallout 3","Daxter","System Shock 2"};
            var subset = currentVideoGames.Where(g => g.Contains(" "))
                .OrderBy(g => g).Select(g => g);
            var sub = from i in currentVideoGames
                      where i.Contains(" ")
                      orderby i descending
                      select i;
            var gamesWithSpaces = currentVideoGames.Where(game => game.Contains(" "));
            var orderedWgames = gamesWithSpaces.OrderBy(g => g);
            var subSet = orderedWgames.Select(g => g);
            foreach (var game in subSet)
            {
                Console.WriteLine("Item: {0}",game);
            }
            Console.WriteLine();
        }
    }
}
