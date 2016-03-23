using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car volvo = new Car();
            volvo.Speed = 40;
            volvo.showSpeed();
            volvo.Color = "Green";
            volvo.showStat();
            MiniVan ford = new MiniVan();
            ford.Speed = 10;
            ford.Color = "Red";
            ford.showStat();
            ford.sizeCar = 3;

        }
    }
}
