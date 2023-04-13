using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    internal class Developer:Employee
    {
        private double _performanceAllowance;

        
        public Developer(double salary ,string name,int id):base(salary,name,id)
        {
            _performanceAllowance = salary * 50;
        }
        public override double CostToCompany
        {
            get
            {
                return (BasicSalary + PerforamceAllowance) * 12;

            }
            
        }
        public override string SalaryBreak
        {
            get
            {
                return "Performance Allowance" + _performanceAllowance;
            }
        }
       
       
        public override string Role
        {
            get
            {
                return "Developer";
            }
        }
        public double PerforamceAllowance
        {
            get
            {
                return _performanceAllowance;
            }
        }
        
    }
}
