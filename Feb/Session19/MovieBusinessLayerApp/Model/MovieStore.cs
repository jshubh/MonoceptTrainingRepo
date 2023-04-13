using MovirBusinessLayerLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovirBusinessLayerLib.Model
{


    [Serializable]

    public class MovieStore
    {
        private Movie[] _movies;
        private int _count;

        public MovieStore()
        {
            _movies = new Movie[5];
        }

        public void Add(Movie movie)
        {
            _movies[_count] = movie;
            _count++;
            if (_count >= _movies.Length)
            {
                Array.Resize(ref _movies, _movies.Length * 2);
            }
        }

        public Movie[] GetMovies()
        {
            return _movies;
        }
    }
}