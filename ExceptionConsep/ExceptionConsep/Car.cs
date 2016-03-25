using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionConsep
{
    class Car
    {
        private string Model;
        private string Color;
        private int Speed;
        private string DriverName;
        private bool CarStop;
        private readonly int MaxSpeed = 100;

        public Car() { }
        public Car(string model, string color, string driver, int speed) { Model = model; Color = color; DriverName = driver; Speed = speed; }

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
                    throw new Exception(string.Format("Car {0} is overheat!", Model));
                }
                else if (CurrentSpeed > 60) Console.WriteLine("Car {0} is high speed over 60 mph.", Model); 
                else { ShowStat(); }
            }

         }
        
        public void Deaccelerate(int speed) { Speed -= speed; }
        public void ShowStat() { Console.WriteLine("Car {1}, current speed = {0}", Speed, Model); }
    }
}
