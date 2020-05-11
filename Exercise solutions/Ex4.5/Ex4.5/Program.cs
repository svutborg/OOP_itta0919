using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._5
{
    class Program
    {
        /*
         * A string is given, composed of several "forbidden" words separated by commas. 
         * Also a text is given, containing those words. Write a program that replaces the forbidden words with asterisks.
         * Sample text:
         * Microsoft announced its next generation C# compiler today. 
         * It uses advanced parser and special optimizer for the Microsoft CLR.
         * 
         * Sample string containing the forbidden words: "C#,CLR,Microsoft".
         * Sample result:
         * 
         * ********* announced its next generation ** compiler today. 
         * It uses advanced parser and special optimizer for the ********* ***.
         */
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. " +
                "It uses advanced parser and special optimizer for the Microsoft CLR.";
            string[] forbidden = "C#,CLR,Microsoft".Split(',');

            Console.WriteLine(text); // Print starting text

            foreach(string token in forbidden)
            {
                text = text.Replace(token, new string('*', token.Length));
            }

            Console.WriteLine(text); // Print censored text
        }
    }
}
