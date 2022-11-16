using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private int accountNumber;
        private char type;
        private decimal balance;
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public BankAccount(char type, decimal intialDeposit, int accountNumber, string firstName, string lastName)
        {
            this.accountNumber = accountNumber;
            this.type = type;
            Deposit(intialDeposit);
            FirstName = firstName;
            LastName = lastName;
        }

        //This is the Copy Constructor!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public BankAccount(BankAccount otherObj) 
        { 
            this.accountNumber = otherObj.accountNumber;
            this.type = otherObj.type;
            this.balance= otherObj.balance;
            this.FirstName= otherObj.FirstName;
            this.LastName= otherObj.LastName;
        }

        public bool Deposit(decimal amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                return true;
            }
        }

        public decimal GetBalance()
        {
            return this.balance;
        }

        public string GetBalanceAsDollars()
        {
            return this.balance.ToString("C");
        }

        public override string ToString()
        {
            string msg = "";

            msg += this.accountNumber + "\n";
            msg += this.type + "\n";
            msg += this.GetBalanceAsDollars() + "\n";
            msg += FirstName + "\n";
           msg += LastName + "\n";

            return msg;
        }
    }
}
