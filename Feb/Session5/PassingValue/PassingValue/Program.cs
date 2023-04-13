using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PassingValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy4();
            CaseStudy5();

        }
        
        private static void CaseStudy4()
        {
            int sum, avg, product;

            Calcuate(10, 20, 30, out sum, out avg, out product);
            Console.WriteLine("Sum is {0} avg is {1} product {2}",sum,avg,product);
            Console.WriteLine("Enter a number only");
            string input = Console.ReadLine();
            int no = 0;
            if(int.TryParse(input,out no))
            {
                Console.WriteLine(no * no);
            }
            else
            {
                Console.WriteLine("number only allowed :" + input);
            }
        }
        private static void Calcuate(int first,int second,int third,out int sum,out int avg,out int product )
        {
            sum = first + second + third;
            avg = sum / 3;
            product = first * second * third;
        }
        private static void CaseStudy5()
        {
            DisplayMultplication(first: 10);
            DisplayMultplication(first: 10,20);
            DisplayMultplication(first: 10,20,30,40,50);

        }
        private static void DisplayMultplication(int first,params int []numbers)
        {
            int product = first;
            foreach(int number in numbers)
            {
                product *= number;
            }
            Console.WriteLine(format: "product is {0}", product);

        }
        

        
    }
}
