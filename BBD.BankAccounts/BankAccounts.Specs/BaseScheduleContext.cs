using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Specs
{
    public class BaseScheduleContext
    {
        protected static Account fromAccount;
        protected static Account toAccount;
        protected static Transfer transfer;

        Establish context = () =>
        {
            transfer = new Transfer(new EmailGateway());
        };

        protected static void CreateAccounts(int fromStartAmount, int toStartAmount)
        {
            fromAccount = new Account(fromStartAmount);
            toAccount = new Account(toStartAmount);
        }
    }
}
