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
            Console.WriteLine($"Number of circles: {Circle.CircleCounter}");

            Circle C2 = new Circle(5, new Point(1, 0));
            Console.WriteLine(C2.ToString());
            Console.WriteLine($"Number of circles: {Circle.CircleCounter}");

            CreateMoreCircles();

            Console.WriteLine($"Number of circles: {Circle.CircleCounter}");
            Console.WriteLine(Circle.Compare(C1, C2));

            C1.Radius = 2;

            Console.WriteLine(C1.ToString());
            Console.WriteLine(C1.Area);

        }

        static void CreateMoreCircles()
        {
            Circle[] circles = new Circle[10];
            for (int i = 0; i < 10; i++)
            {
                circles[i] = new Circle(i, 0, 0);
                Console.WriteLine($"There are now: {Circle.CircleCounter} circles.");
            }
        }
    }
}
