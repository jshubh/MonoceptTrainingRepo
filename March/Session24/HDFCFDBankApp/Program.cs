using FixedDepositCoreLib.Model;
using HDFCFDBankApp.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCFDBankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd = new FixedDeposit(2, "Vikrant",100000,10,new Quarter1RatePolicy());

            Console.WriteLine(fd.SimpleInterset);

            FixedDeposit fd2 = new FixedDeposit(2, "Vikrant", 100000, 10, new Quarter2RatePolicy());
            
        }
    }
}
