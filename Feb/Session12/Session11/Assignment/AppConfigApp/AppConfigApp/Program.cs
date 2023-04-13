using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace AppConfigApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection1 = ConfigurationManager.AppSettings["connection1"];
            string connection2= ConfigurationManager.AppSettings["connection2"];
            string name = ConfigurationManager.AppSettings["shubh"];
            Console.WriteLine(connection1);
            Console.WriteLine(connection2);
            Console.WriteLine(name);
        }
    }
}
