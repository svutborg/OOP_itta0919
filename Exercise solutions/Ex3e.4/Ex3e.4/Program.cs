using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e._4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(new int[] { 1, 4, 7, 2, 4 });
        }

        static void PrintArray(params int[] elements)
        {
            Console.Write("[");
            for (int index = 0; index < elements.Length; index++)
            {
                Console.Write(elements[index]);
                if (index < elements.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
