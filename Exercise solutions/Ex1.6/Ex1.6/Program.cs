using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._6
{
    class Program
    {
        /*
         * Write a program that reads your age from the console and prints your age after 10 years.
         * 
         */
        static void Main(string[] args)
        {
            Console.Write("State your current age: ");
            string line = Console.ReadLine();
            
            int futureAge = int.Parse(line) + 10;
            //int futureAge = Convert.ToInt32(line) + 10;
            Console.WriteLine($"In that case you will be {futureAge} years old in 10 years.");

            Console.Read();
        }
    }
}
