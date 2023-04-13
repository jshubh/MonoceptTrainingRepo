using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritenceApp.Model
{
    internal class Student : Person
    {
        private Branch _branch;
        public Student(int id,string name,string dob,Branch branch):base(id,name,dob)
        {
            _branch = branch;
        }
       public Branch Branchs
        {
            get
            {
                return _branch;
            }
            set
            {
                _branch = value;
            }
        }
    }
}
