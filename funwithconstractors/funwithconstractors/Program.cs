using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using funwithconstractors;

namespace funwithconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //savingBankAcc acc01 = new savingBankAcc(10000);
            //savingBankAcc acc02 = new savingBankAcc(23500);
            //savingBankAcc acc03 = new savingBankAcc(856);

            ////Console.WriteLine("Сумма вклада = {0} ", acc01.currentBalance);
            ////Console.WriteLine("Текущая процентая ставка = {0} ", acc01.currentInterestRate);
            ////Console.WriteLine("Текущий процент по вкладу = {0}", acc01.currentBalanceInterest);
            ////Console.WriteLine(acc02.currentBalanceInterest);
            ////Console.WriteLine(acc03.currentBalanceInterest);
            
            //acc01.NewInterestRate(0.25); // Меняем процентную ставку по первому вкладу.
            
            //Console.WriteLine(acc01.currentInterestRate); // Проверяем текущию процентную ставку
            //Console.WriteLine(acc01.currentBalanceInterest); // Проверяем текущий процент по вкладу


            // work with points
            funwithconstractors.point p1 = new funwithconstractors.point(0, 0);
            p1.ChangeColor("White");
            //p1.ChangeCor(3, 4);
            //p1.ShowCor();
            //p1.MoveCorX(10, 10);
            //p1.MoveCorY(10, 10);
            //p1.ShowCor();
            p1.MoveEvaluation(1, 2);


            
            
        }
    }
}
