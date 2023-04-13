using StudentLinkApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student manjunath = new Student { Name = "Manjunath" };
            Student ekta = new Student { Name = "Ekta" };
            Student Ravi = new Student { Name = "Ravi" };
            Student shubh = new Student { Name = "shubh" };
            manjunath.Buddy = ekta;
            ekta.Buddy = Ravi;

            Ravi.Buddy = shubh;
            PrintDetails2Recursive(manjunath);

            //LinkedList<Student> s1 = new LinkedList<Student>();
            
        }
        private static void PrintDetails(Student  student)
        {
            while (student != null)
            {
                Console.Write(student.Name + " Buddy is : ");
                student = student.Buddy;
                if (student != null)
                    Console.WriteLine(student.Name);
            }




        }
        private static void PrintDetails2Recursive(Student root)
        {
            if (root == null)
                return;

           
            Console.WriteLine(root.Name);
            PrintDetails2Recursive(root.Buddy);
        }
    }
}
/*
*/