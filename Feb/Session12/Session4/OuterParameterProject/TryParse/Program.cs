using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            int number;

            if (int.TryParse(str, out number))
            {
                Console.WriteLine("The string was successfully converted to an integer: " + number);
            }
            else
            {
                Console.WriteLine("The string could not be converted to an integer.");
            }
        }
    }
}
