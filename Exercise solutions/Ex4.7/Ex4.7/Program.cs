using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._7
{
    class Program
    {
        /*
         * Write a program that reverses the words in a given sentence without changing punctuation and spaces.
         * For example:
         * C# is not C++ and PHP is not Delphi → Delphi not is PHP and C++ not is C#
         */
        static void Main(string[] args)
        {
            string input = "C# is not C++ and PHP is not Delphi";
            string[] fractions = input.Split();
            string inputReversed = "";
            for (int i = fractions.Length - 1; i > 0; i--)
            {
                inputReversed += fractions[i] + ' ';
            }
            inputReversed += fractions[0];

            Console.WriteLine(inputReversed);

        }
    }
}
