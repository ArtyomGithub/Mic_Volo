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

            using (WebClientMy ob = new WebClientMy())
            {
                ob.DownloadHTML("https://mic.am");
            }

            WebClient web = new WebClient();
            using (Stream stream = web.OpenRead("https://norvig.com/big.txt"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while((line=reader.ReadLine())!=null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("File downloaded");

        }
    }
}
