using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._8
{
    /* 
     * Objective:
     * Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange(swap) their values and print them. 
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.Read();
        }
    }
}
