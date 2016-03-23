using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolynomicInterface
{
    class Hexagon: Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Draw {0} the hexagon", ShapeName);
        }
    }
}
