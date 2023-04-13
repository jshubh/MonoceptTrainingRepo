using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBusinessLayerLib.Model
{
    [Serializable]
    public class Movie
    {
        private string _name;
        private int _year;

        public Movie(string name, int year)
        {
            _name = name;
            _year = year;
        }
        public string Name { get { return _name;} }
        public int Year { get { return _year;} }
    }
}
