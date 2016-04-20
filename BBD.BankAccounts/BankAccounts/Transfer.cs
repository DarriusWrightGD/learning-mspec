using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Transfer
    {
        private readonly IEmailGateway _emailGateway;

        public Transfer(IEmailGateway emailGateway)
        {
            _emailGateway = emailGateway;
        }

        public void TransferFunds(Account from, Account to, double amount)
        {
            if(from.Balance < amount)
            {
                throw new ArgumentException($"Error, the transfer amount {amount} cannot be higher than the remaining balance {from.Balance}");
            }

            from.Debit(amount);
            to.Credit(amount);
            _emailGateway.SendEmail("Funds transferred", "bdd@bank.com", $"The amount {amount} has been transferred into your account");
        }


    }
}
