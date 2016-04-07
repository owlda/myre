using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservableCol
{
    partial class BasicEmployee
    {
        public string Name;
        public string Surname;
        public int Age;
        public BasicEmployee() { }
        public BasicEmployee (string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
     }
}
