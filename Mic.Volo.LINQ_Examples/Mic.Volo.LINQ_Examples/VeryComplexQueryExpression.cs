using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.LINQ_Examples
{
    public class VeryComplexQueryExpression
    {
        public static bool Filter(string game)
            => game.Contains(" ");
        public static string ProcessItem(string game)
            => game;

        public static void QueryStringWithDelegates()
        {
            Console.WriteLine("*******Using Raw Delegates*******");
            string[] curentVideoGames = {"Marrowind","Uncharted 2",
            "Fallout 3","Daxter","System Shock 2"};
            Func<string, bool> searchFilte = new Func<string, bool>(Filter);
            Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);
            var subset = curentVideoGames.
                Where(searchFilte).
                OrderBy(itemToProcess).Select(itemToProcess);
            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}",game);
            }
            Console.WriteLine();
        }
    }
}
