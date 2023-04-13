using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            foreach (string name in args)
            {
                Console.WriteLine("hello " + name);
            }
        }
    }
}
