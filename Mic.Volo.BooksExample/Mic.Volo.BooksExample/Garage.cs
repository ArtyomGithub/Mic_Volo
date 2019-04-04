using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.BooksExample
{
    class Garage
    {
        public int NumberOfCars { get; set; }
        public Car MyAuto { get; set; }
        public Garage()
        {
            MyAuto = new Car();
            NumberOfCars = 1;
        }
        public Garage(Car car,int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
    }
}
