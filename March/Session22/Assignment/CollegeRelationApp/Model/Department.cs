using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRelationApp.Model
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Professor> professors { get; set; }
        public Department(string name)
        {
            Name = name;
            professors = new List<Professor>();
        }

        public void AddProfessor(Professor professor)
        {
            professors.Add(professor);
        }
    }
}
