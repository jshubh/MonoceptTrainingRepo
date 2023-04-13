using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryApp;
using System.Threading.Tasks;

namespace ClassLibarayPoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator a = new Calculator();
            int sum = a.Sum(5, 6);
            Console.WriteLine("sum is "+sum);

        }
    }
}
