using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritenceApp.Model
{
    internal class Person
    {
        private int _id;
        private string _name;
        private string _dob;

        public Person(int id, string name, string dob)
        {
            _id = id;
            _name = name;
            _dob = dob;
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
        public string Dob
        {
            get
            {
                return _dob;
            }
        }
    }
}

