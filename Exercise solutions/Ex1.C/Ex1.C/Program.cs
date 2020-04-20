using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.C
{
    /*
     * Objective:
     * Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of a circle:");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area and perimeter of a circle with radius {r} is:\n\tArea:     {Math.Round(Math.PI * r * r,2)}\n\tPerimter: {Math.Round(Math.PI * 2 * r,2)} ");
            Console.ReadLine();
        }
    }
}
