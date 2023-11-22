using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterface
{
    public class Smartphone : IConnectable, IDisplayable, IRechargeable
    {
        public bool IsConnected { get; set; }

        public int Battery { get; set; }

        public Smartphone()
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
                Console.WriteLine("Smart phone is connected");
            }
            else
            {
                Console.WriteLine("Smart phone is not Connected");
            }
            Console.WriteLine($"{Battery} hrs is required to charge the battery");

        }



    }
}

