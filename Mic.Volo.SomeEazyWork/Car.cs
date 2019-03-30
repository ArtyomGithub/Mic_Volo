using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.SomeEazyWork
{
    class Car
    {
        public string petName;
        public int carrSpeed;
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.",petName,carrSpeed);
        }
        public void SpeedUP(int delta)
        {
            carrSpeed += delta;
        }

    }
}
