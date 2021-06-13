using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over Lesson 14 static content*/
    public class Lesson14Static
    {
        static readonly int baseTemp;

        static Lesson14Static()
        {
            baseTemp = 32; 
        }

        public static void CelsiusToFahrenheit(string tempreature)
        {
            double celsius = Double.Parse(tempreature);
            double fahrenheit = (celsius * 9 / 5) + baseTemp;
            Console.WriteLine(fahrenheit);
        }

        public static double FahrenheitToCelsius(string temperatur)
        {
            double fahrenheitToCelsius = Double.Parse(temperatur);
            double celsius = (fahrenheitToCelsius - baseTemp) * 5 / 9;
            return celsius;
        }

    } // end class
} // end namespace
