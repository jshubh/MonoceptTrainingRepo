using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1, 2, 3);
            PrintNumbers(4, 5, 6, 7);


        }
        private static void PrintNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}

