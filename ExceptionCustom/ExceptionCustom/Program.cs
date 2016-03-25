using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car007 = new Car("Volvo", "Black", "John" ,0);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    car007.Accelerate(10);
                }
            }
            catch (CarIsDeadException e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
        }
    }
}
