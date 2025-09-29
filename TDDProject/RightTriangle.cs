using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class RightTriangle
    {
        public double A {  get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public bool IsRight()
        {
            bool hA = A * A == C * C + B * B;
            bool hB = B * B == C * C + A * A;
            bool hC = C * C == B * B + A * A;
            return hA||hB||hC;
        }
        public double Perimetr()
        {
            return A + B + C;
        }
        public double Area()
        {
            var (a, b, c) = (A, B, C);
            if (A > B && B > C)
            {
                c = A;
                a = C;
            }
            if (B > A && B > C)
            {
                c = B;
                b = C;
            }

            return (a * b) / 2;
        }
    }
}
