using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    partial class BasicEmployee
    {
        private string Name;
        private string Surname;
        private int Age;
        public BasicEmployee() { }
        public BasicEmployee (string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
     }
}
