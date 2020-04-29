using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNorm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoNorm(3, 4));
        }
        static double TwoNorm(params double[] x)
        {
            double sum = 0; 
            foreach(double a in x)
            {
                sum += a*a;
            }
            return Math.Sqrt(sum);
        }

    }
}
