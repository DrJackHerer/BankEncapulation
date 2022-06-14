using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }

        private double _balance = 10;
        
        public double Deposit(double amount)
        {
          return _balance += amount;
        }

        public double GetBalance()
        {
            return _balance;
        }



        
    }

}
