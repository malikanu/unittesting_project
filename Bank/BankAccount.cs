using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Library
{
    // Bank account Demo Class
    public class BankAccount
    {
        private string m_customerName;
        private double m_balance;

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public String CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        // Method to withdraw amount
        public void Debit(double amount)
        {

            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("Debit amount exceeds balance");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Debit amount less than zero");
            }


            m_balance -= amount; // Intentionaly incorrect code
        }

        // Method to deposit amount
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Debit amount less than zero");
            }

            m_balance += amount;
        }


        /* By analyzing the methods under test (Debit & Credit), we determine that there are at least three behaviors that need to be checked:
             1. The method throws an ArgumentOutOfRangeException if the debit amount is greater than the balance.
             2. It also throws ArgumentOutOfRangeException if the debit amount is less than zero.
             3. If the checks in 1.) and 2.) are satisfied, the method adds and deducts the amount from the account balance.*/
    }
}
