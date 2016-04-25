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
    public class When_transferring_money_between_two_accounts : BaseScheduleContext
    {
        //Arrange
        Establish context = () =>
        {
            CreateAccounts(1000, 1500);
        };

        //act
        Because of = () =>
        {
            transfer.TransferFunds(fromAccount, toAccount, 250);
        };

        //assert
        It should_debit_the_from_account_by_the_transfer_amount = () =>
        {
            fromAccount.Balance.ShouldEqual(750);
        };

        It should_credit_the_to_account_by_the_transfer_amount = () => toAccount.Balance.ShouldEqual(1750);
    }
}
