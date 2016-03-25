using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionConsep
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car01 = new Car("Honda", "Red", "John", 0);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    car01.Accelerate(10);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
