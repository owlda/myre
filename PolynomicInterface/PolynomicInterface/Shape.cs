using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolynomicInterface
{
    abstract class Shape
    {
        public string ShapeName {get; set;}
        public Shape(string name = "noname")
        { ShapeName = name; }
        
        public abstract void Draw();
     }
}
