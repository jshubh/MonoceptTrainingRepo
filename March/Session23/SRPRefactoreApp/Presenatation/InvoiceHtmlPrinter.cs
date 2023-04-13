using SRPViolatiobApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactoreApp.Presenatation
{
    internal class InvoiceHtmlPrinter
    {
        public void PrintToHtml(Invoic invoice)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string template = $"Id:{invoice.Id}" +
               $"description:{invoice.Description}" +
               $"cost is :{invoice.Cost}" +
               $"tax amount is :{invoice.CalculateTax()}" +
               $"discount amt is: {invoice.CalcualteDiscount()}" +
               $"final cost is :{invoice.FinalCost()}";
            


            StreamWriter sw = new StreamWriter(invoice.Id + ".html");

            sw.WriteLine("<html>");
            sw.WriteLine("<body>");
            sw.WriteLine("<h1>");
            sw.WriteLine(template);
            sw.WriteLine("</h1>");
            sw.WriteLine("</body>");
            sw.WriteLine("<html>");
            sw.Close();
            

        }
    }
}

