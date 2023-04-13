using OCPViolationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fd1 = new FixedDeposit(1001, "Ravi", 100000, 5, FesitvalTypes.DIWALI);
            Console.WriteLine(fd1.SimpleInterset);
        }
    }
}
