using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Specs
{
    public class When_transferring_more_money_than_available : BaseScheduleContext
    {
        static Exception exception;

        Establish context = () =>
        {
            CreateAccounts(400, 500);
        };

        Because of = () =>exception = Catch.Exception(()=>transfer.TransferFunds(fromAccount, toAccount, 500));

        It should_throw_an_arguement_exception = () => exception.ShouldBeOfExactType<ArgumentException>();
    }
}
