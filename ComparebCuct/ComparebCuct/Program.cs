using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparebCuct
{
    class Program
    {
        static void Main(string[] args)
        {

            //Garage myAuto = new Garage();
            //foreach (Car i in myAuto)
            //{
            //    Console.WriteLine("Compare cars {0}", i.CarID);
            //}
            //Array.Sort(myAuto);
            Car[] myAutos = new Car[3];
            myAutos[0] = new Car("1","2","3", 0, 545345);
            myAutos[1] = new Car("2", "2", "3", 0, 94543);
            myAutos[2] = new Car("3", "2", "3", 0, 345367567);
            foreach (Car i in myAutos)
            {
                Console.WriteLine("my cars id {0}", i.CarID);
            }
            Array.Sort(myAutos);
            foreach (Car i in myAutos)
            {
                Console.WriteLine("Compares cars {0}", i.CarID);
            }
            

        }
    }
}
