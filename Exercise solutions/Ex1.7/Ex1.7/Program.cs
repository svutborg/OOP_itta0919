using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._7
{
    class Program
    {
        /*
         * Declare a string vairable and assign it a value “The "use" of quotations causes difficulties.” (without the outer quotes).
         * Write the string to the console and verify that it indeed states: The "use" of quotations cause difficulties.
         * 
         */
        static void Main(string[] args)
        {
            string s = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine(s);
            Console.Read();
        }
    }
}
