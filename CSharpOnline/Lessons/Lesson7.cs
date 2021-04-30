using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /* This Lesson Goes Over Operators */
    class Lesson7
    {

        // This method goes over Arithmatic Operators
        public void BasicMath()
        {
            int a = 20;
            int b = 10;

            int total1 = a + b; //addition 
            int total2 = a - b; //Subtraction
            int total3 = a * b; //Multipliction 
            int total4 = b / a; //Division 

            Console.WriteLine("Addition = {0}, Subtraction = {1} ", 
                total1, total2);
            Console.WriteLine("Multiplication = {0}, Division = {1}",
                total3, total4);
        }

        // This method show the modulus operator
        public void BasicModuls()
        {
            int total = 10 % 20;
            Console.WriteLine(total);
        }

        //This method shows the checked operator method 
        public void BasicCheckedOperator(int val, int val2)
        {
            int total = checked(val * val2);
            Console.WriteLine(total);
        }

        // This method shows the checked operator inline block
        public void BasicCheckedOperator2()
        {
            int able = 250, beta = 14;
            checked
            {
                int total = able * beta;
                Console.WriteLine(total);
            }
        }

        // This method show assignment operators 
        public void BasicAssignmentExamples()
        {
            int able = 10, beta = 34, charley = 6;

            able += beta;
            Console.WriteLine(able);

            beta *= charley;
            Console.WriteLine(beta);
        }

        /*
          Left shift operator will take a value, convert it to binary.
          We can group the numbers of 1's and 0's in groups of 4.
          We will then shift the values to the left based on the second value in the expression.
          The higer-oder bits the range of the results are discarded. The remainig bits are shifted left, and the lower-order empty bits are set to zero.
         */

        public void MyLeftShiftOperator()
        {
            // The number 15 converted to binary is 1111
            int value = 15;

            value <<= 2;
            // Shifting value by two results in 0011 1100 is the number 60.
            Console.WriteLine(value);
        }

        /*
         The right shift operation will take the value and convert it to binary.
         This binary value will shift to the right by the number of spaces based on the second value.
         When the variable type is int or long, the lower order bits are discarded, the remaining are shifter right and the higher order empty bit positions are set to zero if the value is not a negative, otherwise the positions are set to one.
         If the type is uInt or uLong the empty positions are set too 0
         */
        public void MyRightShiftOperator()
        {
            // The number 30 in binary is 001 1110
            int value = 30;

            value >>= 2;
            // Shifting the values by two result in 0111
            Console.WriteLine(value);
        }

        /* This and bitwise compares the binary of both numbers and only the matched sets carry to the anwer */
        public void MyAndAssignmentOperator(int val, int val2)
        {
            // If the values is 10 this binary is 1010
            // If the second value is 2, its binary is 0010
            // Only the match will carry, so the answer should be 1
            val &= val2;
            Console.WriteLine(val);
        }


        /* This OR Bitwise compare the binary of both of nubers 
         and only the one's carry over to the answer*/
        public void MyOrAssignmentOperator()
        {
            int value = 15; // 1111
            int value2 = 30; // 0001 1110
            value |= value2;
            Console.WriteLine(value); // andwer is 0001 1111 or 31 
        }

        /*This XOR bitwise compares the two numbers in binary.
         This diffreces between them will product one in its place for the answer*/
        public void MyXORAssignement()
        {
            int value = 15; // 0000 1111
            int value2 = 30; // 0001 1110 

            value ^= value2;
            Console.WriteLine(value); // answer is 0001 or 17 
        }



        //This method will show increment and decrement 
        public void MyIncrementDecrementExamples()
        {
            int alpha = 11, beta = 16;
            alpha++; // post increment which is the same as alpha = alpha + 1
            Console.WriteLine(alpha);
            ++alpha; // preincrement which is alpha = 1 + alpha
            Console.WriteLine(alpha);

            beta--; // post decrement which is the same as beta = beta - 1
            Console.WriteLine(beta);
            --beta; // pre decrement whis is the same as beta = 1 - beta
            Console.WriteLine(beta); 

        }
    } // end class
} // end namespace 