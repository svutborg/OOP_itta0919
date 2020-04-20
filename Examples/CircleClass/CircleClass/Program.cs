using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5, new Point(0,0));
            Console.WriteLine(C1.ToString());

            C1.Radius = 2;

            Console.WriteLine(C1.ToString());
            Console.WriteLine(C1.Area);

        }
    }
}
