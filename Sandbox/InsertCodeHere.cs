using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Create a new BankAccount object
            BankAccount acc = new BankAccount("Anna");

            // What is the initial balance (should be 0)?
            Console.WriteLine("{0}'s account has a balance of {1}", acc.GetName(), acc.GetBalance());

            acc.Deposit(1000.0);
            acc.Deposit(1300.0);

            // What is the balance after some deposits (should be 2300)?
            Console.WriteLine("{0}'s account has a balance of {1}", acc.GetName(), acc.GetBalance());

            acc.Withdraw(2000.0);
            acc.Withdraw(800.0);

            // What is the balance after some withdrawals (should be -500)?
            Console.WriteLine("{0}'s account has a balance of {1}", acc.GetName(), acc.GetBalance());

            acc.Deposit(1000.0);
            acc.Deposit(2800.0);

            // What is the balance after some deposits (should be 3300)?
            Console.WriteLine("{0}'s account has a balance of {1}", acc.GetName(), acc.GetBalance());

            acc.AssignInterest(6.0);

            // What is the balance after assigning interest (should be 3498)?
            Console.WriteLine("{0}'s account has a balance of {1}", acc.GetName(), acc.GetBalance());

            // The LAST line of code should be ABOVE this line
        }
    }
}
