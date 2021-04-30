using System;
using CSharpOnline.Lessons;

namespace CSharpOnline
{
    class Program
    {

        static void Main(string[] args)
        {
            MyLesson7Examples();
            //MyLesson6Examples();
            //MyLesson5Examples();
            // Console.WriteLine("Hello World!");
           // House _myHouse = new House();
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
