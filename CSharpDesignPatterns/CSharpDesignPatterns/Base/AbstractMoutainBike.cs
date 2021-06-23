using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public abstract class AbstractMoutainBike : AbstractBike
    {
        public AbstractMoutainBike(IWheel wheel, BikeColor color) 
            : base(wheel, color) { }

        public AbstractMoutainBike(IWheel wheel) 
            : this (wheel, BikeColor.Black) { }

        public override decimal Price
        {
            get { return 740.00m; }
        }
 
    }
}
