using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._4
{
    class Program
    {
        /*
         * Write a program that reads a string from the console (20 characters maximum) and if shorter complements it right with "*" to 20 characters.
         */
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = input.PadRight(20, '*');

            Console.WriteLine(output);
        }
    }
}
