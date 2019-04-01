using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.LinqExamplesPractic
{
    class MMMM
    {
        public enum s
        {
            dd=10,
        };
        public enum f { gg,};
        public bool t = true;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo[] itemsInStock = new[]
           {
                
                new ProductInfo{Name="Mac`s Coffee",
                Descrpition="Coffee with TEETH",
                NumberInStock=24},
                new ProductInfo{Name="Milk Maid Milk",
                Descrpition="Milk`s cow`s love",
                NumberInStock=100},
                new ProductInfo{Name="Pure Silk Tofu",
                Descrpition="Bland as Possible",
                NumberInStock=120},
                new ProductInfo{Name="Cruchy Pops",
                Descrpition="Cheezy, peppery goodness",
                NumberInStock=2},
                new ProductInfo{Name="RipOff Water",
                Descrpition="From the tap to your wallet",
                NumberInStock=100},
                new ProductInfo{Name="Classic Valpo Pizza",
                Descrpition="Everyone loves pizza!",
                NumberInStock=73}

            };
            ListProductNames(itemsInStock);
            GetNamesAndDescrpition(itemsInStock);
            Array objs = GetProjectSubset(itemsInStock);
            foreach (object o in objs)
            {
                Console.WriteLine(o);
            }
            ReverseEverything(itemsInStock);
            AlphabetizeProductNames(itemsInStock);
            Console.OutputEncoding = UnicodeEncoding.UTF8; 
            Console.WriteLine("привет мир  աաաաաա");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine(MMMM.s.dd);
            Console.WriteLine(MMMM.f.gg);
            //Console.WriteLine(MMMM);
            
        }
        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            var subset = from p in products
                         orderby p.Name ascending
                         select p;
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }
        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Product in reverse:");
            var allProducts = from p in products
                              select p;
            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }
        static void GetCountFromQuery()
        {
            string[] currentVideoGames = {"Marrownid","Uncharted 2",
            "Fallout 3","Daxter","System Shock 2"};
            int numb = (from g in currentVideoGames
                        where g.Length > 6
                        select g).Count();
            Console.WriteLine("{0} items honor the LINQ query.",numb);
        }
        static Array GetProjectSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products
                           select new { p.Name, p.Descrpition };
            return nameDesc.ToArray();
        }
        static void GetNamesAndDescrpition(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descrpition:");
            var nameDesc = from p in products
                           select new { p.Name, p.Descrpition };
            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }
        static void GetOverstock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items!");
            var overstock = from p in products
                            where p.NumberInStock > 25
                            select p;
            foreach (ProductInfo c  in overstock)
            {
                Console.WriteLine(c.ToString());
            }
        }
        static void ListProductNames(ProductInfo[] products)
        {
            Console.WriteLine("Only product names:");
            var names = from n in products
                        select n.Name;
            foreach (var name in names)
            {
                Console.WriteLine("Name : {0}",name);
            }

        }
        static void SelectEverything(ProductInfo[] products)
        {
            Console.WriteLine("All products detalis:");
            var allProducts = from p in products
                              select p;
            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }
    }
}
