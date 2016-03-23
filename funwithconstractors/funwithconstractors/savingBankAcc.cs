using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace funwithconstructors
{
    class savingBankAcc
    {
        public double currentBalance;
        public double currentInterestRate;
        public double currentBalanceInterest;

        public savingBankAcc(double balance)
        {
            currentBalance = balance;
            currentInterestRate = 0.10;
            //currentBalanceInterest = currentBalance * currentInterestRate;
        }
        public void NewInterestRate(double newRate)
        {
            currentInterestRate = newRate;
        }

        public void NewBalanceInterest(double newRate)
        {
            currentBalanceInterest = currentBalance * currentInterestRate;
        }
    }
}
