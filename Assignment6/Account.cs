using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_1
{


    public class Account
    {
        #region Events
        UnderBalance underBalance = new UnderBalance(Events.UnderBalanceEvent);
        BalanceZero balanceZero = new BalanceZero(Events.BalanceZeroEvent);
        #endregion

        #region Fields
        private long accountNumber;
        private string customerName;
        private double balance;
        #endregion

        #region Properties
        public long AccountNumber { get { return accountNumber; } set { accountNumber = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
        #endregion

        #region Withdraw Method
        public double Withdraw(double amount)
        {
            if (this.balance >= amount)
            {
                Console.WriteLine("\nWithdrawal Successful of Rs {0}/-", amount);
                this.balance -= amount;
                underBalance(this.balance, amount);
                balanceZero(this.balance, amount);
                return amount;
            }
            underBalance(this.balance, amount);
            balanceZero(this.balance, amount);
            return 0;
        }
        #endregion

        #region Deposit Method
        public double Deposit(int amount)
        {
            this.balance += amount;
            Console.WriteLine("\nDeposit Successful for Rs. {0}/-", amount);
            return this.balance;
        }
        #endregion

        #region Display
        public void Display()
        {
            Console.WriteLine("\n----------------Display A/C Details---------------");
            Console.WriteLine("Name: {0}", this.CustomerName);
            Console.WriteLine("Account Number: {0}", this.AccountNumber);
            Console.WriteLine("Balance: {0}", this.Balance);
        }
        #endregion
    }
}
