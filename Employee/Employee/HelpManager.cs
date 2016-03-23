using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    sealed class HelpManager : Manager
    {
        public HelpManager(string name, string surname, int age, int number, int numberOfSales) : base(name, surname, age, number, numberOfSales) { }
        
    }
}
