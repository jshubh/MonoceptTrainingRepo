using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRelationApp.Model
{
    internal class College
    {
        public string Name
        {
            get;set;
        }
        public List<Student> Students { get; set; }
        public List<Department> Departments { get; set; }

        public List<Professor> Professors { get; set; }

        public College(string name)
        {
            Name = name;
            Departments = new List<Department>();
            Students = new List<Student>();
            Professors = new List<Professor>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddProfessor(Professor professor)
        {
            Professors.Add(professor);
        }
    }
}
