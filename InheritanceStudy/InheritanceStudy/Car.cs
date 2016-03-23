using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceStudy
{
    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;
        private string colorCar = "White";
        private enum variationColors {White,Red,Black}
        
        public Car(int max)
        {
            maxSpeed = max;
        }
        public Car()
        {
            maxSpeed = 55;
        }
        public int Speed
        {
            get { return currSpeed; }
            set { currSpeed = value;
            if (currSpeed > maxSpeed)
            { currSpeed = maxSpeed; }
                }
                    }
        public void showSpeed()
        { Console.WriteLine("Current speed = {0}" , currSpeed); }

        public string Color
        {
            get { return colorCar; }
            set { colorCar = value;
            //if (colorCar != variationColors.Black.ToString("Black") & colorCar != variationColors.Red.ToString("Red")) 
                if (colorCar != "Black" && colorCar !="Red")
            { colorCar = "White"; }
            }
        }
        public void showStat() 
        {
            Console.WriteLine("Current speed = {0} \nCurrent color = {1}", currSpeed, colorCar);
        }
    }
}
