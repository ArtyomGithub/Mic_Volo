using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry host1 = Dns.GetHostEntry("www.microsoft.com");
            Console.WriteLine(host1.HostName);
            foreach (IPAddress iP in host1.AddressList)
            {
                Console.WriteLine(iP.ToString());
            }
            Console.WriteLine();
            IPHostEntry host2 = Dns.GetHostEntry("google.com");
            Console.WriteLine(host2.HostName);
            foreach (IPAddress iP in host2.AddressList)
            {
                Console.WriteLine(iP.ToString());
            }
            Console.WriteLine("*********");

            //using (WebClientMy ob = new WebClientMy())
            //{
            //    ob.DownloadHTML("https://mic.am");
            //}

            //WebClient web = new WebClient();
            //using (Stream stream = web.OpenRead("https://norvig.com/big.txt"))
            //{
            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        string line = "";
            //        while((line=reader.ReadLine())!=null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //Console.WriteLine("File downloaded");
            Console.WriteLine("Heap memory :"+GC.GetTotalMemory(false));
            Console.WriteLine("Os object generation :"+(GC.MaxGeneration));
            Myclass ob = new Myclass(10, "one");
            Console.WriteLine("ob is {0}",GC.GetGeneration(ob));

            GC.Collect();
            Console.WriteLine("ob is {0}",GC.GetGeneration(ob));

            object[] Arrayob = new object[5000000];
            for (int i = 0; i < 1000000; i++)
            {
                Arrayob[i] = new object();
            }
            GC.Collect(0);
            GC.WaitForPendingFinalizers();
            Console.WriteLine("ob is {0}",GC.GetGeneration(ob));
            GC.Collect();
            Console.WriteLine("\n Gen 0 has benn swept {0} times",GC.CollectionCount(0));
            Console.WriteLine("Gen 1 has been swept {0} times",GC.CollectionCount(1));
            Console.WriteLine("Gen 2 has been swept {0} times",GC.CollectionCount(2));
            Console.WriteLine("Heap memory :"+GC.GetTotalMemory(false));
        }
    }
}
