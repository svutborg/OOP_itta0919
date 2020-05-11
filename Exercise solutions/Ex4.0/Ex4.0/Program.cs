using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._0
{
    /*  Write a program that reads a string from the console, reverse it and prints it to the console.
     *  For example: "introduction" → "noitcudortni".
     *      
     */
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] intermediate = new char[input.Length];
            
            for (int i = 0; i < input.Length; i++)
            {
                intermediate[i] = input[input.Length - i - 1];
            }
            string output = new string(intermediate);

            Console.WriteLine(output);

        }
    }
}
