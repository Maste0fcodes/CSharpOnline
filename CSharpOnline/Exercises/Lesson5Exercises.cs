using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson5Exercises
    {
        // Output Methods that printed out the number 29
        int _val3 = 0b11101;
        int _val = 29;
        int _val2 = 0x1D;

        byte _myByteValue = 20;
        int _myIntValue = 2;
        long _myLongValue = 1234577L;
        short _myShortValue = 12;
        double _myDoubleValue = 12.24D;
        float _myFloatValue = 111.222F;


        void MyExplicit()
        {
            double someValue = (double)_myIntValue;
            Console.WriteLine("longVariable");
        }

        void MyImplicit()
        {
            byte converted = (byte)_myByteValue;
            Console.WriteLine("shortVaraible");
        }


    }
}
