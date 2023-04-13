using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccountConsoleApp;
using System.Threading.Tasks;

namespace AccountClassLib
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account s = new Account(1,1000,"shubhjain");
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Balance);
            Console.WriteLine(s.Balance);




        }
    }
}
