using DIPVoilationRefactoredApp.HighLevel;
using DIPVoilationRefactoredApp.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVilationRefactorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new TaxCalculator(new XMLErrorLogger());
            Console.WriteLine(calc.CalculateTax(10, 2));
            Console.WriteLine(calc.CalculateTax(10, 0));
        }
    }
}
