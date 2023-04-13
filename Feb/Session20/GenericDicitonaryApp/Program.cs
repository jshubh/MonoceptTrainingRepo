using GenericDicitonaryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenericDicitonaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(("10" + "1").GetHashCode());
           // Console.WriteLine(("1"+"10").GetHashCode());
            Student s1 = new Student {Standard=10,RollNo=1,Name="Shubh" };
            Student s2 = new Student { Standard = 11, RollNo = 2, Name = "Ravi" };
           Student s3= new Student { Standard = 10, RollNo = 1, Name = "Shubh" };

            var students = new Dictionary<Student, Student>();
            students.Add(s1, s1);
            students.Add(s2, s2);
           students.Add(s3, s3);
            Console.WriteLine(students.Count);
            Console.WriteLine("value equality s1 and s3 {0}",s1.Equals(s3));
            Console.WriteLine("hashcode s1 & s3 {0}",s1.GetHashCode()==s3.GetHashCode());
            Console.WriteLine("Referetial Equality s1&s3:"+(s1==s3));

        }
        private static void CaseStudy1()
        {
            Dictionary<string, string> stateCodes = new Dictionary<string, string>();

            stateCodes.Add("Mh", "Maharshtra");
            stateCodes.Add("Kl", "kerala");
            stateCodes.Add("Up", "Rampur");
            stateCodes.Add("KS", "Kerala");
            
            if(stateCodes.ContainsKey("Kl"))
            {
                stateCodes.Remove("Kl");
                stateCodes.Add("Kl", "New Kerala");
            }
            Console.WriteLine(stateCodes.Count);
            foreach(var row in stateCodes)
            {
                Console.WriteLine("Key is {0} -value is {1}", row.Key, row.Value);
            }
            stateCodes["M"] = "Mumbai";
            stateCodes["Mh"] = "Solapur";
            foreach (var row in stateCodes)
            {
                Console.WriteLine("Key is {0} -value is {1}", row.Key, row.Value);
            }
        }
    }
}
