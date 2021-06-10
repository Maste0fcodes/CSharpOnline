using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline
{
    class House
    {
        //Attributes of the class
        protected int windowSize;
        protected string foundation;
        //private string _rooftype;
        //private string _doorcolor;

        public int WindowSize
        {
            get { return windowSize; } 
            private set { windowSize = value; }
        }

        public string Foundation
        {
            get { return foundation; }
            set { foundation = value; }
        }

        public string RoofType { get; set; }

        public string DoorColor { get; set; }

        public House() { }

        public House(int windowSize, string foundation)  
        {
            this.windowSize = windowSize;
            this.foundation = foundation;
        }

        /*
         This method will print out 
        about what the door does
            */
        public virtual void DoorOpenClose()
        {
            Console.WriteLine("The door opens");
        }
        public void DoorOpenClose(string doorColor)
        {
            Console.WriteLine("My door color is {0}", doorColor);
        }

    }
}
