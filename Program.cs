using System;
 

namespace MultipleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone Electronic = new Smartphone();
            Electronic.Connect();
            Electronic.Charge(100);
            Electronic.Display();

            Laptop laptop = new Laptop();
            laptop.Connect();
            laptop.Charge(120);
            laptop.Display();
            Console.ReadKey();

        }
    }
}
