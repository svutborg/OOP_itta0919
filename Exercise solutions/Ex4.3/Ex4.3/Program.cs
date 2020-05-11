using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._3
{
    /*
     * A text is given. Write a program that modifies the casing of letters to uppercase at all places in the text surrounded by <upcase> and </upcase> tags. Tags cannot be nested.
     * Example:
     * We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
     * Result:
     * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string[] fragments = testString.Split('<','>');
            StringBuilder sb = new StringBuilder();
            bool upcase = false;
            for (int i = 0; i < fragments.Length; i++)
            {
                if (fragments[i] == "upcase")
                {
                    upcase = true;
                } 
                else if (fragments[i] == "/upcase")
                {
                    upcase = false;
                }
                else 
                {
                    if (upcase)
                    {
                        sb.Append(fragments[i].ToUpper());
                    }
                    else
                    {
                        sb.Append(fragments[i]);
                    }
                        
                }

            }
            string output = sb.ToString();
            Console.WriteLine(output);
        }
    }
}
