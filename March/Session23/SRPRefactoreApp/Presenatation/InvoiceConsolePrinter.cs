using SRPViolatiobApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactoreApp.Presenatation
{
    internal class InvoiceConsolePrinter
    {
        public void PrintToConsole(Invoic invoice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            string template = $"Id:{invoice.Id}" +
               $"description:{invoice.Description}" +
               $"cost is :{invoice.Cost}" +
               $"tax amount is :{invoice.CalculateTax()}" +
               $"discount amt is: {invoice.CalcualteDiscount()}" +
               $"final cost is :{invoice.FinalCost()}";
            Console.WriteLine(template);
        }
    }
}
