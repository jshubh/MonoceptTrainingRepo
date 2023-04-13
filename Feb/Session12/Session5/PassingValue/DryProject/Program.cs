using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("sum is {0}",Sum(arr));

            Console.WriteLine("avg is {0}",Avg(arr));
        }
        private static int Sum(int []arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;

        }
        private static double Avg(int []arr)
        {
            int sum = Sum(arr);
            double avg = (double) sum / arr.Length;
            return avg;
        }
    }
}
