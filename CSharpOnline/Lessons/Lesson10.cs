using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over lesson 10 content
     Constructors */
    public class Lesson10
    {
        public Lesson10(int value, string type)
        {
            Console.WriteLine("This {0} type and {1} value are from another constructor", type);
        }

        public Lesson10(int value)
        {
            Console.WriteLine("This {0} value came for a diffrent constructor", value); 
        }

        public Lesson10()
        {
            Console.WriteLine("My Default Constructor");
        }

    }// end class 
} // end namespace
