using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class MountainBikeRange
    {
        private IBicycle[] bicycles;

        public MountainBikeRange()
        {
            bicycles = new IBicycle[6];

            // Define the range of Moutain Bikes availble
            bicycles[0] = new CrossCountry(new WideWheel(24));
            bicycles[1] = new CrossCountry(new WideWheel(26));
            bicycles[2] = new CrossCountry(new WideWheel(27), BikeColor.Chrome);

        }

    } // end class
} // end namespace
