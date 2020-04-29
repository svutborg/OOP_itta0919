using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._4
{
    class Program
    {
        /*
         * Write a program that implements a class for a right angle triangle.
         * Include the following fileds into your class:
         *   Length of each of the three legs
         *   Area of the triangle
         *   Circumference of the triangle
         *   Define a constructor, that takes the length of the two chateti as argument and initializes the rest of the fields based on these.
         *   
         *   Modify your program to ask for the lengths of the two chateti and wait for the user to input them. Use the entered lengths to call your constructor and create a triangle object
         */

        /* The class is implemented in the separate file RightAngleTriangle.cs */

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengths of the two chateti (sides adjasent to the right angle)");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            RightAngleTriangle t = new RightAngleTriangle(sideA, sideB);

        }
    }
}
