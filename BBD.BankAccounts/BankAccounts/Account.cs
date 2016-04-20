using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Account
    {
        public Account(int initialBalance = 0)
        {
            Balance = initialBalance;
        }

        public double Balance { get; private set; }

        public void Credit(double amount)
        {
            Balance += amount;
        }

        public void Debit(double amount)
        {
            Balance -= amount;
        }



    }
}
