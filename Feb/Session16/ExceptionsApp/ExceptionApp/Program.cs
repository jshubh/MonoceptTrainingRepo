using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 is divided by zero
            //Unhandle exception
            int first = int.Parse(args[0]);

            int second = int.Parse(args[1]);

            int result = first / second;
            Console.WriteLine($"{first}/{second}={result}");


            //   Main(args);



            // Console.WriteLine("{0} /{1}={2}", first, second, result);

            Console.WriteLine("End of main");
        }
    }
}
