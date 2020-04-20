using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsEnumExample
{
    enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current month: ");
            foreach (Months month in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine($"{(int)month}: {month}");
            }
        }
    }
}
