using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.HelloWorldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework");
            Console.WriteLine("Hello World!");
            Console.WriteLine($"{(Environment.ProcessorCount)}");
            Console.WriteLine("{0}",Environment.OSVersion);
            Console.WriteLine($"{(Environment.Is64BitProcess ? "x64" : "x84")}");


        }
    }
}
