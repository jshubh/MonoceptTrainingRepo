using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Unboxing
            object o = 12;
            int i = (int)o;
            Console.WriteLine(i);

            //Boxing
            int d = 10;
            object oe = d;
            Console.WriteLine(oe);
        }
       
       
    }
}
