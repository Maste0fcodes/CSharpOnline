using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /*This class goes over strings & more 
     Lesson 6 - strings & more*/
    class Lesson6
    {

        string _myString = "Hello World";

        // Trim
        public void MyTrimExample()
        {
            string _myStr = " Space ";
            // Before Trim
            Console.WriteLine(_myStr);
            // trim
            string mytrim = _myStr.Trim();
            // After trim
            Console.WriteLine(mytrim);
        }

        // Equals
        public void MyEqualsExample()
        {
            bool isExampleEqual = _myString.Equals("World");
            Console.WriteLine(isExampleEqual);
        }

        // To upper & to lower
        public void MyLowerUpperExample()
        {
            // Nested method - Method called through another method
            Console.WriteLine(_myString.ToLower());
            Console.WriteLine(_myString.ToUpper());
        }

        // Length
        public void myStringLength()
        {
            Console.WriteLine(_myString.Length);
        }

        // Concatenation - with two prameters 
        public void MyJoinedStrings(String value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }

        // String builder - with two prameters, return string 
        public string MyStringBuilder(string food, int amount)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("My favorite food is ");
            builder.Append(food).Append(" and i ate ")
                .Append(amount).Append(" plates of it.");
            // returns the value out of the method
            return builder.ToString();
        }

        // Char - single quote 
        public void MyExampleChar()
        {
            char myChar = 't';
            char myOther = '\u00A7';
            char copyright = '\u00A9';
            Console.WriteLine(myOther + " " + copyright);
            Console.WriteLine(myChar);
        }

        // Escape Sequence
        public string MyEscapeExample()
        {
            return " That\'s a cool toy. \tCan I\t play with it? ";
        }

        public void MyPlaceHolder(string game, string type)
        {
            Console.WriteLine("My favorite game {0} is a {1}", game, type);
        }

       
    } //end clase
} //end namespace
