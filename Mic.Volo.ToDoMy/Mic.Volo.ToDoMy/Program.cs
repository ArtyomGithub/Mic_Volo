using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;

namespace Mic.Volo.ToDoMy
{
    class Fibonacci
    {
        public int a = 0;
        public int b = 1;
        public int c;
        public void Values()
        {
            Console.WriteLine(" "+a);
            while (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {

                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
               
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci f = new Fibonacci();
            while (true)
            {
                f.Values();
            }
        }
    }
}
