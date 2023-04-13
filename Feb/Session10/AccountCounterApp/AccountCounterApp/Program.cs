using AccountCounterApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy3();
            

        }
        private static void CaseStudy3()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Account acc1 = new Account(101, 500, "A");
            Console.Write(Account.HeadCount());
            Account acc2 = new Account(102, 600, "B");
            Console.WriteLine();
            Console.Write(Account.HeadCount());
            Console.WriteLine();
            Account acc3 = new Account(103, 700, "C");
            Console.Write(Account.HeadCount()) ;
            Console.WriteLine();
            Console.ResetColor();

        }
        private static void CaseStudy1()
        {
            Account acc1 = new Account(101, 500, "A");
            Console.Write(acc1.InstanceCount);
            Account acc2 = new Account(102, 600, "B");
            Console.WriteLine();
            Console.Write(acc2.InstanceCount);
            Console.WriteLine();
            Account acc3 = new Account(103, 700, "C");
            Console.Write(acc3.InstanceCount);
            Console.WriteLine();
        }
        private static void CaseStudu2()
        {
            Account acc1 = new Account(101, 500, "A");
            Console.Write(acc1.InstanceCount);
            Account acc2 = new Account(102, 600, "B");
            Console.WriteLine();
            Console.Write(acc1.InstanceCount);
            Console.WriteLine();
            Account acc3 = new Account(103, 700, "C");
            Console.Write(acc1.InstanceCount);
            Console.WriteLine();

        }
    }
}
