using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolynomicInterface
{
    class Circle:Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Draw {0} the circle", ShapeName);
        }
    }
}
