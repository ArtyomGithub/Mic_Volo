using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.BooksExample
{
    class Car
    {
        public string  PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}",PetName);
            Console.WriteLine("Speed: {0}",Speed);
            Console.WriteLine("Color: {0}",Color);
        }
    }
    class Employee
    {
        private string empName;
        private int empID;
        private float curryPay;
        private int empAge;
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return curryPay; }
            set { curryPay = value; }
        }
        public Employee() { }
        public Employee(int age, string name, int iD, float pay)
        {
            Age = age;
            Name = name;
            ID = iD;
            Pay = pay;
        }
        public string GetName()
        {
            return empName;
        }
        public void SetName(string name)
        {
            if (name.Length > 15)
                Console.WriteLine("Error! Name must be less than 16 characters!");
            else
                empName = name;
        }
        public void GiveBonus(float amount)
        {
            curryPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}",empName);
            Console.WriteLine("ID: {0}",empID);
            Console.WriteLine("Age: {0}",empAge);
            Console.WriteLine("Pay: {0}",curryPay);
        }
    }
}
