using CollegeRelationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRelationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            College college = new College("Walchand College");
            Department cs = new Department("Computer Science");
            Department math = new Department("Mathematics");
            college.AddDepartment(cs);
            college.AddDepartment(math);
            
           

            college.AddStudent(new Student(12, "Shubh", "CSE"));
            college.AddStudent(new Student(13, "Rahul", "MECH"));

            Professor p1 = new Professor("Anil", "Computer Science");
            Professor p2 = new Professor("Adnan", "Mathematics");

            college.AddProfessor(p1);
            college.AddProfessor(p2);

            PrintDetails(college, "Details of college");
        }
        private static void PrintDetails(College collleg,string description)
        {
            Console.WriteLine(collleg.Name);

            Console.WriteLine("Departments are");
            foreach (var item in collleg.Departments)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Students Name");
            foreach(var item in collleg.Students)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Professor Name");
            foreach (var item in collleg.Professors)
            {
                Console.WriteLine(item.Name+"-"+item.Department);
            }
            Console.WriteLine("Complete details of student");
            foreach(var student in collleg.Students)
            {
                Console.WriteLine("-"+student.Name+"-"+student.Department);

            }


        }
    }
}
