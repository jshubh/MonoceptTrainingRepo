using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(60);
            PrintDetails(111.33);
            PrintDetails('S');
            PrintDetails("Shubh");
           // PrintDetails();
            PrintDetails(12.3f);

        }
        private static void PrintDetails(int input)
        {
            Console.WriteLine("Printing integer input {0}", input);
        }
        private static void PrintDetails(char input)
        {
            Console.WriteLine("Printing char input {0}", input);
        }
        private static void PrintDetails(double input)
        {
            Console.WriteLine("Printing a double value.value is {0}", input);
        }
        private static void PrintDetails(String input)
        {
            Console.WriteLine("Printing a string value is {0}", input);
        }
        private static void PrintDetails(float input)
        {
            Console.WriteLine("Printing a float value, value is   {0}", input);
        }

    }
}
