using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLib
{
    [Serializable]
   public  class Human
    {
        private string _name;
        private int _age;
        private float _weight;
        private float _height;


        public Human(string name,int age,float weight,float heigth)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _height = heigth;
        }
        public void Workout()
        {
            _weight -=( _weight*.05f);
            return;
            
        }
        public void Eat()
        {
            _height += (_height *.02f);
            _weight += (_weight * .10f);
            return;


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
