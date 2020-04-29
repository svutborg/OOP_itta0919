using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int length = 1000;
            // allocate three equally sized arrays
            int[] numbers1 = new int[length];
            int[] numbers2 = new int[length];
            int[] numbers3 = new int[length];

            // populate array with random numbers
            for (int i = 0; i < length; i++)
            {
                numbers1[i] = r.Next(0, 99);
            }

            // copy array to the two others
            numbers1.CopyTo(numbers2, 0);
            numbers1.CopyTo(numbers3, 0);

            //Console.WriteLine("Before sorting:");
            //PrintArray(numbers1);
            //PrintArray(numbers2);
            //PrintArray(numbers3);

            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            Stopwatch s3 = new Stopwatch();

            s1.Start();
            Sort.Bouble(ref numbers1);
            s1.Stop();

            s2.Start();
            Sort.Selection(ref numbers2);
            s2.Stop();

            s3.Start();
            Sort.Quick(ref numbers3);
            s3.Stop();

            //Console.WriteLine("After sorting:");
            //PrintArray(numbers1);
            //PrintArray(numbers2);
            //PrintArray(numbers3);

            Console.WriteLine("Times:");
            Console.WriteLine($"Time for boublesort:     {s1.ElapsedTicks} ticks, {s1.ElapsedMilliseconds} ms");
            Console.WriteLine($"Time for selection sort: {s2.ElapsedTicks} ticks, {s2.ElapsedMilliseconds} ms");
            Console.WriteLine($"Time for quicksort:      {s3.ElapsedTicks} ticks, {s3.ElapsedMilliseconds} ms");
        }

        static void PrintArray(params int[] elements)
        {   // Solution to previous exercise
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
