using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson17Exercises
    {
        private string _prop;
        public string myProperty
        {
            // (parameters) => expression-or-statement-block
            get => _prop;
            set => _prop = value;
        }
        public string ShoeType { get; private set; }
        public int ShoeSize { get; private set; }
        public string MyResult { get; private set; }

        public delegate void TryOnAnotherShoe(string shoe);
        public delegate string TryFavoriteshoe(string favorite);
        public delegate int del(int beta);

        public event TryFavoriteshoe MyEventHat;

        public Lesson17Exercises()
        {
            TryOnAnotherShoe otherShoe = TryOnShoe;
            TryASmallerShoe("Jordans", ShoeSize, otherShoe);
        }

        public Lesson17Exercises(string type)
        {
            MyShoe += new TryShoe(this.MyFavoriteShoe);
            MyResult = MyShoe(type);
        }

        public Lesson17Exercises (string type, int size)
        {
            ShoeType = type;
            ShoeSize = size;
        }

        public string MyFavoriteShoe(string msg)
        {
            return "My favorite shoes are " + msg;
        }

        public void TryASmallerShoe(string type, int oldSize, TryOnAnotherShoe another)
        {
            another("I sliped my foot inside" + type + "A shoe size" + (++oldSize));
        }

        public void TryOnShoe(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
