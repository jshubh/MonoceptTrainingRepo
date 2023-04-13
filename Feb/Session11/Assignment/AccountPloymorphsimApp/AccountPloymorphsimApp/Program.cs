using AccountPloymorphsimApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPloymorphsimApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CaseStudy1();
          // CaseStudy2();
            CaseStudy3();
           // CaseStudy4();
           


        }
        private static void CaseStudy1()
        {
            SavingAccount acc1 = new SavingAccount(1001, "shubh", 1000);
            PrintDetails(acc1, "acc1 saving Account");

        }
        private static void CaseStudy2()
        {
            CurrentAccount acc2 = new CurrentAccount(1002, "Rahul", 2000);
            PrintDetails(acc2, "acc2 current account");
        }
        private static void CaseStudy3()
        {
            CurrentAccount acc2 = new CurrentAccount(1004, "Adnan", 899);
            acc2.Withdraw(10000);
            PrintDetails(acc2,"amount of withdraw");
        }
        private static void CaseStudy4()
        {
            SavingAccount acc4 = new SavingAccount(1005, "Suksham", 567);
            acc4.Withdraw(1000);
            PrintDetails(acc4, " amount of withdraw");
        }
        static void PrintDetails(Account account,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("Account no is:{0}", account.Accouno);
            Console.WriteLine("Name  is:{0}", account.Name);
            Console.WriteLine("Balance  is:{0}", account.Balance);
        }
    }
}
