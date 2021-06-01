using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson8Exercises()
    static void main(String args [])
    {
        int a = 5;
        int b = 10;

        // Calling the function with 2 parameters
        calc(a, b);
    }
    public static void calc(int a, int b)
    {
        int sum = a + b;
        // Displaying the sum
        Console.WriteLine("Sum of two numbers is :" + sum);
    }

    
    public void myCharValue()
    {
        Console.WriteLine("E is..");
        Console.WriteLine("V is..");
        Console.WriteLine("G is..");
        Console.WriteLine("A is..");
        Console.WriteLine("F is..");
    }

    public static void Printdoublechart(double score)
    {
        if (score >= 90.5)
        {
            Console.WriteLine("Excellent");
        }
        else if (score >= 80.5)
        {
            Console.WriteLine("Very good");
        }
        else if (score >= 70.5)
        {
            Console.WriteLine("Good");
        }
        else if (score >= 60.5)
        {
            Console.WriteLine("Average");
        }
        else if (score >= 50.5)
        {
            Console.WriteLine("Fail");
        }

        static void result(int N)
        {
            for (int num = 0; num < N; num++)
            {
                if (num % 3 == 0 && num % 30 == 0)
                    Console.Write(num + " ");
            }
        }
        static public void Result()
        {
            int N = 190;
            result(N);
        }
    }
}

