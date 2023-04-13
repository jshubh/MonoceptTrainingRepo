using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    internal class Manager:Employee
    {
        private double _houseRentAllonace;
        private double _travellingAllowance;
        public Manager(double salary,string name,int id):base(salary,name,id)
        {
            _houseRentAllonace = salary * .60;
            _travellingAllowance = salary * .50;
        }
        public override double CostToCompany
        {
            get
            {
                return (BasicSalary + _houseRentAllonace
                    + _travellingAllowance) * 12;
            }
        }
        public override string Role
        {
            get
            {
                return "Manger";
            }
        }
        public override string SalaryBreak
        {
            get
            {
                string formattedSalaryBreakUp = "";

                formattedSalaryBreakUp += "HouseRent Allowance" + _houseRentAllonace;
                formattedSalaryBreakUp += "Travelling Allowance" + _travellingAllowance;
                return formattedSalaryBreakUp;
            }
        }
        public double HouseRentAllowance
        {
            get
            {
                return _houseRentAllonace;
            }
        }
        public double TravellingAllowance
        {
            get
            {

                return _travellingAllowance;
            }
        }
    }
}
