using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritenceApp.Model
{
    internal class Professor:Person
    {
        private string _educationalRole;
        private double _salary;
        public Professor(int id, string name, string dob, string educational, double salary) : base(id, name, dob)
        {
            _educationalRole = educational;
            _salary = salary;
        }
        public double CalculateSalary()
        {
            
            
            return _salary * 12;


        }
        public string EducationRole
        {
            get
            {
                return _educationalRole;
            }
            set
            {
                _educationalRole = value;
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }

        }
    }
}
