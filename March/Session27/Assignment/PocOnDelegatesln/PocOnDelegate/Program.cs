using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnDelegate
{
    delegate int Calculation(int x, int y);
    internal class Program
    {

        static int Add(int x, int y)
        {
            return x + y;
        }


        static int Subtract(int x, int y)
        {
            return x - y;
        }
        static int Multiply(int x,int y)
            {

            return x * y;
        }
        static int Divide(int x, int y)
        {

            return x / y;
        }

        static void Main(string[] args)
        {

            Calculation calc = Add;


            int result = calc(5, 3);
            Console.WriteLine("Addition Result: " + result);


            calc = Subtract;


            result = calc(5, 3);
            Console.WriteLine("Subtraction Result: " + result);


            calc = Multiply;

            result = calc(5, 3);
            Console.WriteLine("Mutliply Result: " + result);

            calc = Divide;

            result = calc(5, 3);

            Console.WriteLine("Divide Result: " + result);

        }
    }

}