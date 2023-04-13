using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res;
            string str = "10";
            res = int.Parse(str);
            Console.WriteLine("String is a numeric representation: " + res);
        }
    }
}
