using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.Savings
{
    public class Account
    {
        private double accountBalance = 0.00;
        private bool accountStatus = false;

        private enum Roles
        {
            Customer,
            Manager
        }

        public bool IsAccountActive(string accNumber)
        {
           return accountStatus;            
        }

        public double Balance(string accNumber)
        {
            return accountBalance;
        }
       
        public double Deposit(string accNumber, double amount)
        {
            return accountBalance = accountBalance + amount;
        }

        public double Withdwral(string accNumber, double amount)
        {
            return accountBalance = accountBalance - amount;
        }

        private bool ActivateAccount(string accNumber, Roles userRole)
        {
            accountStatus = true;
            return accountStatus;
        }
    }
}