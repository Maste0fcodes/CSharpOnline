using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson9Exercises
    {
        public void MySingleDimensonionalArray()
        {
            int[] myIntArray2 = { 1, 2, 3 };
            string [] myStringArray2 = { "vanilla","strawberry", "chocolate"};
            for (int i = 0; i < myIntArray2.Length; i++)
            {
                Console.WriteLine(myIntArray2[i]);
            }

            static void MyTwoDimensionArray()
            {

                String[,] myArray = { { "31", "26", "23", "23" }, { "21", "3", "3", "16" }};

                int[,] array2D = new int[2, 2];
                array2D[0, 0] = 2;
                array2D[0, 1] = 4;
                array2D[1, 0] = 6;
                array2D[1, 1] = 8;
                 
                for(int i = 0; i < myArray.GetLength(0); i++)
                {

                    for(int k = 0; k < myArray.GetLength(1); k++)
                    {
                        Console.WriteLine(myArray[i, k]);
                    }

                }

            }
        }
    }
}
