﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._5
{
    class Program
    {
        /*
         * Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.
         * 
         */
        static void Main(string[] args)
        {
            for (int i = 2; i < 102; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($" {i},");
                }
                else
                {
                    Console.Write($" -{i},");
                }
            }
            Console.Read();
        }
    }
}
