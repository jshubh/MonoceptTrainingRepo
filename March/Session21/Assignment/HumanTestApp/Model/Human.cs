using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLib
{
    
   public  class Human
    {
        private string _name;
        private int _age;
        private float _weight;
        private float _height;
        private string _gender;


        public Human(string name,int age,float weight,float heigth,string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _weight = weight;
            _height = heigth;
        }
        public void Workout()
        {
            _weight -=( _weight*.05f);
            return;
            
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
        }
        public void Eat()
        {
            _height += (_height *.02f);
            _weight += (_weight * .10f);
            return;


        }
        public int BMI
        {
            get
            {
                return (int)(_weight / (_height * _height));
            }

        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Age
        {
            get
            {
                return (int)_age;
            }
        }
        public float Weight
        {
            get
            {
                return _weight;
            }
        }
        public float Height
        {
            get
            {
                return _height;
            }
        }
    }
}
