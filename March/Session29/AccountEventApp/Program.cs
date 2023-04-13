using AccountEventApp.Model;

namespace AccountEventApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Manjunath");
            acc1.OnBalanceChanged += SendSMS;
            acc1.OnBalanceChanged += SendEmail;
            acc1.Deposit(1000);
        }
        static void SendSMS(Account acc)
        {
            Console.WriteLine($"Sendning SMS to {acc.Name}");
            Console.WriteLine($"Balanced changed to {acc.Balance}");
        }
        static void SendEmail(Account acc)
        {
            Console.WriteLine($"Sendning Email to {acc.Name}");
            Console.WriteLine($"Balanced changed to {acc.Balance}");
        }
    }
}