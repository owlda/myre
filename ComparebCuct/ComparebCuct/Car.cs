using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ComparebCuct
{
    class Car : IComparable
    {
        private string Model;
        private string Color;
        private int Speed;
        private string DriverName;
        private bool CarStop;
        private readonly int MaxSpeed = 100;
        public int CarID{get;set;}

        public Car() { }
        public Car(string model, string color, string driver, int speed, int id) { Model = model; Color = color; DriverName = driver; Speed = speed; CarID = id; }

        public int CurrentSpeed {get {return Speed;}}
      
        
        public void Accelerate(int speed) 
        {
            if (CarStop)
                Console.WriteLine("Car {0} was stop.", Model);
            else
            {
                Speed += speed;
                if (CurrentSpeed >= MaxSpeed)
                {
                    Speed = 0;
                    CarStop = true;
                    CarIsDeadException exep = new CarIsDeadException(string.Format("{0} has overheated", Model), "You have to high speed", DateTime.Now);
                    exep.HelpLink = "http://helpme.mymind";
                    throw exep;
                                      
                    //throw new Exception(string.Format("Car {0} is overheat!", Model));
                }
                else if (CurrentSpeed > 60) Console.WriteLine("Car {0} is high speed over 60 mph.", Model); 
                else { ShowStat(); }
            }

         }
        public void Deaccelerate(int speed) { Speed -= speed; }
        public void ShowStat() { Console.WriteLine("Car {1}, current speed = {0}", Speed, Model); }

        int IComparable.CompareTo(object o)
        {
            Car temp = o as Car;
            if (temp != null)
            { if (this.CarID > temp.CarID)
                    return 1;
                else if (this.CarID < temp.CarID) 
                    return -1;
                else return 0;
            }
            else throw new ArgumentException("Object is not a car");

        }


    }
}
