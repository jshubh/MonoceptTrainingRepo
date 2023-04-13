using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRelationApp.Model
{
    internal class Professor
    {
      

        public Professor(string name,string department)
        {
            Name = name;
            Department = department;
        }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
