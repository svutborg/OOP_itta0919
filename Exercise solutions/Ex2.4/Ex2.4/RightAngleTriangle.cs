using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2._4
{

    class RightAngleTriangle
    {
        private double sideA;
        private double sideB;
        private double hypotenuse;
        private double area;
        private double circumference;

        public RightAngleTriangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;

            hypotenuse = Math.Sqrt(sideA * sideA + sideB * sideB);
            area = sideA * sideB / 2;
            circumference = sideA + sideB + hypotenuse;
        }

        /* Method is optinal and for diaplaying */
        public override string ToString()
        {
            return $"Triangle:" +
                $"\n\tSide A:        {sideA}" +
                $"\n\tSide B:        {sideB}" +
                $"\n\tHypotenuse:    {hypotenuse}" +
                $"\n\tArea:          {area}" +
                $"\n\tCircumference: {circumference}";
        }
    }
}
