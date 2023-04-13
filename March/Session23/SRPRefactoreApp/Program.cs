using SRPRefactoreApp.Presenatation;
using SRPViolatiobApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
          //  CaseStudy2();
            

            
        }
        private static void CaseStudy1()
        {
            Invoic invoic = new Invoic(1, "Training Invoice", 100, .50);
            InvoiceConsolePrinter printer = new InvoiceConsolePrinter();
            printer.PrintToConsole(invoic);
        }
        private static void CaseStudy2()
        {
            Invoic invoic = new Invoic(1, "Training Invoice", 100, .50);
            InvoiceHtmlPrinter printer2 = new InvoiceHtmlPrinter();
            printer2.PrintToHtml(invoic);

        }
    }
}
