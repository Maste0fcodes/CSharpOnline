using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson18Exercises
    {
        public object MyChecking { get; private set; }

        public void MyLeapYearExample()
        {
            Console.WriteLine("Provide a year");
        }

        static void CheckYear(int year)
        {
            if (year % 400 == 0)
            {
                throw new NullReferenceException("The year was ");
            }
            Console.WriteLine(year);
        }

        public void MyValidChecking()
        {
            string[] names = { "Jan", "Feb", "Mar" };
            string[] values = { "21", "29", "6" };
            try
            {
                byte b = byte.Parse("MyChecking", [1]);
                Console.WriteLine(b);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(MyChecking);
            }

            catch (InsufficientMemoryException)
            {
                Console.WriteLine(" If it’s not 4 digits");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("The user is wrong - " + oe.Message);
            }
            finally
            {
                Console.WriteLine("The user did not provide a valid year");
             
            }
        }

    }
}
