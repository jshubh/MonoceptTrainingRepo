using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
    internal class Program
    {

        static void Main(string[] args)
        {

            //CaseStudy1();
            //CaseStudy2();
            DPrintMessage fptr;
            fptr = (n) => Console.WriteLine("mambda {0",n);
            fptr("Vikrant");
       

            
        }
        private static void CaseStudy2()
        {
            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBye);
            PrintWizard(delegate (string name) {
                Console.WriteLine("Anonomyus delegate function 1");
                Console.WriteLine(name.ToLower());

            });
            PrintWizard((name) =>
            {
                Console.WriteLine("Inside lambdqa function");
                Console.WriteLine(name.ToLower());
            });
        }
        private static void CaseStudy1()
        {
            DPrintMessage obj;
            obj = PrintHello;
            obj("Shubh");
            obj += PrintHello;
            obj += PrintHello;
            obj += PrintHello;
            obj("Ravi");
        }
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        static void PrintWizard(DPrintMessage fptr)
        {
            Console.WriteLine("Doing printing Operaations..");
            Console.WriteLine("operations completed");
            fptr("CHAMP");
            Console.WriteLine();
        }

        static void PrintGoodBye(string name)
        {
            Console.WriteLine("Goodbye {0}", name);

        }
    }

}