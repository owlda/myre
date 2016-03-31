using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CustomEnu
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage myga = new Garage();
            foreach (Car i in myga)
            {
                Console.WriteLine(i);
            }
            IEnumerator enu = myga.GetEnumerator();
            enu.Reset();
            }
    }
}
