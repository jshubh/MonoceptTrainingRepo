using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankSubscriber.cs.Notifiers
{
    internal class EmailNotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Sending email Notifications ");
            Console.WriteLine("Account Holder is " + account.Name);
            Console.WriteLine("FinalBalnce is " + account.Balance);
            Console.WriteLine();
        }
    }
}
