using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
   partial class BasicEmployee
    {
        public void addAge(int age) { Age += age; }
        public void changeName(string namePerson) { Name = namePerson; }
        public void changeSurName(string surnamePerson) { Surname = surnamePerson; }
        public void showPerson() { Console.WriteLine("Person: {0} {1} \nAge:{2}", Name, Surname, Age); }

        protected BenefitPack empBenefits = new BenefitPack();
        public BenefitPack Benefit { get { return empBenefits; } set { empBenefits = value; } }

        //public double GetPenefitsCost() { return empBenefits.AddPayDeduction(); }
    }
}
