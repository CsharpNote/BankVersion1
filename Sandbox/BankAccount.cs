using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class BankAccount
    {
        // Two instance fields for representing the name of the account holder,
        // and the current balance of the account
        private String accountHolderName;
        private double balance;

        // Constructor - a name MUST be provided
        public BankAccount(String name)
        {
            accountHolderName = name;
            balance = 0.0;
        }

        // Deposit the specified amount into the account
        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        // Withdraw the specified amount from the account
        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }

        // Return the current balance of the account
        public double GetBalance()
        {
            return balance;
        }

        // Return the name of the bank account holder
        public String GetName()
        {
            return accountHolderName;
        }

        // Interest is here just defined as a simple percentage
        // of the current balance (not quite realistic...)
        public void AssignInterest(double interestPercentage)
        {
            double interest = balance * (interestPercentage / 100.0);
            balance = balance + interest;
        }
    }
}
