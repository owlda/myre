using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolynomicInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle("Circle1");
            c1.Draw();
            Hexagon x1 = new Hexagon("Hexagon1");
            x1.Draw();

        }
    }
}
