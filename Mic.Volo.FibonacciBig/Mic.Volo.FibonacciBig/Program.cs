using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

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

            List<Phone> phones = new List<Phone>
{
    new Phone {Name="Lumia 430", Company="Microsoft" },
    new Phone {Name="Mi 5", Company="Xiaomi" },
    new Phone {Name="LG G 3", Company="LG" },
    new Phone {Name="iPhone 5", Company="Apple" },
    new Phone {Name="Lumia 930", Company="Microsoft" },
    new Phone {Name="iPhone 6", Company="Apple" },
    new Phone {Name="Lumia 630", Company="Microsoft" },
    new Phone {Name="LG G 4", Company="LG" }
};

            var phoneGroups = from phone in phones
                              group phone by phone.Company;

            foreach (IGrouping<string,Phone> item in phoneGroups)
            {
                Console.WriteLine(item.Key);
                foreach (var t in item)
                {
                    Console.WriteLine(t.Name);
                }
                Console.WriteLine();
            }
            
            //var collection = Enumerable.Range(0, 1000);
            //var res = from i in collection
            //          group i by i.ToString().Count() into g
            //          select new
            //          {
            //              Group = g.Key,
            //              Value = g
            //          };

            //foreach(IGrouping<int,int> v in res)
            //{
            //    Console.WriteLine(v.Key);
            //    foreach (var item in v)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //var result = collection.GroupBy(i => i.ToString().Length).
            //    Select(i=>new { Name=i.Key,Val=i.ToString().Count()});

            //foreach (var group in result)
            //{
            //    Console.WriteLine("{0}:{1}",group.Name,group.Val);
            //    foreach (var item in group.Val)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            var collection = Enumerable.Range(0, 1000);
            var groups = collection.GroupBy(num => num.ToString().Length);
            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"Group #{group.Key}");
            //    foreach (var num in group)
            //    {
            //        Console.Write(num + "  ");
            //    }

            //    Console.WriteLine();
            //    Console.ReadKey();
            //}
            var tvercol = Enumerable.Range(0, 1000);
            var numgroup = from i in tvercol
                           group i by i.ToString().Length;
            foreach (IGrouping<int,int> item in numgroup)
            {
                Console.WriteLine($"#{item.Key}");
                foreach (var t in item)
                {
                    Console.Write(t);
                }
                Console.WriteLine();
            }

        }
    }
}
