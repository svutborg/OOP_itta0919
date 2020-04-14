using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("State your current age: ");
            string line = Console.ReadLine();
            
            int futureAge = int.Parse(line) + 10;
            Console.WriteLine($"In that case you will be {futureAge} years old in 10 years.");

            Console.Read();
        }
    }
}
