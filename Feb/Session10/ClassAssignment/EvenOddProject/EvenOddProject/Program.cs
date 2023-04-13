using EvenOddProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Even e = new Even();
            
            Odd o = new Odd();
            int []el = o.GetOdd(100);
            int [] w = o.GetOdd(100, 200);
           // Console.WriteLine(o.ToString());
            o.GetOdd(100, 200);
            
            
        }
    }
}
