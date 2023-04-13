using AccountApp.Model;
using AccountTransactionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransactionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Vikrant");

            Console.WriteLine(acc1.Balance);
            acc1.Deposit(1000);
            acc1.Withdraw(100);
            CaseStud1(acc1);

            Console.WriteLine();
                CaseStud2(acc1);
        }
        private static void CaseStud1(Account account)
            {
            foreach (Transcation t in account.Transcations)
            {
                Console.WriteLine(t);
            }
        }
        private static void CaseStud2(Account acc1)
        {
            IEnumerator<Transcation> enumerator = acc1.Transcations.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine(acc1.Balance);

        }

    }
}
