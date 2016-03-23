using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class Manager: BasicEmployee
    {
        public int numberOfSales { get; set;}
        private readonly int DEPID = 53;
        public Manager(string name, string surname, int age, int number, int numberOfSales) :base(name, surname, age) { numberOfSales = number; }
        public int depNumber { get { return DEPID; } }
        public void showPersonData() { Console.WriteLine("Person sales data and department: {0}, {1}", numberOfSales, DEPID );}
     }
}
