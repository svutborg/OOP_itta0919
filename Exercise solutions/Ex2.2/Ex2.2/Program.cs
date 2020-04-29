using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._2
{
    class Program
    {
        /*
         * Modify your program so that it reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created.
         * Hint: Use Convert.ToInt32() for converting a string to an integer.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The larger of the three numbers is: {GetMax(num1, GetMax(num2, num3))}");
            Console.Read();
        }

        static int GetMax(int a, int b)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            return max;
        }
    }
}
