using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicConsoleApp.Classes
{
    public class CircleCalculate
    {
        double radius;

        public CircleCalculate(double radius)
        {
            this.radius = radius;
        }

        public void CircleArea()
        {
            double s = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"S = {s}");
        }

        public void CircleLength()
        {
            double l = 2 * Math.PI * radius;

            Console.WriteLine($"L = {l}");
        }
    }
}