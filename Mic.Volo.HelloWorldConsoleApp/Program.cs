using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.HelloWorldConsoleApp
{
    class Person
    {
        public string personName;
        public int personAge;
        public Person()
        {

        }

        public Person(string personName, int personAge)
        {
            this.personName = personName;
            this.personAge = personAge;
        }
        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}",personName,personAge);
        }
    }
    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******Fun with Nullable Data*****\n");
            DatabaseReader dr = new DatabaseReader();

            int moreData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine($"{moreData}");
        }
        
        static void SendPersonByValue(Person p)
        {
            p.personAge = 77;
            p = new Person("AAAA", 44);
        }
        static void SendPersonByReference(ref Person p)
        {
            p.personAge = 99;
            p = new Person("Nikki", 888);
        }
    }
}
