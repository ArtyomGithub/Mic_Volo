using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Mic.Volo.FibonacciBig
{
    class Program
    {
        static IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = new BigInteger(0);
            BigInteger b = new BigInteger(1);
            BigInteger c = new BigInteger(0);

            while (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                yield return c;
                c = a + b;
                a = b;
                b = c;
            }
        }
        static void Main(string[] args)
        {
            IEnumerable<BigInteger> Values = Fibonacci();
            foreach (var V in Values)
            {
                Console.Write("Press Spacebar for Next value:");
                Console.WriteLine(V);
            }

        }
    }
}
