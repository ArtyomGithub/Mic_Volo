using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class Motorcycle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Motorcycle()
        {
            Console.WriteLine("default ctor");
        }
        public Motorcycle(string name):this(name,0)
        {
           // Name = name;
            Console.WriteLine("One parameter ctor");
        }
        public Motorcycle(string n,int s)
        {
            Console.WriteLine("Two parameter ctor ");
            Name = n;
            Speed = s;
        }
        public Motorcycle(int n, string s) : this(s, n)
        {
            Console.WriteLine("<-> ctor");
        }
    }
    class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate = 0.04;
        public SavingAccount(double balance)
        {
            Console.WriteLine("Is static ctor");
            currBalance = balance;
            currInterestRate = 10;
        }
        
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInteresRate()
        {
            
            return currInterestRate;
        }
    }
    public static class TimeUtilClass
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }
        public static void SayHello()
        {
            Console.WriteLine("Hello:");
        }
    }
    class Radio
    {
        public void Power(bool turnOn)
        {
            Console.WriteLine("Radio on: {0}",turnOn);
        }
    }
    class Car
    {
        private Radio myRadio = new Radio();
        public void TurnOnRadio(bool onOff)
        {
            myRadio.Power(onOff);
        }
    }
    class Fibonacci
    {
        public BigInteger a;
        public BigInteger b;
        public Fibonacci()
        {
            a = new BigInteger(0);
            b = new BigInteger(1);
           
        }
        public void Values()
        {
            Console.WriteLine(a);

            while (Console.ReadKey().Key==ConsoleKey.Spacebar)
            {
                BigInteger c = BigInteger.Add(a, b);
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=>Use BigInteger: ");
            //BigInteger biggy = BigInteger.Parse("9999999999999999999");
            //Console.WriteLine("value of biggy is {0}",biggy);
            //Console.WriteLine("Is biggy an even value?: {0}",biggy.IsEven);
            //Console.WriteLine("Is biggy a power of two?:{0}",biggy.IsPowerOfTwo);
            //BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("88888888888888"));
            //Console.WriteLine("Value of reallyBig is {0}",reallyBig);
            Fibonacci f = new Fibonacci();
            f.Values();

        }
    }
}
