using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBusinessLayerLib.Model
{
    [Serializable]
    public class MovieStore
    {

        Movie[] _movie = new Movie[5];
        public int count=0;

        /*public MovieStore(string name, int year) : base(name, year)
        {
        }*/

        public void Add(Movie movie)
        {
            _movie[count] = movie;
            Array.Resize(ref _movie, _movie.Length+1);
            count++;
        }
        public Movie[] GetMovies()
        {
            return _movie;
        }
    }
}
