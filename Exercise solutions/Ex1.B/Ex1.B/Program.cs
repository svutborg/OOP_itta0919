using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.B
{
    /* 
     * Objective: 
     * Write a program that reads from the console three numbers of type int and prints their sum.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter three integer numbers:");
            for (int i = 0; i < 3; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum: {sum}");
            Console.Read();

        }
    }
}
