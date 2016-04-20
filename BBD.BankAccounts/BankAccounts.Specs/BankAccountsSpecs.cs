using BankAccounts;
using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Specs
{
    [Subject("Transferring money from a valid balance")]
    public class When_transferring_money_between_two_accounts
    {
        It Should_debit_the_from_account_by_the_transfer_amount = () =>
        {
            var fromAccount = new Account(1000);
            var toAccount = new Account(500);
            var transferMamanger = new Transfer(new EmailGateway());
            transferMamanger.TransferFunds(fromAccount, toAccount, 250);
            fromAccount.Balance.ShouldEqual(750);
        };
    }
}
