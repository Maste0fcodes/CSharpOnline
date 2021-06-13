using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over Lesson 14 content, Abstracts*/
    public abstract class Lesson14Base
    {
        protected double inches = 12, feet = 3;
        protected int num;

        public abstract void ShowResultFeet();

        public abstract double FeetToInches { get; }
        public abstract double YardsToFeet { get; }

        public Lesson14Base(int num)
        {
            this.num = num; 
        }

    } // end class
} // end namespace
