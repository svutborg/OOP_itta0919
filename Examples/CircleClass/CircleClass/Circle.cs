using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleClass
{
    struct Point
    {
        double x;
        double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    class Circle
    {
        static int circleCounter = 0;
        double radius;
        Point center;
        double area;
        double perimeter;
        
        public Circle(double radius, Point center)
        {
            Radius = radius;
            Center = center;
            circleCounter++;
        }

        public Circle(double radius, double centerX, double centerY)
        {
            Radius = radius;
            Center = new Point(centerX, centerY);
            circleCounter++;
        }

        ~Circle()
        {
            circleCounter--;
            Console.WriteLine("removing circle");
        }

        public static int CircleCounter { get => circleCounter; protected set => circleCounter = value; }
        public double Area { get => area; private set => area = value; }
        public double Perimeter { get => perimeter; private set => perimeter = value; }
        public double Radius
        {
            get { return radius; }
            set 
            {
                if (value >= 0)
                {
                    radius = value;
                    Area = Math.PI * radius * radius;
                    Perimeter = Math.PI * 2 * radius;
                }
                else
                {
                    // TODO: Throw exception 
                }
            }
        }

        public Point Center { get => center; set => center = value; }

        static public Boolean Compare(Circle C1, Circle C2)
        {
            Boolean result = false;
            if (C1.radius == C2.Radius)
            {
                if (C1.Center.X == C2.Center.X && C1.Center.Y == C2.Center.Y)
                {
                    result = true;
                }
            }
            return result;
        }

        public override string ToString()
        {
            return $"Circle with radius {radius} and center {Center}";
        }
    }
}
