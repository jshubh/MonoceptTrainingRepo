using AccountApp.Model;
using AxisBankSubscriber.cs.Notifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankSubscriber.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "sHUBH");
            acc1.AddSubscriber(new EmailNotifier());
            acc1.AddSubscriber(new SmsNotifiers());
            acc1.Deposit(100);
            acc1.Withdraw(100);
        }
    }
}
