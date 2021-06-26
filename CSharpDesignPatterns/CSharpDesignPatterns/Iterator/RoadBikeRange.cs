using CSharpDesignPatterns.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class RoadBikeRange
    {
        private IList<IBicycle> bicycles;

        public RoadBikeRange()
        {
            bicycles = new List<IBicycle>();

            // define the range of models
            bicycles.Add(new Touring(new NarrowWheel(22)));
            bicycles.Add(new Touring(new NarrowWheel(24)));
            bicycles.Add(new Touring(new NarrowWheel(26), BikeColor.Chrome));
            bicycles.Add(new Vintage(new NarrowWheel(22)));
            bicycles.Add(new Vintage(new NarrowWheel(24)));
            bicycles.Add(new Vintage(new NarrowWheel(26), BikeColor.Black));
        }

        public IEnumerable<IBicycle> Range { get; internal set; }

        internal IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    } // end class 
} // end namepace
