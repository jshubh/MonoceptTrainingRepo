using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    internal abstract class Employee
    {
        protected double _salary;
        private string _name;
        private readonly int _id;


        public Employee(double salary,string name,int id)
        {
            _salary = salary;
            _name = name; ;
            _id = id;
        }
        public abstract double CostToCompany { get; }
        public abstract string Role { get; }
        public abstract string SalaryBreak
        {
            get;
        }
       public double BasicSalary
        {
            get
            {
                return _salary;
            }
        }
        
        public double SalaryBreakUp { get; }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }


    }
}
