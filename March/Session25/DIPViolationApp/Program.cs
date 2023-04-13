using DIPVoilationApp.HighLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(ErrorLogOptions.XML);
            Console.WriteLine(calc.CalculateTax(10, 2));
            Console.WriteLine(calc.CalculateTax(10, 0));
        }
    }
}
