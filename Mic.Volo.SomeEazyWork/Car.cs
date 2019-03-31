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
        public Car()
        {
            petName = " ";
            carrSpeed = 0;
        }

    }
    public class MCar
    {
        public string PetName { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public string Make { get; set; }
    }
}
