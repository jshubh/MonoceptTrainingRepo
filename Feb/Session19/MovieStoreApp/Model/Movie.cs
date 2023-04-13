using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Model
{
    internal class Movie
    {
        private string _name;
        private int _year;
        private string _directorName;

        public Movie(string name,int year,string directorName)
        {
            _name = name;
            _year = year;
            _directorName = directorName;
        }
        public Movie()
        {

        }
        public string Name
        {
            get
            {
                return _name;

            }
        }
        public int Year
        {
            get
            {
                return _year; 
            }
        }
        public string DirectorName
        {
            get
            {
                return _directorName;
            }
            set
            {
                _directorName = value;
            }
        }
    }
}
