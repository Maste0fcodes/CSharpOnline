using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson7Exercises
    {

        public void display2(int a)
        {
            Console.WriteLine("Method with a single parameter: " + a);
        }

        public void MyLesson7ExerciseExamples(int val)
        {
            int total = checked(val);

            Console.WriteLine(total);
        }

        public void MyDoubledOperators()
        {
            Console.WriteLine("Value1 +=, Value2 -=");
        }

        public string Implementedvalues()
        {
            String a = "10 +";
            String b = "32 *"; 
            String c = "(12) / 2";
            Console.WriteLine(a, c, b);
        }
       
    }
}