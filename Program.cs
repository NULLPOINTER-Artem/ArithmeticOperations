using System;

namespace ArithmeticOperations
{
    /*
     * This program describe and explain how to use arithmetic operations
     * in C# and which arithmetic operations it has.
     */
    class Program
    {
        static void Main(string[] args)
        {
            /* C# has next Arithmetic Operations: 
             (Unary, Binary, Ternary operations)*/

            // BINARY ARITHMETIC OPERATIONS:

            // + (addition)
            int x = 99;
            int y = x + 2;

            // - (subtraction)
            int x2 = 99;
            int y2 = x2 - 9;

            // * (multiplication)
            int x3 = 9;
            int y3 = x3 * 9;

            // / (division)
            int x4 = 80;
            int y4 = x4 / 4;

            // but
            double d = 10 / 4; // 2 (int) => 10(int) / 4(int) = Convert.ToDouble(2(int)) because all numbers is integer by default
            // You have to indicate it explicit as float or double
            double d2 = 10.0d / 4.0d; // 2.5d
            float f = 9.0f / 3.0f; // 3.0f

            // % remainder of the division (modulo (по модулю)) 
            // !!!REMAINDER IS ONLY INTEGER!!!
            double r = 10.0 % 4.0; // result is 2

            // UNARY ARITHMETIC OPERATIONS:

            // ++ (increment):

            // prefix:
            int pef = 10;
            int a = ++pef + 1; // a = 12 after the operation pef = 11 and 
            // at runtime the operation first pef + 1 (++pef) and after this pef + 1 = 12

            // postfix
            int pof = 10;
            int b = pof++ + 1; // b = 11 after the operation pof = 11 and 
            // at runtime the operation first pof + 1 = 11, and after this pof++ == (pof + 1)

            // also

            // -- (decrement):

            // prefix:
            int a1 = 5;
            int b1 = --a1; // a1 = 4, b1 = 4

            // postfix:
            int a2 = 5;
            int b2 = a2--; // b2 = 5, a2 = 4

            // Priority of the operations:

            // 1. Increment, Decrement
            // 2. Multiplication, Division, Remainder of the division
            // 3. Addition, Subtraction

            // For change the priority of the operations use parentheses => ()

            // If you have a operations with the same priority so following of execution a operations 
            // defining by associativity of the operations

            int l = 10 / 5 * 2; // left to right
            // Console.WriteLine(l); // 4

            // all arithmetic operations is left-associativity operators (except prefix increment and decrement)
        }
    }
}
