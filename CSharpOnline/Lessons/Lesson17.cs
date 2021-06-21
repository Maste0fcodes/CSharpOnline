using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over the Lesson 17 content
     Delegate, Events and Lambads*/
    public class Lesson17
    {
        private string _prop;
        public string myProperty
        {
            // (parameters) => expression-or-statement-block
            get => _prop;
            set => _prop = value;
        }
        public string HatType { get; private set; }
        public int HatSize { get; private set; }
        public string MyResult { get; private set; }

        public delegate void TryOnAnotherHat(string hat);
        public delegate string TryFavoritehat(string favorite);
        public delegate int del(int beta);

        public event TryFavoritehat MyEventHat;

        public Lesson17()
        {
            TryOnAnotherHat otherHat = TryOnHat;
            TryALargerHat("fadora", HatSize, otherHat);
        }

        public Lesson17(string type)
        {
            MyEventHat += new TryFavoritehat(this.MyFavoriteHat);
            MyResult = MyEventHat(type);
        }

        // This below is a parameter
        public Lesson17(string type, int size)
        {
            HatType = type;
            HatSize = size;
        }

        public string MyFavoriteHat(string msg)
        {
            return "My favorite hat is " + msg;
        }

        public void TryALargerHat(string type, int oldSize, TryOnAnotherHat another)
        {
            another("I tried on a" + type + "hat at size" + (++oldSize));
        }

        public void TryOnHat(string msg)
        {
            Console.WriteLine(msg);
        }

        public int MyLambdaExample(int value)
        {
            // (parameters) => expression-or-statement-block
            del myDel = x => x * x;
            return myDel(value);
        }

    } // end class
} // end namespace
