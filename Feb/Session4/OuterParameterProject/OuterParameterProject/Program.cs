using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuterParameterProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            sum(10, 26, out result);
            Console.WriteLine("result should be {0}",result);
            int i = 15;
            increment(ref i);
            Console.WriteLine("value is {0}", i);

            
        }
        static void sum(int x,int y,out int z)
        {
            //Console.WriteLine(x + y);
            z = x + y;

        }
        static void increment( ref int i)
        {
            i++;
        }
    }
        
       

    }

