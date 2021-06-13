using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    private class television
    {

        public television(int value, string type)
        {
           Console.WriteLine("int value", "string type");
        }
        public television()
        {
            Console.WriteLine("the tv is turned on");
        }

        public television  (string screenSize, decimal price, string ports, string isMountable)
        {
            screenSize = screenSize;
            price = price;
            ports = ports;
            isMountable = isMountable;

            Console.WriteLine ("screenSize, price, ports, isMountable");
        }

        public void BasicChildMethod()
        {
            Console.WriteLine("This is a child class.");
        }

        public string screenSize
        {
            get { return screenSize; }
            set { screenSize = value; }
        }

        public string ports
        {
            get { return ports; }
            set { ports = value; }
        }

        public string price
        {
            get { return price; }
            set { price = value; }
        }

        public string isMountable
        {
            get { return isMountable; }
            set { isMountable = value; }
        }


    }
}

