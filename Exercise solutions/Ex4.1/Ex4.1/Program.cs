using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1
{
    class Program
    {
        /*
         * Write a program that checks whether the parentheses are placed correctly in an arithmetic expression.
         * Example of expression with correctly placed brackets: ((a+b)/5-d).
         * Example of an incorrect expression: )(a+b)).
         */
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            bool error = false;
            int openingBrackets = 0, closingBrackets = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBrackets++;  
                }
                else if (expression[i] == ')')
                {
                    closingBrackets++;
                    if (closingBrackets > openingBrackets)
                    {
                        error = true;
                    }
                }
            }
            if (closingBrackets != openingBrackets)
            {
                error = true;
            }

            if (error == false)
            {
                Console.WriteLine("The expression is valid");
            }
            else
            {
                Console.WriteLine("The expression is not valid");
            }
        }
    }
}
