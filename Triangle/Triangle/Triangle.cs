using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        private double p { get; set; }
        public double S { get; private set; }

        private void Semiperimeter(double a, double b, double c)
        {
            p = (a + b + c) / 2;
        }

        public void TriangleArea()
        {
            Semiperimeter(sideA, sideB, sideC);
            S = Math.Sqrt((p * (p - sideA) * (p - sideB) * (p - sideC)));
        }
    }
}
