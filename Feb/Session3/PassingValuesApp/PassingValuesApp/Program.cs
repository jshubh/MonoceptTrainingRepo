using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValuesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy();
        }
        private static void CaseStudy()
        {
            int marks = 100;
           UpdateToMarks(marks);
            Console.WriteLine("Case Study 1,marks value is {0}", marks);
        }
        private static void UpdateToMarks(int marks)
        {
            marks = 0;
           // return marks;
        }




        }
    }
