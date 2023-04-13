using AccountEventRefactoredApp.Model;

namespace AccountEventRefactoredApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Manjunath");
            acc1.OnBalanceChanged += (a) =>
            {
            Console.WriteLine($"Sendning SMS Notification to {a.Name}");
            Console.WriteLine($"Balanced changed to {a.Balance}");
            };
            acc1.OnBalanceChanged += (a) =>
            {
            Console.WriteLine($"Sendning Email Notification to {a.Name}");
            Console.WriteLine($"Balanced changed to {a.Balance}");
            };
            acc1.OnBalanceChanged += (a) =>
            {
                Console.WriteLine($"Sendning WhatsApp Notification to {a.Name}");
                Console.WriteLine($"Balanced changed to {a.Balance}");
            };
            acc1.Deposit(1000);
        }
    }
}