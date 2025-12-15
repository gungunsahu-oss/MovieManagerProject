using System;

namespace MovieProjectImplementation
{
    class MovieManager
    {
        private MovieCollection mc = new MovieCollection();

        public delegate void MovieHandler(string msg);
        public MovieHandler onmovieadd;

        public MovieManager()
        {
            onmovieadd = ShowAck;
        }

        private void ShowAck(string msg)
        {
            Console.WriteLine(msg);
        }

        public void AddMovie(string lang, Movie movie)
        {
            mc.AddMovie(lang, movie);
            onmovieadd?.Invoke($"Movie {movie.Title} added");
        }

        public void RemoveMovie(string lang, Movie movie)
        {
            mc.RemoveMovie(movie, lang);
            Console.WriteLine($"Movie {movie.Title} removed from {lang}");
        }

        public void MovieCount()
        {
            Console.WriteLine("Total Movies: " + mc.MovieCount());
        }
    }
}

