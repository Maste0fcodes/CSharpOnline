using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{ /*This class goes over lesson 15 content 
   Enum, Constants, Indexers*/
    public class Lesson15
    {

        public const float pi = 3.14f;
        public const string words = "Happy Coding";

        public enum IceCreamFlavors : byte
        {
            Vanilla = 10, Chocolate, Strawberry, Rockyroad, ChocolateChip
        }

        public void BasicEnumCasting()
        {
            int value = (int)Lesson15Enum.Thur;
            Console.WriteLine(Lesson15Enum.Thur + " " + value);
        }
        // Below is a method
        public void MyFavoriteFlavor(IceCreamFlavors flavors)
        {
            string msg = "My favorite flavor is ";
            switch(flavors)
            {
                case IceCreamFlavors.Vanilla:
                    msg += IceCreamFlavors.Vanilla;
                        break;
                case IceCreamFlavors.Chocolate:
                    msg += IceCreamFlavors.Chocolate;
                        break;
                case IceCreamFlavors.Strawberry:
                    msg += IceCreamFlavors.Strawberry;
                        break;
                case IceCreamFlavors.ChocolateChip:
                    msg += IceCreamFlavors.ChocolateChip;
                    break;
                default:
                    msg += IceCreamFlavors.Rockyroad;
                    break;
            }
            Console.WriteLine(msg);
        }

    } // end class
} // end namespace
