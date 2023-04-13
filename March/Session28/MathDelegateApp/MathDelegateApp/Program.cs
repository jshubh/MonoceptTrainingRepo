using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp
{
    internal class Program
    {
        delegate void  DMathOperations(int x, int y);

        static void Add(int x, int y)
        {
           System.Console.WriteLine("Addition Result:{0}:", x + y);

        }
            static void Subtract(int x, int y)
            {
            Console.WriteLine("Substrct Result:{0} :" , x - y);

            }
            static void Multiply(int x, int y)
            {

            Console.WriteLine("Mutliply Result:{0} " , x*y);
             }
            static void Divide(int x, int y)
            {
            Console.WriteLine("Divide Result:{0} " , x / y);

            }

            static void Main(string[] args)
            {
            Add(5,6);
            Subtract(9, 8);
            Multiply(3, 4);
            Divide(2, 3);

                

            }
        }
}