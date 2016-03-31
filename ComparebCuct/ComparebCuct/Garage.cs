﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ComparebCuct
{
    public class Garage: IEnumerable
    {
        Car[] CarsInGarage = new Car[4];
        
        public Garage() 
        {
            CarsInGarage[0] = new Car("Ford","DarkGreen","Rusty",0,125);
            CarsInGarage[1] = new Car("Renault", "DarkRed", "Bony", 0,158);
            CarsInGarage[2] = new Car("Mitsubishi", "Green", "Cookie", 0,652);
            CarsInGarage[3] = new Car("Chevrolet", "White", "Don", 0,542);
        }
        public IEnumerator GetEnumerator() { return CarsInGarage.GetEnumerator(); }
      
    }
}