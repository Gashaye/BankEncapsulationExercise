using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    class BankAccount
    {
        private double balance = 0;
        public void Deposit(double myDeposit)
        {
            balance+= myDeposit;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
