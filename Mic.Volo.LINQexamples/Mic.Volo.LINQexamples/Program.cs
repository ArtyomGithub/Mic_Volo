using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Mic.Volo.LINQexamples
{
    public class User
    {
        public string Name { get; set; }
    }
    public static class StringExtension
    {
        public static int WordCount(this string str,char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
        public static int SpacesCounter(this string s,string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    count++;
            }
            return count;
        }
    }
    class ProductInfo
    {
        public string Name { get; set; }
        public string Descrition { get; set; }
        public int NumberInStock { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0}, Description={1}," +
                "Number in Stock={2}", Name, Descrition, NumberInStock);
        }
    }
    class Program
    {
        delegate void MessageHandler(string message);
        static void ShowMessage(string mes,MessageHandler handler)
        {
            handler(mes);
        }
        delegate int Operation(int x, int y);
        delegate int Square(int x);
        delegate bool IsEqual(int x);
        static int Sum(int[] numbers,IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            ShowMessage("Hello World!", delegate (string mes)
            {
                Console.WriteLine(mes);
            });
            MessageHandler message = delegate
            {
                Console.WriteLine("Anonym method");
            };
            message("Hi guyes!");
            int z = 10;
            Operation operation = delegate (int x, int y)
              {
                  return x + y + z;
              };
            int d = Sum(new int[] { 1, 2, 3, 4, 5, 6 }, x => x % 2 == 0);

            Console.WriteLine(d);

            Operation oper = (x, y) => x + y;
            Console.WriteLine(oper.Invoke(10,55));
            Square square = i => i * i;
            int ze = square(6);
            Console.WriteLine(ze);
            //User tom = new User { Name = "Tom" };
            //int age = 34;

            //var student = new
            //{
            //    tom.Name,
            //    age
            //};
            //Console.WriteLine(student.Name);
            //Console.WriteLine(student.age);
            //var people = new[]
            //{
            //    new {Name="Tom"},
            //    new {Name="Bob"}
            //};
            //foreach (var item in people)
            //{
            //    Console.WriteLine(item.Name);
            //}

            string s = "Hello World!";
            Console.WriteLine(s.SpacesCounter("sdsd sdsds dsds dsdsd sdsd ds"));

            Console.WriteLine("*******Fun With Query Expresssions******\n");
            ProductInfo[] itemsInStock = new []
            {
                new ProductInfo{Name="Mac`s Coffee",
                Descrition="Coffee with TEETH",
                NumberInStock=24},
                new ProductInfo{Name="Milk Maid Milk",
                Descrition="Milk`s cow`s love",
                NumberInStock=100},
                new ProductInfo{Name="Pure Silk Tofu",
                Descrition="Bland as Possible",
                NumberInStock=120},
                new ProductInfo{Name="Cruchy Pops",
                Descrition="Cheezy, peppery goodness",
                NumberInStock=2},
                new ProductInfo{Name="RipOff Water",
                Descrition="From the tap to your wallet",
                NumberInStock=100},
                new ProductInfo{Name="Classic Valpo Pizza",
                Descrition="Everyone loves pizza!",
                NumberInStock=73}

            };
            List<int> numbers = new List<int>(new int[] { 10, 30, 5, 4, 5,7, 6, 8, 2, 2, 0,1, 5, 20,4, 6 });
            MessageHandler handler = delegate (string mes)
              {
                  Console.WriteLine(mes);
              };
            handler("hello");

        }
    }
}
