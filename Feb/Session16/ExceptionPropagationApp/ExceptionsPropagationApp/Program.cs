using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPropagationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("inside main");
            try
            {
                F1();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToUpper());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.StackTrace);
                Console.ResetColor();
            }
            Console.WriteLine("End of the main");

        }

        private static void F1()
        {

            Console.WriteLine("inside f1");
            F2();
            Console.WriteLine("End of f1");
        }

        private static void F2()
        {
            Console.WriteLine("inside f2");
            F3();

            Console.WriteLine("End of f2");
        }
        private static void F3()
        {
            Console.WriteLine("inside F3");
            throw new Exception("Something went wrong in f3");
        }
    }
}
