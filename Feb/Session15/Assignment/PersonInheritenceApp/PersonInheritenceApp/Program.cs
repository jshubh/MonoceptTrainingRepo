using PersonInheritenceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritenceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


           

            Student studentA = new Student(1, "Shubh","24-12-2000",Branch.CSE);
            Console.WriteLine("student Name:"+studentA.Name);
            Console.WriteLine("student Id:"+studentA.Id);
            Console.WriteLine("student Dob"+studentA.Dob);
            Console.WriteLine("student Branch:"+Branch.CSE);

            Professor professorA = new Professor(12, "Rahul", "24-2-1998", "AssistantProfessor", 40000);
            Console.WriteLine("Professor name:"+professorA.Name);
            Console.WriteLine("Professor id :"+professorA.Id);
            Console.WriteLine("Professor Dob:"+professorA.Dob);
            Console.WriteLine("Professor Role:"+professorA.EducationRole);

        }
      /* public void PrintDetails(Person person)
        {
            if (person.is())
            {
                Console.WriteLine("person name " + person.Name);

            }
        }
      */
        
        
    }
}
