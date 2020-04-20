using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._4
{
    /*
     * Write a program that prints the square root of 12345.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The squareroot of 12345 is {Math.Round(Math.Sqrt(12345),2)}"); // printing squareroot of 12345 rounded to two decimals

            Console.Read();
        }
    }
}
