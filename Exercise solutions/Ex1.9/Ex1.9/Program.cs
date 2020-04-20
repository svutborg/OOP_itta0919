using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._9
{
    /* 
     * Write an expression that checks whether an integer is odd or even.
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Enter a number");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is Even");
            }
            else
            {
                Console.WriteLine($"{i} is Odd");
            }
            Console.Read();
        }
    }
}
