using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.A
{
    /* 
     * Objective:
     * Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the area and perimeter of a rectangle, given side and height measurement:");
            Console.Write("Side: ");
            int side = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Area: {side * height}; Perimeter {2 * side + 2 * height}");
            Console.Read();

        }
    }
}
