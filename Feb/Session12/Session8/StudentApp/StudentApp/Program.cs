
using StudentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(12, "ShubhJain", 11f);
            PrintDetails(s1,"details of first Student");

             
        }
       static void PrintDetails(Student s1,string descrption)

        {
            Console.WriteLine(descrption.ToUpper());

            Console.WriteLine("name of student"+" "+ s1.Name);
            Console.WriteLine("rollNo of student"+" "+ s1.RollNo);
            Console.WriteLine("Cgpa of student" + " " + s1.Cgpa);
            Console.WriteLine("Percentage of student"+" "+  s1.Percentage);

        }
    }
}
