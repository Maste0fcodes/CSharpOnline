﻿using System;
using CSharpOnline.Lessons;

namespace CSharpOnline
{
    class Program
    {

        static void Main(string[] args)
        {
            MyLesson18Examples();
            // MyLesson17Examples();
            // MyLesson16Examples();
            // MyLesson15Examples();
           // MyLesson14Examples();
            // MyLesson13Examples();
            // MyLesson12Examples();
            // MyLesson11Examples();
            // MyLesson10Examples();
            // MyLesson9Examples();
            // MyLesson7Examples();
            // MyLesson6Examples();
            // MyLesson5Examples();
            // Console.WriteLine("Hello World!");
           // House _myHouse = new House();
        }

        static void MyLesson18Examples()
        {
            Lesson18 my18 = new Lesson18();
            House testHouse = null;
            // my18.MyThrowExample(testHouse);
            //my18.MyException(testHouse);
            my18.MyArrayException();
        }
        
        // This is a delegate example
        public delegate void TryOn(string val);

        static void MyLesson17Examples()
        {
            Lesson17 my17 = new Lesson17("Cowboy", 7);
            TryOn theHat = my17.TryOnHat;
            theHat("I tried on a " + my17.HatType + "hat that was size" + my17.HatSize);

            Lesson17 myLesson17 = new Lesson17();
            Lesson17 myFav17 = new Lesson17("Trucker");
            Console.WriteLine(myFav17.MyResult);
            Console.WriteLine(myFav17.MyLambdaExample(6));
        }

        static void MyLesson16Examples()
        {
            Lesson16 my16 = new Lesson16();
            my16.MyArrayListExample();
            my16.MyHashTableExamples();
            my16.MyListExample();
            my16.MyHouseListExample();
            my16.MyDictionaryExample();
            my16.MyLinqExample();
            my16.MyOtherLinq();
        }
        static void MyLesson15Examples()
        {
            Lesson15 my15 = new Lesson15();
            my15.BasicEnumCasting();
            my15.MyFavoriteFlavor(Lesson15.IceCreamFlavors.ChocolateChip);
            // Constants can not be altered, but can be used
            Console.WriteLine(Lesson15.words);
            my15[2] = 17;

            for(int i = 0; i < my15.ConeArrayLength; i++)
            {
                Console.WriteLine("The Value of {0} = {1}", i, my15[i]);
            }
        }

        static void MyLesson13Examples()
        {
            House myHouse = new House();
            Console.WriteLine("The door color is {0}", myHouse.DoorColor);
            Condo myCondo = new Condo();
            myCondo.DoorOpenClose();
            Console.WriteLine("This foundation type is {0}", myCondo.Foundation);
        }

        static void MyLesson14Examples()
        {
            Lesson14Static.CelsiusToFahrenheit("34.5");
            Console.WriteLine(Lesson14Static.FahrenheitToCelsius("64"));

            Lesson14Derived myLesson14 = new Lesson14Derived(8);
            myLesson14.ShowResultFeet();
            myLesson14.ShowResultMiles();

            Lesson14Base myBase = new Lesson14Derived(10);
            myBase.ShowResultFeet();
        }

        static void MyLesson12Examples()
        {
            Lesson12 myTwelve = new Lesson12();
            myTwelve.BasicPublicMethod();
            Lesson12Child myChild = new Lesson12Child();
            myChild.BasicChildMethod();
            myTwelve.BaicProtectedInternalMethod();
        }

        static void MyLesson11Examples()
        {
            Condo myCondo = new Condo();
            myCondo.Maintenance();
            myCondo.DoorOpenClose();
            House myHouse = new House();
            myHouse.DoorOpenClose();
            myHouse.DoorOpenClose("Red");
        }

        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10(); // default constructor 
            Lesson10 myOtherTen = new Lesson10(10);
            Lesson10 lesson10 = new Lesson10(21, "apples");

            Lesson10Struct myStruct = new Lesson10Struct(9.99m, "King", "The Stand");

            int myVal1 = 14, myVal2 = 14;

            myTen.MyBasicRef(ref myVal1, myVal2); ;
            Console.WriteLine("My Val1 = {0} , My Val2 = {1}", myVal1, myVal2);


            string first, last;
            myTen.MyBasicOut("FogHorn Leghorn", out first, out last);
            Console.WriteLine(first);
            Console.WriteLine(last);
        }

        static void MyLesson9Examples()
        {
            Lesson9 myNine = new Lesson9();
            myNine.BasicArray();
            myNine.MultiArray2D();
            myNine.My3DArray();
            myNine.MyJaggedArray();
        }

        static void MyLesson7Examples()
        {
            Lesson7 mySeven = new Lesson7();
            mySeven.BasicMath();
            mySeven.BasicModuls();
            mySeven.BasicCheckedOperator(46,85);
            mySeven.BasicCheckedOperator2();
            mySeven.BasicAssignmentExamples();
            mySeven.MyLeftShiftOperator();
            mySeven.MyRightShiftOperator();
            mySeven.MyAndAssignmentOperator(10, 2);
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXORAssignement();
            mySeven.MyIncrementDecrementExamples();
        }

        static void MyLesson6Examples()
        {
            Lesson6 mySix = new Lesson6();
            mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.MyLowerUpperExample();
            mySix.myStringLength();
            mySix.MyJoinedStrings("apple" , "orange");
            string food = mySix.MyStringBuilder("pizza", 2);
            Console.WriteLine(food);
            mySix.MyExampleChar();
            mySix.MyEscapeExample();
            mySix.MyPlaceHolder("Galaga", "shooter");
        }

        static void MyLesson5Examples()
        {
             Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();
        }
    }
}
