using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    internal class Student
    {
       private  readonly  int _rollno;
      private  float _cpga;
      private  string _name;

        public Student(int rollno,string name,float cgpa)
        {
            _rollno = ValidateRollNo(rollno);
            _name = ValidateName(name);
            _cpga =ValidateCgp(cgpa);
        }
        public string ValidateName(string name)
        {
            if(name.Length<=5)
            {
                return name;
            }
            else
            {
                return null;
            }
        }

        public int ValidateRollNo(int rollno)
        {
            if(rollno>=1)
            {
                return rollno;
            }
            else
            {
                return 0;
            }
        }
        public float ValidateCgp(float cgpa)
        {
            if (cgpa>=1 ||cgpa <= 10)
            {

                float perc = (float)(cgpa * 9.5);
                return perc;
            }
            else
                return 0;
        }
        public int RollNo
        {
            get{
                return _rollno;
            }
        }
        public float Cgpa
        {
            get
            {
                return _cpga;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public float Percentage
        {
            get
            {
                return (float)_cpga;
            }
            set
            {
                _cpga = value;
            }
        }
        
       
    }
}
