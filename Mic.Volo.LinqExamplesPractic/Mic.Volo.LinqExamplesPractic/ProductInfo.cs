using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.LinqExamplesPractic
{
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
}
