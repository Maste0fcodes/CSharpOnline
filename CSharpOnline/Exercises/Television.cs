using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Television
    {
    
        public Television (int value, string type)
        {
           Console.WriteLine("int value", "string type");
        }
        public Television()
        {
            Console.WriteLine("the tv is turned in");
        }

        public Television (string screenSize, decimal price, string ports, string isMountable)
        {
            screenSize = screenSize;
            price = price;
            ports = ports;
            isMountable = isMountable;

            Console.WriteLine ("screenSize, price, ports, isMountable");
        }

    }
}

