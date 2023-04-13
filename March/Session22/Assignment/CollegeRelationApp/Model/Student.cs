using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRelationApp.Model
{
    internal class Student
    {
        public int RollNo
        {
            get; set;
        }
        public string Name { get; set; }
        public string Department { get; set; }

        public Student(int rollNo,string name,string department)
        {
            RollNo = rollNo;
            Name = name;
            Department = department;

        }

    }
}
