using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            
        }
        private static void CaseStudy1()
        {
            Object box = null;
            box = new object();
            Console.WriteLine(box.GetHashCode());
            Console.WriteLine(box.GetType());
            box = 100.55;
            Console.WriteLine(box.GetType());
            Console.WriteLine(box.GetHashCode());
            box = (double)box + 18;
            Console.WriteLine(box.GetHashCode());
        }
        private static void CaseStudy2()
        {
            Object[] boxedItem = new object[3];
            boxedItem[0] = 10d;
            boxedItem[1] = 20.55d;
            boxedItem[2] = 30.45d;
            Console.WriteLine(boxedItem[0].GetType());
            Console.WriteLine(boxedItem[1].GetType());
            Console.WriteLine(boxedItem[2].GetType());

            double sum = 0;
            foreach (Object item in boxedItem)
            {
                double unboxedItem = (double)item;
                sum += unboxedItem;
            }
            Console.WriteLine(sum);

        }
    }
}
