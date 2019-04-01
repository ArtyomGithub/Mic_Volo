using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.LinqExamplesPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductInfo[] itemsInStock = new[]
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
        }
    }
}
