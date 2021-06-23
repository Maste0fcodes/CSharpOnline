using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class MountainBikeBuilder : BikeBuilder 
    {
        private AbstractMoutainBike _moutainBikeInProgress;

        public override IBicycle Bicycle
        {
            get { return _moutainBikeInProgress; }
        }

        public MountainBikeBuilder(AbstractMoutainBike moutainBike)
        {
            this._moutainBikeInProgress = moutainBike;
        }

        public override void BuildHandlebars()
        {
            Console.WriteLine("Building MoutainBike handle bars.");
        }

        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike Wide Tires");
        }

    } // enc class
} // end namespace
