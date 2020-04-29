using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._3
{
    class Program
    {
        /*
         * Write a method that returns the English name of the last digit of a given number. Example: for 512 prints "two"; for 1024 prints "four".
         * Hint: Use modulo 10 to get the last digit (number % 10).
         */
        enum Numbers { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine }
        static void Main(string[] args)
        {
            //string[] numbers = { "Zero", "One", "Two", "Three" ...}; // exercise is solved by using an enumertation, but can more easily be sovled by using an array of strings
            Console.WriteLine("Enter a number");
            Numbers num = (Numbers) (int.Parse(Console.ReadLine())%10);
            Console.WriteLine("The last digit of the number you entered is: {0}", num);

        }
    }
}
