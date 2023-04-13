using AccountApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1,122,"shubh");
            Account acc2 = new Account(5, 22.3, "Rahul");
            Account acc3 = new Account(9, 78.3, "Adarsh");
            Account[] manyAccounts = { acc1, acc2, acc3};
            Account rich= FindTheRichestAccountHolder(manyAccounts);
            PrintDetails(rich);
            Account names = LongestAccountHolderName(manyAccounts);
            PrintDetails(names);
            
           



        }
        
       private  static  Account FindTheRichestAccountHolder(Account [] manyAccount )

        {
            double max = int.MinValue;
           foreach(Account account in manyAccount)
            {
                if(account.Balance>max)
                {
                    max =(double) account.Balance;

                }
               
            }
            Account w=null;
            foreach (Account account in manyAccount)

                if (account.Balance == max)
                {
                   
                    w = account;


                }
            return w;
            


        }
       
       private static Account LongestAccountHolderName(Account[] myAccount )
        {
            int l = 0;
            foreach(Account account in myAccount)
            {
               if( account.Name.Length>l)
                {
                    l = account.Name.Length;
                }

            }
            Account w = null;
            foreach(Account account in myAccount)
            {
                if (l == account.Name.Length)
                {
                    w = account;
                }
            }
            return w;

        }
        
        private static void CaseStudy1()
        {
            Account accountB = new Account(1001,1500, "Shubh");
            accountB.Withdraw(3000);
            PrintDetails(accountB);
        }
        private static void CaseStudy2()
        {
            Account accountB = new Account(1001, "Shubh");
            accountB.Deposit(2000);
            PrintDetails(accountB);
            
        }
        private static void CaseStudy3()
        {
            Account accountA = new Account(1001, "Shubh");
            accountA.Deposit(1000);
            PrintDetails(accountA);


        }
        private static void CaseStudy4()
        {
            Account accountA = new Account(1001,1500, "Shubh");
            accountA.Withdraw(1000);
            PrintDetails(accountA);


        }
        static void PrintDetails(Account account)
        {
            Console.WriteLine("Details of Account ");
            Console.WriteLine("name:" + account.Name);
            Console.WriteLine("accountNo:" + account.Accouno);
            Console.WriteLine("Balance:" + account.Balance);
        }
    }
}
