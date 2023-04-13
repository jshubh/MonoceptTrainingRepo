using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeToStringEqualsApp.Model
{
    internal class Employee
    {

        private int _id;
        private string _name;
        private double _salary;

        public Employee(int id,string name,double salary)
        {
            _name = name;
            _id = id;
            _salary = salary;
        }

        public override string ToString()
        {
            string template = "";
            template += "Id:" + _id;
            template += "Name:" + _name;
            template += "Salary:" + _salary;
            //show overflowexception
            // template += "parent:" + this.Name;
            template += "Parent:" + base.ToString();
            return template;
        }
        public override bool Equals(object box)
        {
            Employee second = (Employee)box;
            if (this.Id == second.Id && second.Name == this.Name)
                return true;

            return false;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
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
    }
}
