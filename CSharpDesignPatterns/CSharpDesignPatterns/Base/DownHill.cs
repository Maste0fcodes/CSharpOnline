using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class DownHill : AbstractMoutainBike
    {
        public DownHill(IWheel wheel, BikeColor color)
            : base (wheel,color) { }
        
        public DownHill(IWheel wheel)
            :this (wheel, BikeColor.Blue) { }

        public override decimal Price
        {
            get { return 870.00m; }
        }

    }
}
