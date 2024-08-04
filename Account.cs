using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represent single customer account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The representation of the owner's account number
        /// </summary>
        public String Owner { get; set; }

        /// <summary>
        /// This is the account balance
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Create an account with specific owner and balance is 0.0
        /// </summary>
        /// <param name="accOwner">The customer full name that own the account</param>
        public Account(string accOwner)
        {
            Owner = accOwner;
        }

        /// <summary>
        /// This method will deposit the amount to the account
        /// </summary>
        /// <param name="amount">The positive amount will deposit into the account</param>
        /// <returns>Return the account's balance after depoist </returns>
        public double Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                throw new ArgumentException("Amount must be positive");
            }
            
            return Balance;
        }

        /// <summary>
        /// This method will withdraw the amount from the account
        /// </summary>
        /// <param name="amount">The positive amount will withdraw from the account</param>
        /// <returns>Return the account's balance after withdraw</returns>
        public double Withdraw(double amount)
        {
            if(Balance >= amount) { 
                Balance -= amount;
            }
            return Balance;
        }
    }
}
