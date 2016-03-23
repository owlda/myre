using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicEmployee person1 = new BasicEmployee("John", "Bowle", 34);
            person1.showPerson();
            Manager person2 = new Manager("Inna", "Doe", 21, 0, 0);
            person2.numberOfSales = 3;
            person2.showPerson();
            person2.showPersonData();
            HelpManager person3 = new HelpManager("Sanya","Boreni", 33, 0, 0);
            person3.Benefit.AddPayDeduction();
            
            //double addbenefitPerson3 = person3.GetPenefitsCost();

            person1.Benefit.MinusBenefit = 100;
        }
    }
}
