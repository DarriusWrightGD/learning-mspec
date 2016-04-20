using System;

namespace BankAccounts
{
    public interface IEmailGateway
    {
        void SendEmail(string subject, string from, string content);
    }

    public class EmailGateway : IEmailGateway
    {
        public void SendEmail(string subject, string from, string content)
        {
            Console.WriteLine($"Message sent from {from}, about {subject}. \n{content}");
        }
    }
}