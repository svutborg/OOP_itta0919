using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The larger of the two numbers is: {GetMax(num1, num2, 4)}");
        }

        static int GetMax(int a, int b, int? c=null)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = (int)c;
            }
            return max;
        }

        static int GetMax(params int[] numbers)
        {
            int max = int.MinValue;
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
