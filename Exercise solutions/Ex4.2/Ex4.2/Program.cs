using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._2
{
    class Program
    {
        /*
         * Write a program that detects how many times a substring is contained in the text.
         * For example, let's look for the substring "in" in the text:
         * 
         * We are living in a yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
         * 
         * The result is 9 occurrences.
         */

        static void Main(string[] args)
        {
            string testString = "We are living in a yellow submarine. " +
                "We don't have anything else. " +
                "inside the submarine is very tight. " +
                "So we are drinking all the day. " +
                "We will move out of it in 5 days.";
            string substring = "in";
            int occurrences = 0;
            int lastIndex = 0;

            lastIndex = testString.IndexOf(substring);
            while (lastIndex != -1)
            {
                occurrences++;
                lastIndex = testString.IndexOf(substring, lastIndex+1, StringComparison.CurrentCultureIgnoreCase);
            }
            Console.WriteLine(occurrences);
        }
    }
}
