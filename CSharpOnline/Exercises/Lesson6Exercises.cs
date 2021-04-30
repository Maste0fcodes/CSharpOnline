using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    public class Main
    {
        static void myMethod(String name)
        {
            myMethod("gabe");
        }
    }

    static void MyCharMethod()
    {
        char myChar = '\U+A9';
        Console.WriteLine(myChar);
    }

    static void MyMethod(string = "Output:")
    {
        Console.WriteLine("Output");
    }

    private static void MyStringExample(string[] args)
    {
        Console.WriteLine("Jack and Jill");
        Console.WriteLine("Went up the hill");
        Console.WriteLine("To fetch a pail of water");
        Console.WriteLine("Jack fell down and broke his crown");
        Console.WriteLine("And jill came tumbling after");
    }

}
