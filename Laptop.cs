using System;
 

namespace MultipleInterface
{
    internal class Laptop : IConnectable, IDisplayable, IRechargeable
    {
        public bool IsConnected { get; set; }
        public string Name { get; set; }
        public int Battery { get; set; }

        public Laptop()
        {
            IsConnected = false;
            Battery = 0;
        }

        public bool Connect()
        {
            IsConnected = true;
            return true;

        }
        public int Charge(int min)
        {
            Battery = min;
            Battery = Battery / 60;
            return Battery;
        }

        public void Display()
        {
            if (IsConnected == true)
            {
                Console.WriteLine("Laptop is Connected");

            }
            else
            {
                Console.WriteLine("Laptop is not Connected");
            }
            Console.WriteLine($"{Battery} hours  is required to charge");


        }
    }
}