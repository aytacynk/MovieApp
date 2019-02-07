using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public static class MovieRepository
    {
        private static List<Movie> movies = null;

        public static List<Movie> Movies
        {
            get { return movies; }
        }

        static MovieRepository()
        {
            movies = new List<Movie>()
            {
                new Movie(){ Id=1, Name="Movie 1", Image="1.jpg", Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
                new Movie(){ Id=2, Name="Movie 2", Image="2.jpg",Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
                new Movie(){ Id=3, Name="Movie 3", Image="3.jpg",Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
                new Movie(){ Id=4, Name="Movie 4", Image="4.jpg",Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
                new Movie(){ Id=5, Name="Movie 5", Image="5.jpg",Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
                new Movie(){ Id=6, Name="Movie 6", Image="6.jpg",Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
                new Movie(){ Id=7, Name="Movie 7", Image="7.jpg",Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
                new Movie(){ Id=8, Name="Movie 8", Image="8.jpg",Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
                new Movie(){ Id=9, Name="Movie 9", Image="9.jpg",Description=" It was popularised in the 1960s with the release of Letraset sheets containing"},
            };
        }


        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public static Movie GetById(int? id)
        {
            return movies.FirstOrDefault(x => x.Id == id);
        }

    }
}
