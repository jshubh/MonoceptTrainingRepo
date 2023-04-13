using EmployeeToStringEqualsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1(); 
        }
        private static void CaseStudy2()
        {
            var employeeA = new Employee(1, "Rahul", 2000);
            var employeeB = new Employee(1, "Rahul", 2000);
            Console.WriteLine("refernce equality A & B:{0}", employeeA == employeeB);
            var employeeC = employeeB;

            Console.WriteLine("refernce equality A & B:{0}", employeeA.Equals(employeeB));


        }

        private static void CaseStudy1()
        {
            var employeeA = new Employee(1, "Shubh", 1000);
            Console.WriteLine(employeeA);
            Console.WriteLine(employeeA.ToString());

            Console.WriteLine(employeeA.GetType());
        }
    }
}
