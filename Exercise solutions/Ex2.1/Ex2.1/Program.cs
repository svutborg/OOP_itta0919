using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._1
{
    class Program
    {
        /*
         * Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The larger of the two numbers is: {GetMax(num1, num2)}");
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
